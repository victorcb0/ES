using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;


        string serialDataIn;
        sbyte indexOfT;
        sbyte indexOfH;
        sbyte indexOfI;
        sbyte indexOfTT;
        sbyte indexOfHH;
        sbyte indexOfII;
        string dataSensor1;
        string dataSensor2;
        string dataSensor3;
        string dataSensor11;
        string dataSensor22;
        string dataSensor33;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            ProgressBar_statusCom.Value = 0;
            comboBox_BaudRate.Text = "115200";

            timer1.Enabled = true;
            timer1.Start();
        }

        private void comboBox_ComPort_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_ComPort.Items.Clear();
            comboBox_ComPort.Items.AddRange(portLists);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try 
            {
                serialPort1.PortName = comboBox_ComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                ProgressBar_statusCom.Value = 100;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                button_open.Enabled = true;
                button_close.Enabled = false;
                ProgressBar_statusCom.Value = 0;
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadLine();
            this.BeginInvoke(new EventHandler(ProcessData));
        }

        private void ProcessData(object sender, EventArgs e)
        {


           indexOfT = Convert.ToSByte(serialDataIn.IndexOf("T"));
           indexOfH = Convert.ToSByte(serialDataIn.IndexOf("H"));
           indexOfI = Convert.ToSByte(serialDataIn.IndexOf("I"));
           indexOfTT = Convert.ToSByte(serialDataIn.IndexOf("TT"));
           indexOfHH = Convert.ToSByte(serialDataIn.IndexOf("HH"));
           indexOfII = Convert.ToSByte(serialDataIn.IndexOf("II"));




           dataSensor1 = serialDataIn.Substring(0, indexOfT);
           dataSensor2 = serialDataIn.Substring(indexOfT + 1, (indexOfH - indexOfT) - 1);
           dataSensor3 = serialDataIn.Substring(indexOfH + 1, (indexOfI - indexOfH) - 1);

           dataSensor11 = serialDataIn.Substring(indexOfI + 1, (indexOfTT - indexOfI) - 1);
           dataSensor22 = serialDataIn.Substring(indexOfTT + 2, (indexOfHH - indexOfTT) - 2);
           dataSensor33 = serialDataIn.Substring(indexOfHH + 2, (indexOfII - indexOfHH) - 2);




              textBox_sensor1.Text = dataSensor1;// + "°C";
              textBox_sensor2.Text = dataSensor2;// + "%";
              textBox_sensor3.Text = dataSensor3;// + "°C";
            textBox_sensor11.Text = dataSensor11;// + "°C";
            textBox_sensor22.Text = dataSensor22;// + "%";
            textBox_sensor33.Text = dataSensor33;// + "°C";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B5L5MQ1\SQLEXPRESS;Initial Catalog=Testdb;Integrated Security=True");
                string text = textBox_sensor1.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    string InsrtQuey = "Insert Into Temperatura(Temperatura_INTERIOR_C,Umiditate_INTERIOR,Indexul_de_Caldura_INTERIOR_C,Temperatura_EXTERIOR_C,Umiditate_EXTERIOR,Indexul_de_Caldura_EXTERIOR_C)Values('" + textBox_sensor1.Text + "','" + textBox_sensor2.Text + "','" + textBox_sensor3.Text + "','" + textBox_sensor11.Text + "','" + textBox_sensor22.Text + "','" + textBox_sensor33.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(InsrtQuey, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_sensor1.Text = String.Empty;
            textBox_sensor2.Text = String.Empty;
            textBox_sensor3.Text = String.Empty;
            textBox_sensor11.Text = String.Empty;
            textBox_sensor22.Text = String.Empty;
            textBox_sensor33.Text = String.Empty;
        }

        private void Tabel_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Tabel1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
