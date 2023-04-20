
namespace TextEditorSem1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.WordCount = new System.Windows.Forms.TextBox();
            this.UniqueWordCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LongestWords = new System.Windows.Forms.RichTextBox();
            this.MostUsedWords = new System.Windows.Forms.RichTextBox();
            this.Letters = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество слов:";
            // 
            // WordCount
            // 
            this.WordCount.Location = new System.Drawing.Point(16, 30);
            this.WordCount.Name = "WordCount";
            this.WordCount.ReadOnly = true;
            this.WordCount.Size = new System.Drawing.Size(100, 20);
            this.WordCount.TabIndex = 1;
            this.WordCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UniqueWordCount
            // 
            this.UniqueWordCount.Location = new System.Drawing.Point(16, 82);
            this.UniqueWordCount.Name = "UniqueWordCount";
            this.UniqueWordCount.ReadOnly = true;
            this.UniqueWordCount.Size = new System.Drawing.Size(100, 20);
            this.UniqueWordCount.TabIndex = 2;
            this.UniqueWordCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество уникальных слов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Самые длинные:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Самые часто встречающиеся:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ранжирование букв:";
            // 
            // LongestWords
            // 
            this.LongestWords.Location = new System.Drawing.Point(16, 139);
            this.LongestWords.Name = "LongestWords";
            this.LongestWords.ReadOnly = true;
            this.LongestWords.Size = new System.Drawing.Size(131, 130);
            this.LongestWords.TabIndex = 7;
            this.LongestWords.Text = "";
            this.LongestWords.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MostUsedWords
            // 
            this.MostUsedWords.Location = new System.Drawing.Point(16, 311);
            this.MostUsedWords.Name = "MostUsedWords";
            this.MostUsedWords.ReadOnly = true;
            this.MostUsedWords.Size = new System.Drawing.Size(131, 130);
            this.MostUsedWords.TabIndex = 8;
            this.MostUsedWords.Text = "";
            this.MostUsedWords.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Letters
            // 
            this.Letters.Location = new System.Drawing.Point(191, 30);
            this.Letters.Name = "Letters";
            this.Letters.ReadOnly = true;
            this.Letters.Size = new System.Drawing.Size(149, 411);
            this.Letters.TabIndex = 9;
            this.Letters.Text = "";
            this.Letters.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 457);
            this.Controls.Add(this.Letters);
            this.Controls.Add(this.MostUsedWords);
            this.Controls.Add(this.LongestWords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UniqueWordCount);
            this.Controls.Add(this.WordCount);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Результаты анализа текста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WordCount;
        private System.Windows.Forms.TextBox UniqueWordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox LongestWords;
        private System.Windows.Forms.RichTextBox MostUsedWords;
        private System.Windows.Forms.RichTextBox Letters;
    }
}