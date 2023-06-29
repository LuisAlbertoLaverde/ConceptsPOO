using ConceptsPOO.Logic;

namespace ConceptsPOO.UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("You must enter a year.", "Error");
                return;
            }
            if (txtMonth.Text.Length==0)
            {
                MessageBox.Show("You must enter a month.", "Error");
                return;
            }
            if (txtDay.Text.Length==0)
            {
                MessageBox.Show("You must enter a day.", "Error");
                return;
            }
            try
            {
                int year = Convert.ToInt32(txtYear.Text);
                int month = Convert.ToInt32(txtMonth.Text);
                int day = Convert.ToInt32(txtDay.Text);

                var date = new Date(year, month, day);
                MessageBox.Show($"Congratulations the date: {date} is valid!", "Confirm");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something wrong was ocurred: {ex.Message}", "Error");
            }
        }
    }
}