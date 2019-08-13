using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Rodrigo");
            nomes.Add("Luana");
            nomes.Add("Laura");
            nomes.Add("lorena");

            foreach(string item in nomes)
            {
                lista.Items.Add(item);
            }

            MessageBox.Show(nomes.Count.ToString());
        }
    }
}
