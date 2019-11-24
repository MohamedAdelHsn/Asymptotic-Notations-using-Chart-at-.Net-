using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestComplexity_OfAlgorithm
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private int[] arr = new int[] { 25000, 50000, 75000, 100000, 250000, 500000, 1000000 };
             

        private double test_complexity(int size)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            st.Stop();

            return Convert.ToDouble(st.ElapsedMilliseconds);

        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series.Clear();
            chart1.Series.Add(new Series("Time complexity of loop : O(n)"));
            chart1.Series[0].Points.AddXY(arr[0], test_complexity(arr[0]));
            chart1.Series[0].Points.AddXY(arr[1], test_complexity(arr[1]));
            chart1.Series[0].Points.AddXY(arr[2], test_complexity(arr[2]));
            chart1.Series[0].Points.AddXY(arr[3], test_complexity(arr[3]));
            chart1.Series[0].Points.AddXY(arr[4], test_complexity(arr[4]));
            chart1.Series[0].Points.AddXY(arr[5], test_complexity(arr[5]));
            chart1.Series[0].Points.AddXY(arr[6], test_complexity(arr[6]));


            chart1.Series[0].Color = Color.Black;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].ChartType = SeriesChartType.Line;

            

        }

 
        

        }
    }


