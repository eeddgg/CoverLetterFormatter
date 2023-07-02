namespace CoverLetterFormatter
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
            companyName = new TextBox();
            label1 = new Label();
            baseFile = new OpenFileDialog();
            jobTitle = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            cityNameBox = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            templateName = new TextBox();
            label5 = new Label();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            textBox2 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // companyName
            // 
            companyName.Location = new Point(10, 71);
            companyName.Name = "companyName";
            companyName.Size = new Size(226, 23);
            companyName.TabIndex = 0;
            companyName.TextChanged += companyName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 53);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Company Name";
            // 
            // baseFile
            // 
            baseFile.FileOk += baseFile_FileOk;
            // 
            // jobTitle
            // 
            jobTitle.Location = new Point(12, 117);
            jobTitle.Name = "jobTitle";
            jobTitle.Size = new Size(224, 23);
            jobTitle.TabIndex = 2;
            jobTitle.TextChanged += jobTitle_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Job Title";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 224);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 5;
            label3.Text = "Availability Date";
            // 
            // cityNameBox
            // 
            cityNameBox.Location = new Point(12, 186);
            cityNameBox.Name = "cityNameBox";
            cityNameBox.Size = new Size(226, 23);
            cityNameBox.TabIndex = 6;
            cityNameBox.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Location";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remote Work Available";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(268, 343);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 9;
            button1.Text = "Create Letter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // templateName
            // 
            templateName.Location = new Point(10, 27);
            templateName.Name = "templateName";
            templateName.Size = new Size(226, 23);
            templateName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 11;
            label5.Text = "Template File Path";
            // 
            // button2
            // 
            button2.Location = new Point(242, 26);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 12;
            button2.Text = "Choose File...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "docx";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 299);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 281);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 14;
            label6.Text = "Output File";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(244, 298);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 15;
            button3.Text = "Choose File...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 378);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(templateName);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(cityNameBox);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(jobTitle);
            Controls.Add(label1);
            Controls.Add(companyName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox companyName;
        private Label label1;
        private OpenFileDialog baseFile;
        private TextBox jobTitle;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox cityNameBox;
        private Label label4;
        private CheckBox checkBox1;
        private Button button1;
        private TextBox templateName;
        private Label label5;
        private Button button2;
        private SaveFileDialog saveFileDialog1;
        private TextBox textBox2;
        private Label label6;
        private Button button3;
    }
}