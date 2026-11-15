using System.Net.Http.Json;
using BookInventory.Client.Models;

namespace BookInventory.Client;

public partial class Form1 : Form
{
    static readonly HttpClient api = new() { BaseAddress = new Uri("https://localhost:7092/") };

    readonly DataGridView dgvBooks = new()
    {
        Location = new Point(12, 12),
        Size = new Size(760, 260),
        ReadOnly = true,
        AllowUserToAddRows = false,
        MultiSelect = false,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        BackgroundColor = SystemColors.Window,
        RowHeadersVisible = false
    };
    readonly TextBox txtIsbn = new() { MaxLength = 13 };
    readonly TextBox txtTitle = new();
    readonly TextBox txtAuthor = new();
    readonly ComboBox cboGenre = new() { DropDownStyle = ComboBoxStyle.DropDownList };
    readonly DateTimePicker dtpPublished = new() { Format = DateTimePickerFormat.Short, ShowCheckBox = true };
    readonly NumericUpDown numPrice = new() { DecimalPlaces = 2, Maximum = 10000 };
    readonly NumericUpDown numQuantity = new() { Maximum = 100000 };

    List<Genre> genres = new();
    List<Book> books = new();
    int? selectedBookId;

    public Form1()
    {
        InitializeComponent();
        Text = "Book Inventory (Web API Client)";
        ClientSize = new Size(784, 475);
        BuildLayout();

        Load += async (_, _) => await RunAsync(LoadAllAsync);
        dgvBooks.SelectionChanged += (_, _) => FillFormFromSelection();
    }

    void BuildLayout()
    {
        Controls.Add(dgvBooks);

        AddField("ISBN", txtIsbn, 12, 290);
        AddField("Title", txtTitle, 12, 325);
        AddField("Author", txtAuthor, 12, 360);
        AddField("Genre", cboGenre, 12, 395);
        AddField("Published", dtpPublished, 400, 290);
        AddField("Price", numPrice, 400, 325);
        AddField("Quantity", numQuantity, 400, 360);

        AddButton("Add", 12, 435, async (_, _) => await RunAsync(AddBookAsync));
        AddButton("Update", 112, 435, async (_, _) => await RunAsync(UpdateBookAsync));
        AddButton("Delete", 212, 435, async (_, _) => await RunAsync(DeleteBookAsync));
        AddButton("Clear", 312, 435, (_, _) => ClearForm());
        AddButton("Refresh", 412, 435, async (_, _) => await RunAsync(LoadBooksAsync));
    }

    void AddField(string label, Control input, int x, int y)
    {
        Controls.Add(new Label { Text = label, Location = new Point(x, y + 3), AutoSize = true });
        input.Location = new Point(x + 100, y);
        input.Width = 260;
        Controls.Add(input);
    }

    void AddButton(string text, int x, int y, EventHandler onClick)
    {
        var button = new Button { Text = text, Location = new Point(x, y), Size = new Size(90, 28) };
        button.Click += onClick;
        Controls.Add(button);
    }

    static async Task RunAsync(Func<Task> action)
    {
        try
        {
            await action();
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show($"Cannot reach the API. Make sure BookInventory.Api is running.\n\n{ex.Message}");
        }
    }

