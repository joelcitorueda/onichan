﻿namespace SistemaVenta.Vista.ProveeVistas
{
	partial class ProveeInsertarVista
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(188, 121);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(225, 27);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(167, 48);
			label1.Name = "label1";
			label1.Size = new Size(171, 20);
			label1.TabIndex = 1;
			label1.Text = "INSERTE DATOS PROVEE";
			// 
			// button1
			// 
			button1.Location = new Point(188, 378);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 124);
			label2.Name = "label2";
			label2.Size = new Size(104, 20);
			label2.TabIndex = 3;
			label2.Text = "ID PRODUCTO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(37, 183);
			label3.Name = "label3";
			label3.Size = new Size(112, 20);
			label3.TabIndex = 4;
			label3.Text = "ID PROVEEDOR";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(95, 234);
			label4.Name = "label4";
			label4.Size = new Size(54, 20);
			label4.TabIndex = 5;
			label4.Text = "FECHA";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(91, 291);
			label5.Name = "label5";
			label5.Size = new Size(58, 20);
			label5.TabIndex = 6;
			label5.Text = "PRECIO";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(188, 180);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(225, 27);
			textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(188, 231);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(225, 27);
			textBox3.TabIndex = 8;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(188, 288);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(225, 27);
			textBox4.TabIndex = 9;
			// 
			// button2
			// 
			button2.Location = new Point(304, 378);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 10;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(439, 120);
			button3.Name = "button3";
			button3.Size = new Size(141, 29);
			button3.TabIndex = 11;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Location = new Point(439, 180);
			button4.Name = "button4";
			button4.Size = new Size(141, 29);
			button4.TabIndex = 12;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			// 
			// ProveeInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(592, 450);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "ProveeInsertarVista";
			Text = "ProveeInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Button button1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}