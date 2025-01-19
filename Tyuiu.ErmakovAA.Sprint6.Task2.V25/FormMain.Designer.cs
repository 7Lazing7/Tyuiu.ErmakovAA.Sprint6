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
            chartResult_ErmakovAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxTask_ErmakovAA = new TextBox();
            groupBoxTask_ErmakovAA = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBoxStopStep_ErmakovAA = new TextBox();
            textBoxStartStep_ErmakovAA = new TextBox();
            buttonHelp_ErmakovAA = new Button();
            buttonDone_ErmakovAA = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            dataGridView_ErmakovAA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chartResult_ErmakovAA).BeginInit();
            groupBoxTask_ErmakovAA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ErmakovAA).BeginInit();
            SuspendLayout();
            // 
            // chartResult_ErmakovAA
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_ErmakovAA.ChartAreas.Add(chartArea1);
            chartResult_ErmakovAA.Cursor = Cursors.SizeNWSE;
            chartResult_ErmakovAA.Location = new Point(131, 19);
            chartResult_ErmakovAA.Name = "chartResult_ErmakovAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartResult_ErmakovAA.Series.Add(series1);
            chartResult_ErmakovAA.Size = new Size(415, 314);
            chartResult_ErmakovAA.TabIndex = 0;
            chartResult_ErmakovAA.Text = "chart1";
            // 
            // textBoxTask_ErmakovAA
            // 
            textBoxTask_ErmakovAA.BorderStyle = BorderStyle.None;
            textBoxTask_ErmakovAA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_ErmakovAA.Location = new Point(11, 19);
            textBoxTask_ErmakovAA.Multiline = true;
            textBoxTask_ErmakovAA.Name = "textBoxTask_ErmakovAA";
            textBoxTask_ErmakovAA.ReadOnly = true;
            textBoxTask_ErmakovAA.Size = new Size(468, 127);
            textBoxTask_ErmakovAA.TabIndex = 0;
            textBoxTask_ErmakovAA.Text = "Протабулировать функцию:\r\n((5x + 2,5)/(sin(x)-2))+ 2 на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxTask_ErmakovAA
            // 
            groupBoxTask_ErmakovAA.Controls.Add(textBoxTask_ErmakovAA);
            groupBoxTask_ErmakovAA.Location = new Point(12, 12);
            groupBoxTask_ErmakovAA.Name = "groupBoxTask_ErmakovAA";
            groupBoxTask_ErmakovAA.Size = new Size(513, 241);
            groupBoxTask_ErmakovAA.TabIndex = 2;
            groupBoxTask_ErmakovAA.TabStop = false;
            groupBoxTask_ErmakovAA.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxStopStep_ErmakovAA);
            groupBox1.Controls.Add(textBoxStartStep_ErmakovAA);
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
            // textBoxStopStep_ErmakovAA
            // 
            textBoxStopStep_ErmakovAA.Location = new Point(145, 57);
            textBoxStopStep_ErmakovAA.Name = "textBoxStopStep_ErmakovAA";
            textBoxStopStep_ErmakovAA.Size = new Size(128, 23);
            textBoxStopStep_ErmakovAA.TabIndex = 8;
            textBoxStopStep_ErmakovAA.KeyPress += textBoxSteps_ErmakovAA_KeyPress;
            // 
            // textBoxStartStep_ErmakovAA
            // 
            textBoxStartStep_ErmakovAA.Location = new Point(11, 57);
            textBoxStartStep_ErmakovAA.Name = "textBoxStartStep_ErmakovAA";
            textBoxStartStep_ErmakovAA.Size = new Size(128, 23);
            textBoxStartStep_ErmakovAA.TabIndex = 6;
            textBoxStartStep_ErmakovAA.KeyPress += textBoxSteps_ErmakovAA_KeyPress;
            // 
            // buttonHelp_ErmakovAA
            // 
            buttonHelp_ErmakovAA.BackColor = Color.FromArgb(255, 128, 255);
            buttonHelp_ErmakovAA.Location = new Point(319, 259);
            buttonHelp_ErmakovAA.Name = "buttonHelp_ErmakovAA";
            buttonHelp_ErmakovAA.Size = new Size(66, 92);
            buttonHelp_ErmakovAA.TabIndex = 8;
            buttonHelp_ErmakovAA.Text = "Справка";
            buttonHelp_ErmakovAA.UseVisualStyleBackColor = false;
            buttonHelp_ErmakovAA.Click += buttonHelp_ErmakovAA_Click;
            // 
            // buttonDone_ErmakovAA
            // 
            buttonDone_ErmakovAA.BackColor = Color.Salmon;
            buttonDone_ErmakovAA.Location = new Point(391, 259);
            buttonDone_ErmakovAA.Name = "buttonDone_ErmakovAA";
            buttonDone_ErmakovAA.Size = new Size(134, 92);
            buttonDone_ErmakovAA.TabIndex = 7;
            buttonDone_ErmakovAA.Text = "Выполнить";
            buttonDone_ErmakovAA.UseVisualStyleBackColor = false;
            buttonDone_ErmakovAA.Click += buttonDone_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGridView_ErmakovAA);
            groupBox2.Controls.Add(chartResult_ErmakovAA);
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
            // dataGridView_ErmakovAA
            // 
            dataGridView_ErmakovAA.AllowUserToAddRows = false;
            dataGridView_ErmakovAA.AllowUserToDeleteRows = false;
            dataGridView_ErmakovAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ErmakovAA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView_ErmakovAA.Location = new Point(6, 37);
            dataGridView_ErmakovAA.Name = "dataGridView_ErmakovAA";
            dataGridView_ErmakovAA.ReadOnly = true;
            dataGridView_ErmakovAA.RowHeadersVisible = false;
            dataGridView_ErmakovAA.Size = new Size(119, 296);
            dataGridView_ErmakovAA.TabIndex = 1;
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
            Controls.Add(buttonHelp_ErmakovAA);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone_ErmakovAA);
            Controls.Add(groupBoxTask_ErmakovAA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 25 | Ермаков А.А. ";
            ((System.ComponentModel.ISupportInitialize)chartResult_ErmakovAA).EndInit();
            groupBoxTask_ErmakovAA.ResumeLayout(false);
            groupBoxTask_ErmakovAA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ErmakovAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_ErmakovAA;
        private TextBox textBoxTask_ErmakovAA;
        private GroupBox groupBoxTask_ErmakovAA;
        private GroupBox groupBox1;
        private Button buttonHelp_ErmakovAA;
        private Button buttonDone_ErmakovAA;
        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dataGridView_ErmakovAA;
        private Label label2;
        private Label label3;
        private TextBox textBoxStopStep_ErmakovAA;
        private TextBox textBoxStartStep_ErmakovAA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
