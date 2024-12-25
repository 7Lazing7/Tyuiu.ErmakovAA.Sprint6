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
            groupBoxTask_SBI = new GroupBox();
            textBoxTask_SBI = new TextBox();
            groupBoxResult_SBI = new GroupBox();
            labelResult_SBI = new Label();
            textBoxResult_SBI = new TextBox();
            groupBoxInput_SBI = new GroupBox();
            label2 = new Label();
            textBoxStopStep_SBI = new TextBox();
            label1 = new Label();
            textBoxStartStep_SBI = new TextBox();
            buttonDone_SBI = new Button();
            buttonHelp_SBI = new Button();
            groupBoxTask_SBI.SuspendLayout();
            groupBoxResult_SBI.SuspendLayout();
            groupBoxInput_SBI.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Location = new Point(12, 12);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.Size = new Size(485, 308);
            groupBoxTask_SBI.TabIndex = 1;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие";
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_SBI.Location = new Point(11, 19);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(468, 169);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = resources.GetString("textBoxTask_SBI.Text");
            // 
            // groupBoxResult_SBI
            // 
            groupBoxResult_SBI.Controls.Add(labelResult_SBI);
            groupBoxResult_SBI.Controls.Add(textBoxResult_SBI);
            groupBoxResult_SBI.Location = new Point(503, 12);
            groupBoxResult_SBI.Name = "groupBoxResult_SBI";
            groupBoxResult_SBI.Size = new Size(285, 414);
            groupBoxResult_SBI.TabIndex = 2;
            groupBoxResult_SBI.TabStop = false;
            groupBoxResult_SBI.Text = "Вывод данных";
            // 
            // labelResult_SBI
            // 
            labelResult_SBI.AutoSize = true;
            labelResult_SBI.Location = new Point(6, 23);
            labelResult_SBI.Name = "labelResult_SBI";
            labelResult_SBI.Size = new Size(63, 15);
            labelResult_SBI.TabIndex = 2;
            labelResult_SBI.Text = "Результат:";
            // 
            // textBoxResult_SBI
            // 
            textBoxResult_SBI.BorderStyle = BorderStyle.None;
            textBoxResult_SBI.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SBI.Location = new Point(6, 41);
            textBoxResult_SBI.Multiline = true;
            textBoxResult_SBI.Name = "textBoxResult_SBI";
            textBoxResult_SBI.ReadOnly = true;
            textBoxResult_SBI.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SBI.Size = new Size(273, 367);
            textBoxResult_SBI.TabIndex = 1;
            // 
            // groupBoxInput_SBI
            // 
            groupBoxInput_SBI.Controls.Add(label2);
            groupBoxInput_SBI.Controls.Add(textBoxStopStep_SBI);
            groupBoxInput_SBI.Controls.Add(label1);
            groupBoxInput_SBI.Controls.Add(textBoxStartStep_SBI);
            groupBoxInput_SBI.Location = new Point(12, 326);
            groupBoxInput_SBI.Name = "groupBoxInput_SBI";
            groupBoxInput_SBI.Size = new Size(273, 100);
            groupBoxInput_SBI.TabIndex = 3;
            groupBoxInput_SBI.TabStop = false;
            groupBoxInput_SBI.Text = "Ввод данных";
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
            // textBoxStopStep_SBI
            // 
            textBoxStopStep_SBI.Location = new Point(140, 53);
            textBoxStopStep_SBI.Name = "textBoxStopStep_SBI";
            textBoxStopStep_SBI.Size = new Size(128, 23);
            textBoxStopStep_SBI.TabIndex = 4;
            textBoxStopStep_SBI.KeyPress += textBoxSteps_SBI_KeyPress;
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
            // textBoxStartStep_SBI
            // 
            textBoxStartStep_SBI.Location = new Point(6, 53);
            textBoxStartStep_SBI.Name = "textBoxStartStep_SBI";
            textBoxStartStep_SBI.Size = new Size(128, 23);
            textBoxStartStep_SBI.TabIndex = 0;
            textBoxStartStep_SBI.KeyPress += textBoxSteps_SBI_KeyPress;
            // 
            // buttonDone_SBI
            // 
            buttonDone_SBI.BackColor = SystemColors.ActiveCaption;
            buttonDone_SBI.Location = new Point(363, 337);
            buttonDone_SBI.Name = "buttonDone_SBI";
            buttonDone_SBI.Size = new Size(134, 89);
            buttonDone_SBI.TabIndex = 5;
            buttonDone_SBI.Text = "Выполнить";
            buttonDone_SBI.UseVisualStyleBackColor = false;
            buttonDone_SBI.Click += buttonDone_Click;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.BackColor = SystemColors.ActiveCaption;
            buttonHelp_SBI.Location = new Point(291, 337);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(66, 89);
            buttonHelp_SBI.TabIndex = 6;
            buttonHelp_SBI.Text = "Справка";
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            buttonHelp_SBI.Click += buttonHelp_SBI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_SBI);
            Controls.Add(buttonDone_SBI);
            Controls.Add(groupBoxInput_SBI);
            Controls.Add(groupBoxResult_SBI);
            Controls.Add(groupBoxTask_SBI);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 6 | Ермаков А.А.";
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            groupBoxResult_SBI.ResumeLayout(false);
            groupBoxResult_SBI.PerformLayout();
            groupBoxInput_SBI.ResumeLayout(false);
            groupBoxInput_SBI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SBI;
        private TextBox textBoxTask_SBI;
        private GroupBox groupBoxResult_SBI;
        private GroupBox groupBoxInput_SBI;
        private Label label1;
        private TextBox textBoxStartStep_SBI;
        private Label label2;
        private TextBox textBoxStopStep_SBI;
        private Label labelResult_SBI;
        private TextBox textBoxResult_SBI;
        private Button buttonDone_SBI;
        private Button buttonHelp_SBI;
    }
}
