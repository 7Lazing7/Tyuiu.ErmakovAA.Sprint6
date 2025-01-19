namespace Tyuiu.ErmakovAA.Sprint6.Task4.V15
{
    partial class FromMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromMain));
            this.groupBoxTask_ErmakovAA = new System.Windows.Forms.GroupBox();
            this.chartFunc_ErmakovAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSave_ErmakovAA = new System.Windows.Forms.Button();
            this.pictureBoxFormula_ErmakovAA = new System.Windows.Forms.PictureBox();
            this.labelTask_ErmakovAA = new System.Windows.Forms.Label();
            this.buttonHelp_ErmakovAA = new System.Windows.Forms.Button();
            this.groupBoxInputData_ErmakovAA = new System.Windows.Forms.GroupBox();
            this.textBoxVarStart_ErmakovAA = new System.Windows.Forms.TextBox();
            this.labelStart_ErmakovAA = new System.Windows.Forms.Label();
            this.labelStop_ErmakovAA = new System.Windows.Forms.Label();
            this.textBoxVarStop_ErmakovAA = new System.Windows.Forms.TextBox();
            this.buttonDone_ErmakovAA = new System.Windows.Forms.Button();
            this.textBoxRes_ErmakovAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_ErmakovAA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_ErmakovAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_ErmakovAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ErmakovAA)).BeginInit();
            this.groupBoxInputData_ErmakovAA.SuspendLayout();
            this.groupBoxOutputData_ErmakovAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_ErmakovAA
            // 
            this.groupBoxTask_ErmakovAA.Controls.Add(this.labelTask_ErmakovAA);
            this.groupBoxTask_ErmakovAA.Controls.Add(this.pictureBoxFormula_ErmakovAA);
            this.groupBoxTask_ErmakovAA.Location = new System.Drawing.Point(12, 6);
            this.groupBoxTask_ErmakovAA.Name = "groupBoxTask_ErmakovAA";
            this.groupBoxTask_ErmakovAA.Size = new System.Drawing.Size(355, 103);
            this.groupBoxTask_ErmakovAA.TabIndex = 15;
            this.groupBoxTask_ErmakovAA.TabStop = false;
            this.groupBoxTask_ErmakovAA.Text = "Условие";
            // 
            // chartFunc_ErmakovAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_ErmakovAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunc_ErmakovAA.Legends.Add(legend1);
            this.chartFunc_ErmakovAA.Location = new System.Drawing.Point(221, 115);
            this.chartFunc_ErmakovAA.Name = "chartFunc_ErmakovAA";
            this.chartFunc_ErmakovAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunc_ErmakovAA.Series.Add(series1);
            this.chartFunc_ErmakovAA.Size = new System.Drawing.Size(557, 399);
            this.chartFunc_ErmakovAA.TabIndex = 20;
            this.chartFunc_ErmakovAA.Text = "chart1";
            // 
            // buttonSave_ErmakovAA
            // 
            this.buttonSave_ErmakovAA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave_ErmakovAA.Location = new System.Drawing.Point(524, 64);
            this.buttonSave_ErmakovAA.Name = "buttonSave_ErmakovAA";
            this.buttonSave_ErmakovAA.Size = new System.Drawing.Size(135, 29);
            this.buttonSave_ErmakovAA.TabIndex = 21;
            this.buttonSave_ErmakovAA.Text = "Сохранить";
            this.buttonSave_ErmakovAA.UseVisualStyleBackColor = false;
            this.buttonSave_ErmakovAA.Click += new System.EventHandler(this.buttonSave_ErmakovAA_Click);
            // 
            // pictureBoxFormula_ErmakovAA
            // 
            this.pictureBoxFormula_ErmakovAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_ErmakovAA.Image")));
            this.pictureBoxFormula_ErmakovAA.Location = new System.Drawing.Point(22, 50);
            this.pictureBoxFormula_ErmakovAA.Name = "pictureBoxFormula_ErmakovAA";
            this.pictureBoxFormula_ErmakovAA.Size = new System.Drawing.Size(322, 37);
            this.pictureBoxFormula_ErmakovAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFormula_ErmakovAA.TabIndex = 0;
            this.pictureBoxFormula_ErmakovAA.TabStop = false;
            // 
            // labelTask_ErmakovAA
            // 
            this.labelTask_ErmakovAA.AutoSize = true;
            this.labelTask_ErmakovAA.Location = new System.Drawing.Point(19, 17);
            this.labelTask_ErmakovAA.Name = "labelTask_ErmakovAA";
            this.labelTask_ErmakovAA.Size = new System.Drawing.Size(299, 26);
            this.labelTask_ErmakovAA.TabIndex = 2;
            this.labelTask_ErmakovAA.Text = "Протабулировать функцию на заданном диапазоне [-5;5].\r\nРезультат вывести в таблиц" +
    "у.\r\n";
            // 
            // buttonHelp_ErmakovAA
            // 
            this.buttonHelp_ErmakovAA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_ErmakovAA.Location = new System.Drawing.Point(688, 23);
            this.buttonHelp_ErmakovAA.Name = "buttonHelp_ErmakovAA";
            this.buttonHelp_ErmakovAA.Size = new System.Drawing.Size(90, 30);
            this.buttonHelp_ErmakovAA.TabIndex = 19;
            this.buttonHelp_ErmakovAA.Text = "Справка";
            this.buttonHelp_ErmakovAA.UseVisualStyleBackColor = false;
            this.buttonHelp_ErmakovAA.Click += new System.EventHandler(this.buttonHelp_ErmakovAA_Click);
            // 
            // groupBoxInputData_ErmakovAA
            // 
            this.groupBoxInputData_ErmakovAA.Controls.Add(this.textBoxVarStop_ErmakovAA);
            this.groupBoxInputData_ErmakovAA.Controls.Add(this.labelStop_ErmakovAA);
            this.groupBoxInputData_ErmakovAA.Controls.Add(this.labelStart_ErmakovAA);
            this.groupBoxInputData_ErmakovAA.Controls.Add(this.textBoxVarStart_ErmakovAA);
            this.groupBoxInputData_ErmakovAA.Location = new System.Drawing.Point(373, 6);
            this.groupBoxInputData_ErmakovAA.Name = "groupBoxInputData_ErmakovAA";
            this.groupBoxInputData_ErmakovAA.Size = new System.Drawing.Size(145, 103);
            this.groupBoxInputData_ErmakovAA.TabIndex = 16;
            this.groupBoxInputData_ErmakovAA.TabStop = false;
            this.groupBoxInputData_ErmakovAA.Text = "Ввод данных";
            // 
            // textBoxVarStart_ErmakovAA
            // 
            this.textBoxVarStart_ErmakovAA.Location = new System.Drawing.Point(6, 31);
            this.textBoxVarStart_ErmakovAA.Name = "textBoxVarStart_ErmakovAA";
            this.textBoxVarStart_ErmakovAA.Size = new System.Drawing.Size(108, 20);
            this.textBoxVarStart_ErmakovAA.TabIndex = 0;
            // 
            // labelStart_ErmakovAA
            // 
            this.labelStart_ErmakovAA.AutoSize = true;
            this.labelStart_ErmakovAA.Location = new System.Drawing.Point(6, 15);
            this.labelStart_ErmakovAA.Name = "labelStart_ErmakovAA";
            this.labelStart_ErmakovAA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ErmakovAA.TabIndex = 1;
            this.labelStart_ErmakovAA.Text = "Старт шага:";
            // 
            // labelStop_ErmakovAA
            // 
            this.labelStop_ErmakovAA.AutoSize = true;
            this.labelStop_ErmakovAA.Location = new System.Drawing.Point(6, 61);
            this.labelStop_ErmakovAA.Name = "labelStop_ErmakovAA";
            this.labelStop_ErmakovAA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ErmakovAA.TabIndex = 2;
            this.labelStop_ErmakovAA.Text = "Конец шага:";
            // 
            // textBoxVarStop_ErmakovAA
            // 
            this.textBoxVarStop_ErmakovAA.Location = new System.Drawing.Point(6, 77);
            this.textBoxVarStop_ErmakovAA.Name = "textBoxVarStop_ErmakovAA";
            this.textBoxVarStop_ErmakovAA.Size = new System.Drawing.Size(108, 20);
            this.textBoxVarStop_ErmakovAA.TabIndex = 3;
            // 
            // buttonDone_ErmakovAA
            // 
            this.buttonDone_ErmakovAA.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_ErmakovAA.Location = new System.Drawing.Point(524, 22);
            this.buttonDone_ErmakovAA.Name = "buttonDone_ErmakovAA";
            this.buttonDone_ErmakovAA.Size = new System.Drawing.Size(135, 31);
            this.buttonDone_ErmakovAA.TabIndex = 18;
            this.buttonDone_ErmakovAA.Text = "Выполнить";
            this.buttonDone_ErmakovAA.UseVisualStyleBackColor = false;
            this.buttonDone_ErmakovAA.Click += new System.EventHandler(this.buttonDone_ErmakovAA_Click);
            // 
            // textBoxRes_ErmakovAA
            // 
            this.textBoxRes_ErmakovAA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_ErmakovAA.Location = new System.Drawing.Point(6, 19);
            this.textBoxRes_ErmakovAA.Multiline = true;
            this.textBoxRes_ErmakovAA.Name = "textBoxRes_ErmakovAA";
            this.textBoxRes_ErmakovAA.ReadOnly = true;
            this.textBoxRes_ErmakovAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_ErmakovAA.Size = new System.Drawing.Size(191, 374);
            this.textBoxRes_ErmakovAA.TabIndex = 21;
            this.textBoxRes_ErmakovAA.TabStop = false;
            this.textBoxRes_ErmakovAA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxOutputData_ErmakovAA
            // 
            this.groupBoxOutputData_ErmakovAA.Controls.Add(this.textBoxRes_ErmakovAA);
            this.groupBoxOutputData_ErmakovAA.Location = new System.Drawing.Point(12, 115);
            this.groupBoxOutputData_ErmakovAA.Name = "groupBoxOutputData_ErmakovAA";
            this.groupBoxOutputData_ErmakovAA.Size = new System.Drawing.Size(203, 399);
            this.groupBoxOutputData_ErmakovAA.TabIndex = 17;
            this.groupBoxOutputData_ErmakovAA.TabStop = false;
            this.groupBoxOutputData_ErmakovAA.Text = "Вывод данных";
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 544);
            this.Controls.Add(this.buttonSave_ErmakovAA);
            this.Controls.Add(this.chartFunc_ErmakovAA);
            this.Controls.Add(this.groupBoxTask_ErmakovAA);
            this.Controls.Add(this.groupBoxInputData_ErmakovAA);
            this.Controls.Add(this.groupBoxOutputData_ErmakovAA);
            this.Controls.Add(this.buttonHelp_ErmakovAA);
            this.Controls.Add(this.buttonDone_ErmakovAA);
            this.MinimumSize = new System.Drawing.Size(806, 583);
            this.Name = "FromMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 15 | Колчаков Д. Р.";
            this.groupBoxTask_ErmakovAA.ResumeLayout(false);
            this.groupBoxTask_ErmakovAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_ErmakovAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ErmakovAA)).EndInit();
            this.groupBoxInputData_ErmakovAA.ResumeLayout(false);
            this.groupBoxInputData_ErmakovAA.PerformLayout();
            this.groupBoxOutputData_ErmakovAA.ResumeLayout(false);
            this.groupBoxOutputData_ErmakovAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ErmakovAA;
        private System.Windows.Forms.Label labelTask_ErmakovAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_ErmakovAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_ErmakovAA;
        private System.Windows.Forms.Button buttonSave_ErmakovAA;
        private System.Windows.Forms.Button buttonHelp_ErmakovAA;
        private System.Windows.Forms.GroupBox groupBoxInputData_ErmakovAA;
        private System.Windows.Forms.TextBox textBoxVarStop_ErmakovAA;
        private System.Windows.Forms.Label labelStop_ErmakovAA;
        private System.Windows.Forms.Label labelStart_ErmakovAA;
        private System.Windows.Forms.TextBox textBoxVarStart_ErmakovAA;
        private System.Windows.Forms.Button buttonDone_ErmakovAA;
        private System.Windows.Forms.TextBox textBoxRes_ErmakovAA;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ErmakovAA;
    }
}
