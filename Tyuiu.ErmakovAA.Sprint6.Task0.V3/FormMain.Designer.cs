
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
            groupBoxTask_ErmakovAA = new GroupBox();
            pictureBox_ErmakovAA = new PictureBox();
            textBoxTask_ErmakovAA = new TextBox();
            groupBoxInput_ErmakovAA = new GroupBox();
            label1 = new Label();
            textBoxX_ErmakovAA = new TextBox();
            groupBoxOutput__ErmakovAA = new GroupBox();
            label4 = new Label();
            textBoxResult__ErmakovAA = new TextBox();
            buttonQuestion__ErmakovAA = new Button();
            buttonDoneResult__ErmakovAA = new Button();
            groupBoxTask_ErmakovAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ErmakovAA).BeginInit();
            groupBoxInput_ErmakovAA.SuspendLayout();
            groupBoxOutput__ErmakovAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ErmakovAA
            // 
            groupBoxTask_ErmakovAA.Controls.Add(pictureBox_ErmakovAA);
            groupBoxTask_ErmakovAA.Controls.Add(textBoxTask_ErmakovAA);
            groupBoxTask_ErmakovAA.Font = new Font("Segoe UI", 12F);
            groupBoxTask_ErmakovAA.Location = new Point(12, 12);
            groupBoxTask_ErmakovAA.Name = "groupBoxTask_ErmakovAA";
            groupBoxTask_ErmakovAA.Size = new Size(706, 231);
            groupBoxTask_ErmakovAA.TabIndex = 0;
            groupBoxTask_ErmakovAA.TabStop = false;
            groupBoxTask_ErmakovAA.Text = "Условие";
            // 
            // pictureBox_ErmakovAA
            // 
            pictureBox_ErmakovAA.ErrorImage = null;
            pictureBox_ErmakovAA.Image = Resources.Снимок_экрана_2024_12_12_042410;
            pictureBox_ErmakovAA.Location = new Point(432, 22);
            pictureBox_ErmakovAA.Name = "pictureBox_ErmakovAA";
            pictureBox_ErmakovAA.Size = new Size(236, 136);
            pictureBox_ErmakovAA.TabIndex = 1;
            pictureBox_ErmakovAA.TabStop = false;
            // 
            // textBoxTask_ErmakovAA
            // 
            textBoxTask_ErmakovAA.BorderStyle = BorderStyle.None;
            textBoxTask_ErmakovAA.Font = new Font("Segoe UI", 12F);
            textBoxTask_ErmakovAA.Location = new Point(22, 31);
            textBoxTask_ErmakovAA.Multiline = true;
            textBoxTask_ErmakovAA.Name = "textBoxTask_ErmakovAA";
            textBoxTask_ErmakovAA.ReadOnly = true;
            textBoxTask_ErmakovAA.Size = new Size(326, 127);
            textBoxTask_ErmakovAA.TabIndex = 0;
            textBoxTask_ErmakovAA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            textBoxTask_ErmakovAA.TextChanged += textBoxTask_ErmakovAA_TextChanged;
            // 
            // groupBoxInput_ErmakovAA
            // 
            groupBoxInput_ErmakovAA.Controls.Add(label1);
            groupBoxInput_ErmakovAA.Controls.Add(textBoxX_ErmakovAA);
            groupBoxInput_ErmakovAA.Font = new Font("Segoe UI", 12F);
            groupBoxInput_ErmakovAA.Location = new Point(12, 261);
            groupBoxInput_ErmakovAA.Name = "groupBoxInput_ErmakovAA";
            groupBoxInput_ErmakovAA.Size = new Size(426, 100);
            groupBoxInput_ErmakovAA.TabIndex = 1;
            groupBoxInput_ErmakovAA.TabStop = false;
            groupBoxInput_ErmakovAA.Text = "Ввод данных";
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
            // textBoxX_ErmakovAA
            // 
            textBoxX_ErmakovAA.Font = new Font("Segoe UI", 10F);
            textBoxX_ErmakovAA.Location = new Point(22, 57);
            textBoxX_ErmakovAA.Name = "textBoxX_ErmakovAA";
            textBoxX_ErmakovAA.Size = new Size(108, 25);
            textBoxX_ErmakovAA.TabIndex = 0;
            textBoxX_ErmakovAA.KeyPress += textBoxVarX_ErmakovAA_KeyPress;
            // 
            // groupBoxOutput__ErmakovAA
            // 
            groupBoxOutput__ErmakovAA.Controls.Add(label4);
            groupBoxOutput__ErmakovAA.Controls.Add(textBoxResult__ErmakovAA);
            groupBoxOutput__ErmakovAA.Font = new Font("Segoe UI", 12F);
            groupBoxOutput__ErmakovAA.Location = new Point(444, 261);
            groupBoxOutput__ErmakovAA.Name = "groupBoxOutput_ErmakovAA";
            groupBoxOutput__ErmakovAA.Size = new Size(274, 100);
            groupBoxOutput__ErmakovAA.TabIndex = 2;
            groupBoxOutput__ErmakovAA.TabStop = false;
            groupBoxOutput__ErmakovAA.Text = "Вывод данных";
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
            // textBoxResult__ErmakovAA
            // 
            textBoxResult__ErmakovAA.Font = new Font("Segoe UI", 10F);
            textBoxResult__ErmakovAA.Location = new Point(6, 53);
            textBoxResult__ErmakovAA.Name = "textBoxResult__ErmakovAA";
            textBoxResult__ErmakovAA.ReadOnly = true;
            textBoxResult__ErmakovAA.Size = new Size(262, 25);
            textBoxResult__ErmakovAA.TabIndex = 8;
            // 
            // buttonQuestion__ErmakovAA
            // 
            buttonQuestion__ErmakovAA.FlatStyle = FlatStyle.Flat;
            buttonQuestion__ErmakovAA.Location = new Point(450, 376);
            buttonQuestion__ErmakovAA.Name = "buttonQuestion__ErmakovAA";
            buttonQuestion__ErmakovAA.Size = new Size(63, 62);
            buttonQuestion__ErmakovAA.TabIndex = 3;
            buttonQuestion__ErmakovAA.Text = "?";
            buttonQuestion__ErmakovAA.UseVisualStyleBackColor = true;
            buttonQuestion__ErmakovAA.Click += buttonQuestion_ErmakovAA_Click;
            // 
            // buttonDoneResult__ErmakovAA
            // 
            buttonDoneResult__ErmakovAA.BackgroundImageLayout = ImageLayout.None;
            buttonDoneResult__ErmakovAA.FlatStyle = FlatStyle.System;
            buttonDoneResult__ErmakovAA.Location = new Point(530, 376);
            buttonDoneResult__ErmakovAA.Name = "buttonDoneResult__ErmakovAA";
            buttonDoneResult__ErmakovAA.Size = new Size(182, 62);
            buttonDoneResult__ErmakovAA.TabIndex = 4;
            buttonDoneResult__ErmakovAA.Text = "Выполнить";
            buttonDoneResult__ErmakovAA.UseVisualStyleBackColor = true;
            buttonDoneResult__ErmakovAA.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(buttonDoneResult__ErmakovAA);
            Controls.Add(buttonQuestion__ErmakovAA);
            Controls.Add(groupBoxOutput__ErmakovAA);
            Controls.Add(groupBoxInput_ErmakovAA);
            Controls.Add(groupBoxTask_ErmakovAA);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 3 | Ермаков А.А.";
            groupBoxTask_ErmakovAA.ResumeLayout(false);
            groupBoxTask_ErmakovAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ErmakovAA).EndInit();
            groupBoxInput_ErmakovAA.ResumeLayout(false);
            groupBoxInput_ErmakovAA.PerformLayout();
            groupBoxOutput__ErmakovAA.ResumeLayout(false);
            groupBoxOutput__ErmakovAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ErmakovAA;
        private GroupBox groupBoxInput_ErmakovAA;
        private GroupBox groupBoxOutput__ErmakovAA;
        private TextBox textBoxTask_ErmakovAA;
        private Label label1;
        private TextBox textBoxX_ErmakovAA;
        private Label label4;
        private TextBox textBoxResult__ErmakovAA;
        private Button buttonQuestion__ErmakovAA;
        private Button buttonDoneResult__ErmakovAA;
        private PictureBox pictureBox_ErmakovAA;
    }
}

