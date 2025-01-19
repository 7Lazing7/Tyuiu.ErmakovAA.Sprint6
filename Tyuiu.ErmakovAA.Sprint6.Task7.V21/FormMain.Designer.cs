namespace Tyuiu.ErmakovAA.Sprint6.Task7.V21
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_ErmakovAA = new Panel();
            buttonSaveFile_ErmakovAA = new Button();
            buttonAbout_ErmakovAA = new Button();
            buttonHelp_ErmakovAA = new Button();
            buttonDone_ErmakovAA = new Button();
            buttonOpenFile_ErmakovAA = new Button();
            panel2 = new Panel();
            groupBoxTask_ErmakovAA = new GroupBox();
            textBoxTask_ErmakovAA = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxInPut_ErmakovAA = new GroupBox();
            dataGridViewInPut_ErmakovAA = new DataGridView();
            groupBoxOutPut_ErmakovAA = new GroupBox();
            dataGridViewOutPut_ErmakovAA = new DataGridView();
            toolTip_ErmakovAA = new ToolTip(components);
            openFileDialog_ErmakovAA = new OpenFileDialog();
            saveFileDialog_ErmakovAA = new SaveFileDialog();
            panelButtons_ErmakovAA.SuspendLayout();
            groupBoxTask_ErmakovAA.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxInPut_ErmakovAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_ErmakovAA).BeginInit();
            groupBoxOutPut_ErmakovAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_ErmakovAA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_ErmakovAA
            // 
            panelButtons_ErmakovAA.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_ErmakovAA.Controls.Add(buttonSaveFile_ErmakovAA);
            panelButtons_ErmakovAA.Controls.Add(buttonAbout_ErmakovAA);
            panelButtons_ErmakovAA.Controls.Add(buttonHelp_ErmakovAA);
            panelButtons_ErmakovAA.Controls.Add(buttonDone_ErmakovAA);
            panelButtons_ErmakovAA.Controls.Add(buttonOpenFile_ErmakovAA);
            panelButtons_ErmakovAA.Controls.Add(panel2);
            panelButtons_ErmakovAA.Dock = DockStyle.Top;
            panelButtons_ErmakovAA.Location = new Point(0, 0);
            panelButtons_ErmakovAA.Name = "panelButtons_ErmakovAA";
            panelButtons_ErmakovAA.Size = new Size(800, 72);
            panelButtons_ErmakovAA.TabIndex = 1;
            // 
            // buttonSaveFile_ErmakovAA
            // 
            buttonSaveFile_ErmakovAA.BackColor = Color.Transparent;
            buttonSaveFile_ErmakovAA.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_ErmakovAA.Enabled = false;
            buttonSaveFile_ErmakovAA.Image = Properties.Resources.page_save;
            buttonSaveFile_ErmakovAA.Location = new Point(171, 3);
            buttonSaveFile_ErmakovAA.Name = "buttonSaveFile_ErmakovAA";
            buttonSaveFile_ErmakovAA.Size = new Size(78, 62);
            buttonSaveFile_ErmakovAA.TabIndex = 6;
            toolTip_ErmakovAA.SetToolTip(buttonSaveFile_ErmakovAA, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_ErmakovAA.UseVisualStyleBackColor = false;
            buttonSaveFile_ErmakovAA.Click += buttonSaveFile_ErmakovAA_Click;
            buttonSaveFile_ErmakovAA.MouseEnter += buttonSaveFile_ErmakovAA_MouseEnter;
            // 
            // buttonAbout_ErmakovAA
            // 
            buttonAbout_ErmakovAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_ErmakovAA.BackColor = Color.Transparent;
            buttonAbout_ErmakovAA.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_ErmakovAA.Image = Properties.Resources.help;
            buttonAbout_ErmakovAA.Location = new Point(715, 3);
            buttonAbout_ErmakovAA.Name = "buttonAbout_ErmakovAA";
            buttonAbout_ErmakovAA.Size = new Size(78, 62);
            buttonAbout_ErmakovAA.TabIndex = 5;
            buttonAbout_ErmakovAA.UseVisualStyleBackColor = false;
            buttonAbout_ErmakovAA.Click += buttonAbout_ErmakovAA_Click;
            // 
            // buttonHelp_ErmakovAA
            // 
            buttonHelp_ErmakovAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ErmakovAA.BackColor = Color.Transparent;
            buttonHelp_ErmakovAA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_ErmakovAA.Location = new Point(1311, 3);
            buttonHelp_ErmakovAA.Name = "buttonHelp_ErmakovAA";
            buttonHelp_ErmakovAA.Size = new Size(78, 62);
            buttonHelp_ErmakovAA.TabIndex = 4;
            buttonHelp_ErmakovAA.UseVisualStyleBackColor = false;
            // 
            // buttonDone_ErmakovAA
            // 
            buttonDone_ErmakovAA.BackColor = Color.Transparent;
            buttonDone_ErmakovAA.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_ErmakovAA.Enabled = false;
            buttonDone_ErmakovAA.Image = Properties.Resources.page_go;
            buttonDone_ErmakovAA.Location = new Point(87, 3);
            buttonDone_ErmakovAA.Name = "buttonDone_ErmakovAA";
            buttonDone_ErmakovAA.Size = new Size(78, 62);
            buttonDone_ErmakovAA.TabIndex = 3;
            toolTip_ErmakovAA.SetToolTip(buttonDone_ErmakovAA, "Выполнить обработку данных");
            buttonDone_ErmakovAA.UseVisualStyleBackColor = false;
            buttonDone_ErmakovAA.Click += buttonDone_ErmakovAA_Click;
            buttonDone_ErmakovAA.MouseEnter += buttonDone_ErmakovAA_MouseEnter;
            // 
            // buttonOpenFile_ErmakovAA
            // 
            buttonOpenFile_ErmakovAA.BackColor = Color.Transparent;
            buttonOpenFile_ErmakovAA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_ErmakovAA.Image = Properties.Resources.folder_page;
            buttonOpenFile_ErmakovAA.Location = new Point(3, 3);
            buttonOpenFile_ErmakovAA.Name = "buttonOpenFile_ErmakovAA";
            buttonOpenFile_ErmakovAA.Size = new Size(78, 62);
            buttonOpenFile_ErmakovAA.TabIndex = 2;
            toolTip_ErmakovAA.SetToolTip(buttonOpenFile_ErmakovAA, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonOpenFile_ErmakovAA.UseVisualStyleBackColor = false;
            buttonOpenFile_ErmakovAA.Click += buttonOpenFile_ErmakovAA_Click;
            buttonOpenFile_ErmakovAA.MouseEnter += buttonOpenFile_ErmakovAA_MouseEnter;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 76);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_ErmakovAA
            // 
            groupBoxTask_ErmakovAA.Controls.Add(textBoxTask_ErmakovAA);
            groupBoxTask_ErmakovAA.Dock = DockStyle.Fill;
            groupBoxTask_ErmakovAA.Font = new Font("Segoe UI", 9F);
            groupBoxTask_ErmakovAA.Location = new Point(5, 5);
            groupBoxTask_ErmakovAA.Name = "groupBoxTask_ErmakovAA";
            groupBoxTask_ErmakovAA.RightToLeft = RightToLeft.No;
            groupBoxTask_ErmakovAA.Size = new Size(790, 107);
            groupBoxTask_ErmakovAA.TabIndex = 2;
            groupBoxTask_ErmakovAA.TabStop = false;
            groupBoxTask_ErmakovAA.Text = "Условие:";
            // 
            // textBoxTask_ErmakovAA
            // 
            textBoxTask_ErmakovAA.BorderStyle = BorderStyle.None;
            textBoxTask_ErmakovAA.Dock = DockStyle.Fill;
            textBoxTask_ErmakovAA.Font = new Font("Segoe UI", 9F);
            textBoxTask_ErmakovAA.Location = new Point(3, 19);
            textBoxTask_ErmakovAA.Multiline = true;
            textBoxTask_ErmakovAA.Name = "textBoxTask_ErmakovAA";
            textBoxTask_ErmakovAA.ReadOnly = true;
            textBoxTask_ErmakovAA.Size = new Size(784, 85);
            textBoxTask_ErmakovAA.TabIndex = 0;
            textBoxTask_ErmakovAA.Text = resources.GetString("textBoxTask_ErmakovAA.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask_ErmakovAA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBoxInPut_ErmakovAA, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxOutPut_ErmakovAA, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 261);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBoxInPut_ErmakovAA
            // 
            groupBoxInPut_ErmakovAA.Controls.Add(dataGridViewInPut_ErmakovAA);
            groupBoxInPut_ErmakovAA.Dock = DockStyle.Fill;
            groupBoxInPut_ErmakovAA.Location = new Point(6, 6);
            groupBoxInPut_ErmakovAA.Name = "groupBoxInPut_ErmakovAA";
            groupBoxInPut_ErmakovAA.Size = new Size(391, 249);
            groupBoxInPut_ErmakovAA.TabIndex = 0;
            groupBoxInPut_ErmakovAA.TabStop = false;
            groupBoxInPut_ErmakovAA.Text = "Ввод:";
            // 
            // dataGridViewInPut_ErmakovAA
            // 
            dataGridViewInPut_ErmakovAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_ErmakovAA.ColumnHeadersVisible = false;
            dataGridViewInPut_ErmakovAA.Dock = DockStyle.Fill;
            dataGridViewInPut_ErmakovAA.Location = new Point(3, 19);
            dataGridViewInPut_ErmakovAA.Name = "dataGridViewInPut_ErmakovAA";
            dataGridViewInPut_ErmakovAA.RowHeadersVisible = false;
            dataGridViewInPut_ErmakovAA.Size = new Size(385, 227);
            dataGridViewInPut_ErmakovAA.TabIndex = 0;
            // 
            // groupBoxOutPut_ErmakovAA
            // 
            groupBoxOutPut_ErmakovAA.Controls.Add(dataGridViewOutPut_ErmakovAA);
            groupBoxOutPut_ErmakovAA.Dock = DockStyle.Fill;
            groupBoxOutPut_ErmakovAA.Location = new Point(403, 6);
            groupBoxOutPut_ErmakovAA.Name = "groupBoxOutPut_ErmakovAA";
            groupBoxOutPut_ErmakovAA.Size = new Size(391, 249);
            groupBoxOutPut_ErmakovAA.TabIndex = 1;
            groupBoxOutPut_ErmakovAA.TabStop = false;
            groupBoxOutPut_ErmakovAA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_ErmakovAA
            // 
            dataGridViewOutPut_ErmakovAA.AllowUserToResizeRows = false;
            dataGridViewOutPut_ErmakovAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_ErmakovAA.ColumnHeadersVisible = false;
            dataGridViewOutPut_ErmakovAA.Dock = DockStyle.Fill;
            dataGridViewOutPut_ErmakovAA.Location = new Point(3, 19);
            dataGridViewOutPut_ErmakovAA.Name = "dataGridViewOutPut_ErmakovAA";
            dataGridViewOutPut_ErmakovAA.RowHeadersVisible = false;
            dataGridViewOutPut_ErmakovAA.Size = new Size(385, 227);
            dataGridViewOutPut_ErmakovAA.TabIndex = 0;
            // 
            // toolTip_ErmakovAA
            // 
            toolTip_ErmakovAA.IsBalloon = true;
            // 
            // openFileDialog_ErmakovAA
            // 
            openFileDialog_ErmakovAA.FileName = "file.csv";
            // 
            // saveFileDialog_ErmakovAA
            // 
            saveFileDialog_ErmakovAA.FileName = "file.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelButtons_ErmakovAA);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 21 | Ермаков А.А.";
            panelButtons_ErmakovAA.ResumeLayout(false);
            groupBoxTask_ErmakovAA.ResumeLayout(false);
            groupBoxTask_ErmakovAA.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxInPut_ErmakovAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_ErmakovAA).EndInit();
            groupBoxOutPut_ErmakovAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_ErmakovAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_ErmakovAA;
        private Button buttonHelp_ErmakovAA;
        private Button buttonDone_ErmakovAA;
        private Button buttonOpenFile_ErmakovAA;
        private Panel panel2;
        private Button buttonAbout_ErmakovAA;
        private GroupBox groupBoxTask_ErmakovAA;
        private TextBox textBoxTask_ErmakovAA;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxInPut_ErmakovAA;
        private DataGridView dataGridViewInPut_ErmakovAA;
        private GroupBox groupBoxOutPut_ErmakovAA;
        private DataGridView dataGridViewOutPut_ErmakovAA;
        private Button buttonSaveFile_ErmakovAA;
        private ToolTip toolTip_ErmakovAA;
        private OpenFileDialog openFileDialog_ErmakovAA;
        private SaveFileDialog saveFileDialog_ErmakovAA;
    }
}
