namespace Project.V1
{
    partial class FormMain_GSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GSA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxToolsPanel_GSA = new GroupBox();
            buttonSaveResult_GSA = new Button();
            buttonOpenFile_GSA = new Button();
            buttonHelp_GSA = new Button();
            panelTools_GSA = new Panel();
            panelOutput_GSA = new Panel();
            buttonGuide_GSA = new Button();
            groupBox1 = new GroupBox();
            buttonSearchByNumber_GSA = new Button();
            groupBoxStats_GSA = new GroupBox();
            buttonStats_GSA = new Button();
            buttonCreateChart_GSA = new Button();
            groupBoxSortTools = new GroupBox();
            buttonSortByPower_GSA = new Button();
            buttonSortByBrand_GSA = new Button();
            buttonSortByColor_GSA = new Button();
            tabControl_GSA = new TabControl();
            tabPage1_GSA = new TabPage();
            dataGridViewInput_GSA = new DataGridView();
            tabPage2_GSA = new TabPage();
            dataGridViewOutput_GSA = new DataGridView();
            panelStats_GSA = new Panel();
            chartStats_GSA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewStats_GSA = new DataGridView();
            splitterLeftPanel_GSA = new Splitter();
            dataServiceBindingSource = new BindingSource(components);
            saveFileDialog_GSA = new SaveFileDialog();
            toolTip_GSA = new ToolTip(components);
            openFileDialogTask_GSA = new OpenFileDialog();
            contextMenuStripColor_GSA = new ContextMenuStrip(components);
            toolStripMenuItemRed_GSA = new ToolStripMenuItem();
            toolStripMenuItemBlue_GSA = new ToolStripMenuItem();
            toolStripMenuItemWhite_GSA = new ToolStripMenuItem();
            toolStripMenuItemGray_GSA = new ToolStripMenuItem();
            toolStripMenuItemBlack_GSA = new ToolStripMenuItem();
            contextMenuStripBrand_GSA = new ContextMenuStrip(components);
            toolStripMenuItemToyota_GSA = new ToolStripMenuItem();
            toolStripMenuItemNissan_GSA = new ToolStripMenuItem();
            toolStripMenuItemFerrari_GSA = new ToolStripMenuItem();
            toolStripMenuItemLADA_GSA = new ToolStripMenuItem();
            toolStripMenuItemMersedes_GSA = new ToolStripMenuItem();
            toolStripMenuItemBMW_GSA = new ToolStripMenuItem();
            contextMenuStripPower_GSA = new ContextMenuStrip(components);
            toolStripMenuItem100_GSA = new ToolStripMenuItem();
            toolStripMenuItem100200_GSA = new ToolStripMenuItem();
            toolStripMenuItem200300_GSA = new ToolStripMenuItem();
            toolStripMenuItem300AndMore_GSA = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxToolsPanel_GSA.SuspendLayout();
            panelTools_GSA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxStats_GSA.SuspendLayout();
            groupBoxSortTools.SuspendLayout();
            tabControl_GSA.SuspendLayout();
            tabPage1_GSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_GSA).BeginInit();
            tabPage2_GSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_GSA).BeginInit();
            panelStats_GSA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartStats_GSA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_GSA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataServiceBindingSource).BeginInit();
            contextMenuStripColor_GSA.SuspendLayout();
            contextMenuStripBrand_GSA.SuspendLayout();
            contextMenuStripPower_GSA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxToolsPanel_GSA
            // 
            groupBoxToolsPanel_GSA.Controls.Add(buttonSaveResult_GSA);
            groupBoxToolsPanel_GSA.Controls.Add(buttonOpenFile_GSA);
            groupBoxToolsPanel_GSA.Controls.Add(buttonHelp_GSA);
            groupBoxToolsPanel_GSA.Controls.Add(panelTools_GSA);
            groupBoxToolsPanel_GSA.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxToolsPanel_GSA.Location = new Point(0, 0);
            groupBoxToolsPanel_GSA.Name = "groupBoxToolsPanel_GSA";
            groupBoxToolsPanel_GSA.Size = new Size(280, 859);
            groupBoxToolsPanel_GSA.TabIndex = 0;
            groupBoxToolsPanel_GSA.TabStop = false;
            groupBoxToolsPanel_GSA.Text = "Панель управления";
            // 
            // buttonSaveResult_GSA
            // 
            buttonSaveResult_GSA.Image = (Image)resources.GetObject("buttonSaveResult_GSA.Image");
            buttonSaveResult_GSA.Location = new Point(203, 51);
            buttonSaveResult_GSA.Name = "buttonSaveResult_GSA";
            buttonSaveResult_GSA.Size = new Size(70, 66);
            buttonSaveResult_GSA.TabIndex = 2;
            buttonSaveResult_GSA.UseVisualStyleBackColor = true;
            buttonSaveResult_GSA.Click += buttonSaveResult_GSA_Click;
            buttonSaveResult_GSA.MouseEnter += buttonSaveResult_GSA_MouseEnter;
            // 
            // buttonOpenFile_GSA
            // 
            buttonOpenFile_GSA.Image = (Image)resources.GetObject("buttonOpenFile_GSA.Image");
            buttonOpenFile_GSA.Location = new Point(108, 51);
            buttonOpenFile_GSA.Name = "buttonOpenFile_GSA";
            buttonOpenFile_GSA.Size = new Size(70, 66);
            buttonOpenFile_GSA.TabIndex = 1;
            buttonOpenFile_GSA.UseVisualStyleBackColor = true;
            buttonOpenFile_GSA.Click += buttonOpenFile_GSA_Click;
            // 
            // buttonHelp_GSA
            // 
            buttonHelp_GSA.Image = (Image)resources.GetObject("buttonHelp_GSA.Image");
            buttonHelp_GSA.Location = new Point(12, 51);
            buttonHelp_GSA.Name = "buttonHelp_GSA";
            buttonHelp_GSA.Size = new Size(70, 66);
            buttonHelp_GSA.TabIndex = 0;
            buttonHelp_GSA.UseVisualStyleBackColor = true;
            buttonHelp_GSA.Click += buttonHelp_GSA_Click;
            buttonHelp_GSA.MouseEnter += buttonHelp_GSA_MouseEnter;
            // 
            // panelTools_GSA
            // 
            panelTools_GSA.Controls.Add(panelOutput_GSA);
            panelTools_GSA.Controls.Add(groupBoxSortTools);
            panelTools_GSA.Controls.Add(groupBoxStats_GSA);
            panelTools_GSA.Controls.Add(buttonGuide_GSA);
            panelTools_GSA.Location = new Point(0, 0);
            panelTools_GSA.Name = "panelTools_GSA";
            panelTools_GSA.Size = new Size(279, 1082);
            panelTools_GSA.TabIndex = 2;
            panelTools_GSA.Paint += panelTools_GSA_Paint;
            // 
            // panelOutput_GSA
            // 
            panelOutput_GSA.BackColor = SystemColors.GrayText;
            panelOutput_GSA.Location = new Point(279, 0);
            panelOutput_GSA.Name = "panelOutput_GSA";
            panelOutput_GSA.Size = new Size(846, 965);
            panelOutput_GSA.TabIndex = 1;
            // 
            // buttonGuide_GSA
            // 
            buttonGuide_GSA.Image = (Image)resources.GetObject("buttonGuide_GSA.Image");
            buttonGuide_GSA.Location = new Point(80, 762);
            buttonGuide_GSA.Name = "buttonGuide_GSA";
            buttonGuide_GSA.Size = new Size(88, 90);
            buttonGuide_GSA.TabIndex = 7;
            buttonGuide_GSA.UseVisualStyleBackColor = true;
            buttonGuide_GSA.Click += buttonGuide_GSA_Click;
            buttonGuide_GSA.MouseEnter += buttonGuide_GSA_MouseEnter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSearchByNumber_GSA);
            groupBox1.Location = new Point(63, 576);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(119, 99);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Поиск";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // buttonSearchByNumber_GSA
            // 
            buttonSearchByNumber_GSA.Image = (Image)resources.GetObject("buttonSearchByNumber_GSA.Image");
            buttonSearchByNumber_GSA.Location = new Point(6, 34);
            buttonSearchByNumber_GSA.Name = "buttonSearchByNumber_GSA";
            buttonSearchByNumber_GSA.Size = new Size(107, 59);
            buttonSearchByNumber_GSA.TabIndex = 0;
            buttonSearchByNumber_GSA.UseVisualStyleBackColor = true;
            buttonSearchByNumber_GSA.Click += buttonSearchByNumber_GSA_Click;
            buttonSearchByNumber_GSA.MouseEnter += buttonSearchByNumber_GSA_MouseEnter;
            // 
            // groupBoxStats_GSA
            // 
            groupBoxStats_GSA.Controls.Add(buttonStats_GSA);
            groupBoxStats_GSA.Controls.Add(buttonCreateChart_GSA);
            groupBoxStats_GSA.Location = new Point(63, 364);
            groupBoxStats_GSA.Name = "groupBoxStats_GSA";
            groupBoxStats_GSA.Size = new Size(140, 99);
            groupBoxStats_GSA.TabIndex = 1;
            groupBoxStats_GSA.TabStop = false;
            groupBoxStats_GSA.Text = "Статистика";
            // 
            // buttonStats_GSA
            // 
            buttonStats_GSA.Image = (Image)resources.GetObject("buttonStats_GSA.Image");
            buttonStats_GSA.Location = new Point(73, 33);
            buttonStats_GSA.Name = "buttonStats_GSA";
            buttonStats_GSA.Size = new Size(61, 60);
            buttonStats_GSA.TabIndex = 5;
            buttonStats_GSA.UseVisualStyleBackColor = true;
            buttonStats_GSA.Click += buttonStats_GSA_Click;
            buttonStats_GSA.MouseEnter += buttonStats_GSA_MouseEnter;
            // 
            // buttonCreateChart_GSA
            // 
            buttonCreateChart_GSA.Image = (Image)resources.GetObject("buttonCreateChart_GSA.Image");
            buttonCreateChart_GSA.Location = new Point(6, 33);
            buttonCreateChart_GSA.Name = "buttonCreateChart_GSA";
            buttonCreateChart_GSA.Size = new Size(61, 60);
            buttonCreateChart_GSA.TabIndex = 4;
            buttonCreateChart_GSA.UseVisualStyleBackColor = true;
            buttonCreateChart_GSA.Click += buttonCreateChart_GSA_Click;
            buttonCreateChart_GSA.MouseEnter += buttonCreateChart_GSA_MouseEnter;
            // 
            // groupBoxSortTools
            // 
            groupBoxSortTools.Controls.Add(buttonSortByPower_GSA);
            groupBoxSortTools.Controls.Add(buttonSortByBrand_GSA);
            groupBoxSortTools.Controls.Add(buttonSortByColor_GSA);
            groupBoxSortTools.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBoxSortTools.Location = new Point(34, 190);
            groupBoxSortTools.Name = "groupBoxSortTools";
            groupBoxSortTools.Size = new Size(209, 99);
            groupBoxSortTools.TabIndex = 3;
            groupBoxSortTools.TabStop = false;
            groupBoxSortTools.Text = "Фильтр";
            // 
            // buttonSortByPower_GSA
            // 
            buttonSortByPower_GSA.Image = (Image)resources.GetObject("buttonSortByPower_GSA.Image");
            buttonSortByPower_GSA.Location = new Point(140, 33);
            buttonSortByPower_GSA.Name = "buttonSortByPower_GSA";
            buttonSortByPower_GSA.Size = new Size(61, 60);
            buttonSortByPower_GSA.TabIndex = 2;
            buttonSortByPower_GSA.UseVisualStyleBackColor = true;
            buttonSortByPower_GSA.Click += buttonSortByPower_GSA_Click;
            buttonSortByPower_GSA.MouseEnter += buttonSortByPower_GSA_MouseEnter;
            // 
            // buttonSortByBrand_GSA
            // 
            buttonSortByBrand_GSA.Image = (Image)resources.GetObject("buttonSortByBrand_GSA.Image");
            buttonSortByBrand_GSA.Location = new Point(73, 33);
            buttonSortByBrand_GSA.Name = "buttonSortByBrand_GSA";
            buttonSortByBrand_GSA.Size = new Size(61, 60);
            buttonSortByBrand_GSA.TabIndex = 1;
            buttonSortByBrand_GSA.UseVisualStyleBackColor = true;
            buttonSortByBrand_GSA.Click += buttonSortByBrand_GSA_Click;
            buttonSortByBrand_GSA.MouseEnter += buttonSortByBrand_GSA_MouseEnter;
            // 
            // buttonSortByColor_GSA
            // 
            buttonSortByColor_GSA.Image = (Image)resources.GetObject("buttonSortByColor_GSA.Image");
            buttonSortByColor_GSA.Location = new Point(6, 33);
            buttonSortByColor_GSA.Name = "buttonSortByColor_GSA";
            buttonSortByColor_GSA.Size = new Size(61, 60);
            buttonSortByColor_GSA.TabIndex = 0;
            buttonSortByColor_GSA.UseVisualStyleBackColor = true;
            buttonSortByColor_GSA.Click += buttonSortByColor_GSA_Click;
            buttonSortByColor_GSA.MouseEnter += buttonSortByColor_GSA_MouseEnter;
            // 
            // tabControl_GSA
            // 
            tabControl_GSA.Controls.Add(tabPage1_GSA);
            tabControl_GSA.Controls.Add(tabPage2_GSA);
            tabControl_GSA.Location = new Point(279, 0);
            tabControl_GSA.Name = "tabControl_GSA";
            tabControl_GSA.SelectedIndex = 0;
            tabControl_GSA.Size = new Size(846, 859);
            tabControl_GSA.TabIndex = 0;
            // 
            // tabPage1_GSA
            // 
            tabPage1_GSA.Controls.Add(dataGridViewInput_GSA);
            tabPage1_GSA.Location = new Point(4, 34);
            tabPage1_GSA.Name = "tabPage1_GSA";
            tabPage1_GSA.Padding = new Padding(3);
            tabPage1_GSA.Size = new Size(838, 821);
            tabPage1_GSA.TabIndex = 0;
            tabPage1_GSA.Text = "Таблица";
            tabPage1_GSA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInput_GSA
            // 
            dataGridViewInput_GSA.AllowUserToAddRows = false;
            dataGridViewInput_GSA.AllowUserToDeleteRows = false;
            dataGridViewInput_GSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_GSA.Dock = DockStyle.Fill;
            dataGridViewInput_GSA.Location = new Point(3, 3);
            dataGridViewInput_GSA.Name = "dataGridViewInput_GSA";
            dataGridViewInput_GSA.RowHeadersWidth = 62;
            dataGridViewInput_GSA.Size = new Size(832, 815);
            dataGridViewInput_GSA.TabIndex = 11;
            dataGridViewInput_GSA.CellContentClick += dataGridViewInput_GSA_CellContentClick;
            // 
            // tabPage2_GSA
            // 
            tabPage2_GSA.Controls.Add(dataGridViewOutput_GSA);
            tabPage2_GSA.Location = new Point(4, 34);
            tabPage2_GSA.Name = "tabPage2_GSA";
            tabPage2_GSA.Padding = new Padding(3);
            tabPage2_GSA.Size = new Size(838, 821);
            tabPage2_GSA.TabIndex = 1;
            tabPage2_GSA.Text = "Вывод";
            tabPage2_GSA.UseVisualStyleBackColor = true;
            tabPage2_GSA.Click += tabPage2_GSA_Click;
            // 
            // dataGridViewOutput_GSA
            // 
            dataGridViewOutput_GSA.AllowUserToAddRows = false;
            dataGridViewOutput_GSA.AllowUserToDeleteRows = false;
            dataGridViewOutput_GSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_GSA.Dock = DockStyle.Fill;
            dataGridViewOutput_GSA.Location = new Point(3, 3);
            dataGridViewOutput_GSA.Name = "dataGridViewOutput_GSA";
            dataGridViewOutput_GSA.RowHeadersWidth = 62;
            dataGridViewOutput_GSA.Size = new Size(832, 815);
            dataGridViewOutput_GSA.TabIndex = 10;
            // 
            // panelStats_GSA
            // 
            panelStats_GSA.BackColor = SystemColors.ScrollBar;
            panelStats_GSA.Controls.Add(chartStats_GSA);
            panelStats_GSA.Controls.Add(dataGridViewStats_GSA);
            panelStats_GSA.Controls.Add(splitterLeftPanel_GSA);
            panelStats_GSA.Location = new Point(1124, 37);
            panelStats_GSA.Name = "panelStats_GSA";
            panelStats_GSA.Size = new Size(604, 822);
            panelStats_GSA.TabIndex = 12;
            panelStats_GSA.Paint += panelStats_GSA_Paint;
            // 
            // chartStats_GSA
            // 
            chartArea1.Name = "ChartArea1";
            chartStats_GSA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartStats_GSA.Legends.Add(legend1);
            chartStats_GSA.Location = new Point(89, 25);
            chartStats_GSA.Name = "chartStats_GSA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartStats_GSA.Series.Add(series1);
            chartStats_GSA.Size = new Size(450, 382);
            chartStats_GSA.TabIndex = 11;
            chartStats_GSA.Text = "chart1";
            // 
            // dataGridViewStats_GSA
            // 
            dataGridViewStats_GSA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStats_GSA.Location = new Point(26, 459);
            dataGridViewStats_GSA.Name = "dataGridViewStats_GSA";
            dataGridViewStats_GSA.RowHeadersWidth = 62;
            dataGridViewStats_GSA.Size = new Size(550, 225);
            dataGridViewStats_GSA.TabIndex = 0;
            dataGridViewStats_GSA.CellContentClick += dataGridView1_CellContentClick;
            // 
            // splitterLeftPanel_GSA
            // 
            splitterLeftPanel_GSA.Location = new Point(0, 0);
            splitterLeftPanel_GSA.Name = "splitterLeftPanel_GSA";
            splitterLeftPanel_GSA.Size = new Size(4, 822);
            splitterLeftPanel_GSA.TabIndex = 0;
            splitterLeftPanel_GSA.TabStop = false;
            // 
            // dataServiceBindingSource
            // 
            dataServiceBindingSource.DataSource = typeof(Tyuiu.GrabinaSA.Sprint7.ProjectV1.Lib.DataService);
            // 
            // openFileDialogTask_GSA
            // 
            openFileDialogTask_GSA.FileName = "openFileDialog1";
            // 
            // contextMenuStripColor_GSA
            // 
            contextMenuStripColor_GSA.ImageScalingSize = new Size(24, 24);
            contextMenuStripColor_GSA.Items.AddRange(new ToolStripItem[] { toolStripMenuItemRed_GSA, toolStripMenuItemBlue_GSA, toolStripMenuItemWhite_GSA, toolStripMenuItemGray_GSA, toolStripMenuItemBlack_GSA });
            contextMenuStripColor_GSA.Name = "contextMenuStripColor_GSA";
            contextMenuStripColor_GSA.Size = new Size(156, 164);
            // 
            // toolStripMenuItemRed_GSA
            // 
            toolStripMenuItemRed_GSA.Name = "toolStripMenuItemRed_GSA";
            toolStripMenuItemRed_GSA.Size = new Size(155, 32);
            toolStripMenuItemRed_GSA.Text = "Красный";
            // 
            // toolStripMenuItemBlue_GSA
            // 
            toolStripMenuItemBlue_GSA.Name = "toolStripMenuItemBlue_GSA";
            toolStripMenuItemBlue_GSA.Size = new Size(155, 32);
            toolStripMenuItemBlue_GSA.Text = "Синий";
            // 
            // toolStripMenuItemWhite_GSA
            // 
            toolStripMenuItemWhite_GSA.Name = "toolStripMenuItemWhite_GSA";
            toolStripMenuItemWhite_GSA.Size = new Size(155, 32);
            toolStripMenuItemWhite_GSA.Text = "Белый";
            // 
            // toolStripMenuItemGray_GSA
            // 
            toolStripMenuItemGray_GSA.Name = "toolStripMenuItemGray_GSA";
            toolStripMenuItemGray_GSA.Size = new Size(155, 32);
            toolStripMenuItemGray_GSA.Text = "Серый";
            // 
            // toolStripMenuItemBlack_GSA
            // 
            toolStripMenuItemBlack_GSA.Name = "toolStripMenuItemBlack_GSA";
            toolStripMenuItemBlack_GSA.Size = new Size(155, 32);
            toolStripMenuItemBlack_GSA.Text = "Черный";
            // 
            // contextMenuStripBrand_GSA
            // 
            contextMenuStripBrand_GSA.ImageScalingSize = new Size(24, 24);
            contextMenuStripBrand_GSA.Items.AddRange(new ToolStripItem[] { toolStripMenuItemToyota_GSA, toolStripMenuItemNissan_GSA, toolStripMenuItemFerrari_GSA, toolStripMenuItemLADA_GSA, toolStripMenuItemMersedes_GSA, toolStripMenuItemBMW_GSA });
            contextMenuStripBrand_GSA.Name = "contextMenuStripBrand_GSA";
            contextMenuStripBrand_GSA.Size = new Size(161, 196);
            contextMenuStripBrand_GSA.Opening += contextMenuStripBrand_GSA_Opening;
            // 
            // toolStripMenuItemToyota_GSA
            // 
            toolStripMenuItemToyota_GSA.Name = "toolStripMenuItemToyota_GSA";
            toolStripMenuItemToyota_GSA.Size = new Size(160, 32);
            toolStripMenuItemToyota_GSA.Text = "Toyota";
            toolStripMenuItemToyota_GSA.Click += toyotaToolStripMenuItem_Click;
            // 
            // toolStripMenuItemNissan_GSA
            // 
            toolStripMenuItemNissan_GSA.Name = "toolStripMenuItemNissan_GSA";
            toolStripMenuItemNissan_GSA.Size = new Size(160, 32);
            toolStripMenuItemNissan_GSA.Text = "Nissan";
            // 
            // toolStripMenuItemFerrari_GSA
            // 
            toolStripMenuItemFerrari_GSA.Name = "toolStripMenuItemFerrari_GSA";
            toolStripMenuItemFerrari_GSA.Size = new Size(160, 32);
            toolStripMenuItemFerrari_GSA.Text = "Ferrari";
            // 
            // toolStripMenuItemLADA_GSA
            // 
            toolStripMenuItemLADA_GSA.Name = "toolStripMenuItemLADA_GSA";
            toolStripMenuItemLADA_GSA.Size = new Size(160, 32);
            toolStripMenuItemLADA_GSA.Text = "LADA";
            // 
            // toolStripMenuItemMersedes_GSA
            // 
            toolStripMenuItemMersedes_GSA.Name = "toolStripMenuItemMersedes_GSA";
            toolStripMenuItemMersedes_GSA.Size = new Size(160, 32);
            toolStripMenuItemMersedes_GSA.Text = "Mercedes";
            // 
            // toolStripMenuItemBMW_GSA
            // 
            toolStripMenuItemBMW_GSA.Name = "toolStripMenuItemBMW_GSA";
            toolStripMenuItemBMW_GSA.Size = new Size(160, 32);
            toolStripMenuItemBMW_GSA.Text = "BMW";
            // 
            // contextMenuStripPower_GSA
            // 
            contextMenuStripPower_GSA.ImageScalingSize = new Size(24, 24);
            contextMenuStripPower_GSA.Items.AddRange(new ToolStripItem[] { toolStripMenuItem100_GSA, toolStripMenuItem100200_GSA, toolStripMenuItem200300_GSA, toolStripMenuItem300AndMore_GSA });
            contextMenuStripPower_GSA.Name = "contextMenuStripPower_GSA";
            contextMenuStripPower_GSA.Size = new Size(152, 132);
            // 
            // toolStripMenuItem100_GSA
            // 
            toolStripMenuItem100_GSA.Name = "toolStripMenuItem100_GSA";
            toolStripMenuItem100_GSA.Size = new Size(151, 32);
            toolStripMenuItem100_GSA.Text = "0-100";
            // 
            // toolStripMenuItem100200_GSA
            // 
            toolStripMenuItem100200_GSA.Name = "toolStripMenuItem100200_GSA";
            toolStripMenuItem100200_GSA.Size = new Size(151, 32);
            toolStripMenuItem100200_GSA.Text = "100-200";
            // 
            // toolStripMenuItem200300_GSA
            // 
            toolStripMenuItem200300_GSA.Name = "toolStripMenuItem200300_GSA";
            toolStripMenuItem200300_GSA.Size = new Size(151, 32);
            toolStripMenuItem200300_GSA.Text = "200-300";
            // 
            // toolStripMenuItem300AndMore_GSA
            // 
            toolStripMenuItem300AndMore_GSA.Name = "toolStripMenuItem300AndMore_GSA";
            toolStripMenuItem300AndMore_GSA.Size = new Size(151, 32);
            toolStripMenuItem300AndMore_GSA.Text = ">300";
            // 
            // FormMain_GSA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 860);
            Controls.Add(tabControl_GSA);
            Controls.Add(groupBox1);
            Controls.Add(panelStats_GSA);
            Controls.Add(groupBoxToolsPanel_GSA);
            Name = "FormMain_GSA";
            Text = "Авторемонтные мастерские";
            Load += FormMain_GSA_Load_1;
            groupBoxToolsPanel_GSA.ResumeLayout(false);
            panelTools_GSA.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBoxStats_GSA.ResumeLayout(false);
            groupBoxSortTools.ResumeLayout(false);
            tabControl_GSA.ResumeLayout(false);
            tabPage1_GSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_GSA).EndInit();
            tabPage2_GSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_GSA).EndInit();
            panelStats_GSA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartStats_GSA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStats_GSA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataServiceBindingSource).EndInit();
            contextMenuStripColor_GSA.ResumeLayout(false);
            contextMenuStripBrand_GSA.ResumeLayout(false);
            contextMenuStripPower_GSA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxToolsPanel_GSA;
        private Button buttonHelp_GSA;
        private Button buttonOpenFile_GSA;
        private Button buttonSaveResult_GSA;
        private GroupBox groupBoxSortTools;
        private Button buttonSortByPower_GSA;
        private Button buttonSortByBrand_GSA;
        private Button buttonSortByColor_GSA;
        private GroupBox groupBoxStats_GSA;
        private Button buttonStats_GSA;
        private Button buttonCreateChart_GSA;
        private GroupBox groupBox1;
        private Button buttonSearchByNumber_GSA;
        private Panel panelOutput_GSA;
        private TabControl tabControl_GSA;
        private TabPage tabPage1_GSA;
        private TabPage tabPage2_GSA;
        private DataGridView dataGridViewOutput_GSA;
        private Panel panelStats_GSA;
        private Splitter splitterLeftPanel_GSA;
        private Button buttonGuide_GSA;
        private DataGridView dataGridViewInput_GSA;
        private Panel panelTools_GSA;
        private DataGridView dataGridViewStats_GSA;
        private BindingSource dataServiceBindingSource;
        private SaveFileDialog saveFileDialog_GSA;
        private ToolTip toolTip_GSA;
        private OpenFileDialog openFileDialogTask_GSA;
        private ContextMenuStrip contextMenuStripColor_GSA;
        private ToolStripMenuItem toolStripMenuItemRed_GSA;
        private ToolStripMenuItem toolStripMenuItemBlue_GSA;
        private ToolStripMenuItem toolStripMenuItemWhite_GSA;
        private ToolStripMenuItem toolStripMenuItemGray_GSA;
        private ToolStripMenuItem toolStripMenuItemBlack_GSA;
        private ContextMenuStrip contextMenuStripBrand_GSA;
        private ToolStripMenuItem toolStripMenuItemToyota_GSA;
        private ToolStripMenuItem toolStripMenuItemNissan_GSA;
        private ToolStripMenuItem toolStripMenuItemFerrari_GSA;
        private ToolStripMenuItem toolStripMenuItemLADA_GSA;
        private ToolStripMenuItem toolStripMenuItemMersedes_GSA;
        private ToolStripMenuItem toolStripMenuItemBMW_GSA;
        private ContextMenuStrip contextMenuStripPower_GSA;
        private ToolStripMenuItem toolStripMenuItem100_GSA;
        private ToolStripMenuItem toolStripMenuItem100200_GSA;
        private ToolStripMenuItem toolStripMenuItem200300_GSA;
        private ToolStripMenuItem toolStripMenuItem300AndMore_GSA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_GSA;
    }
}
