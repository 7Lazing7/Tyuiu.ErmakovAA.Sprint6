using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.ErmakovAA.Sprint6.Task5.V2
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxMain_TDA = new GroupBox();
            textBoxCondition_TDA = new TextBox();
            buttonDone_TDA = new Button();
            buttonHelp_TDA = new Button();
            buttonOpen_TDA = new Button();
            panelTop_TDA = new Panel();
            chartResult_TDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_TDA = new GroupBox();
            dataGridViewFunction_TDA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            panelGridResult_TDA = new Panel();
            splitterResult_TDA = new Splitter();
            panelChartResult_TDA = new Panel();
            groupBoxMain_TDA.SuspendLayout();
            panelTop_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_TDA).BeginInit();
            groupBoxOutput_TDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_TDA).BeginInit();
            panelGridResult_TDA.SuspendLayout();
            panelChartResult_TDA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_TDA
            // 
            groupBoxMain_TDA.AccessibleName = "Условие";
            groupBoxMain_TDA.Controls.Add(textBoxCondition_TDA);
            groupBoxMain_TDA.Location = new Point(12, 5);
            groupBoxMain_TDA.Name = "groupBoxMain_TDA";
            groupBoxMain_TDA.Size = new Size(336, 101);
            groupBoxMain_TDA.TabIndex = 0;
            groupBoxMain_TDA.TabStop = false;
            groupBoxMain_TDA.Text = "Условие";
            // 
            // textBoxCondition_TDA
            // 
            textBoxCondition_TDA.BackColor = SystemColors.Menu;
            textBoxCondition_TDA.BorderStyle = BorderStyle.None;
            textBoxCondition_TDA.Location = new Point(6, 22);
            textBoxCondition_TDA.Multiline = true;
            textBoxCondition_TDA.Name = "textBoxCondition_TDA";
            textBoxCondition_TDA.ReadOnly = true;
            textBoxCondition_TDA.Size = new Size(320, 68);
            textBoxCondition_TDA.TabIndex = 1;
            textBoxCondition_TDA.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView.\r\n Вывести все числа не кратные 5. Построить диаграмму по этим значениям.";
            textBoxCondition_TDA.TextChanged += textBoxCondition_TDA_TextChanged;
            // 
            // buttonDone_TDA
            // 
            buttonDone_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_TDA.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_TDA.Location = new Point(354, 42);
            buttonDone_TDA.Name = "buttonDone_TDA";
            buttonDone_TDA.Size = new Size(132, 35);
            buttonDone_TDA.TabIndex = 3;
            buttonDone_TDA.Text = "Выполнить";
            buttonDone_TDA.UseVisualStyleBackColor = false;
            buttonDone_TDA.Click += buttonDone_TDA_Click;
            // 
            // buttonHelp_TDA
            // 
            buttonHelp_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_TDA.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp_TDA.Location = new Point(710, 42);
            buttonHelp_TDA.Name = "buttonHelp_TDA";
            buttonHelp_TDA.Size = new Size(142, 35);
            buttonHelp_TDA.TabIndex = 4;
            buttonHelp_TDA.Text = "Справка";
            buttonHelp_TDA.UseVisualStyleBackColor = false;
            buttonHelp_TDA.Click += buttonHelp_TDA_Click;
            // 
            // buttonOpen_TDA
            // 
            buttonOpen_TDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_TDA.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpen_TDA.Location = new Point(532, 42);
            buttonOpen_TDA.Name = "buttonOpen_TDA";
            buttonOpen_TDA.Size = new Size(133, 35);
            buttonOpen_TDA.TabIndex = 5;
            buttonOpen_TDA.Text = "Открыть файл";
            buttonOpen_TDA.UseVisualStyleBackColor = false;
            buttonOpen_TDA.Click += buttonSave_TDA_Click;
            // 
            // panelTop_TDA
            // 
            panelTop_TDA.Controls.Add(groupBoxMain_TDA);
            panelTop_TDA.Controls.Add(buttonHelp_TDA);
            panelTop_TDA.Controls.Add(buttonOpen_TDA);
            panelTop_TDA.Controls.Add(buttonDone_TDA);
            panelTop_TDA.Dock = DockStyle.Top;
            panelTop_TDA.Location = new Point(0, 0);
            panelTop_TDA.Name = "panelTop_TDA";
            panelTop_TDA.Size = new Size(864, 122);
            panelTop_TDA.TabIndex = 6;
            // 
            // chartResult_TDA
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_TDA.ChartAreas.Add(chartArea1);
            chartResult_TDA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartResult_TDA.Legends.Add(legend1);
            chartResult_TDA.Location = new Point(0, 0);
            chartResult_TDA.Name = "chartResult_TDA";
            chartResult_TDA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "F(X)";
            chartResult_TDA.Series.Add(series1);
            chartResult_TDA.Size = new Size(705, 439);
            chartResult_TDA.TabIndex = 3;
            chartResult_TDA.Text = "chart_Result_TDA";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.Name = "TitleFunction";
            chartResult_TDA.Titles.Add(title1);
            // 
            // groupBoxOutput_TDA
            // 
            groupBoxOutput_TDA.Controls.Add(dataGridViewFunction_TDA);
            groupBoxOutput_TDA.Dock = DockStyle.Fill;
            groupBoxOutput_TDA.Location = new Point(0, 0);
            groupBoxOutput_TDA.Name = "groupBoxOutput_TDA";
            groupBoxOutput_TDA.Size = new Size(156, 439);
            groupBoxOutput_TDA.TabIndex = 2;
            groupBoxOutput_TDA.TabStop = false;
            groupBoxOutput_TDA.Text = "Вывод данных";
            // 
            // dataGridViewFunction_TDA
            // 
            dataGridViewFunction_TDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_TDA.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewFunction_TDA.Dock = DockStyle.Fill;
            dataGridViewFunction_TDA.Location = new Point(3, 19);
            dataGridViewFunction_TDA.Name = "dataGridViewFunction_TDA";
            dataGridViewFunction_TDA.RowHeadersVisible = false;
            dataGridViewFunction_TDA.Size = new Size(150, 417);
            dataGridViewFunction_TDA.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 75;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.Name = "FX";
            FX.ReadOnly = true;
            FX.Width = 75;
            // 
            // panelGridResult_TDA
            // 
            panelGridResult_TDA.Controls.Add(groupBoxOutput_TDA);
            panelGridResult_TDA.Dock = DockStyle.Left;
            panelGridResult_TDA.Location = new Point(0, 122);
            panelGridResult_TDA.Name = "panelGridResult_TDA";
            panelGridResult_TDA.Size = new Size(156, 439);
            panelGridResult_TDA.TabIndex = 7;
            // 
            // splitterResult_TDA
            // 
            splitterResult_TDA.Location = new Point(156, 122);
            splitterResult_TDA.Name = "splitterResult_TDA";
            splitterResult_TDA.Size = new Size(3, 439);
            splitterResult_TDA.TabIndex = 8;
            splitterResult_TDA.TabStop = false;
            // 
            // panelChartResult_TDA
            // 
            panelChartResult_TDA.Controls.Add(chartResult_TDA);
            panelChartResult_TDA.Dock = DockStyle.Fill;
            panelChartResult_TDA.Location = new Point(159, 122);
            panelChartResult_TDA.Name = "panelChartResult_TDA";
            panelChartResult_TDA.Size = new Size(705, 439);
            panelChartResult_TDA.TabIndex = 9;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 561);
            Controls.Add(panelChartResult_TDA);
            Controls.Add(splitterResult_TDA);
            Controls.Add(panelGridResult_TDA);
            Controls.Add(panelTop_TDA);
            MinimumSize = new Size(880, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 27 | Томилов Д.А.";
            groupBoxMain_TDA.ResumeLayout(false);
            groupBoxMain_TDA.PerformLayout();
            panelTop_TDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_TDA).EndInit();
            groupBoxOutput_TDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_TDA).EndInit();
            panelGridResult_TDA.ResumeLayout(false);
            panelChartResult_TDA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_TDA;
        private Button buttonDone_TDA;
        private Button buttonHelp_TDA;
        private TextBox textBoxCondition_TDA;
        private Button buttonOpen_TDA;
        private Panel panelTop_TDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_TDA;
        private GroupBox groupBoxOutput_TDA;
        private Panel panelGridResult_TDA;
        private Splitter splitterResult_TDA;
        private Panel panelChartResult_TDA;
        private DataGridView dataGridViewFunction_TDA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
    }
}
