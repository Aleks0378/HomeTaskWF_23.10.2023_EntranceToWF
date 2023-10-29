namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            nameTxtBox = new TextBox();
            countryTextBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            AddButton = new Button();
            WeightNumericUpDown = new NumericUpDown();
            AgeNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            UserslistBox = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(12, 55);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(215, 27);
            nameTxtBox.TabIndex = 1;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(12, 127);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(215, 27);
            countryTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(WeightNumericUpDown);
            groupBox1.Controls.Add(AgeNumericUpDown);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameTxtBox);
            groupBox1.Controls.Add(countryTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 183);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные для ввода пользователя";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(534, 125);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(121, 29);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // WeightNumericUpDown
            // 
            WeightNumericUpDown.Location = new Point(534, 56);
            WeightNumericUpDown.Name = "WeightNumericUpDown";
            WeightNumericUpDown.Size = new Size(85, 27);
            WeightNumericUpDown.TabIndex = 3;
            // 
            // AgeNumericUpDown
            // 
            AgeNumericUpDown.Location = new Point(330, 57);
            AgeNumericUpDown.Name = "AgeNumericUpDown";
            AgeNumericUpDown.Size = new Size(105, 27);
            AgeNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 104);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 8;
            label2.Text = "Страна";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(534, 34);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 7;
            label4.Text = "Вес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 34);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Возраст";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(263, 197);
            label5.Name = "label5";
            label5.Size = new Size(222, 28);
            label5.TabIndex = 8;
            label5.Text = "Список пользователей";
            // 
            // UserslistBox
            // 
            UserslistBox.Dock = DockStyle.Bottom;
            UserslistBox.FormattingEnabled = true;
            UserslistBox.ItemHeight = 20;
            UserslistBox.Location = new Point(0, 236);
            UserslistBox.Name = "UserslistBox";
            UserslistBox.Size = new Size(723, 224);
            UserslistBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 460);
            Controls.Add(UserslistBox);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox nameTxtBox;
        private TextBox countryTextBox;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private NumericUpDown WeightNumericUpDown;
        private NumericUpDown AgeNumericUpDown;
        private Label label2;
        private Button AddButton;
        private Label label5;
        private ListBox UserslistBox;
    }
}