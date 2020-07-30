using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace EntityFramework
{
    public partial class LoadPriceForm : Form
    {
        public LoadPriceForm()
        {
            InitializeComponent();
        }

        List<string> listFiles = new List<string>();

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }
        string connectionString = GetConnectionStringByName("AutoShopConnectionString");

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listFiles.Remove(listView.SelectedItems[0].Text);
                listView.Items.Remove(listView.SelectedItems[0]);


            }
        }

        private void btnBrowsOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excel Workbook|*.xlsx|XLS files| *.xls";
            od.Multiselect = true;
            if (od.ShowDialog() == DialogResult.OK)
            {

                foreach (string fileName in od.FileNames)
                {

                    if (!listFiles.Contains(fileName))
                    {

                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(fileName));
                        FileInfo fi = new FileInfo(fileName);
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, fi.FullName, imageList.Images.Count - 1);

                    }
                }
            }
        }
        DataTableCollection tableCollection;

        private void loadPriceButton_Click(object sender, EventArgs e)
        {
            foreach (string fileName in listFiles)
            {
                string pathF = fileName;
                using (var stream = File.Open(pathF, FileMode.Open, FileAccess.Read))
                {
                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }

                        });
                        tableCollection = result.Tables;
                        foreach (DataTable dt in tableCollection)
                        {
                            int erNum = 0;
                            string erList = "";

                            if (dt != null)
                            {


                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++)
                                    {

                                        SqlCommand cmd = new SqlCommand();
                                        //cmd.Connection = connection;
                                        cmd.Connection = connection;
                                        cmd.CommandText = "INSERT INTO Products (Vendor, Brand, PartNumber, ProductName, Price, QuantityInStock) VALUES (@Vendor, @Brand, @PartNumber, @ProductName, @Price, @QuantityInStock)";
                                        cmd.Parameters.AddWithValue("@vendor", dt.Rows[i]["Поставщик"].ToString());
                                        cmd.Parameters.AddWithValue("@Brand", dt.Rows[i]["Бренд"].ToString());
                                        cmd.Parameters.AddWithValue("@PartNumber", dt.Rows[i]["Артикул"].ToString());
                                        cmd.Parameters.AddWithValue("@ProductName", dt.Rows[i]["Наименование"].ToString());
                                        cmd.Parameters.AddWithValue("@Price", dt.Rows[i]["Цена"]);
                                        cmd.Parameters.AddWithValue("@QuantityInStock", dt.Rows[i]["Количество"]);

                                        try
                                        {
                                            
                                            if (connection.State == ConnectionState.Closed)
                                            {
                                                MessageBox.Show("Подключаемся к базе");
                                                connection.Open();

                                            }


                                            cmd.ExecuteNonQuery();
                                        }
                                        catch
                                        {
                                            erNum++;
                                            erList += "-" + Convert.ToString(i) + " ";
                                        }



                                    }
                                }

                            }
                            if (erNum != 0)
                                MessageBox.Show("В файле: " + pathF + ".\r\n" + "Всего ошибок..." + erNum + ".\r\n" + "Незагруженные строки ..." + erList);


                        }

                    }
                    MessageBox.Show(pathF + " загружен.");


                }
            }
        }
    }
}
