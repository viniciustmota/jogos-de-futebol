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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Brasil_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Coral;
            Russia.Font = new Font(Russia.Font, Russia.Font.Style | FontStyle.Strikeout);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = Color.Aqua;
            Panama.Font = new Font(Panama.Font, Panama.Font.Style | FontStyle.Strikeout);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
            Irã.Font = new Font(Irã.Font, Irã.Font.Style | FontStyle.Strikeout);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Yellow;
            Alemanhã.Font = new Font(Alemanhã.Font, Alemanhã.Font.Style | FontStyle.Strikeout);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Green;
            Uruguai.Font = new Font(Uruguai.Font, Uruguai.Font.Style | FontStyle.Strikeout);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.Pink;
            Suecia.Font = new Font(Suecia.Font, Suecia.Font.Style | FontStyle.Strikeout);
        }

        private void Russia_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Brown;
            Brasil.Font = new Font(Brasil.Font, Brasil.Font.Style | FontStyle.Strikeout);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGray;
            label2.BackColor = Color.LightGray;
            label3.BackColor = Color.LightGray;
            label4.BackColor = Color.LightGray;
            label5.BackColor = Color.LightGray;
            label6.BackColor = Color.LightGray;
            label7.BackColor = Color.LightGray;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
