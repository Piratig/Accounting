using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_cartridges
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        Request request = new Request();
        string inventary;
        string cartridge;
        string status;
        int quantity;
        int i = 0;
        int indexRow = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        void ResizeArray()
        {
            dgwInventaryCheck.Rows.Clear();
            if (label7.Visible)
                label7.Visible = false;

            if (!string.IsNullOrEmpty(txbDepartment.Text) && !string.IsNullOrWhiteSpace(txbDepartment.Text) &&
                !string.IsNullOrEmpty(txbRequest.Text) && !string.IsNullOrWhiteSpace(txbRequest.Text) &&
                !string.IsNullOrEmpty(txbCartridge.Text) && !string.IsNullOrWhiteSpace(txbCartridge.Text) &&
                !string.IsNullOrEmpty(txbQuantity.Text) && !string.IsNullOrWhiteSpace(txbQuantity.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Cartridges] (RequestId, InventaryNumber, Department, Cartridge, Quantity, DeliveryDate, Status)VALUES(@RequestId, @InventaryNumber, @Department, @Cartridge, @Quantity, @DeliveryDate, @Status)", sqlConnection);
                command.Parameters.AddWithValue("RequestId", txbRequest.Text);
                command.Parameters.AddWithValue("InventaryNumber", inventary);
                command.Parameters.AddWithValue("Department", txbDepartment.Text);
                command.Parameters.AddWithValue("Cartridge", cartridge);
                command.Parameters.AddWithValue("Quantity", quantity);
                command.Parameters.AddWithValue("DeliveryDate", dtpInPut.Value);
                command.Parameters.AddWithValue("Status", status);
                command.ExecuteNonQueryAsync();
            }
            else
            {
                label7.Visible = true;
                label7.Text = "Не все поля заполнены!";
            }
        }

        void Aggregate(string stat)
        {
                inventary = txbInventoryNumber.Text;
                cartridge = txbCartridge.Text;
                status = stat;
                while (quantity == 0)
                {
                    int.TryParse(txbQuantity.Text, out quantity);
                    if (quantity == 0)
                        txbQuantity.Text = "Введите колличество!";
                }
            for (int j = 0; j <= i; j++)
            {
                dgwInventaryCheck.Rows.Add(inventary, cartridge, quantity, status);
            }
            i++;
        } 

        private void dgvChage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvChage.Rows[index];
            txbCartridgeChange.Text = selectedRow.Cells[3].Value.ToString();
            txbRequestIdChange.Text = selectedRow.Cells[1].Value.ToString();
            indexRow = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
        }       

        private void StatusChange(string status)
        {
            //string str = String.Format("UPDATE [Cartridges] SET [Status] = @Status, WHERE [Id] = @Id", status, indexRow);
            SqlCommand command = new SqlCommand("UPDATE [Cartridges] SET [Status] = @Status WHERE [Id] = @Id", sqlConnection);
            command.Parameters.AddWithValue("Status", status);
            command.Parameters.AddWithValue("Id", indexRow);
            command.ExecuteNonQuery();
        }

        private void dgvDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        //Buttons
        #region buttons

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ResizeArray();
            Aggregate("Выдано");
        }

        private void btnReserv_Click_1(object sender, EventArgs e)
        {
            ResizeArray();
            Aggregate("Зарезервировано");
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            ResizeArray();
            Aggregate("Заказано");
        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            ResizeArray();
            Aggregate("Ожидание закупки");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvDelete.Rows[indexRow];
            //string str = String.Format("DELETE FROM [Cartridges] WHERE [Id] = N'{0}'", indexRow);
            SqlCommand command = new SqlCommand(/*str*/"DELETE FROM [Cartridges] WHERE [Id] = @ID", sqlConnection);
            command.Parameters.AddWithValue("Id", indexRow);
            command.ExecuteNonQueryAsync();
        }

        private void btnAddChange_Click(object sender, EventArgs e)
        {
            StatusChange("Выдано");
        }

        private async void btnSearchDelete_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;

            string str = String.Format("SELECT [InventaryNumber], [Cartridge], [RequestId], [Status] FROM [Cartridges] WHERE [RequestId] = N'{0}'", txbReqestIDDelete.Text);
            SqlCommand command = new SqlCommand(str, sqlConnection);


            dgvDelete.Rows.Clear();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string[] data = new string[4];
                    data[0] = sqlReader[2].ToString();
                    data[1] = sqlReader[0].ToString();
                    data[2] = sqlReader[1].ToString();
                    data[3] = sqlReader[3].ToString();

                    dgvDelete.Rows.Add(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private async void btnSerchChange_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;

            string str = String.Format("SELECT [InventaryNumber], [Cartridge], [RequestId], [Status], [Quantity], [Id] FROM [Cartridges] WHERE [RequestId] = N'{0}'", txbRequestIdChange.Text);
            SqlCommand command = new SqlCommand(str, sqlConnection);

            dgvChage.Rows.Clear();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string[] data = new string[6];
                    data[1] = sqlReader[2].ToString();
                    data[2] = sqlReader[0].ToString();
                    data[3] = sqlReader[1].ToString();
                    data[4] = sqlReader[4].ToString();
                    data[5] = sqlReader[3].ToString();
                    data[0] = sqlReader[5].ToString();
                    dgvChage.Rows.Add(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void tsbReport_Click(object sender, EventArgs e)
        {
            request.ShowDialog();
        }

        private async void txbCheck_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;

            string str = String.Format("SELECT InventaryNumber, Cartridge, DeliveryDate FROM [Cartridges] WHERE InventaryNumber = N'{0}' AND DeliveryDate = (SELECT MAX(DeliveryDate) FROM [Cartridges])", txbInventoryNumber.Text);
            SqlCommand command = new SqlCommand(str, sqlConnection);
            rtbCartridge.Clear();
            rtbCartridge.Text = "Инвентарный номер | Картридж | Дата выдачи\n";

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string date = Convert.ToString(sqlReader["DeliveryDate"]);
                    rtbCartridge.Text += Convert.ToString(sqlReader["InventaryNumber"]) + " | " + Convert.ToString(sqlReader["Cartridge"]) + " | " + date.Substring(0, 10) + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

            dgwInventaryCheck.Visible = true;
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }

        private void tsbAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accounting cartridges v.1.0\nСоздал: Харьковский Игорь Сергеевичь.\nПо всем вопросам обращяться по почте kharkovskiy-is@mosmetro.ru или his1994@mail.ru", e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnReservChange_Click(object sender, EventArgs e)
        {
            StatusChange("Зарезервировано");
        }

        private void btnOrderChange_Click(object sender, EventArgs e)
        {
            StatusChange("Заказано");
        }

        private void btnBuyChange_Click(object sender, EventArgs e)
        {
            StatusChange("Ожидание закупки");
        }

        #endregion

    }
}

