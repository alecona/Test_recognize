using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string vedomost;
        string head = "";
        bool single = true;
        

        int[] v1 = new int[31];
        int[] v2 = new int[31];
        int[] v3 = new int[31];
        int[] v4 = new int[31];
        int[] v5 = new int[31];
        int[] v6 = new int[31];
        int[] v7 = new int[31];
        int[] v8 = new int[31];
        int[] v9 = new int[31];
        int[] v10 = new int[31];
        int[] v11 = new int[31];
        int[] v12 = new int[31];
        int[] v13 = new int[31];
        int[] v14 = new int[31];
        int[] v15 = new int[31];
        int[] v16 = new int[31];
        int[] v17 = new int[31];
        int[] v18 = new int[31];
        int[] v19 = new int[31];
        int[] v20 = new int[31];
        int[] v21 = new int[31];
        int[] v22 = new int[31];
        int[] v23 = new int[31];
        int[] v24 = new int[31];
        int[] v25 = new int[31];
        int[] v26 = new int[31];
        int[] v27 = new int[31];
        int[] v28 = new int[31];
        int[] v29 = new int[31];
        int[] v30 = new int[31];


        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "result";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                File.WriteAllText(filename, vedomost);
            }
        }
        
  


        private void btnGet_Click(object sender, EventArgs e)
        {
            
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                    var sr = new StreamReader(openFileDialog1.FileName);
                    var arr = v1;
                    int i = 1;
                    try
                    {
                        foreach (string line in System.IO.File.ReadLines(openFileDialog1.FileName, Encoding.GetEncoding(1251))) //Encoding.GetEncoding(1251)
                        {
                            if (String.IsNullOrEmpty(line))
                                continue;
                            //richTextBox1.Text += line;
                            if (line.Contains("Вариант"))
                            {
                                string ss;
                                try
                                {
                                    ss = String.Concat(line[line.IndexOf(":") + 1], line[line.IndexOf(":") + 2]);
                                }
                                catch
                                {
                                    ss = line[line.IndexOf(":") + 1].ToString();
                                }

                                switch (ss.Trim())
                                {
                                    case "1":
                                        arr = v1;

                                        break;
                                    case "2":
                                        arr = v2;

                                        break;
                                    case "3":
                                        arr = v3;

                                        break;
                                    case "4":
                                        arr = v4;

                                        break;
                                    case "5":
                                        arr = v5;

                                        break;
                                    case "6":
                                        arr = v6;

                                        break;
                                    case "7":
                                        arr = v7;

                                        break;
                                    case "8":
                                        arr = v8;

                                        break;
                                    case "9":
                                        arr = v9;

                                        break;
                                    case "10":
                                        arr = v10;

                                        break;
                                    case "11":
                                        arr = v11;

                                        break;
                                    case "12":
                                        arr = v12;

                                        break;
                                    case "13":
                                        arr = v13;

                                        break;
                                    case "14":
                                        arr = v14;

                                        break;
                                    case "15":
                                        arr = v15;

                                        break;
                                    case "16":
                                        arr = v16;

                                        break;
                                    case "17":
                                        arr = v17;

                                        break;
                                    case "18":
                                        arr = v18;

                                        break;
                                    case "19":
                                        arr = v19;

                                        break;
                                    case "20":
                                        arr = v20;

                                        break;
                                    case "21":
                                        arr = v21;

                                        break;
                                    case "22":
                                        arr = v22;

                                        break;
                                    case "23":
                                        arr = v23;

                                        break;
                                    case "24":
                                        arr = v24;

                                        break;
                                    case "25":
                                        arr = v25;

                                        break;
                                    case "26":
                                        arr = v26;

                                        break;
                                    case "27":
                                        arr = v27;

                                        break;
                                    case "28":
                                        arr = v28;

                                        break;
                                    case "29":
                                        arr = v29;

                                        break;
                                    case "30":
                                        arr = v30;

                                        break;
                                }
                                i = 1;
                                continue;

                            }
                           
                                arr[i++] = Int32.Parse(line[line.LastIndexOf(":") + 1].ToString());
                            
                            
                        }
                        label1.Visible = true;
                        btnStu.Enabled = true;
                        btnFolder.Enabled = true;
                    }
                    catch 
                    {
                        MessageBox.Show($"Ошибка в файле правильных ответов " + openFileDialog1.FileName);
                    }
                    
                
                
                
            }
        }

        


        void doIt(string file)
        {
            head = "";
            
            //var sr = new StreamReader(openFileDialog1.FileName);
            var arr = v1;
            int i = 1;
            int h = 0;
            int tru = 0;
            int ll = 0;
            try
            {
                foreach (string line in System.IO.File.ReadLines(file, Encoding.GetEncoding(1251)))
                {
                    if (String.IsNullOrEmpty(line))
                        continue;

                    if (h < 3)
                    {
                        if (single)
                        {
                            head += line + '\n';
                        }
                        else head += line + '\t';
                        h++;
                        continue;
                    }
                    //richTextBox1.Text += line;
                    if (line.Contains("Вариант"))
                    {
                        if (single)
                        {
                            head += line + '\n';
                            head += "Вопрос    Студент  Верный   Результат" + '\n';
                        }
                        else head += line + '\t';

                        string ss;
                        try
                        {
                            ss = String.Concat(line[line.IndexOf(":") + 1], line[line.IndexOf(":") + 2]);
                        }
                        catch
                        {
                            ss = line[line.IndexOf(":") + 1].ToString();
                        }

                        switch (ss.Trim())
                        {
                            case "1":
                                arr = v1;

                                break;
                            case "2":
                                arr = v2;

                                break;
                            case "3":
                                arr = v3;

                                break;
                            case "4":
                                arr = v4;

                                break;
                            case "5":
                                arr = v5;

                                break;
                            case "6":
                                arr = v6;

                                break;
                            case "7":
                                arr = v7;

                                break;
                            case "8":
                                arr = v8;

                                break;
                            case "9":
                                arr = v9;

                                break;
                            case "10":
                                arr = v10;

                                break;
                            case "11":
                                arr = v11;

                                break;
                            case "12":
                                arr = v12;

                                break;
                            case "13":
                                arr = v13;

                                break;
                            case "14":
                                arr = v14;

                                break;
                            case "15":
                                arr = v15;

                                break;
                            case "16":
                                arr = v16;

                                break;
                            case "17":
                                arr = v17;

                                break;
                            case "18":
                                arr = v18;

                                break;
                            case "19":
                                arr = v19;

                                break;
                            case "20":
                                arr = v20;

                                break;
                            case "21":
                                arr = v21;

                                break;
                            case "22":
                                arr = v22;

                                break;
                            case "23":
                                arr = v23;

                                break;
                            case "24":
                                arr = v24;

                                break;
                            case "25":
                                arr = v25;

                                break;
                            case "26":
                                arr = v26;

                                break;
                            case "27":
                                arr = v27;

                                break;
                            case "28":
                                arr = v28;

                                break;
                            case "29":
                                arr = v29;

                                break;
                            case "30":
                                arr = v30;

                                break;
                        }
                        i = 1;
                        continue;

                    }
                    ll++;
                    if (arr[i++] == Int32.Parse(line[line.Length - 1].ToString()))
                    {
                        if (single)
                        {
                            head += (i - 1).ToString() + " \t | " + Int32.Parse(line[line.Length - 1].ToString()) + " \t| " + arr[i - 1] + " \t| " + " TRUE\n";
                        }

                        tru++;
                    }
                    else
                    {
                        if (single)
                        {
                            head += (i - 1).ToString() + " \t | " + Int32.Parse(line[line.Length - 1].ToString()) + " \t| " + arr[i - 1] + " \t| " + " FALSE\n";
                        }

                    }

                }
            }
            catch
            {
                MessageBox.Show($"Ошибка в файле студента \n" + file);
            }
            tru = (int)((float)(((float)tru / ll) + 0.005) * 100);
            head += "Результат " + tru.ToString() + "%\n";
            
        }
    

       
        private void btnStu_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            richTextBox1.Text = "";
            single = true;
            head = "";
            vedomost = "";
            
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    doIt(openFileDialog1.FileName);
                    vedomost += head + "\n";
                    
                }
                catch
                {
                    MessageBox.Show($"Ошибка в файле студента \n" + openFileDialog1.FileName);
                }

                richTextBox1.Text = vedomost;
                
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            richTextBox1.Text = "";
            head = "";
            vedomost = "";
            single = false;
            int num = 1;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                foreach (var file in files)
                {
                    vedomost += num.ToString() + " ";
                    doIt(file);
                    vedomost += head;
                    head = "";
                    num++;
                }
                
                /**richTextBox1.Text += "\nFiles found: " + files.Length.ToString();
                for(int i = 0; i < files.Length; i++)
                {
                    richTextBox1.Text += "\n" + files[i];
                }**/
                richTextBox1.Text = vedomost;

            }
        }
    }
}
