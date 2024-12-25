
using Tyuiu.ErmakovAA.Sprint6.Task0.V3.Properties;

namespace Tyuiu.ErmakovAA.Sprint6.Task0.V3
{
    partial class FormMain
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
            groupBoxTask_SBI = new GroupBox();
            pictureBox1 = new PictureBox();
            textBoxTask_SBI = new TextBox();
            groupBoxInput_SBI = new GroupBox();
            label1 = new Label();
            textBoxX_SBI = new TextBox();
            groupBoxOutput_SBI = new GroupBox();
            label4 = new Label();
            textBoxResult_SBI = new TextBox();
            buttonQuestion_SBI = new Button();
            buttonDoneResult_SBI = new Button();
            groupBoxTask_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_SBI.SuspendLayout();
            groupBoxOutput_SBI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(pictureBox1);
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Font = new Font("Segoe UI", 12F);
            groupBoxTask_SBI.Location = new Point(12, 12);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.Size = new Size(706, 231);
            groupBoxTask_SBI.TabIndex = 0;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Resources.Снимок_экрана_2024_12_12_042410;
            pictureBox1.Location = new Point(432, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 136);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Font = new Font("Segoe UI", 12F);
            textBoxTask_SBI.Location = new Point(22, 31);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(326, 127);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // groupBoxInput_SBI
            // 
            groupBoxInput_SBI.Controls.Add(label1);
            groupBoxInput_SBI.Controls.Add(textBoxX_SBI);
            groupBoxInput_SBI.Font = new Font("Segoe UI", 12F);
            groupBoxInput_SBI.Location = new Point(12, 261);
            groupBoxInput_SBI.Name = "groupBoxInput_SBI";
            groupBoxInput_SBI.Size = new Size(426, 100);
            groupBoxInput_SBI.TabIndex = 1;
            groupBoxInput_SBI.TabStop = false;
            groupBoxInput_SBI.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 3;
            label1.Text = "Переменная X:";
            // 
            // textBoxX_SBI
            // 
            textBoxX_SBI.Font = new Font("Segoe UI", 10F);
            textBoxX_SBI.Location = new Point(22, 57);
            textBoxX_SBI.Name = "textBoxX_SBI";
            textBoxX_SBI.Size = new Size(108, 25);
            textBoxX_SBI.TabIndex = 0;
            textBoxX_SBI.KeyPress += textBoxVarX_SBI_KeyPress;
            // 
            // groupBoxOutput_SBI
            // 
            groupBoxOutput_SBI.Controls.Add(label4);
            groupBoxOutput_SBI.Controls.Add(textBoxResult_SBI);
            groupBoxOutput_SBI.Font = new Font("Segoe UI", 12F);
            groupBoxOutput_SBI.Location = new Point(444, 261);
            groupBoxOutput_SBI.Name = "groupBoxOutput_SBI";
            groupBoxOutput_SBI.Size = new Size(274, 100);
            groupBoxOutput_SBI.TabIndex = 2;
            groupBoxOutput_SBI.TabStop = false;
            groupBoxOutput_SBI.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 9;
            label4.Text = "Результат:";
            // 
            // textBoxResult_SBI
            // 
            textBoxResult_SBI.Font = new Font("Segoe UI", 10F);
            textBoxResult_SBI.Location = new Point(6, 53);
            textBoxResult_SBI.Name = "textBoxResult_SBI";
            textBoxResult_SBI.ReadOnly = true;
            textBoxResult_SBI.Size = new Size(262, 25);
            textBoxResult_SBI.TabIndex = 8;
            // 
            // buttonQuestion_SBI
            // 
            buttonQuestion_SBI.FlatStyle = FlatStyle.Flat;
            buttonQuestion_SBI.Location = new Point(450, 376);
            buttonQuestion_SBI.Name = "buttonQuestion_SBI";
            buttonQuestion_SBI.Size = new Size(63, 62);
            buttonQuestion_SBI.TabIndex = 3;
            buttonQuestion_SBI.Text = "?";
            buttonQuestion_SBI.UseVisualStyleBackColor = true;
            buttonQuestion_SBI.Click += buttonQuestion_SBI_Click;
            // 
            // buttonDoneResult_SBI
            // 
            buttonDoneResult_SBI.BackgroundImageLayout = ImageLayout.None;
            buttonDoneResult_SBI.FlatStyle = FlatStyle.System;
            buttonDoneResult_SBI.Location = new Point(530, 376);
            buttonDoneResult_SBI.Name = "buttonDoneResult_SBI";
            buttonDoneResult_SBI.Size = new Size(182, 62);
            buttonDoneResult_SBI.TabIndex = 4;
            buttonDoneResult_SBI.Text = "Выполнить";
            buttonDoneResult_SBI.UseVisualStyleBackColor = true;
            buttonDoneResult_SBI.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(buttonDoneResult_SBI);
            Controls.Add(buttonQuestion_SBI);
            Controls.Add(groupBoxOutput_SBI);
            Controls.Add(groupBoxInput_SBI);
            Controls.Add(groupBoxTask_SBI);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Ермаков А.А.";
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput_SBI.ResumeLayout(false);
            groupBoxInput_SBI.PerformLayout();
            groupBoxOutput_SBI.ResumeLayout(false);
            groupBoxOutput_SBI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SBI;
        private GroupBox groupBoxInput_SBI;
        private GroupBox groupBoxOutput_SBI;
        private TextBox textBoxTask_SBI;
        private Label label1;
        private TextBox textBoxX_SBI;
        private Label label4;
        private TextBox textBoxResult_SBI;
        private Button buttonQuestion_SBI;
        private Button buttonDoneResult_SBI;
        private PictureBox pictureBox1;
    }
}
