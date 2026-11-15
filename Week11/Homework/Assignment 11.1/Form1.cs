using Assignment_11._1.Data;
using Assignment_11._1.Models;

namespace Assignment_11._1;

public partial class Form1 : Form
{
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

    int? selectedBookId;

    public Form1()
    {
        InitializeComponent();
        Text = "Book Inventory";
        ClientSize = new Size(784, 475);
        BuildLayout();

        Load += (_, _) => { LoadGenres(); LoadBooks(); };
        Shown += (_, _) => ClearForm();
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

        AddButton("Add", 12, 435, (_, _) => AddBook());
        AddButton("Update", 112, 435, (_, _) => UpdateBook());
        AddButton("Delete", 212, 435, (_, _) => DeleteBook());
        AddButton("Clear", 312, 435, (_, _) => ClearForm());
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

    void LoadGenres()
    {
        using var db = new BookInventoryContext();
        cboGenre.DisplayMember = nameof(Genre.Name);
        cboGenre.ValueMember = nameof(Genre.GenreId);
        cboGenre.DataSource = db.Genres.OrderBy(g => g.Name).ToList();
    }

    void LoadBooks()
    {
        using var db = new BookInventoryContext();
        dgvBooks.DataSource = db.Books
            .OrderBy(b => b.BookId)
            .Select(b => new
            {
                b.BookId,
                b.Isbn,
                b.Title,
                b.Author,
                Genre = b.Genre.Name,
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
    }

    void FillFormFromSelection()
    {
        if (dgvBooks.SelectedRows.Count == 0) return;
        if (dgvBooks.SelectedRows[0].Cells["BookId"].Value is not int id) return;

        using var db = new BookInventoryContext();
        var book = db.Books.Find(id);
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

    void AddBook()
    {
        var book = new Book();
        if (!TryReadForm(book)) return;

        using var db = new BookInventoryContext();
        db.Books.Add(book);
        db.SaveChanges();

        LoadBooks();
        ClearForm();
    }

    void UpdateBook()
    {
        if (selectedBookId is null)
        {
            MessageBox.Show("Select a book first.");
            return;
        }

        using var db = new BookInventoryContext();
        var book = db.Books.Find(selectedBookId);
        if (book is null || !TryReadForm(book)) return;
        db.SaveChanges();

        LoadBooks();
        ClearForm();
    }

    void DeleteBook()
    {
        if (selectedBookId is null)
        {
            MessageBox.Show("Select a book first.");
            return;
        }
        if (MessageBox.Show("Delete this book?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

        using var db = new BookInventoryContext();
        var book = db.Books.Find(selectedBookId);
        if (book is null) return;
        db.Books.Remove(book);
        db.SaveChanges();

        LoadBooks();
        ClearForm();
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