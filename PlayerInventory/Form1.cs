using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PlayerInventory
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["PlayerInventory.Properties.Settings.PlayerInventoryConnectionString"].ConnectionString;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            PopulateInventory();
            PopulateAllItems();
        }

        private void PopulateInventory()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inventory", connection))
            {
                DataTable inventoryTable = new DataTable();
                adapter.Fill(inventoryTable);

                lstInventory.DisplayMember = "Name";
                lstInventory.ValueMember = "Id";
                lstInventory.DataSource = inventoryTable;
            }
        }

        private void PopulateAllItems()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Items", connection))
            {
                DataTable itemTable = new DataTable();
                adapter.Fill(itemTable);

                lstItems.DisplayMember = "Name";
                lstItems.ValueMember = "Id";
                lstItems.DataSource = itemTable;
            }
        }

        private void PopulateInventoryItems()
        {
            string query = "SELECT a.Name FROM Items a " +
                "INNER JOIN InventoryItems b ON a.Id = b.ItemId " +
                "WHERE b.InventoryId = @InventoryId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter myAdapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@InventoryId", lstInventory.SelectedValue);

                DataTable itemTable = new DataTable();
                myAdapter.Fill(itemTable);

                lstInventoryItems.DisplayMember = "Name";
                lstInventoryItems.ValueMember = "Id";
                lstInventoryItems.DataSource = itemTable;
            }
        }

        private void PopulateInventoryItemQuantities()
        {
            string query = "SELECT a.Quantity FROM InventoryItems a " +
            "WHERE a.InventoryId = @InventoryId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter myAdapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@InventoryId", lstInventory.SelectedValue);

                DataTable itemTable = new DataTable();
                myAdapter.Fill(itemTable);

                lstQuantities.DisplayMember = "Quantity";
                lstQuantities.ValueMember = "Id";
                lstQuantities.DataSource = itemTable;
            }
        }

        private void lstInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //called when inventory item is selected
            PopulateInventoryItems();
            PopulateInventoryItemQuantities();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //called when add item button is clicked
            //should add input quantity of selected item into player inventory
            string query = "INSERT INTO InventoryItems VALUES (@InventoryId, @ItemId, @ItemQuantity)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@InventoryId", lstInventory.SelectedValue);
                command.Parameters.AddWithValue("@ItemId", lstItems.SelectedValue);

                int distance;
                if (int.TryParse(txtQuantity.Text, out distance))
                {
                    // it's a valid integer
                    command.Parameters.AddWithValue("@ItemQuantity", txtQuantity.Text);
                }
                else
                {
                    // it's not a valid integer, so pass in 1
                    command.Parameters.AddWithValue("@ItemQuantity", "1");
                }

                command.ExecuteScalar();
            }

            PopulateInventoryItems();
            PopulateInventoryItemQuantities();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE InventoryItems SET Quantity = @ItemQuantity WHERE ItemId = @ItemId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@ItemQuantity", txtQuantity.Text);
                command.Parameters.AddWithValue("@ItemId", lstItems.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateInventoryItemQuantities();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //called when remove item button is clicked
            //should remove selected item from player inventory and clear any quantity values


            string myQuery = "DELETE FROM InventoryItems WHERE InventoryId = @InventoryId AND ItemId = @ItemId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(myQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@InventoryId", lstInventory.SelectedValue);
                command.Parameters.AddWithValue("@ItemId", lstItems.SelectedValue);

                command.ExecuteScalar();
            }

            PopulateInventoryItems();
            PopulateInventoryItemQuantities();
        }
    }
}
