using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cMiembro nmm = new cMiembro();
            DataSet dset = new DataSet();
            dset = nmm.consultar();
            this.dataGridView1.DataSource = dset.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar();
            this.Hide();
            agregar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aclase aClase = new aclase();
            this.Hide();
            aClase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            acancha aCancha = new acancha();
            this.Hide();
            aCancha.Show();
        }
    }
}
