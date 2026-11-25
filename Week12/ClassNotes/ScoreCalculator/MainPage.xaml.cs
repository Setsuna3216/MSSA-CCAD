using System.Diagnostics;

namespace ScoreCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0, totalscore = 0;
        float average = 0.0f;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(txtScore.Text,out int score))
            {
                totalscore += score;
                lblScoreTotal.Text = $"{totalscore}";
                count++;
                lblScoreCount.Text = $"{count}";
                average =(float)totalscore / count;
                lblScoreAvg.Text = $"{average:F2}";
                
            }
            else
            {
                DisplayAlert("Invalid input", "Enter valid number", "Ok");
            }


        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            count = 0;
            totalscore = 0;
            average = 0.0f;
            lblScoreTotal.Text = string.Empty;
            lblScoreCount.Text = string.Empty;
            lblScoreAvg.Text = string.Empty;
            txtScore.Text = string.Empty;
        }

        private void btnExit_Clicked(object sender, EventArgs e)
        {
            
            Process.GetCurrentProcess().CloseMainWindow();
        }
    }

}
