using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogos_de_futebol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "C")
            {
                textBox2.Focus();
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "O")
            {
                textBox3.Focus();
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "R")
            {
                textBox4.Focus();
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "I")
            {
                textBox5.Focus();
            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "N")
            {
                textBox6.Focus();
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "T")
            {
                textBox7.Focus();
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "H")
            {
                textBox8.Focus();
            }
            else
            {
                textBox7.Text = "";
            }
        }


        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "N")
            {
                textBox11.Focus();
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox8.Text=="I")
            {
                textBox9.Focus();
            }
            else
            {
                textBox8.Text="";
            }

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox9.Text=="A")
            {
                textBox10.Focus();
            }
            else
            {
                textBox9.Text="";
            }

        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "R")
            {
                textBox20.Focus();
            }
            else
            {
                textBox19.Text = "";
            }
        }

        private void TextBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "P")
            {
                textBox23.Focus();
            }
            else
            {
                textBox22.Text = "";
            }
        }

        private void TextBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "D")
            {
                textBox22.Focus();
            }
            else
            {
                textBox21.Text = "";
            }
        }

        private void TextBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "I")
            {
                textBox21.Focus();
            }
            else
            {
                textBox20.Text = "";
            }
        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "D")
            {
                textBox19.Focus();
            }
            else
            {
                textBox18.Text = "";
            }
        }

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == "A")
            {
                textBox18.Focus();
            }
            else
            {
                textBox10.Text = "";
            }
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "M")
            {
                textBox17.Focus();
            }
            else
            {
                textBox16.Text = "";
            }
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "L")
            {
                textBox16.Focus();
            }
            else
            {
                textBox14.Text = "";
            }
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "A")
            {
                textBox14.Focus();
            }
            else
            {
                textBox13.Text = "";
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "E")
            {
                textBox13.Focus();
            }
            else
            {
                textBox12.Text = "";
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void TextBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text == "D")
            {
                textBox28.Focus();
            }
            else
            {
                textBox27.Text = "";
            }
        }

        private void TextBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "N")
            {
                textBox27.Focus();
            }
            else
            {
                textBox26.Text = "";
            }
        }

        private void TextBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text == "A")
            {
                textBox26.Focus();
            }
            else
            {
                textBox25.Text = "";
            }
        }

        private void TextBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "S")
            {
                textBox25.Focus();
            }
            else
            {
                textBox24.Text = "";
            }
        }

        private void TextBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "Y")
            {
                textBox24.Focus();
            }
            else
            {
                textBox23.Text = "";
            }
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "S")
            {
                textBox12.Focus();
            }
            else
            {
                textBox11.Text = "";
            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text == "U")
            {
                textBox29.Focus();
            }
            else
            {
                textBox28.Text = "";
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text == "B")
            {
                textBox30.Focus();
            }
            else
            {
                textBox29.Text = "";
            }
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text == "Y")
            {
                textBox31.Focus();
            }
            else
            {
                textBox30.Text = "";
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text == "E")
            {
                textBox32.Focus();
            }
            else
            {
                textBox31.Text = "";
            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text == "R")
            {
                textBox33.Focus();
            }
            else
            {
                textBox32.Text = "";
            }
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text == "N")
            {
                textBox35.Focus();
            }
            else
            {
                textBox33.Text = "";
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text == "D")
            {
                textBox36.Focus();
            }
            else
            {
                textBox35.Text = "";
            }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text == "E")
            {
                textBox38.Focus();
            }
            else
            {
                textBox36.Text = "";
            }
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text == "M")
            {
                textBox39.Focus();
            }
            else
            {
                textBox38.Text = "";
            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (textBox39.Text == "U")
            {
                textBox40.Focus();
            }
            else
            {
                textBox39.Text = "";
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (textBox40.Text == "N")
            {
                textBox41.Focus();
            }
            else
            {
                textBox40.Text = "";
            }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (textBox41.Text == "I")
            {
                textBox42.Focus();
            }
            else
            {
                textBox41.Text = "";
            }
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (textBox42.Text == "Q")
            {
                textBox43.Focus();
            }
            else
            {
                textBox42.Text = "";
            }
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (textBox43.Text == "U")
            {
                textBox44.Focus();
            }
            else
            {
                textBox43.Text = "";
            }
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (textBox44.Text == "E")
            {
                textBox45.Focus();
            }
            else
            {
                textBox44.Text = "";
            }
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (textBox45.Text == "A")
            {
                textBox46.Focus();
            }
            else
            {
                textBox45.Text = "";
            }
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (textBox46.Text == "N")
            {
                textBox47.Focus();
            }
            else
            {
                textBox46.Text = "";
            }
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            if (textBox47.Text == "T")
            {
                textBox48.Focus();
            }
            else
            {
                textBox47.Text = "";
            }
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            if (textBox48.Text == "O")
            {
                textBox49.Focus();
            }
            else
            {
                textBox48.Text = "";
            }
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            if (textBox49.Text == "S")
            {
                DialogResult mensagem = MessageBox.Show("Deseja jogar o proximo jogo?", "Proximo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (mensagem == System.Windows.Forms.DialogResult.Yes)
                {
                    Form3 form3 = new Form3();
                    this.Hide();
                    form3.ShowDialog();
                }
                if (mensagem == System.Windows.Forms.DialogResult.No)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                }
            }
            else
            {
                textBox49.Text = "";
            }
        }
    }
}
