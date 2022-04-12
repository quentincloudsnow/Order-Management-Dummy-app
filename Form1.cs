using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CONSTRUCT COLUMNS
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Firstname";
            dataGridView1.Columns[1].Name = "Lastname";
            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[3].Name = "SKU";
            dataGridView1.Columns[4].Name = "Address";
            dataGridView1.Columns[5].Name = "City";
            dataGridView1.Columns[6].Name = "Zip";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 100000);

            MessageBox.Show("Order ACM" + num + " Submitted");
            addData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox1.Text);
        }

        //CUSTOM TO ADD ROQW DATA
        private void addData(string Firstname, string Lastname, string Quantity, string Address,string City, string Zip, string SKU)
        {
            String[] row = {Firstname, Lastname, Quantity, SKU, Address, City, Zip};
            dataGridView1.Rows.Add(row);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }


}
