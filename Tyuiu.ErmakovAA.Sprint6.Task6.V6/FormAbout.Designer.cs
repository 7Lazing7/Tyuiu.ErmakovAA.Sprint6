namespace Tyuiu.ErmakovAA.Sprint6.Task6.V6
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
            labelInfo_TVD = new Label();
            buttonOK_TVD = new Button();
            pictureBoxPhoto_TVD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_TVD).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_TVD
            // 
            labelInfo_TVD.AutoSize = true;
            labelInfo_TVD.Location = new Point(140, 15);
            labelInfo_TVD.Margin = new Padding(4, 0, 4, 0);
            labelInfo_TVD.Name = "labelInfo_TVD";
            labelInfo_TVD.Size = new Size(0, 15);
            labelInfo_TVD.TabIndex = 1;
            // 
            // buttonOK_TVD
            // 
            buttonOK_TVD.Location = new Point(379, 153);
            buttonOK_TVD.Margin = new Padding(4, 3, 4, 3);
            buttonOK_TVD.Name = "buttonOK_TVD";
            buttonOK_TVD.Size = new Size(88, 27);
            buttonOK_TVD.TabIndex = 2;
            buttonOK_TVD.Text = "Ок";
            buttonOK_TVD.UseVisualStyleBackColor = true;
            buttonOK_TVD.Click += buttonOK_TVD_Click;
            // 
            // pictureBoxPhoto_TVD
            // 
            pictureBoxPhoto_TVD.Location = new Point(15, 15);
            pictureBoxPhoto_TVD.Margin = new Padding(4, 3, 4, 3);
            pictureBoxPhoto_TVD.Name = "pictureBoxPhoto_TVD";
            pictureBoxPhoto_TVD.Size = new Size(117, 157);
            pictureBoxPhoto_TVD.TabIndex = 0;
            pictureBoxPhoto_TVD.TabStop = false;
            pictureBoxPhoto_TVD.Click += this.pictureBoxPhoto_TVD_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 186);
            Controls.Add(buttonOK_TVD);
            Controls.Add(labelInfo_TVD);
            Controls.Add(pictureBoxPhoto_TVD);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_TVD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Button buttonOK_TVD;
    }
}