namespace Lab12
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 84);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 0;
            label2.Text = "Kitap Ad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 136);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 0;
            label3.Text = "Yazar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 194);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 0;
            label4.Text = "Sayfa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 243);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 0;
            label5.Text = "Fiyat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 292);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 0;
            label6.Text = "Yayinevi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 344);
            label7.Name = "label7";
            label7.Size = new Size(37, 25);
            label7.TabIndex = 0;
            label7.Text = "Tür";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 31);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 188);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 31);
            textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(158, 237);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 31);
            textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(158, 286);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 31);
            textBox6.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 344);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 33);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 3;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(187, 409);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 4;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(13, 466);
            button3.Name = "button3";
            button3.Size = new Size(160, 34);
            button3.TabIndex = 5;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(187, 466);
            button4.Name = "button4";
            button4.Size = new Size(161, 34);
            button4.TabIndex = 6;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(13, 530);
            button5.Name = "button5";
            button5.Size = new Size(160, 34);
            button5.TabIndex = 7;
            button5.Text = "Stored";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(187, 530);
            button6.Name = "button6";
            button6.Size = new Size(161, 34);
            button6.TabIndex = 8;
            button6.Text = "Parametreli Stored";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1047, 530);
            dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 581);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
    }
}
