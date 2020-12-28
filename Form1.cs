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
    }
}

