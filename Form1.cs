using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace WindowsFormsApp1
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
        public void Graficar2(int i)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(i.ToString(), i);
            int s = 0;
            foreach (KeyValuePair<string, int> d in dic)
            {
                chart2.Series["DATOS"].Points.AddXY(s, d.Value);
                chart2.Refresh();
                s++;
                
            }
        }
        public void Graficar(int c) 
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(c.ToString(), c);
            int s = 0;
            foreach (KeyValuePair<string, int> d in dic)
            {
                chart1.Series["DATOS"].Points.AddXY(s, d.Value);
                chart1.Refresh();
                s++;
                Thread.Sleep(8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLimite.Text != "")
            {
                chart1.Series["DATOS"].Points.Clear();
                chart2.Series["DATOS"].Points.Clear();
                int[] array = new int[Convert.ToInt32(txtLimite.Text)];
                Random random = new Random();
                int x = 0;
                int[] b;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(0, 1000);
                }
                for (int i = 0; i < array.Length; i++)
                {
                    x = array[i];
                    Graficar2(x);
                }
                listBox1.Items.Clear();
                if (radioButton1.Checked)
                {
                    listBox1.Items.Clear();
                    QuickSort a = new QuickSort();
                    b = a.Quick_Sort(array);

                    foreach (int c in b)
                    {
                        listBox1.Items.Add(c);
                        Graficar(c);
                    }

                }
                else if (radioButton2.Checked)
                {
                    listBox1.Items.Clear();
                    BubbleSort a = new BubbleSort();
                    b = a.Bubble_sort(array);

                    foreach (int c in b)
                    {
                        listBox1.Items.Add(c);
                        Graficar(c);
                    }
                }
                else if (radioButton3.Checked)
                {
                    listBox1.Items.Clear();
                    MergeSort a = new MergeSort();
                    b = a.mergeSort(array);

                    foreach (int c in b)
                    {
                        listBox1.Items.Add(c);
                        Graficar(c);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un metodo de ordenamiento");
                }
            }
            else 
            {
                MessageBox.Show("Ingrese un Valor Límite");
            }
        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
