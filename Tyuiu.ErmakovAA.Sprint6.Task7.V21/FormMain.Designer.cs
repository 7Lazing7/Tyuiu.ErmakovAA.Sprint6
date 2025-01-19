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
            panelButtons_SBI = new Panel();
            buttonSaveFile_SBI = new Button();
            buttonAbout_SBI = new Button();
            buttonHelp_SBI = new Button();
            buttonDone_SBI = new Button();
            buttonOpenFile_SBI = new Button();
            panel2 = new Panel();
            groupBoxTask_SBI = new GroupBox();
            textBoxTask_SBI = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxInPut_SBI = new GroupBox();
            dataGridViewInPut_SBI = new DataGridView();
            groupBoxOutPut_SBI = new GroupBox();
            dataGridViewOutPut_SBI = new DataGridView();
            toolTip_SBI = new ToolTip(components);
            openFileDialog_SBI = new OpenFileDialog();
            saveFileDialog_SBI = new SaveFileDialog();
            panelButtons_SBI.SuspendLayout();
            groupBoxTask_SBI.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxInPut_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_SBI).BeginInit();
            groupBoxOutPut_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_SBI).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_SBI
            // 
            panelButtons_SBI.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_SBI.Controls.Add(buttonSaveFile_SBI);
            panelButtons_SBI.Controls.Add(buttonAbout_SBI);
            panelButtons_SBI.Controls.Add(buttonHelp_SBI);
            panelButtons_SBI.Controls.Add(buttonDone_SBI);
            panelButtons_SBI.Controls.Add(buttonOpenFile_SBI);
            panelButtons_SBI.Controls.Add(panel2);
            panelButtons_SBI.Dock = DockStyle.Top;
            panelButtons_SBI.Location = new Point(0, 0);
            panelButtons_SBI.Name = "panelButtons_SBI";
            panelButtons_SBI.Size = new Size(800, 72);
            panelButtons_SBI.TabIndex = 1;
            // 
            // buttonSaveFile_SBI
            // 
            buttonSaveFile_SBI.BackColor = Color.Transparent;
            buttonSaveFile_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_SBI.Enabled = false;
            buttonSaveFile_SBI.Image = Properties.Resources.page_save;
            buttonSaveFile_SBI.Location = new Point(171, 3);
            buttonSaveFile_SBI.Name = "buttonSaveFile_SBI";
            buttonSaveFile_SBI.Size = new Size(78, 62);
            buttonSaveFile_SBI.TabIndex = 6;
            toolTip_SBI.SetToolTip(buttonSaveFile_SBI, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_SBI.UseVisualStyleBackColor = false;
            buttonSaveFile_SBI.Click += buttonSaveFile_SBI_Click;
            buttonSaveFile_SBI.MouseEnter += buttonSaveFile_SBI_MouseEnter;
            // 
            // buttonAbout_SBI
            // 
            buttonAbout_SBI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_SBI.BackColor = Color.Transparent;
            buttonAbout_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_SBI.Image = Properties.Resources.help;
            buttonAbout_SBI.Location = new Point(715, 3);
            buttonAbout_SBI.Name = "buttonAbout_SBI";
            buttonAbout_SBI.Size = new Size(78, 62);
            buttonAbout_SBI.TabIndex = 5;
            buttonAbout_SBI.UseVisualStyleBackColor = false;
            buttonAbout_SBI.Click += buttonAbout_SBI_Click;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SBI.BackColor = Color.Transparent;
            buttonHelp_SBI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_SBI.Location = new Point(1311, 3);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(78, 62);
            buttonHelp_SBI.TabIndex = 4;
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            // 
            // buttonDone_SBI
            // 
            buttonDone_SBI.BackColor = Color.Transparent;
            buttonDone_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_SBI.Enabled = false;
            buttonDone_SBI.Image = Properties.Resources.page_go;
            buttonDone_SBI.Location = new Point(87, 3);
            buttonDone_SBI.Name = "buttonDone_SBI";
            buttonDone_SBI.Size = new Size(78, 62);
            buttonDone_SBI.TabIndex = 3;
            toolTip_SBI.SetToolTip(buttonDone_SBI, "Выполнить обработку данных");
            buttonDone_SBI.UseVisualStyleBackColor = false;
            buttonDone_SBI.Click += buttonDone_SBI_Click;
            buttonDone_SBI.MouseEnter += buttonDone_SBI_MouseEnter;
            // 
            // buttonOpenFile_SBI
            // 
            buttonOpenFile_SBI.BackColor = Color.Transparent;
            buttonOpenFile_SBI.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_SBI.Image = Properties.Resources.folder_page;
            buttonOpenFile_SBI.Location = new Point(3, 3);
            buttonOpenFile_SBI.Name = "buttonOpenFile_SBI";
            buttonOpenFile_SBI.Size = new Size(78, 62);
            buttonOpenFile_SBI.TabIndex = 2;
            toolTip_SBI.SetToolTip(buttonOpenFile_SBI, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonOpenFile_SBI.UseVisualStyleBackColor = false;
            buttonOpenFile_SBI.Click += buttonOpenFile_SBI_Click;
            buttonOpenFile_SBI.MouseEnter += buttonOpenFile_SBI_MouseEnter;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 76);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Dock = DockStyle.Fill;
            groupBoxTask_SBI.Font = new Font("Segoe UI", 9F);
            groupBoxTask_SBI.Location = new Point(5, 5);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.RightToLeft = RightToLeft.No;
            groupBoxTask_SBI.Size = new Size(790, 107);
            groupBoxTask_SBI.TabIndex = 2;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие:";
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Dock = DockStyle.Fill;
            textBoxTask_SBI.Font = new Font("Segoe UI", 9F);
            textBoxTask_SBI.Location = new Point(3, 19);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(784, 85);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = resources.GetString("textBoxTask_SBI.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask_SBI);
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
            tableLayoutPanel1.Controls.Add(groupBoxInPut_SBI, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxOutPut_SBI, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 261);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBoxInPut_SBI
            // 
            groupBoxInPut_SBI.Controls.Add(dataGridViewInPut_SBI);
            groupBoxInPut_SBI.Dock = DockStyle.Fill;
            groupBoxInPut_SBI.Location = new Point(6, 6);
            groupBoxInPut_SBI.Name = "groupBoxInPut_SBI";
            groupBoxInPut_SBI.Size = new Size(391, 249);
            groupBoxInPut_SBI.TabIndex = 0;
            groupBoxInPut_SBI.TabStop = false;
            groupBoxInPut_SBI.Text = "Ввод:";
            // 
            // dataGridViewInPut_SBI
            // 
            dataGridViewInPut_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_SBI.ColumnHeadersVisible = false;
            dataGridViewInPut_SBI.Dock = DockStyle.Fill;
            dataGridViewInPut_SBI.Location = new Point(3, 19);
            dataGridViewInPut_SBI.Name = "dataGridViewInPut_SBI";
            dataGridViewInPut_SBI.RowHeadersVisible = false;
            dataGridViewInPut_SBI.Size = new Size(385, 227);
            dataGridViewInPut_SBI.TabIndex = 0;
            // 
            // groupBoxOutPut_SBI
            // 
            groupBoxOutPut_SBI.Controls.Add(dataGridViewOutPut_SBI);
            groupBoxOutPut_SBI.Dock = DockStyle.Fill;
            groupBoxOutPut_SBI.Location = new Point(403, 6);
            groupBoxOutPut_SBI.Name = "groupBoxOutPut_SBI";
            groupBoxOutPut_SBI.Size = new Size(391, 249);
            groupBoxOutPut_SBI.TabIndex = 1;
            groupBoxOutPut_SBI.TabStop = false;
            groupBoxOutPut_SBI.Text = "Вывод:";
            // 
            // dataGridViewOutPut_SBI
            // 
            dataGridViewOutPut_SBI.AllowUserToResizeRows = false;
            dataGridViewOutPut_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_SBI.ColumnHeadersVisible = false;
            dataGridViewOutPut_SBI.Dock = DockStyle.Fill;
            dataGridViewOutPut_SBI.Location = new Point(3, 19);
            dataGridViewOutPut_SBI.Name = "dataGridViewOutPut_SBI";
            dataGridViewOutPut_SBI.RowHeadersVisible = false;
            dataGridViewOutPut_SBI.Size = new Size(385, 227);
            dataGridViewOutPut_SBI.TabIndex = 0;
            // 
            // toolTip_SBI
            // 
            toolTip_SBI.IsBalloon = true;
            // 
            // openFileDialog_SBI
            // 
            openFileDialog_SBI.FileName = "file.csv";
            // 
            // saveFileDialog_SBI
            // 
            saveFileDialog_SBI.FileName = "file.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelButtons_SBI);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 21 | Ермаков А.А.";
            panelButtons_SBI.ResumeLayout(false);
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxInPut_SBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_SBI).EndInit();
            groupBoxOutPut_SBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_SBI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_SBI;
        private Button buttonHelp_SBI;
        private Button buttonDone_SBI;
        private Button buttonOpenFile_SBI;
        private Panel panel2;
        private Button buttonAbout_SBI;
        private GroupBox groupBoxTask_SBI;
        private TextBox textBoxTask_SBI;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxInPut_SBI;
        private DataGridView dataGridViewInPut_SBI;
        private GroupBox groupBoxOutPut_SBI;
        private DataGridView dataGridViewOutPut_SBI;
        private Button buttonSaveFile_SBI;
        private ToolTip toolTip_SBI;
        private OpenFileDialog openFileDialog_SBI;
        private SaveFileDialog saveFileDialog_SBI;
    }
}
