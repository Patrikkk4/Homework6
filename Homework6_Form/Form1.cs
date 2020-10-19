using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Homework6_Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Stopwatch time = new Stopwatch();

        public delegate void Delegate(string label);

        List<int> allNumbers = new List<int>();
        List<int> OutNumbers = new List<int>();
        int GroupNum = 1;
        int number;
        string label;
        Thread work;

        async void thread()
        {
            time.Start();

            lblTime.Text = "Идет работа";

            work = new Thread(delegate () 
            {                
                while (allNumbers.Count > 0)
                {
                    calculation(allNumbers, OutNumbers, GroupNum);
                    GroupNum++;
                }
            });
            work.Start();

            time.Stop();

            lblTime.Text = time.Elapsed.TotalMilliseconds.ToString();
        }

        void FileChouse(List<int> allNumbers)
        {
            opnFIle.Filter = "Текстовый файл(*.txt)|*.txt|Таблица(*.cvs)|*cvs|All files(*.*)|*.*";

            if (opnFIle.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = opnFIle.FileName;
            }

            string[] numberStr = File.ReadAllLines(lblPath.Text);
            number = Convert.ToInt32(numberStr[0]);

            for (int i = 1; i <= number; i++)
            {
                allNumbers.Add(i);
            }
        }

        void fileSave()
        {
            dlgSave.Filter = "Таблица(*.csv)|*.csv|Текстовый файл(*.txt)|*.txt|All files(*.*)|*.*";
            dlgSave.FileName = "Результат";

            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                    lblSavePath.Text = dlgSave.FileName;
            }
        }

        void changeLabels(string label)
        {
            lblCount.Text = "Групп: " + File.ReadAllLines(lblSavePath.Text).Length.ToString();
            lblFileSize.Text = "Байт: " + new FileInfo(lblSavePath.Text).Length.ToString();
        }

        void calculation(List<int> allNumbers, List<int> OutNumbers, int GroupNum)
        {           
            OutNumbers.Add(allNumbers.First());
            allNumbers.Remove(allNumbers.First());
            for (int i = 0; i < allNumbers.Count; i++)
            {
                if (allNumbers[i] % OutNumbers[0] != 0)
                {
                    OutNumbers.Add(allNumbers[i]);
                    for (int k = 0; k < OutNumbers.Count; k++)
                    {
                        if (allNumbers[i] != OutNumbers[k])
                        {
                            if (allNumbers[i] % OutNumbers[k] == 0)
                            {
                                OutNumbers.Remove(allNumbers[i]);
                            }
                        }
                    }
                }
            }
            allNumbers.RemoveAll(x => OutNumbers.Contains(x));

            using (StreamWriter calc = File.AppendText(lblSavePath.Text))
            {
                calc.Write("Группа № " + GroupNum + ": \t");

                for (int i = 0; i < OutNumbers.Count; i++)
                {
                    if (OutNumbers[i] != OutNumbers.Last())
                    {
                        calc.Write(OutNumbers[i] + "\t");
                    }
                    else
                    {
                        calc.Write(OutNumbers[i] + "\t" + "\n");
                    }
                }
                calc.Close();
            }

            label = "Групп: " + File.ReadAllLines(lblSavePath.Text).Length.ToString();

            BeginInvoke(new Delegate(changeLabels), label);

            //label = "Байт: " + new FileInfo(lblSavePath.Text).Length.ToString();

            //BeginInvoke(new Delegate(changeLabels), label);

            GroupNum++;
            OutNumbers.Clear();
        }

        void archive()
        {
            string sourceFile = lblSavePath.Text;
            string resize = lblSavePath.Text + ".zip";
            using (FileStream stream = new FileStream(sourceFile, FileMode.OpenOrCreate))
            {
                using (FileStream resized = File.Create(resize))
                {
                    using (GZipStream compress = new GZipStream(resized, CompressionMode.Compress))
                    {
                        lblResizeResult.Text = "Идет сжатие";
                        stream.CopyTo(compress);
                        lblResizeResult.Text = "Байт: " + resized.Length;
                    }
                }
            }
        }
        

        private void BtnFileChouse_Click(object sender, EventArgs e)
        {
            FileChouse(allNumbers);
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (lblPath.Text != "Путь к файлу")
            {
                fileSave();
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл. Нажмите открыть");
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {         
            if (lblPath.Text != "Путь к файлу" && lblSavePath.Text != "Путь к файлу")
            {
                thread();
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл или не выбрали место сохранения.");
            }            
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            if (lblPath.Text != "Путь к файлу" && lblSavePath.Text != "Путь к файлу")
            {
                archive();
            }
            else
            {
                MessageBox.Show("Вы не создали файл с результатом.");
            }
        }

        private void BtnOpenResult_Click(object sender, EventArgs e)
        {
            Process.Start(lblSavePath.Text);
        }
    }
}
