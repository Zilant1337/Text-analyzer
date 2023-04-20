using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorSem1
{
    public partial class Form2 : Form
    {
        public string text;
        public Form2(string input)
        {
            InitializeComponent();

            text = input;
            Console.WriteLine(text);
            if (text == null)
            {
                MessageBox.Show("Упс! Вы не ввели текста! Закройте окно и попробуйте ещё раз!");
                return;
            }

            Regex reg = new Regex("[0-9а-яА-яa-zA-Z]+");
            var words = new List<string>();
            if (reg.IsMatch(text))
            {
                foreach (Match match in reg.Matches(text))
                {
                    words.Add(match.Value);
                }

            }
            
            
            reg = new Regex("[0-9а-яА-яa-zA-Z']");
            var letters = new List<string>();
            if (reg.IsMatch(text))
            {
                foreach (Match match in reg.Matches(text))
                {
                    letters.Add(match.Value);
                }

            }

            int unique_word_count=0, word_count=0,symbol_count=0;
            var found_unique_words = new List<string>();
            var found_unique_symbols = new List<string>();

            foreach(string word in words)
            {
                if (!found_unique_words.Contains(word))
                {
                    found_unique_words.Add(word);
                    unique_word_count++;
                }

                word_count++;
            }

            for(int i = 0; i < found_unique_words.Count; i++)
            {
                for(int j = i; j < found_unique_words.Count; j++)
                {
                    if (found_unique_words[j].Length > found_unique_words[i].Length)
                    {
                        string temp = found_unique_words[i];
                        found_unique_words[i] = found_unique_words[j];
                        found_unique_words[j] = temp;
                    }
                }
            }

            var unique_words = new List<Tuple<string, int>>();

            foreach (string word in found_unique_words)
            {
                unique_words.Add(Tuple.Create(word, 0));
            }

            foreach(string word in words)
            {
                for(int i = 0; i < unique_words.Count; i++)
                {
                    if (unique_words[i].Item1 == word)
                    {
                        unique_words[i]= Tuple.Create(unique_words[i].Item1, unique_words[i].Item2 + 1);
                    }
                }
            }

            for(int i = 0; i < unique_words.Count; i++)
            {
                for(int j = i; j < unique_words.Count;j++)
                {
                    if (unique_words[j].Item2 > unique_words[i].Item2)
                    {
                        Tuple<string,int> temp = Tuple.Create(unique_words[i].Item1, unique_words[i].Item2);
                        unique_words[i] = Tuple.Create(unique_words[j].Item1, unique_words[j].Item2);
                        unique_words[j] = Tuple.Create(temp.Item1, temp.Item2);
                    }
                }
            }

            //повторяем для букв

            foreach (string letter in letters)
            {
                if (!found_unique_symbols.Contains(letter))
                {
                    found_unique_symbols.Add(letter);
                }

                symbol_count++;
            }

            var unique_symbols = new List<Tuple<string, int>>();

            foreach (string letter in found_unique_symbols)
            {
                unique_symbols.Add(Tuple.Create(letter, 0));
            }

            foreach (string letter in letters)
            {
                for (int i = 0; i < unique_symbols.Count; i++)
                {
                    if (unique_symbols[i].Item1 == letter)
                    {
                        unique_symbols[i] = Tuple.Create(unique_symbols[i].Item1, unique_symbols[i].Item2 + 1);
                    }
                }
            }

            for (int i = 0; i < unique_symbols.Count; i++)
            {
                for (int j = i; j < unique_symbols.Count; j++)
                {
                    if (unique_symbols[j].Item2 > unique_symbols[i].Item2)
                    {
                        Tuple<string, int> temp = Tuple.Create(unique_symbols[i].Item1, unique_symbols[i].Item2);
                        unique_symbols[i] = Tuple.Create(unique_symbols[j].Item1, unique_symbols[j].Item2);
                        unique_symbols[j] = Tuple.Create(temp.Item1, temp.Item2);
                    }
                }
            }

            //выводы в текст боксы
            for (int i = 0; i < 10; i++)
            {
                if (i < found_unique_words.Count)
                {
                    LongestWords.Text += found_unique_words[i];
                    LongestWords.Text += "\n";
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (i < unique_words.Count)
                {
                    MostUsedWords.Text += unique_words[i].Item1;
                    MostUsedWords.Text += " - ";
                    MostUsedWords.Text += unique_words[i].Item2;
                    MostUsedWords.Text += "\n";
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < unique_symbols.Count; i++)
            {
                
                Letters.Text += unique_symbols[i].Item1;
                Letters.Text += " - ";
                Letters.Text +=((float)unique_symbols[i].Item2/(float)symbol_count)*100;
                Letters.Text +='%';
                Letters.Text +="\n";
            }

            WordCount.Text += word_count;
            UniqueWordCount.Text += unique_word_count;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
