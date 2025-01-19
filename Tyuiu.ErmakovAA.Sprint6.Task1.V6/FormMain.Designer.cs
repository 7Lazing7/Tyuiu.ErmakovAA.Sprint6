namespace Tyuiu.ErmakovAA.Sprint6.Task1.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_ErmakovAA




                = new GroupBox();
            textBoxTask_ErmakovAA = new TextBox();
            groupBoxResult_ErmakovAA = new GroupBox();
            labelResult_ErmakovAA = new Label();
            textBoxResult_ErmakovAA = new TextBox();
            groupBoxInput_ErmakovAA = new GroupBox();
            label2 = new Label();
            textBoxStopStep_ErmakovAA = new TextBox();
            label1 = new Label();
            textBoxStartStep_ErmakovAA = new TextBox();
            buttonDone_ErmakovAA = new Button();
            buttonHelp_ErmakovAA = new Button();
            groupBoxTask_ErmakovAA.SuspendLayout();
            groupBoxResult_ErmakovAA.SuspendLayout();
            groupBoxInput_ErmakovAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_ErmakovAA
            // 
            groupBoxTask_ErmakovAA.Controls.Add(textBoxTask_ErmakovAA);
            groupBoxTask_ErmakovAA.Location = new Point(12, 12);
            groupBoxTask_ErmakovAA.Name = "groupBoxTask_ErmakovAA";
            groupBoxTask_ErmakovAA.Size = new Size(485, 308);
            groupBoxTask_ErmakovAA.TabIndex = 1;
            groupBoxTask_ErmakovAA.TabStop = false;
            groupBoxTask_ErmakovAA.Text = "Условие";
            // 
            // textBoxTask_ErmakovAA
            // 
            textBoxTask_ErmakovAA.BorderStyle = BorderStyle.None;
            textBoxTask_ErmakovAA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_ErmakovAA.Location = new Point(11, 19);
            textBoxTask_ErmakovAA.Multiline = true;
            textBoxTask_ErmakovAA.Name = "textBoxTask_ErmakovAA";
            textBoxTask_ErmakovAA.ReadOnly = true;
            textBoxTask_ErmakovAA.Size = new Size(468, 169);
            textBoxTask_ErmakovAA.TabIndex = 0;
            textBoxTask_ErmakovAA.Text = resources.GetString("textBoxTask_ErmakovAA.Text");
            // 
            // groupBoxResult_ErmakovAA
            // 
            groupBoxResult_ErmakovAA.Controls.Add(labelResult_ErmakovAA);
            groupBoxResult_ErmakovAA.Controls.Add(textBoxResult_ErmakovAA);
            groupBoxResult_ErmakovAA.Location = new Point(503, 12);
            groupBoxResult_ErmakovAA.Name = "groupBoxResult_ErmakovAA";
            groupBoxResult_ErmakovAA.Size = new Size(285, 414);
            groupBoxResult_ErmakovAA.TabIndex = 2;
            groupBoxResult_ErmakovAA.TabStop = false;
            groupBoxResult_ErmakovAA.Text = "Вывод данных";
            // 
            // labelResult_ErmakovAA
            // 
            labelResult_ErmakovAA.AutoSize = true;
            labelResult_ErmakovAA.Location = new Point(6, 23);
            labelResult_ErmakovAA.Name = "labelResult_ErmakovAA";
            labelResult_ErmakovAA.Size = new Size(63, 15);
            labelResult_ErmakovAA.TabIndex = 2;
            labelResult_ErmakovAA.Text = "Результат:";
            // 
            // textBoxResult_ErmakovAA
            // 
            textBoxResult_ErmakovAA.BorderStyle = BorderStyle.None;
            textBoxResult_ErmakovAA.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_ErmakovAA.Location = new Point(6, 41);
            textBoxResult_ErmakovAA.Multiline = true;
            textBoxResult_ErmakovAA.Name = "textBoxResult_ErmakovAA";
            textBoxResult_ErmakovAA.ReadOnly = true;
            textBoxResult_ErmakovAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_ErmakovAA.Size = new Size(273, 367);
            textBoxResult_ErmakovAA.TabIndex = 1;
            // 
            // groupBoxInput_ErmakovAA
            // 
            groupBoxInput_ErmakovAA.Controls.Add(label2);
            groupBoxInput_ErmakovAA.Controls.Add(textBoxStopStep_ErmakovAA);
            groupBoxInput_ErmakovAA.Controls.Add(label1);
            groupBoxInput_ErmakovAA.Controls.Add(textBoxStartStep_ErmakovAA);
            groupBoxInput_ErmakovAA.Location = new Point(12, 326);
            groupBoxInput_ErmakovAA.Name = "groupBoxInput_ErmakovAA";
            groupBoxInput_ErmakovAA.Size = new Size(273, 100);
            groupBoxInput_ErmakovAA.TabIndex = 3;
            groupBoxInput_ErmakovAA.TabStop = false;
            groupBoxInput_ErmakovAA.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Конец шага:";
            // 
            // textBoxStopStep_ErmakovAA
            // 
            textBoxStopStep_ErmakovAA.Location = new Point(140, 53);
            textBoxStopStep_ErmakovAA.Name = "textBoxStopStep_ErmakovAA";
            textBoxStopStep_ErmakovAA.Size = new Size(128, 23);
            textBoxStopStep_ErmakovAA.TabIndex = 4;
            textBoxStopStep_ErmakovAA.KeyPress += textBoxSteps_ErmakovAA_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            // 
            // textBoxStartStep_ErmakovAA
            // 
            textBoxStartStep_ErmakovAA.Location = new Point(6, 53);
            textBoxStartStep_ErmakovAA.Name = "textBoxStartStep_ErmakovAA";
            textBoxStartStep_ErmakovAA.Size = new Size(128, 23);
            textBoxStartStep_ErmakovAA.TabIndex = 0;
            textBoxStartStep_ErmakovAA.KeyPress += textBoxSteps_ErmakovAA_KeyPress;
            // 
            // buttonDone_ErmakovAA
            // 
            buttonDone_ErmakovAA.BackColor = SystemColors.ActiveCaption;
            buttonDone_ErmakovAA.Location = new Point(363, 337);
            buttonDone_ErmakovAA.Name = "buttonDone_ErmakovAA";
            buttonDone_ErmakovAA.Size = new Size(134, 89);
            buttonDone_ErmakovAA.TabIndex = 5;
            buttonDone_ErmakovAA.Text = "Выполнить";
            buttonDone_ErmakovAA.UseVisualStyleBackColor = false;
            buttonDone_ErmakovAA.Click += buttonDone_Click;
            // 
            // buttonHelp_ErmakovAA
            // 
            buttonHelp_ErmakovAA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_ErmakovAA.Location = new Point(291, 337);
            buttonHelp_ErmakovAA.Name = "buttonHelp_ErmakovAA";
            buttonHelp_ErmakovAA.Size = new Size(66, 89);
            buttonHelp_ErmakovAA.TabIndex = 6;
            buttonHelp_ErmakovAA.Text = "Справка";
            buttonHelp_ErmakovAA.UseVisualStyleBackColor = false;
            buttonHelp_ErmakovAA.Click += buttonHelp_ErmakovAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_ErmakovAA);
            Controls.Add(buttonDone_ErmakovAA);
            Controls.Add(groupBoxInput_ErmakovAA);
            Controls.Add(groupBoxResult_ErmakovAA);
            Controls.Add(groupBoxTask_ErmakovAA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 6 | Ермаков А.А.";
            groupBoxTask_ErmakovAA.ResumeLayout(false);
            groupBoxTask_ErmakovAA.PerformLayout();
            groupBoxResult_ErmakovAA.ResumeLayout(false);
            groupBoxResult_ErmakovAA.PerformLayout();
            groupBoxInput_ErmakovAA.ResumeLayout(false);
            groupBoxInput_ErmakovAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_ErmakovAA;
        private TextBox textBoxTask_ErmakovAA;
        private GroupBox groupBoxResult_ErmakovAA;
        private GroupBox groupBoxInput_ErmakovAA;
        private Label label1;
        private TextBox textBoxStartStep_ErmakovAA;
        private Label label2;
        private TextBox textBoxStopStep_ErmakovAA;
        private Label labelResult_ErmakovAA;
        private TextBox textBoxResult_ErmakovAA;
        private Button buttonDone_ErmakovAA;
        private Button buttonHelp_ErmakovAA;
    }
}
