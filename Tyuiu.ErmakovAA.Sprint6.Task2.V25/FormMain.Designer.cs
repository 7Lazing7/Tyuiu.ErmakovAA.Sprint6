using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;
using System;
namespace Tyuiu.ErmakovAA.Sprint6.Task2.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartResult_SBI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxTask_SBI = new TextBox();
            groupBoxTask_SBI = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBoxStopStep_SBI = new TextBox();
            textBoxStartStep_SBI = new TextBox();
            buttonHelp_SBI = new Button();
            buttonDone_SBI = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            dataGridView_SBI = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chartResult_SBI).BeginInit();
            groupBoxTask_SBI.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SBI).BeginInit();
            SuspendLayout();
            // 
            // chartResult_SBI
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_SBI.ChartAreas.Add(chartArea1);
            chartResult_SBI.Cursor = Cursors.SizeNWSE;
            chartResult_SBI.Location = new Point(131, 19);
            chartResult_SBI.Name = "chartResult_SBI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartResult_SBI.Series.Add(series1);
            chartResult_SBI.Size = new Size(415, 314);
            chartResult_SBI.TabIndex = 0;
            chartResult_SBI.Text = "chart1";
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_SBI.Location = new Point(11, 19);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(468, 127);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = "Протабулировать функцию:\r\n((5x + 2,5)/(sin(x)-2))+ 2 на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Location = new Point(12, 12);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.Size = new Size(513, 241);
            groupBoxTask_SBI.TabIndex = 2;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxStopStep_SBI);
            groupBox1.Controls.Add(textBoxStartStep_SBI);
            groupBox1.Location = new Point(12, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 92);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 9;
            label2.Text = "Конец шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 39);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Старт шага:";
            // 
            // textBoxStopStep_SBI
            // 
            textBoxStopStep_SBI.Location = new Point(145, 57);
            textBoxStopStep_SBI.Name = "textBoxStopStep_SBI";
            textBoxStopStep_SBI.Size = new Size(128, 23);
            textBoxStopStep_SBI.TabIndex = 8;
            textBoxStopStep_SBI.KeyPress += textBoxSteps_SBI_KeyPress;
            // 
            // textBoxStartStep_SBI
            // 
            textBoxStartStep_SBI.Location = new Point(11, 57);
            textBoxStartStep_SBI.Name = "textBoxStartStep_SBI";
            textBoxStartStep_SBI.Size = new Size(128, 23);
            textBoxStartStep_SBI.TabIndex = 6;
            textBoxStartStep_SBI.KeyPress += textBoxSteps_SBI_KeyPress;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.BackColor = Color.FromArgb(255, 128, 255);
            buttonHelp_SBI.Location = new Point(319, 259);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(66, 92);
            buttonHelp_SBI.TabIndex = 8;
            buttonHelp_SBI.Text = "Справка";
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            buttonHelp_SBI.Click += buttonHelp_SBI_Click;
            // 
            // buttonDone_SBI
            // 
            buttonDone_SBI.BackColor = Color.Salmon;
            buttonDone_SBI.Location = new Point(391, 259);
            buttonDone_SBI.Name = "buttonDone_SBI";
            buttonDone_SBI.Size = new Size(134, 92);
            buttonDone_SBI.TabIndex = 7;
            buttonDone_SBI.Text = "Выполнить";
            buttonDone_SBI.UseVisualStyleBackColor = false;
            buttonDone_SBI.Click += buttonDone_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGridView_SBI);
            groupBox2.Controls.Add(chartResult_SBI);
            groupBox2.Location = new Point(531, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(552, 339);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Результат";
            // 
            // dataGridView_SBI
            // 
            dataGridView_SBI.AllowUserToAddRows = false;
            dataGridView_SBI.AllowUserToDeleteRows = false;
            dataGridView_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SBI.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView_SBI.Location = new Point(6, 37);
            dataGridView_SBI.Name = "dataGridView_SBI";
            dataGridView_SBI.ReadOnly = true;
            dataGridView_SBI.RowHeadersVisible = false;
            dataGridView_SBI.Size = new Size(119, 296);
            dataGridView_SBI.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 363);
            Controls.Add(groupBox2);
            Controls.Add(buttonHelp_SBI);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone_SBI);
            Controls.Add(groupBoxTask_SBI);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 25 | Ермаков А.А. ";
            ((System.ComponentModel.ISupportInitialize)chartResult_SBI).EndInit();
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SBI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SBI;
        private TextBox textBoxTask_SBI;
        private GroupBox groupBoxTask_SBI;
        private GroupBox groupBox1;
        private Button buttonHelp_SBI;
        private Button buttonDone_SBI;
        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dataGridView_SBI;
        private Label label2;
        private Label label3;
        private TextBox textBoxStopStep_SBI;
        private TextBox textBoxStartStep_SBI;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
