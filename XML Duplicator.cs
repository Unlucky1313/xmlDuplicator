using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        TextBox[] findBox;
        TextBox[] replaceBox;

        public Form1()
        {
            InitializeComponent();
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                inputText.Text = selectedFileName;
                OutputText.Text = Path.GetDirectoryName(inputText.Text) + "\\duplicates\\" + Path.GetFileNameWithoutExtension(inputText.Text) + "Copy" + Path.GetExtension(inputText.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0);
                End = strSource.IndexOf(strEnd, Start) + strEnd.Length;
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        public static string getBetweenExclusive(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullText, dupText, tempText, columnData;
            int k = 0, columnIndex; // Array index
            TextBox[] findBoxes = { findBox1, findBox2, findBox3, findBox4, findBox5, findBox6, findBox7, findBox8 };

            // If input is empty
            if (inputText.Text == "") { MessageBox.Show("No file selected."); return; }

            using (var streamReader = new StreamReader(inputText.Text, Encoding.UTF8))
            {
                fullText = streamReader.ReadToEnd();
            }

            // If input does not contain OI tags
            if (!(fullText.Contains("<ExportedObjects>") && fullText.Contains("</ExportedObjects>"))) { MessageBox.Show("Could not find OI Tags in the text file."); return; }

            // Get text to be duplicated
            dupText = getBetweenExclusive(fullText, "<ExportedObjects>", "</ExportedObjects>");

            foreach (DataGridViewRow row in dataGridMain.Rows)
            {

                tempText = dupText; // Get new text for each roe
                for (int i = 0; i < 8; i++)
                {

                    if (findBoxes[i].Text != "")
                    {
                        columnData = string.Empty;
                        columnData = Convert.ToString(row.Cells[i].Value);
                        if (columnData != "")
                        {
                            tempText = tempText.Replace(findBoxes[i].Text,columnData);

                        }
                    }

                }

                if (tempText != dupText)
                {
                    fullText = fullText + System.Environment.NewLine + System.Environment.NewLine + "  " + tempText;
                }

            }

            tempText = getBetween(fullText,"</ExportedObjects>", "/ObjectSet>");
            System.Diagnostics.Debug.WriteLine(tempText);
            fullText = fullText.Replace(tempText, "");
            fullText = fullText + System.Environment.NewLine + tempText;

            System.Diagnostics.Debug.WriteLine(fullText);

            Directory.CreateDirectory(Path.GetDirectoryName(OutputText.Text));
            using (FileStream fs = File.Create(OutputText.Text))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(fullText);
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            MessageBox.Show("Duplication Successful!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridMain.Rows.Add(replaceBox1.Text, replaceBox2.Text, replaceBox3.Text, replaceBox4.Text, replaceBox5.Text, replaceBox6.Text, replaceBox7.Text, replaceBox8.Text);
        }

    }
}
