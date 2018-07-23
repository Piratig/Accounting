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
using Excel = Microsoft.Office.Interop.Excel;


namespace Accounting_cartridges
{
    public partial class Request : Form
    {
        SqlConnection sqlConnection;

        public Request()
        {
            InitializeComponent();
        }

        private async void Request_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }

        private async void btnCreateReport_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;
            string str = String.Format("SELECT [Department], [Cartridge], COUNT(*) FROM [Cartridges] WHERE [Department] = N'{0}' AND [DeliveryDate] BETWEEN @DateSins AND @DateTill GROUP BY [Cartridge], [Department]", txbDepartment.Text);
            SqlCommand command = new SqlCommand(str, sqlConnection);
            command.Parameters.AddWithValue("Department", txbDepartment.Text);
            command.Parameters.AddWithValue("DateSins", dtpSins.Value);
            command.Parameters.AddWithValue("DateTill", dtpTill.Value);
            command.ExecuteNonQuery();

            dgwDepartmens.Rows.Clear();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string[] data = new string[4];
                    data[0] = sqlReader[0].ToString();
                    data[1] = sqlReader[1].ToString();
                    data[2] = sqlReader[2].ToString();

                    dgwDepartmens.Rows.Add(data);
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

        private void Request_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }

        private async void btnCartridgeReport_Click(object sender, EventArgs e)
        {
            dgwCartridgeReport.Rows.Clear(); 
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT [Department], [Cartridge], COUNT(*) FROM [Cartridges] WHERE [Cartridge] = @Cartridge AND [DeliveryDate] BETWEEN @DateSins AND @DateTill GROUP BY [Department], [Cartridge], [DeliveryDate]", sqlConnection);
            command.Parameters.AddWithValue("Cartridge", txbCartridgeReport.Text);
            command.Parameters.AddWithValue("DateSins", dtpSinsCartridgeReport.Value);
            command.Parameters.AddWithValue("DateTill", dtpTillCartridgeReport.Value);
            command.ExecuteNonQuery();

            dgwDepartmens.Rows.Clear();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    string[] data = new string[3];
                    data[0] = sqlReader[1].ToString();
                    data[1] = sqlReader[2].ToString();
                    data[2] = sqlReader[0].ToString();

                    dgwCartridgeReport.Rows.Add(data);
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

        private void btnExportDepartment_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, 1] = "Служба";
            workSheet.Cells[1, 2] = "Картридж";
            workSheet.Cells[1, 3] = "Количество";
            workSheet.Cells[1, 4] = "Дата";
            int rowExcel = 2;
            for (int i = 0; i < dgwDepartmens.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, 1] = Convert.ToString(dgwDepartmens.Rows[i].Cells[0].Value);
                workSheet.Cells[rowExcel, 2] = Convert.ToString(dgwDepartmens.Rows[i].Cells[1].Value);
                workSheet.Cells[rowExcel, 3] = Convert.ToString(dgwDepartmens.Rows[i].Cells[2].Value);
                workSheet.Cells[rowExcel, 4] = Convert.ToString(dgwDepartmens.Rows[i].Cells[3].Value);
                rowExcel++;
            }
            workSheet.Cells[rowExcel, 1] = "Отчет сотавлен в программе Accounting cartridges. В случае не правильного вывода данных обратитесь к автору программы по электронной почте: kharkovskiy-is@mosmetro.ru или his1994@mail.ru.";
            string str = Convert.ToString(DateTime.Now.Day + "_" + DateTime.Now.Month);
            string pathToXmlFile = Environment.CurrentDirectory + "\\" + "ACDepartmentReport_" + str + ".xlsx";
            workSheet.SaveAs(pathToXmlFile);
            exApp.Quit();
        }

        private void tsbAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accounting cartridges v.1.0\nСоздал: Харьковский Игорь Сергеевичь.\nПо всем вопросам обращяться по почте kharkovskiy-is@mosmetro.ru или his1994@mail.ru", e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnExportCartridgRaport_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)exApp.ActiveSheet;
            workSheet.Cells[1, 1] = "Картридж";
            workSheet.Cells[1, 2] = "Количество";
            workSheet.Cells[1, 3] = "Служба";
            workSheet.Cells[1, 4] = "Дата";
            int rowExcel = 2;
            for (int i = 0; i < dgwCartridgeReport.Rows.Count; i++)
            {
                workSheet.Cells[rowExcel, 1] = Convert.ToString(dgwCartridgeReport.Rows[i].Cells[0].Value);
                workSheet.Cells[rowExcel, 2] = Convert.ToString(dgwCartridgeReport.Rows[i].Cells[1].Value);
                workSheet.Cells[rowExcel, 3] = Convert.ToString(dgwCartridgeReport.Rows[i].Cells[2].Value);
                workSheet.Cells[rowExcel, 4] = Convert.ToString(dgwCartridgeReport.Rows[i].Cells[3].Value);
                rowExcel++;
            }
            workSheet.Cells[rowExcel, 1] = "Отчет сотавлен в программе Accounting cartridges. В случае не правильного вывода данных обратитесь к автору программы по электронной почте: kharkovskiy-is@mosmetro.ru или his1994@mail.ru.";
            string str = Convert.ToString(DateTime.Now.Day + "_" + DateTime.Now.Month);
            string pathToXmlFile = Environment.CurrentDirectory + "\\" + "ACCartridgesReport_" + str + ".xlsx";
            workSheet.SaveAs(pathToXmlFile);
            exApp.Quit();
        }

        private async void tsbFullMoutheReport_Click(object sender, EventArgs e)
        {

            SqlDataReader sqlReader = null;

            string str = String.Format("SELECT [Department], [Cartridge], COUNT(*), [Status] FROM [Cartridges] GROUP BY [Department], [Cartridge], [Status]", dtpSinsCartridgeReport.Value, dtpTillCartridgeReport.Value);

            SqlCommand command = new SqlCommand(str, sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                Excel.Application exApp = new Excel.Application();
                exApp.Workbooks.Add();
                Excel.Worksheet workSheet = (Excel.Worksheet)exApp.ActiveSheet;
                workSheet.Cells[1, 1] = "Картридж";
                workSheet.Cells[1, 2] = "Количество";
                workSheet.Cells[1, 3] = "Служба";
                workSheet.Cells[1, 4] = "Статус";

                int rowExcel = 2;
                while (await sqlReader.ReadAsync())
                {
                    for (int i = 0; i < dgwCartridgeReport.Rows.Count; i++)
                    {
                        workSheet.Cells[rowExcel, 1] = sqlReader[1].ToString();
                        workSheet.Cells[rowExcel, 2] = sqlReader[2].ToString();
                        workSheet.Cells[rowExcel, 3] = sqlReader[0].ToString();
                        workSheet.Cells[rowExcel, 4] = sqlReader[3].ToString();
                        rowExcel++;
                    } 
                }
                workSheet.Cells[rowExcel + 1, 1] = "Отчет сотавлен в программе Accounting cartridges. В случае не правильного вывода данных обратитесь к автору программы по электронной почте: kharkovskiy-is@mosmetro.ru или his1994@mail.ru.";
                string stringName = Convert.ToString(DateTime.Now.Day + "_" + DateTime.Now.Month);
                string pathToXmlFile = Environment.CurrentDirectory + "\\" + "FullRequest_" + stringName + ".xlsx";
                workSheet.SaveAs(pathToXmlFile);
                exApp.Quit();
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
    }
}
