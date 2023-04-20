using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditorSem1
{
    public partial class Form1 : Form
    {
        public string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите текст в поле ниже, нажмите кнопочку ввод и вам выведутся данные. Либо же вы можете загрузить текстовый файл формата .txt");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            input = richTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(input);
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        input = reader.ReadToEnd();
                    }
                }
            }

            Form2 f2 = new Form2(input);
            f2.Show();
        }
    }
}
