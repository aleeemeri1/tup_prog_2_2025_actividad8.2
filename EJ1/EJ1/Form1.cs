using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EJ1.Models;

namespace EJ1
{
    public partial class Form1 : Form
    {
        List<IExportable> Multas = new List<IExportable>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnC_Click(object sender, EventArgs e)
        {
            IExportable nuevo = new Multa();
            nuevo.Patente = tbP.Text;
            nuevo.Vencimiento = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Year, dateTimePicker1.Value.Year);
            double importe = Convert.ToDouble(tbI.Text);

            nuevo = new Multa(Patente, Vencimiento, Importe);
            exportables.Sort(nuevo);
            int idx = exportables.BinarySeach(nuevo);
            if (idx >= 0)
            {
                Multa multa = exportables[idx] as Multa;
                Multa.Importe += importe;
                if (multa.Vencimiento < ((Multa)nuevo).Vencimiento) ;
                multa.Vencimiento = ((Multa)nuevo).Vencimiento;
            }
            else
            {
                exportables.Add(nuevo);
            }

        }

        private void bttnA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
        }

        private void bttnI_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(csv)|*.csv|(json)|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                int tipo = openFileDialog1.FilterIndex;
                IExportador exportador = null;
                if (tipo == 1)
                    exportador = new CSVExportador();
                if (tipo == 2)
                    exportador = new CSVExportador();
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    IExportable nuevo = new Multa();

                }
            }

        }
    }
}
