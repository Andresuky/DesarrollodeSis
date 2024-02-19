namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(546, 212);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(251, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 34);
            textBox2.TabIndex = 19;
            textBox2.Text = "Nueva contraseña";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(251, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 18;
            textBox1.Text = "Usuario";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(279, 385);
            button1.Name = "button1";
            button1.Size = new Size(223, 40);
            button1.TabIndex = 17;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(251, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 3);
            panel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(251, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 3);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 25);
            label1.Name = "label1";
            label1.Size = new Size(383, 38);
            label1.TabIndex = 13;
            label1.Text = "Restablecer contraseña";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(546, 303);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(251, 293);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 34);
            textBox3.TabIndex = 22;
            textBox3.Text = "Confirmar contraseña";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(251, 334);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 21;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Panel panel3;
    }
}