﻿using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kallulater_shond
{
    public partial class form1 : Form
    {

        public form1()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; // Запрет на изменения размера формы
            MaximizeBox = false;

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);

            void aboutItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Разработчик: Sithond\n\nDiscord: Вечно \"Злой VINISHKO ТЯН\"#8161\nVK: vk.com\\sithond", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {}
        public void button1_Click(object sender, EventArgs e)
        {            
            textBox3.Text = Math.math_plas(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_minus(textBox1.Text, textBox2.Text);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_division(textBox1.Text, textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_multiply(textBox1.Text, textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void button5_Click(object sender, EventArgs e)
        {
            //Обработка ошибок :3 А то есть тут злыдни, которые всё ломают 
            try
            {
                //---------- Нахождение степени числа ----------
                // Этот кусок кода не оптимизирован, трубуется доработка. 
                /*string text = "";

                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);

                double answer = Math.Pow(num1, num2);
                text = Convert.ToString(answer);

                textBox3.Text = text;

                label4.Text = "^";
                label4.Visible = true;
                 */
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_percent(textBox1.Text, textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

