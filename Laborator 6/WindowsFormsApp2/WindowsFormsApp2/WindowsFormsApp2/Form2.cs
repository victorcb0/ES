﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testdbDataSet.Temperatura' table. You can move, or remove it, as needed.
            this.temperaturaTableAdapter.Fill(this.testdbDataSet.Temperatura);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chart1.Series[0].XValueMember  = "Temperatura_INTERIOR_C";
            chart2.Series[0].YValueMembers = "Temperatura_INTERIOR_C";

            //chart1.Series[1].XValueMember  = "Umiditate_INTERIOR";
            chart2.Series[1].YValueMembers = "Umiditate_INTERIOR";

            //chart1.Series[2].XValueMember  = "Indexul_de_Caldura_INTERIOR_C";
            chart2.Series[2].YValueMembers = "Indexul_de_Caldura_INTERIOR_C";

            //chart1.Series[0].XValueMember  = "Temperatura_EXTERIOR_C";
            //chart1.Series[0].YValueMembers = "Temperatura_EXTERIOR_C";


            //chart1.Series[1].XValueMember  = "Umiditate_EXTERIOR";
            //chart1.Series[1].YValueMembers = "Umiditate_EXTERIOR";

            //chart1.Series[2].XValueMember  = "Indexul_de_Caldura_EXTERIOR_C";
            //chart1.Series[2].YValueMembers = "Indexul_de_Caldura_EXTERIOR_C";

            chart2.DataSource = testdbDataSet.Temperatura;
            chart2.DataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
