using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;


namespace Willett_405
{
    public partial class Form1 : Form
    {
        //Stopwatch timer_for_shutter_delay = new Stopwatch();
        private RSPort port; // use private field for SerialPort

        public string fName;
        private int selectedRow; //Текущая строка
        public bool Stop = false;
        public int SelectedRow
        {
            get
            {
                return selectedRow;
            }

            set
            {
                selectedRow = value;
            }
        }
        //public Serial sr = new Serial();
        public Form1()
        {
            InitializeComponent();
            //port = new RSPort("COM8", 19200, Parity.None, 8, StopBits.One); // instantiates field
            //port.PinChanged += new SerialPinChangedEventHandler(Port_PinChanged); // New event trigger for communications
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //sr.InitRs();
            itemsTable.ColumnCount = 9;
            itemsTable.Enabled = false;
            itemsTable.Columns[0].Name = "Гот.";
            itemsTable.Columns[1].Name = "№";
            itemsTable.Columns[2].Name = "Ширина";
            itemsTable.Columns[3].Name = "Высота";
            itemsTable.Columns[4].Name = "Рамка";
            itemsTable.Columns[5].Name = "Портфель";
            itemsTable.Columns[6].Name = "Заказчик";
            itemsTable.Columns[7].Name = "Формула";
            itemsTable.Columns[8].Name = "Фирма";
            Finished.Visible = false;
            TaskFile.Enabled = false;
            PgUPButton.Enabled = false;
            PgDNButton.Enabled = false;
            UPButton.Enabled = false;
            DNButton.Enabled = false;

            StopButton.Text = "С\n \nT\n \nО\n \nП";
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow ThisRow = itemsTable.Rows[SelectedRow];
            //UIClass.Sendmess(ThisRow, sr);
            ThisRow.Cells[0].Value = "V";
            SelectedRow++;
            itemsTable.Rows[SelectedRow].Selected = true;

        }
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = "c:/TEMP",
                Filter = "Файл задания BSV *.fil|*.fil",
                Title = "Выберите файл с заданием",
                Multiselect = false,
                SupportMultiDottedExtensions = false
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenDialog(openFileDialog1.FileName);
            }
        }
        public void OpenDialog(string file)
        {
            fName = file;
            TaskFile.Text = fName;
            TaskFile.Enabled = true;
            TaskFile.ReadOnly = true;
            Finished.Visible = false;
            StreamReader sr = new StreamReader(fName);
            string line;
            string firstLine = sr.ReadLine();
            string secondLine = sr.ReadLine();
            itemsTable.Visible = false;
            if (firstLine == "*" && secondLine == "*$")
            {
                Finished.Visible = true;
            }
            else
            {
                itemsTable.Rows.Add(Misc.GetRow(firstLine));
                itemsTable.Rows.Add(Misc.GetRow(secondLine));
            }
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                itemsTable.Rows.Add(Misc.GetRow(line));
            }
            itemsTable.Visible = true;
            itemsTable.Enabled = true;
            itemsTable.Rows[0].Selected = true;
            PgUPButton.Enabled = true;
            PgDNButton.Enabled = true;
            UPButton.Enabled = true;
            DNButton.Enabled = true;
            sr.Close();
        }
        private bool CheckedItem(string str)
        {
            if (str.StartsWith("*"))
            {
                return true;
            }
            return false;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
        }
        private void PgUPButton_Click(object sender, EventArgs e)
        {

        }
        private void UPButton_Click(object sender, EventArgs e)
        {
            SelectedRow--;
            if (SelectedRow < 0)
            {
                SelectedRow = 0;
            }
            itemsTable.Rows[SelectedRow].Selected = true;
            NextButton.Enabled = false;
        }
        private void DNButton_Click(object sender, EventArgs e)
        {
            SelectedRow++;
            if (SelectedRow > itemsTable.RowCount)
            {
                SelectedRow = itemsTable.RowCount;
            }
            itemsTable.Rows[SelectedRow].Selected = true;
            NextButton.Enabled = false;
        }
        private void PgDNButton_Click(object sender, EventArgs e)
        {

        }
        private void ItemsTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (itemsTable.SelectedRows.Count == 1)
            {
                DataGridViewSelectedRowCollection selrows = itemsTable.SelectedRows;
                SelectedRow = selrows[0].Index;
            }
        }
        private void Port_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            string info = string.Empty;
            switch (e.EventType)
            {
                case SerialPinChange.Ring:
                    //timer_for_shutter_delay.Stop();
                    info = "Pin 9";
                    break;
                default:
                    //timer_for_shutter_delay.Stop();
                    info = "Other Pins";
                    break;
            }

        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop = true;
        }
    }
}
