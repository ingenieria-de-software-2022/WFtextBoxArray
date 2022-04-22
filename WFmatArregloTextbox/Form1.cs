using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFmatArregloTextbox
{
    public partial class Form1 : Form
    {
        int m, n;
        TextBox[,] textBoxMatrix;
        double[,] elem;

        public Form1()
        {
            InitializeComponent();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    elem[i, j] = double.Parse(textBoxMatrix[i, j].Text);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string aux;

            for (int i = 0; i < m; i++)
            {
                aux = " ";
                for (int j = 0; j < n; j++)
                {
                    aux += elem[i, j] + " \t";
                }

                listBoxMatrix.Items.Add(aux);
            }
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            m = int.Parse(textBoxM.Text);
            n = int.Parse(textBoxN.Text);
            elem = new double[m, n];
            textBoxMatrix = new TextBox[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    textBoxMatrix[i, j] = new TextBox();
                    textBoxMatrix[i, j].Width = 30;
                    textBoxMatrix[i, j].Height = 20;
                    textBoxMatrix[i, j].Location = new Point(j * 30, i * 20);
                    panel1.Controls.Add(textBoxMatrix[i, j]);
                }
            }
        }
    }
}
