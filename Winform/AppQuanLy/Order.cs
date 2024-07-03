using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderManagementApp
{
	public partial class MainForm : Form
	{
		private MySqlConnection connection;

		public MainForm()
		{
			InitializeComponent();
			string connectionString = "server=localhost;user id=ADMIN;password=123;database=QLBANHANGDIENLANH;";
			connection = new MySqlConnection(connectionString);
		}

		private void loadOrdersButton_Click(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				string query = "SELECT * FROM orders";
				MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
				DataTable table = new DataTable();
				adapter.Fill(table);
				ordersDataGridView.DataSource = table;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
	}
}
