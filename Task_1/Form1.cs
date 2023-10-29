//ќсновное задание: —оздать приложение, вывод€щее на экран показани€ времени.
//–еализовать возможность задани€ периодичности обновлени€ показаний времени в секундах.
//ѕри помощи кнопок RadioButton реализовать возможность изменени€ формата выводимого времени: 24 - часовый и 12-часовый форматы.

namespace Task_1
{
    public partial class Form1 : Form
    {
        bool format;
        int value = 1;
        public Form1()
        {
            InitializeComponent();
            format = true;
            numericUpDown1.Value = 1;
            StartTime();
        }

        private void StartTime()
        {
            timer1.Interval = value * 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            textBox1.Text = format ? DateTime.Now.ToString("hh.mm.ss tt  dddd") : DateTime.Now.ToString("HH.mm.ss  dddd");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            value = (int)numericUpDown1.Value;
            StartTime();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radiobutton = sender as RadioButton;
            format = radiobutton.Text.Equals("12");
            //MessageBox.Show($"Format changed to {format}");
        }
    }
}