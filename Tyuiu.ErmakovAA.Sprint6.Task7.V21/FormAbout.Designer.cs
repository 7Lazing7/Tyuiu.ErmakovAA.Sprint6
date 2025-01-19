namespace Tyuiu.ErmakovAA.Sprint6.Task7.V21
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panel1 = new Panel();
            buttonExit_ErmakovAA = new Button();
            buttonOk_ErmakovAA = new Button();
            textBoxAbout_ErmakovAA = new TextBox();
            pictureBox_ErmakovAA = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ErmakovAA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExit_ErmakovAA);
            panel1.Controls.Add(buttonOk_ErmakovAA);
            panel1.Controls.Add(textBoxAbout_ErmakovAA);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(183, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(398, 254);
            panel1.TabIndex = 3;
            // 
            // buttonExit_ErmakovAA
            // 
            buttonExit_ErmakovAA.Location = new Point(285, 202);
            buttonExit_ErmakovAA.Name = "buttonExit_ErmakovAA";
            buttonExit_ErmakovAA.Size = new Size(101, 44);
            buttonExit_ErmakovAA.TabIndex = 2;
            buttonExit_ErmakovAA.Text = "Окей";
            buttonExit_ErmakovAA.UseVisualStyleBackColor = true;
            buttonExit_ErmakovAA.Click += buttonExit_ErmakovAA_Click;
            // 
            // buttonOk_ErmakovAA
            // 
            buttonOk_ErmakovAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk_ErmakovAA.Location = new Point(467, 354);
            buttonOk_ErmakovAA.Name = "buttonOk_ErmakovAA";
            buttonOk_ErmakovAA.Size = new Size(112, 45);
            buttonOk_ErmakovAA.TabIndex = 1;
            buttonOk_ErmakovAA.Text = "Окей";
            buttonOk_ErmakovAA.UseVisualStyleBackColor = true;
            // 
            // textBoxAbout_ErmakovAA
            // 
            textBoxAbout_ErmakovAA.BorderStyle = BorderStyle.None;
            textBoxAbout_ErmakovAA.Dock = DockStyle.Fill;
            textBoxAbout_ErmakovAA.Font = new Font("Segoe UI", 10F);
            textBoxAbout_ErmakovAA.Location = new Point(5, 5);
            textBoxAbout_ErmakovAA.Multiline = true;
            textBoxAbout_ErmakovAA.Name = "textBoxAbout_ErmakovAA";
            textBoxAbout_ErmakovAA.ReadOnly = true;
            textBoxAbout_ErmakovAA.Size = new Size(388, 244);
            textBoxAbout_ErmakovAA.TabIndex = 0;
            textBoxAbout_ErmakovAA.Text = resources.GetString("textBoxAbout_ErmakovAA.Text");
            // 
            // pictureBox_ErmakovAA
            // 
            pictureBox_ErmakovAA.ErrorImage = null;
            pictureBox_ErmakovAA.Image = (Image)resources.GetObject("pictureBox_ErmakovAA.Image");
            pictureBox_ErmakovAA.InitialImage = null;
            pictureBox_ErmakovAA.Location = new Point(6, 5);
            pictureBox_ErmakovAA.Name = "pictureBox_ErmakovAA";
            pictureBox_ErmakovAA.Size = new Size(168, 245);
            pictureBox_ErmakovAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_ErmakovAA.TabIndex = 4;
            pictureBox_ErmakovAA.TabStop = false;
          
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 254);
            Controls.Add(panel1);
            Controls.Add(pictureBox_ErmakovAA);
            MinimumSize = new Size(597, 293);
            Name = "FormAbout";
            Text = "О программе";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ErmakovAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonOk_ErmakovAA;
        private TextBox textBoxAbout_ErmakovAA;
        private PictureBox pictureBox_ErmakovAA;
        private Button buttonExit_ErmakovAA;
    }

}