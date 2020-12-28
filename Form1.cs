using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Kr_DB
{
    public partial class Form1 : Form
    {
        //SqlConnection sqlConnection = null;
        SqlConnection compConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwndDataSet.EmployeeTerritories". При необходимости она может быть перемещена или удалена.
            this.employeeTerritoriesTableAdapter.Fill(this.northwndDataSet.EmployeeTerritories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwndDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.northwndDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwndDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.northwndDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwndDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.northwndDataSet.Employees);
            //sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Personnel"].ConnectionString);
            //sqlConnection.Open();
            compConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Company"].ConnectionString);
            compConnection.Open();
            //if (compConnection.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Подключение установлено!");
            //}
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void employeesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void employeesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        /*void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath from Employees where EmployeeID = @EmployeeID", compConnection);
                cmd.Parameters.AddWithValue("@EmployeeID", int.Parse(textBox11.Text));
                using (SqlDataReader CheckTable = cmd.ExecuteReader())
                {
                    while (CheckTable.Read())
                    {
                        textBox1.Text = CheckTable.GetValue(0).ToString();
                        textBox2.Text = CheckTable.GetValue(1).ToString();
                        textBox3.Text = CheckTable.GetValue(2).ToString();
                        textBox4.Text = CheckTable.GetValue(3).ToString();
                        dateTimePicker1.Value = (DateTime)CheckTable.GetValue(4);
                        dateTimePicker2.Value = (DateTime)CheckTable.GetValue(5);
                        textBox5.Text = CheckTable.GetValue(7).ToString();
                        textBox6.Text = CheckTable.GetValue(6).ToString();
                        textBox7.Text = CheckTable.GetValue(8).ToString();
                        textBox15.Text = CheckTable.GetValue(9).ToString();
                        textBox8.Text = CheckTable.GetValue(10).ToString();
                        textBox9.Text = CheckTable.GetValue(11).ToString();
                        textBox10.Text = CheckTable.GetValue(12).ToString();
                        textBox14.Text = CheckTable.GetValue(14).ToString();
                        textBox13.Text = CheckTable.GetValue(15).ToString();
                        textBox12.Text = CheckTable.GetValue(16).ToString();
                        //pictureBox1.Image = Image.FromFile("Photo");
                    }
                }
                
            }
            else
            {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        dateTimePicker1.Value = DateTime.Today;
                        dateTimePicker2.Value = DateTime.Today;
                        textBox5.Text =  "";
                        textBox6.Text =  "";
                        textBox7.Text =  "";
                        textBox15.Text = "";
                        textBox8.Text =  "";
                        textBox9.Text =  "";
                        textBox10.Text = "";
                        textBox14.Text = "";
                        textBox13.Text = "";
                        textBox12.Text = "";
            }
        }*/
    }
}

