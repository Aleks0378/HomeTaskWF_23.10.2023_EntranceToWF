//2.Реализуйте игру минер на поле 3x3 из кнопок (Button).
//Первоначально все кнопки не содержат надписей.
//При попытке нажатия на кнопку на ней либо показывается количество мин рядом,
//либо надпись «мина!» и меняется цвет окна.


namespace Task_3
{
    public partial class Form1 : Form
    {
        bool choise = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int r1 = new Random().Next(1, 9);
            int r2 = new Random().Next(1, 9);
            int r3 = new Random().Next(1, 9);
            foreach (Button b in tableLayoutPanel1.Controls)
            {
                if (b.Name == $"button{r1}" || b.Name == $"button{r2}" || b.Name == $"button{r3}")
                {
                    if (b.Name.Equals(button.Name))
                    {
                        b.Text = "BOOM!!!";
                        b.BackColor = Color.Red;
                    }
                    else
                        b.Text = "Мина";
                }
                else b.Text = "1";
            }
            DialogResult result = MessageBox.Show("????????", "Хотите продолжить?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {Reset();}
            else this.Close();
        }

        private void Reset()
        {
            foreach (Button b in tableLayoutPanel1.Controls)
            {
                b.Text = "*";
                b.BackColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button b in tableLayoutPanel1.Controls)
            {
                b.Text = "*";
                b.BackColor = Color.Gray;
            }
        }
    }
}