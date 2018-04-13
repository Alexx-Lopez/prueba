using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A");
            MessageBox.Show("B");
        }

        private void button4_Click( object sender, EventArgs e )
        {
            MessageBox.Show("C");
            MessageBox.Show("D");
        }
    }
}
