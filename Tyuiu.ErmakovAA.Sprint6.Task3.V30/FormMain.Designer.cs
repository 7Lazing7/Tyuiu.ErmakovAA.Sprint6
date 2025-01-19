namespace Tyuiu.ErmakovAA.Sprint6.Task3.V30
{
    partial class FormMain
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
            groupBoxTask_TVD = new GroupBox();
            dataGridViewMatrix_TVD = new DataGridView();
            labelInfo_TVD = new Label();
            groupBoxOutPutData_TVD = new GroupBox();
            dataGridViewMatrix2_TVD = new DataGridView();
            buttonDone_TVD = new Button();
            buttonHelp_TVD = new Button();
            groupBox1 = new GroupBox();
            groupBoxTask_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_TVD).BeginInit();
            groupBoxOutPutData_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix2_TVD).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_TVD
            // 
            groupBoxTask_TVD.Controls.Add(groupBox1);
            groupBoxTask_TVD.Controls.Add(labelInfo_TVD);
            groupBoxTask_TVD.Location = new Point(15, 15);
            groupBoxTask_TVD.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask_TVD.Name = "groupBoxTask_TVD";
            groupBoxTask_TVD.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask_TVD.Size = new Size(603, 294);
            groupBoxTask_TVD.TabIndex = 0;
            groupBoxTask_TVD.TabStop = false;
            groupBoxTask_TVD.Text = "Условие";
            // 
            // dataGridViewMatrix_TVD
            // 
            dataGridViewMatrix_TVD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_TVD.ColumnHeadersVisible = false;
            dataGridViewMatrix_TVD.Location = new Point(8, 22);
            dataGridViewMatrix_TVD.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMatrix_TVD.Name = "dataGridViewMatrix_TVD";
            dataGridViewMatrix_TVD.ReadOnly = true;
            dataGridViewMatrix_TVD.RowHeadersVisible = false;
            dataGridViewMatrix_TVD.Size = new Size(280, 257);
            dataGridViewMatrix_TVD.TabIndex = 1;
            // 
            // labelInfo_TVD
            // 
            labelInfo_TVD.AutoSize = true;
            labelInfo_TVD.Location = new Point(8, 23);
            labelInfo_TVD.Margin = new Padding(4, 0, 4, 0);
            labelInfo_TVD.Name = "labelInfo_TVD";
            labelInfo_TVD.Size = new Size(269, 105);
            labelInfo_TVD.TabIndex = 0;
            labelInfo_TVD.Text = "Дана матрица 5 на 5\r\n -9  -4  17  -1 -20\r\n -19  18  -4   2  14\r\n -12  16  -2   7  18\r\n -16  15   4 -12 -13\r\n -15  -4 -16   1 -14\r\nЗаменить четные значения в пятой строке на 0.";
            // 
            // groupBoxOutPutData_TVD
            // 
            groupBoxOutPutData_TVD.Controls.Add(dataGridViewMatrix2_TVD);
            groupBoxOutPutData_TVD.Location = new Point(625, 15);
            groupBoxOutPutData_TVD.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPutData_TVD.Name = "groupBoxOutPutData_TVD";
            groupBoxOutPutData_TVD.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPutData_TVD.Size = new Size(294, 294);
            groupBoxOutPutData_TVD.TabIndex = 1;
            groupBoxOutPutData_TVD.TabStop = false;
            groupBoxOutPutData_TVD.Text = "Вывод данных";
            // 
            // dataGridViewMatrix2_TVD
            // 
            dataGridViewMatrix2_TVD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix2_TVD.ColumnHeadersVisible = false;
            dataGridViewMatrix2_TVD.Location = new Point(7, 22);
            dataGridViewMatrix2_TVD.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMatrix2_TVD.Name = "dataGridViewMatrix2_TVD";
            dataGridViewMatrix2_TVD.ReadOnly = true;
            dataGridViewMatrix2_TVD.RowHeadersVisible = false;
            dataGridViewMatrix2_TVD.Size = new Size(280, 257);
            dataGridViewMatrix2_TVD.TabIndex = 0;
            // 
            // buttonDone_TVD
            // 
            buttonDone_TVD.Location = new Point(798, 309);
            buttonDone_TVD.Margin = new Padding(4, 3, 4, 3);
            buttonDone_TVD.Name = "buttonDone_TVD";
            buttonDone_TVD.Size = new Size(114, 38);
            buttonDone_TVD.TabIndex = 2;
            buttonDone_TVD.Text = "Выполнить";
            buttonDone_TVD.UseVisualStyleBackColor = true;
            buttonDone_TVD.Click += buttonDone_Click;
            // 
            // buttonHelp_TVD
            // 
            buttonHelp_TVD.Location = new Point(755, 309);
            buttonHelp_TVD.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_TVD.Name = "buttonHelp_TVD";
            buttonHelp_TVD.Size = new Size(36, 38);
            buttonHelp_TVD.TabIndex = 3;
            buttonHelp_TVD.Text = "?";
            buttonHelp_TVD.UseVisualStyleBackColor = true;
            buttonHelp_TVD.Click += buttonHelp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMatrix_TVD);
            groupBox1.Location = new Point(315, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(294, 294);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Исходные данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 372);
            Controls.Add(buttonHelp_TVD);
            Controls.Add(buttonDone_TVD);
            Controls.Add(groupBoxOutPutData_TVD);
            Controls.Add(groupBoxTask_TVD);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 30 | Ермаков А.А";
            Load += FormMain_Load;
            groupBoxTask_TVD.ResumeLayout(false);
            groupBoxTask_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_TVD).EndInit();
            groupBoxOutPutData_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix2_TVD).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_TVD;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_TVD;
        private System.Windows.Forms.DataGridView dataGridViewMatrix2_TVD;
        private System.Windows.Forms.Button buttonDone_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private GroupBox groupBox1;
    }
}