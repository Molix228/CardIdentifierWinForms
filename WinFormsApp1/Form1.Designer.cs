namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            imageList1 = new ImageList(components);
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.ImageIndex = 1;
            button2.ImageList = imageList1;
            button2.Location = new Point(453, 180);
            button2.Name = "button2";
            button2.Size = new Size(258, 410);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = SystemColors.Menu;
            imageList1.Images.SetKeyName(0, "queen_of_hearts2.png");
            imageList1.Images.SetKeyName(1, "king_of_spades2.png");
            imageList1.Images.SetKeyName(2, "3_of_diamonds.png");
            imageList1.Images.SetKeyName(3, "red_joker.png");
            imageList1.Images.SetKeyName(4, "ace_of_diamonds.png");
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.Cursor = Cursors.Hand;
            button1.ImageIndex = 0;
            button1.ImageList = imageList1;
            button1.Location = new Point(76, 180);
            button1.Name = "button1";
            button1.Size = new Size(258, 410);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.ImageIndex = 2;
            button3.ImageList = imageList1;
            button3.Location = new Point(823, 180);
            button3.Name = "button3";
            button3.Size = new Size(258, 410);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.ImageIndex = 3;
            button4.ImageList = imageList1;
            button4.Location = new Point(1199, 180);
            button4.Name = "button4";
            button4.Size = new Size(258, 410);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.ImageIndex = 4;
            button5.ImageList = imageList1;
            button5.Location = new Point(1583, 180);
            button5.Name = "button5";
            button5.Size = new Size(258, 410);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.No;
            textBox1.Font = new Font("Verdana", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Desktop;
            textBox1.Location = new Point(453, 744);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Card Identifier";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1004, 53);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Transparent;
            exit_btn.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.ForeColor = Color.OrangeRed;
            exit_btn.Location = new Point(775, 869);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(369, 80);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(exit_btn);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(1920, 1080);
            Name = "Form1";
            Text = "Card Identifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ImageList imageList1;
        private TextBox textBox1;
        private Button exit_btn;
    }
}