    static async Task<bool> CheckAsync(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode) return true;
        var body = await response.Content.ReadAsStringAsync();
        MessageBox.Show($"API error {(int)response.StatusCode} {response.ReasonPhrase}\n\n{body}");
        return false;
    }

    async Task LoadAllAsync()
    {
        genres = await api.GetFromJsonAsync<List<Genre>>("api/Genres") ?? new();
        cboGenre.DisplayMember = nameof(Genre.Name);
        cboGenre.ValueMember = nameof(Genre.GenreId);
        cboGenre.DataSource = genres.OrderBy(g => g.Name).ToList();

        await LoadBooksAsync();
    }

    async Task LoadBooksAsync()
    {
        books = await api.GetFromJsonAsync<List<Book>>("api/Books") ?? new();

        dgvBooks.DataSource = books
            .OrderBy(b => b.BookId)
            .Select(b => new
            {
                b.BookId,
                b.Isbn,
                b.Title,
                b.Author,
                Genre = genres.FirstOrDefault(g => g.GenreId == b.GenreId)?.Name,
                b.PublicationDate,
                b.Price,
                b.Quantity
            })
            .ToList();

        dgvBooks.Columns["BookId"]!.HeaderText = "ID";
        dgvBooks.Columns["BookId"]!.FillWeight = 30;
        dgvBooks.Columns["Isbn"]!.FillWeight = 90;
        dgvBooks.Columns["Title"]!.FillWeight = 150;
        dgvBooks.Columns["Author"]!.FillWeight = 120;
        dgvBooks.Columns["Genre"]!.FillWeight = 90;
        dgvBooks.Columns["PublicationDate"]!.HeaderText = "Published";
        dgvBooks.Columns["PublicationDate"]!.FillWeight = 90;
        dgvBooks.Columns["Price"]!.FillWeight = 50;
        dgvBooks.Columns["Quantity"]!.HeaderText = "Qty";
        dgvBooks.Columns["Quantity"]!.FillWeight = 35;

        ClearForm();
    }

    void FillFormFromSelection()
    {
        if (dgvBooks.SelectedRows.Count == 0) return;
        if (dgvBooks.SelectedRows[0].Cells["BookId"].Value is not int id) return;

        var book = books.FirstOrDefault(b => b.BookId == id);
        if (book is null) return;

        selectedBookId = book.BookId;
        txtIsbn.Text = book.Isbn;
        txtTitle.Text = book.Title;
        txtAuthor.Text = book.Author;
        cboGenre.SelectedValue = book.GenreId;
        dtpPublished.Value = book.PublicationDate?.ToDateTime(TimeOnly.MinValue) ?? DateTime.Today;
        dtpPublished.Checked = book.PublicationDate.HasValue;
        numPrice.Value = book.Price ?? 0;
        numQuantity.Value = book.Quantity;
    }

    bool TryReadForm(Book book)
    {
        if (string.IsNullOrWhiteSpace(txtTitle.Text))
        {
            MessageBox.Show("Title is required.");
            return false;
        }
        if (cboGenre.SelectedValue is not int genreId)
        {
            MessageBox.Show("Please choose a genre.");
            return false;
        }

        book.Isbn = string.IsNullOrWhiteSpace(txtIsbn.Text) ? null : txtIsbn.Text.Trim();
        book.Title = txtTitle.Text.Trim();
        book.Author = string.IsNullOrWhiteSpace(txtAuthor.Text) ? null : txtAuthor.Text.Trim();
        book.GenreId = genreId;
        book.PublicationDate = dtpPublished.Checked ? DateOnly.FromDateTime(dtpPublished.Value) : null;
        book.Price = numPrice.Value;
        book.Quantity = (int)numQuantity.Value;
        return true;
    }

    async Task AddBookAsync()
    {
        var book = new Book();
        if (!TryReadForm(book)) return;

        var response = await api.PostAsJsonAsync("api/Books", book);
        if (!await CheckAsync(response)) return;

        await LoadBooksAsync();
    }

    async Task UpdateBookAsync()
    {
        if (selectedBookId is not int id)
        {
            MessageBox.Show("Select a book first.");
            return;
        }

        var book = new Book { BookId = id };
        if (!TryReadForm(book)) return;

        var response = await api.PutAsJsonAsync($"api/Books/{id}", book);
        if (!await CheckAsync(response)) return;

        await LoadBooksAsync();
    }

    async Task DeleteBookAsync()
    {
        if (selectedBookId is not int id)
        {
            MessageBox.Show("Select a book first.");
            return;
        }
        if (MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        var response = await api.DeleteAsync($"api/Books/{id}");
        if (!await CheckAsync(response)) return;

        await LoadBooksAsync();
    }

    void ClearForm()
    {
        selectedBookId = null;
        txtIsbn.Clear();
        txtTitle.Clear();
        txtAuthor.Clear();
        if (cboGenre.Items.Count > 0) cboGenre.SelectedIndex = 0;
        dtpPublished.Value = DateTime.Today;
        dtpPublished.Checked = false;
        numPrice.Value = 0;
        numQuantity.Value = 0;
        dgvBooks.ClearSelection();
    }
}
