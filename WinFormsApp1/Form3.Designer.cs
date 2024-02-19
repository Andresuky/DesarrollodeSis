namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBox1 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            textBox4 = new TextBox();
            panel4 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(40, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 21;
            textBox1.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(40, 178);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 3);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 39);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 19;
            label1.Text = "Registro usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(40, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 34);
            textBox2.TabIndex = 23;
            textBox2.Text = "Correo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(40, 251);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 3);
            panel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(727, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(432, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 34);
            textBox3.TabIndex = 28;
            textBox3.Text = "Confirmar contraseña";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(432, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(727, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(432, 137);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 34);
            textBox4.TabIndex = 25;
            textBox4.Text = "Contraseña";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(432, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 3);
            panel4.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(274, 339);
            button1.Name = "button1";
            button1.Size = new Size(223, 40);
            button1.TabIndex = 30;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox4);
            Controls.Add(panel4);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private Panel panel4;
        private Button button1;
    }
}