
namespace WinFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.replaceBox1 = new System.Windows.Forms.TextBox();
            this.replaceBox2 = new System.Windows.Forms.TextBox();
            this.replaceBox4 = new System.Windows.Forms.TextBox();
            this.replaceBox3 = new System.Windows.Forms.TextBox();
            this.replaceBox6 = new System.Windows.Forms.TextBox();
            this.replaceBox5 = new System.Windows.Forms.TextBox();
            this.replaceBox8 = new System.Windows.Forms.TextBox();
            this.replaceBox7 = new System.Windows.Forms.TextBox();
            this.findBox1 = new System.Windows.Forms.TextBox();
            this.findBox2 = new System.Windows.Forms.TextBox();
            this.findBox3 = new System.Windows.Forms.TextBox();
            this.findBox4 = new System.Windows.Forms.TextBox();
            this.findBox5 = new System.Windows.Forms.TextBox();
            this.findBox6 = new System.Windows.Forms.TextBox();
            this.findBox7 = new System.Windows.Forms.TextBox();
            this.findBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(25, 50);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(300, 23);
            this.inputText.TabIndex = 1;
            this.inputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "File to open:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(25, 125);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(300, 23);
            this.OutputText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Output file:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Duplicate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridMain
            // 
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridMain.Location = new System.Drawing.Point(25, 277);
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.RowTemplate.Height = 25;
            this.dataGridMain.Size = new System.Drawing.Size(843, 587);
            this.dataGridMain.TabIndex = 22;
            this.dataGridMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Replacement #1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Replacement #2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Replacement #3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Replacement #4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Replacement #5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Replacement #6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Replacement #7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Replacement #8";
            this.Column8.Name = "Column8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Find:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // replaceBox1
            // 
            this.replaceBox1.Location = new System.Drawing.Point(66, 226);
            this.replaceBox1.Name = "replaceBox1";
            this.replaceBox1.Size = new System.Drawing.Size(90, 23);
            this.replaceBox1.TabIndex = 13;
            // 
            // replaceBox2
            // 
            this.replaceBox2.Location = new System.Drawing.Point(166, 226);
            this.replaceBox2.Name = "replaceBox2";
            this.replaceBox2.Size = new System.Drawing.Size(90, 23);
            this.replaceBox2.TabIndex = 14;
            // 
            // replaceBox4
            // 
            this.replaceBox4.Location = new System.Drawing.Point(366, 226);
            this.replaceBox4.Name = "replaceBox4";
            this.replaceBox4.Size = new System.Drawing.Size(90, 23);
            this.replaceBox4.TabIndex = 16;
            // 
            // replaceBox3
            // 
            this.replaceBox3.Location = new System.Drawing.Point(266, 226);
            this.replaceBox3.Name = "replaceBox3";
            this.replaceBox3.Size = new System.Drawing.Size(90, 23);
            this.replaceBox3.TabIndex = 15;
            // 
            // replaceBox6
            // 
            this.replaceBox6.Location = new System.Drawing.Point(566, 226);
            this.replaceBox6.Name = "replaceBox6";
            this.replaceBox6.Size = new System.Drawing.Size(90, 23);
            this.replaceBox6.TabIndex = 18;
            // 
            // replaceBox5
            // 
            this.replaceBox5.Location = new System.Drawing.Point(466, 226);
            this.replaceBox5.Name = "replaceBox5";
            this.replaceBox5.Size = new System.Drawing.Size(90, 23);
            this.replaceBox5.TabIndex = 17;
            // 
            // replaceBox8
            // 
            this.replaceBox8.Location = new System.Drawing.Point(766, 226);
            this.replaceBox8.Name = "replaceBox8";
            this.replaceBox8.Size = new System.Drawing.Size(90, 23);
            this.replaceBox8.TabIndex = 20;
            // 
            // replaceBox7
            // 
            this.replaceBox7.Location = new System.Drawing.Point(666, 226);
            this.replaceBox7.Name = "replaceBox7";
            this.replaceBox7.Size = new System.Drawing.Size(90, 23);
            this.replaceBox7.TabIndex = 19;
            // 
            // findBox1
            // 
            this.findBox1.Location = new System.Drawing.Point(66, 172);
            this.findBox1.Name = "findBox1";
            this.findBox1.Size = new System.Drawing.Size(90, 23);
            this.findBox1.TabIndex = 5;
            // 
            // findBox2
            // 
            this.findBox2.Location = new System.Drawing.Point(166, 172);
            this.findBox2.Name = "findBox2";
            this.findBox2.Size = new System.Drawing.Size(90, 23);
            this.findBox2.TabIndex = 6;
            // 
            // findBox3
            // 
            this.findBox3.Location = new System.Drawing.Point(266, 172);
            this.findBox3.Name = "findBox3";
            this.findBox3.Size = new System.Drawing.Size(90, 23);
            this.findBox3.TabIndex = 7;
            // 
            // findBox4
            // 
            this.findBox4.Location = new System.Drawing.Point(366, 172);
            this.findBox4.Name = "findBox4";
            this.findBox4.Size = new System.Drawing.Size(90, 23);
            this.findBox4.TabIndex = 8;
            // 
            // findBox5
            // 
            this.findBox5.Location = new System.Drawing.Point(466, 172);
            this.findBox5.Name = "findBox5";
            this.findBox5.Size = new System.Drawing.Size(90, 23);
            this.findBox5.TabIndex = 9;
            // 
            // findBox6
            // 
            this.findBox6.Location = new System.Drawing.Point(566, 172);
            this.findBox6.Name = "findBox6";
            this.findBox6.Size = new System.Drawing.Size(90, 23);
            this.findBox6.TabIndex = 10;
            // 
            // findBox7
            // 
            this.findBox7.Location = new System.Drawing.Point(666, 172);
            this.findBox7.Name = "findBox7";
            this.findBox7.Size = new System.Drawing.Size(90, 23);
            this.findBox7.TabIndex = 11;
            // 
            // findBox8
            // 
            this.findBox8.Location = new System.Drawing.Point(766, 172);
            this.findBox8.Name = "findBox8";
            this.findBox8.Size = new System.Drawing.Size(90, 23);
            this.findBox8.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Replace:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(873, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 891);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findBox8);
            this.Controls.Add(this.replaceBox8);
            this.Controls.Add(this.findBox7);
            this.Controls.Add(this.replaceBox7);
            this.Controls.Add(this.findBox6);
            this.Controls.Add(this.replaceBox6);
            this.Controls.Add(this.findBox5);
            this.Controls.Add(this.replaceBox5);
            this.Controls.Add(this.findBox4);
            this.Controls.Add(this.replaceBox4);
            this.Controls.Add(this.findBox3);
            this.Controls.Add(this.replaceBox3);
            this.Controls.Add(this.findBox2);
            this.Controls.Add(this.replaceBox2);
            this.Controls.Add(this.findBox1);
            this.Controls.Add(this.replaceBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutputText);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox replaceBox1;
        private System.Windows.Forms.TextBox replaceBox2;
        private System.Windows.Forms.TextBox replaceBox4;
        private System.Windows.Forms.TextBox replaceBox3;
        private System.Windows.Forms.TextBox replaceBox6;
        private System.Windows.Forms.TextBox replaceBox5;
        private System.Windows.Forms.TextBox replaceBox8;
        private System.Windows.Forms.TextBox replaceBox7;
        private System.Windows.Forms.TextBox findBox1;
        private System.Windows.Forms.TextBox findBox2;
        private System.Windows.Forms.TextBox findBox3;
        private System.Windows.Forms.TextBox findBox4;
        private System.Windows.Forms.TextBox findBox5;
        private System.Windows.Forms.TextBox findBox6;
        private System.Windows.Forms.TextBox findBox7;
        private System.Windows.Forms.TextBox findBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridMain;
    }
}

