namespace NumberConverter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(371, 252);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(274, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(217, 124);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Choose your kind of number options:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(247, 160);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(398, 76);
			this.label2.TabIndex = 2;
			this.label2.Text = "1. Binary Conversion (Number 0 -> 1).\r\n2. Decimal Conversion (Number from 0 -> 10" +
    ").\r\n3. Octal Conversion (Number from 0-> 7 ).\r\n4. Hexadecimal Conversion (Number" +
    " from 0 -> 10 and A -> F).\r\n";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(86, 295);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "Current number system:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(689, 400);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(206, 29);
			this.button1.TabIndex = 4;
			this.button1.Text = "Click to continue";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(74, 505);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 29);
			this.button2.TabIndex = 5;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(739, 292);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 29);
			this.button3.TabIndex = 6;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(52, 30);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 78);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(851, 30);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(90, 78);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(86, 252);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(276, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "Input your number need convert:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(371, 292);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(274, 26);
			this.textBox2.TabIndex = 10;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(371, 335);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(274, 26);
			this.textBox3.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(274, 446);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 22);
			this.label5.TabIndex = 12;
			this.label5.Text = "Result:";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(371, 445);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(274, 23);
			this.textBox4.TabIndex = 13;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(86, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(255, 22);
			this.label6.TabIndex = 14;
			this.label6.Text = "Number system that you need:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1029, 570);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Convert number system";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private Button button2;
		private Button button3;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label4;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label label5;
		private TextBox textBox4;
		private Label label6;
	}
}