using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GrabinaSA.Sprint7.ProjectV1.Lib;
namespace Project.V1
{
    public partial class FormMain_GSA : Form
    {
        static string openFilePath;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public FormMain_GSA()
        {
            InitializeComponent(); toolStripMenuItemRed_GSA.Click += MenuItem_Click; toolStripMenuItemBlue_GSA.Click += MenuItem_Click; toolStripMenuItemGray_GSA.Click += MenuItem_Click; toolStripMenuItemWhite_GSA.Click += MenuItem_Click; toolStripMenuItemBlack_GSA.Click += MenuItem_Click; toolStripMenuItemBMW_GSA.Click += MenuItem_Click; toolStripMenuItemNissan_GSA.Click += MenuItem_Click; toolStripMenuItemLADA_GSA.Click += MenuItem_Click; toolStripMenuItemMersedes_GSA.Click += MenuItem_Click; toolStripMenuItemToyota_GSA.Click += MenuItem_Click; toolStripMenuItemFerrari_GSA.Click += MenuItem_Click; toolStripMenuItem100_GSA.Click += MenuItem_Click; toolStripMenuItem100200_GSA.Click += MenuItem_Click; toolStripMenuItem200300_GSA.Click += MenuItem_Click; toolStripMenuItem300AndMore_GSA.Click += MenuItem_Click;
        }

        private void buttonHelp_GSA_Click(object sender, EventArgs e) { FormAbout formAbout = new FormAbout(); formAbout.ShowDialog(); }

        private void buttonSortByBrand_GSA_Click(object sender, EventArgs e) { contextMenuStripBrand_GSA.Show(buttonSortByBrand_GSA, new Point(0, buttonSortByBrand_GSA.Height)); }
        #region MouseEnterTips private void buttonSortByColor_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonSortByColor_GSA, "Фильтровать по цвету автомобиля"); } 

