namespace Task_2
{

    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            UserslistBox.Items.AddRange(users.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User temp = new User();
            temp.Name = nameTxtBox.Text;
            temp.Country = countryTextBox.Text;
            temp.Age = (int)AgeNumericUpDown.Value;
            temp.Weight = (int)WeightNumericUpDown.Value;
            users.Add(temp);
            UserslistBox.Items.Clear();
            UserslistBox.Items.AddRange(users.ToArray());
        }
    }
}