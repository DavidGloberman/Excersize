namespace Excersize
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
            comboBox_daysOfWeek = new ComboBox();
            comboBox_daysOfMonth = new ComboBox();
            button1 = new Button();
            comboBox_Years = new ComboBox();
            comboBox_Month = new ComboBox();
            textBox_reslut = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_Search = new Button();
            SuspendLayout();
            // 
            // comboBox_daysOfWeek
            // 
            comboBox_daysOfWeek.FormattingEnabled = true;
            comboBox_daysOfWeek.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBox_daysOfWeek.Location = new Point(569, 95);
            comboBox_daysOfWeek.Name = "comboBox_daysOfWeek";
            comboBox_daysOfWeek.Size = new Size(127, 28);
            comboBox_daysOfWeek.TabIndex = 0;
            // 
            // comboBox_daysOfMonth
            // 
            comboBox_daysOfMonth.FormattingEnabled = true;
            comboBox_daysOfMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBox_daysOfMonth.Location = new Point(412, 95);
            comboBox_daysOfMonth.Name = "comboBox_daysOfMonth";
            comboBox_daysOfMonth.Size = new Size(127, 28);
            comboBox_daysOfMonth.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(342, 183);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox_Years
            // 
            comboBox_Years.FormattingEnabled = true;
            comboBox_Years.Items.AddRange(new object[] { "תשפ''ד", "תשפ''ה", "תשפ''ו", "תשפ''ז", "תשפ''ח", "תשפ''ט", "תש''צ", "תשצ''א", "תשצ''ב", "תשצ''ג" });
            comboBox_Years.Location = new Point(98, 95);
            comboBox_Years.Name = "comboBox_Years";
            comboBox_Years.Size = new Size(127, 28);
            comboBox_Years.TabIndex = 4;
            // 
            // comboBox_Month
            // 
            comboBox_Month.FormattingEnabled = true;
            comboBox_Month.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            comboBox_Month.Location = new Point(255, 95);
            comboBox_Month.Name = "comboBox_Month";
            comboBox_Month.Size = new Size(127, 28);
            comboBox_Month.TabIndex = 3;
            // 
            // textBox_reslut
            // 
            textBox_reslut.Location = new Point(57, 275);
            textBox_reslut.Name = "textBox_reslut";
            textBox_reslut.Size = new Size(671, 27);
            textBox_reslut.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(604, 59);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 6;
            label1.Text = "היום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 59);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 59);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 9;
            label3.Text = "שנה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 59);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "חודש";
            // 
            // button_Search
            // 
            button_Search.Location = new Point(298, 341);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(181, 29);
            button_Search.TabIndex = 10;
            button_Search.Text = "Search another day";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 450);
            Controls.Add(button_Search);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_reslut);
            Controls.Add(comboBox_Years);
            Controls.Add(comboBox_Month);
            Controls.Add(button1);
            Controls.Add(comboBox_daysOfMonth);
            Controls.Add(comboBox_daysOfWeek);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_daysOfWeek;
        private ComboBox comboBox_daysOfMonth;
        private Button button1;
        private ComboBox comboBox_Years;
        private ComboBox comboBox_Month;
        private TextBox textBox_reslut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_Search;
    }
}