        private void buttonSortByBrand_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonSortByBrand_GSA, "Фильтровать по марке автомобиля"); }

        private void buttonSortByPower_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonSortByPower_GSA, "Фильтровать по мощности двигателя"); }

        private void buttonSearchByNumber_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonSearchByNumber_GSA, "Поиск автомобиля по гос. номеру"); }

        private void buttonHelp_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonHelp_GSA, "Справка"); }

        private void buttonOpenFile_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonOpenFile_GSA, "Открыть базу данных"); }

        private void buttonSaveResult_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonSaveResult_GSA, "Сохранить результат в файл"); }

        private void buttonCreateChart_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonCreateChart_GSA, "Построить диаграмму"); }

        private void buttonStats_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonStats_GSA, "Вывести статистику"); }
        private void buttonGuide_GSA_MouseEnter(object sender, EventArgs e) { toolTip_GSA.SetToolTip(buttonGuide_GSA, "Руководство пользователя"); }
        #endregion

        public static string[,] LoadFromFileData(string FilePath)
        {
            string fileData = File.ReadAllText(FilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] data = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = line[j];
                }
            }
            return data;


        }

        private void buttonOpenFile_GSA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GSA.ShowDialog(); openFilePath = openFileDialogTask_GSA.FileName;

            string[,] data = new string[rows, columns];

            data = LoadFromFileData(openFilePath);

            dataGridViewInput_GSA.ColumnCount = columns;
            dataGridViewInput_GSA.RowCount = rows + 1;
            dataGridViewOutput_GSA.ColumnCount = columns;
            dataGridViewOutput_GSA.RowCount = rows;

            for (int h = 0; h < columns; h++)
            {
                dataGridViewInput_GSA.Columns[h].Width = 190;
                dataGridViewOutput_GSA.Columns[h].Width = 190;
            }

            dataGridViewInput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
            dataGridViewInput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
            dataGridViewInput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
            dataGridViewInput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";
            dataGridViewInput_GSA.Rows[0].Height = 50;

            int r = 1;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_GSA.Rows[r].Cells[j].Value = data[i, j];

                }
                r++;
            }
            buttonSortByBrand_GSA.Enabled = true;
            buttonSortByColor_GSA.Enabled = true;
            buttonSortByPower_GSA.Enabled = true;
            buttonCreateChart_GSA.Enabled = true;
            buttonStats_GSA.Enabled = true;
            buttonSearchByNumber_GSA.Enabled = true;
            buttonSaveResult_GSA.Enabled = true;


        }

        private void buttonSortByColor_GSA_Click(object sender, EventArgs e) { contextMenuStripColor_GSA.Show(buttonSortByColor_GSA, new Point(0, buttonSortByColor_GSA.Height)); }
        private void MenuItem_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, columns]; data = LoadFromFileData(openFilePath);

            dataGridViewOutput_GSA.ColumnCount = columns;
            dataGridViewOutput_GSA.RowCount = rows;

            for (int h = 0; h < columns; h++)
            {
                dataGridViewInput_GSA.Columns[h].Width = 190;
                dataGridViewOutput_GSA.Columns[h].Width = 190;
            }

            dataGridViewOutput_GSA.Rows[0].Height = 50;

            ToolStripMenuItem selectedItem = sender as ToolStripMenuItem;


            switch (selectedItem.Text)
            {
                case "Красный":
                    int r = 1;
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 2] == "Красный")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }

                    }
                    break;

                case "Синий":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";


                    r = 1;
                    for (int i = 1; i < rows; i++)
                    {
                        if (data[i, 2] == "Синий")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;

                case "Белый":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 1; i < rows; i++)
                    {
                        if (data[i, 2] == "Белый")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;

                case "Серый":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 1; i < rows; i++)
                    {
                        if (data[i, 2] == "Серый")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    };
                    break;
                case "Черный":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 2] == "Черный")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "BMW":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 1] == "BMW")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "Mersedes":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 1] == "Mersedes")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "Toyota":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 1] == "Toyota")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "Nissan":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 1] == "Nissan")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "Ferrari":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 1] == "Ferrari")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "LADA":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (data[i, 1] == "LADA")
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "0-100":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (Convert.ToInt32(data[i, 3]) >= 0 && Convert.ToInt32(data[i, 3]) <= 100)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "100-200":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (Convert.ToInt32(data[i, 3]) >= 100 && Convert.ToInt32(data[i, 3]) <= 200)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case "200-300":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (Convert.ToInt32(data[i, 3]) >= 200 && Convert.ToInt32(data[i, 3]) <= 300)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
                case ">300":
                    dataGridViewOutput_GSA.Rows.Clear();
                    dataGridViewOutput_GSA.ColumnCount = columns;
                    dataGridViewOutput_GSA.RowCount = rows;
                    dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                    dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                    r = 1;
                    for (int i = 0; i < rows; i++)
                    {
                        if (Convert.ToInt32(data[i, 3]) >= 300)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                            }
                            r++;
                        }
                    }
                    break;
            }


        }

        private void buttonSortByPower_GSA_Click(object sender, EventArgs e) { contextMenuStripPower_GSA.Show(buttonSortByPower_GSA, new Point(0, buttonSortByPower_GSA.Height)); }

        private void buttonSaveResult_GSA_Click(object sender, EventArgs e)
        {
            saveFileDialog_GSA.FileName = "file.csv"; saveFileDialog_GSA.InitialDirectory = Directory.GetCurrentDirectory(); saveFileDialog_GSA.ShowDialog();

            string path = saveFileDialog_GSA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (dataGridViewOutput_GSA.Rows[i].Cells[j].Value.ToString() == "") break;
                        if (j != columns - 1)
                        {
                            str += dataGridViewOutput_GSA.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewOutput_GSA.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch { }


        }

        private void buttonStats_GSA_Click(object sender, EventArgs e)
        {

            string[,] data = new string[rows, columns];

            data = LoadFromFileData(openFilePath);

            dataGridViewStats_GSA.ColumnCount = 2;
            dataGridViewStats_GSA.RowCount = 6;



            dataGridViewStats_GSA.Rows[0].Cells[0].Value = "Общее кол-во машин";
            dataGridViewStats_GSA.Rows[1].Cells[0].Value = "Преобладающий цвет машин";
            dataGridViewStats_GSA.Rows[2].Cells[0].Value = "Преобладающая марка машин";
            dataGridViewStats_GSA.Rows[3].Cells[0].Value = "Средняя мощность двигателя";
            dataGridViewStats_GSA.Rows[4].Cells[0].Value = "Максимальная мощность двигателя";
            dataGridViewStats_GSA.Rows[5].Cells[0].Value = "Минимальная мощность двигателя";
            dataGridViewStats_GSA.Columns[0].Width = 300;
            dataGridViewStats_GSA.Columns[1].Width = 100;
            dataGridViewStats_GSA.Rows[0].Cells[1].Value = dataGridViewInput_GSA.Rows.Count - 1;
            int red = 0;
            int blue = 0;
            int gray = 0;
            int white = 0;
            int black = 0;
            int toyota = 0;
            int ferrari = 0;
            int lada = 0;
            int nissan = 0;
            int bmw = 0;
            int mersedes = 0;
            double AveragePower = 0;
            int maxPower = 0;
            int minPower = 1000;
            for (int i = 0; i < rows; i++)
            {
                switch (data[i, 2])
                {
                    case "Красный":
                        red++; break;
                    case "Синий":
                        blue++; break;
                    case "Серый":
                        gray++; break;
                    case "Белый":
                        white++; break;
                    case "Черный":
                        black++; break;
                }
                switch (data[i, 1])
                {
                    case "BMW":
                        bmw++; break;
                    case "Toyota":
                        toyota++; break;
                    case "Mersedes":
                        mersedes++; break;
                    case "LADA":
                        lada++; break;
                    case "Nissan":
                        nissan++; break;
                    case "Ferrari":
                        ferrari++; break;

                }
                AveragePower += Convert.ToInt32(data[i, 3]);
                if (Convert.ToInt32(data[i, 3]) >= maxPower) maxPower = Convert.ToInt32(data[i, 3]);
                if (Convert.ToInt32(data[i, 3]) <= minPower) minPower = Convert.ToInt32(data[i, 3]);
            }
            AveragePower = Math.Round(AveragePower / (dataGridViewInput_GSA.Rows.Count - 1), 2);
            string color;
            int maxcolor = Math.Max(red, (Math.Max(blue, Math.Max(white, Math.Max(gray, black)))));
            if (maxcolor == red) dataGridViewStats_GSA.Rows[1].Cells[1].Value = "Красный";
            if (maxcolor == blue) dataGridViewStats_GSA.Rows[1].Cells[1].Value = "Синий";
            if (maxcolor == white) dataGridViewStats_GSA.Rows[1].Cells[1].Value = "Белый";
            if (maxcolor == black) dataGridViewStats_GSA.Rows[1].Cells[1].Value = "Черный";
            if (maxcolor == gray) dataGridViewStats_GSA.Rows[1].Cells[1].Value = "Серый";
            int maxbrand = Math.Max(toyota, (Math.Max(nissan, Math.Max(bmw, Math.Max(lada, Math.Max(ferrari, mersedes))))));
            if (maxbrand == toyota) dataGridViewStats_GSA.Rows[2].Cells[1].Value = "Toyota";
            if (maxbrand == bmw) dataGridViewStats_GSA.Rows[2].Cells[1].Value = "BMW";
            if (maxbrand == mersedes) dataGridViewStats_GSA.Rows[2].Cells[1].Value = "Mersedes";
            if (maxbrand == lada) dataGridViewStats_GSA.Rows[2].Cells[1].Value = "LADA";
            if (maxbrand == nissan) dataGridViewStats_GSA.Rows[2].Cells[1].Value = "Nissan";
            if (maxbrand == ferrari) dataGridViewStats_GSA.Rows[2].Cells[1].Value = "Ferrari";
            dataGridViewStats_GSA.Rows[3].Cells[1].Value = Convert.ToString(AveragePower);
            dataGridViewStats_GSA.Rows[4].Cells[1].Value = Convert.ToString(maxPower);
            dataGridViewStats_GSA.Rows[5].Cells[1].Value = Convert.ToString(minPower);


        }

        private void buttonSearchByNumber_GSA_Click(object sender, EventArgs e)
        {
            FormSearch FormSearch = new FormSearch(); FormSearch.ShowDialog(); FormSearch textBoxSearch = new FormSearch(); try
            {
                string[,] data = new string[rows, columns];

                data = LoadFromFileData(openFilePath);
                int r = 1;
                dataGridViewOutput_GSA.Rows.Clear();
                dataGridViewOutput_GSA.ColumnCount = columns;
                dataGridViewOutput_GSA.RowCount = rows;
                dataGridViewOutput_GSA.Rows[0].Cells[0].Value = "Гос. номер автомобиля";
                dataGridViewOutput_GSA.Rows[0].Cells[1].Value = "Марка автомобиля";
                dataGridViewOutput_GSA.Rows[0].Cells[2].Value = "Цвет автомобиля";
                dataGridViewOutput_GSA.Rows[0].Cells[3].Value = "Мощность двигателя, л.с.";

                for (int i = 0; i < rows; i++)
                {
                    if (data[i, 0] == DataBank.text)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridViewOutput_GSA.Rows[r].Cells[j].Value = data[i, j];
                        }
                        r++;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Номер введен неверно или машины с таким номером нет в автомастерской", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonCreateChart_GSA_Click(object sender, EventArgs e)
        {
            string[,] data = new string[rows, columns];

            data = LoadFromFileData(openFilePath);

            this.chartStats_GSA.ChartAreas[0].AxisX.Title = "Марка автомобиля";
            this.chartStats_GSA.ChartAreas[0].AxisY.Title = "Средняя мощность двигателя";

            double averagePowerToyota = 0;
            int toyotacount = 0; int nissancount = 0; int bmwcount = 0; int ladacount = 0; int mersedescount = 0; int ferraricount = 0;
            double averagePowerNissan = 0;
            double averagePowerMersedes = 0;
            double averagePowerBMW = 0;
            double averagePowerLADA = 0;
            double averagePowerFerrari = 0;

            for (int i = 0; i < rows; i++)
            {
                if (data[i, 1] == "Toyota")
                {
                    averagePowerToyota += Convert.ToInt32(data[i, 3]);
                    toyotacount++;
                }
                if (data[i, 1] == "BMW")
                {
                    averagePowerBMW += Convert.ToInt32(data[i, 3]);
                    bmwcount++;
                }
                if (data[i, 1] == "Mersedes")
                {
                    averagePowerMersedes += Convert.ToInt32(data[i, 3]);
                    mersedescount++;
                }
                if (data[i, 1] == "Nissan")
                {
                    averagePowerNissan += Convert.ToInt32(data[i, 3]);
                    nissancount++;
                }
                if (data[i, 1] == "LADA")
                {
                    averagePowerLADA += Convert.ToInt32(data[i, 3]);
                    ladacount++;
                }
                if (data[i, 1] == "Ferrari")
                {
                    averagePowerFerrari += Convert.ToInt32(data[i, 3]);
                    ferraricount++;
                }
            }



            averagePowerToyota = Math.Round(averagePowerToyota / toyotacount, 2);
            averagePowerNissan = Math.Round(averagePowerNissan / nissancount, 2);
            averagePowerMersedes = Math.Round(averagePowerMersedes / mersedescount, 2);
            averagePowerLADA = Math.Round(averagePowerLADA / ladacount, 2);
            averagePowerFerrari = Math.Round(averagePowerFerrari / ferraricount, 2);
            averagePowerBMW = Math.Round(averagePowerBMW / bmwcount, 2);
            /* this.chartStats_GSA.Series[0].Points.AddXY("Toyota", averagePowerToyota); 
             this.chartStats_GSA.Series[0].Points.AddXY("BMW", averagePowerBMW); 
             this.chartStats_GSA.Series[0].Points.AddXY("Mersedes", averagePowerMersedes); 
             this.chartStats_GSA.Series[0].Points.AddXY("Nissan", averagePowerNissan); 
             this.chartStats_GSA.Series[0].Points.AddXY("LADA", averagePowerLADA); 
             this.chartStats_GSA.Series[0].Points.AddXY("Ferrari", averagePowerFerrari);*/

            this.chartStats_GSA.Series.Add("Toyota");
            this.chartStats_GSA.Series.Add("BMW");
            this.chartStats_GSA.Series.Add("Mersedes");
            this.chartStats_GSA.Series.Add("Nissan");
            this.chartStats_GSA.Series.Add("LADA");
            this.chartStats_GSA.Series.Add("Ferrari");


            foreach (Series series in this.chartStats_GSA.Series)
            {
                series.ChartType = SeriesChartType.Column;
            }


            this.chartStats_GSA.Series["Toyota"]["PointWidth"] = "1";
            this.chartStats_GSA.Series["Toyota"].Points.AddXY(0, averagePowerToyota);
            this.chartStats_GSA.Series["BMW"].Points.AddXY(1, averagePowerBMW);
            this.chartStats_GSA.Series["Mersedes"].Points.AddXY(2, averagePowerMersedes);
            this.chartStats_GSA.Series["Nissan"].Points.AddXY(3, averagePowerNissan);
            this.chartStats_GSA.Series["LADA"].Points.AddXY(4, averagePowerLADA);
            this.chartStats_GSA.Series["Ferrari"].Points.AddXY(5, averagePowerFerrari);


        }

        private void buttonGuide_GSA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_GSA_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void FormMain_GSA_Load_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_GSA_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewInput_GSA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearchByNumber_GSA_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelTools_GSA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toyotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStripBrand_GSA_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void panelStats_GSA_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSortByColor_GSA_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}

