using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Store
{
    class DB
    {
        string connetionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        SqlDataReader mainReader;
        int billNumber;
        string dbSource = Properties.Settings.Default.source;
        string salesMan = "";

        public DB()
        {
            ///Connections : VCENTER\\VIM_SQLEXP
            ///            : DESKTOP-MKVLAC4\\SQLEXPRESS        
            connetionString = "Data Source='" + dbSource + "';  Initial Catalog=store; Integrated Security=true; MultipleActiveResultSets=true;";
            connection = new SqlConnection(connetionString);
            connection.Open();
        }

        public string checkLogin(string user, string pass)
        {
            command = new SqlCommand("SELECT userRole,name from users where userName = '" + user + "' and pass = '" + pass + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string role = reader.GetString(0);
                string name = reader.GetString(1);
                salesMan = name;
                reader.Close();
                command.Dispose();
                return role;
            }
            else
            {
                reader.Close();
                command.Dispose();
                return "none";
            }
        }
        public void autoCompleteItemsName(TextBox box)
        {
            command = new SqlCommand("SELECT name from items", connection);
            reader = command.ExecuteReader();
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                autoText.Add(reader.GetString(0));
            }
            box.AutoCompleteMode = AutoCompleteMode.Suggest;
            box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            box.AutoCompleteCustomSource = autoText;
            reader.Close();
        }
        public void autoCompleteCustomersName(TextBox box)
        {
            command = new SqlCommand("SELECT customerName from saleBills", connection);
            reader = command.ExecuteReader();
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                autoText.Add(reader.GetString(0));
            }
            box.AutoCompleteMode = AutoCompleteMode.Suggest;
            box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            box.AutoCompleteCustomSource = autoText;
            reader.Close();
        }
        public void autoCompleteCompanyName(TextBox box)
        {
            command = new SqlCommand("SELECT incName from bills", connection);
            reader = command.ExecuteReader();
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                autoText.Add(reader.GetString(0));
            }
            box.AutoCompleteMode = AutoCompleteMode.Suggest;
            box.AutoCompleteSource = AutoCompleteSource.CustomSource;
            box.AutoCompleteCustomSource = autoText;
            reader.Close();
            command.Dispose();
        }

        /// Kinds Table
        public void insertKind(string name)
        {
            try
            {
                command = new SqlCommand("insert into kinds values(N'" + name + "')", connection);
                command.ExecuteReader();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("هذا النوع موجود بالفعل");
            }
        }
        public void updateKind(string oldName, string newName)
        {
            try
            {
                command = new SqlCommand("update kinds set name = N'" + newName + "' where name = N'" + oldName + "'", connection);
                command.ExecuteReader();
                reader.Close();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("هذا النوع موجود بالفعل");
            }
        }
        public int getKindId(string name)
        {
            int id = -1;
            command = new SqlCommand("select id from kinds where name = N'" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            command.Dispose();
            reader.Close();
            return id;
        }

        public List<string> getAllKinds()
        {
            string kind;
            List<string> list = new List<string>();
            command = new SqlCommand("select name from kinds", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    kind = reader.GetString(0);
                    list.Add(kind);
                }
            }
            command.Dispose();
            reader.Close();
            return list;
        }

        ///===========================================================================================================

        /// Units Table
        public void insertUnit(string name)
        {
            try
            {
                command = new SqlCommand("insert into units values(N'" + name + "')", connection);
                command.ExecuteReader();
                reader.Close();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("هذا النوع موجود بالفعل");
            }
        }
        public void updateUnit(string oldName, string newName)
        {
            try
            {
                command = new SqlCommand("update units set name = N'" + newName + "' where name = N'" + oldName + "'", connection);
                command.ExecuteReader();
                reader.Close();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("هذا النوع موجود بالفعل");
            }
        }
        public int getUnitId(string name)
        {
            int id = -1;
            command = new SqlCommand("select id from units where name = N'" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            command.Dispose();
            reader.Close();
            return id;
        }
        public string getUnitName(int itemId)
        {
            string name = "";
            command = new SqlCommand("select units.name from units, items where items.id = '" + itemId + "' and items.unit = units.id", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                name = reader.GetString(0);
            }
            command.Dispose();
            reader.Close();
            return name;
        }

        public List<string> getAllUnits()
        {
            string kind;
            List<string> list = new List<string>();
            command = new SqlCommand("select name from units", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    kind = reader.GetString(0);
                    list.Add(kind);
                }
            }
            command.Dispose();
            reader.Close();
            return list;
        }

        ///===========================================================================================================










        ///Items table
        public int updateItemName(string oldName, string newName, TextBox box)
        {
            try
            {
                command = new SqlCommand("select name from items where name = N'" + newName + "'", connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("!لا يمكن إتمام التعديل, هذا الأسم موجود بالفعل");
                    return 2;
                }
                else
                {
                    command = new SqlCommand("update items set name = N'" + newName + "' where name = N'" + oldName + "'", connection);
                    int success = command.ExecuteNonQuery();
                    command.Dispose();
                    if (success != 0)
                    {
                        MessageBox.Show("تم تعديل الأسم بنجاح");
                        autoCompleteItemsName(box);
                        return 1;
                    }
                    else
                    {
                        MessageBox.Show("!لا يوجد أسم يطابق الأسم الحالى");
                        return 3;
                    }
                }
            }
            catch
            {
                MessageBox.Show("!لا يوجد أسم يطابق الأسم الحالى");
                return 3;
            }
        }
        public void updateItemPrice(string name, float price, TextBox box)
        {
            try
            {

                command = new SqlCommand("update items set salePrice = '" + price + "' where name = N'" + name + "'", connection);
                int success = command.ExecuteNonQuery();
                command.Dispose();
                if (success != 0)
                {
                    MessageBox.Show("تم تعديل السعر بنجاح");
                    box.Text = price.ToString();
                }
                else
                {
                    MessageBox.Show("فشل فى تعديل السعر");
                }

            }
            catch
            {
            }
        }
        public int getItemId(string name)
        {
            int id = -1;
            command = new SqlCommand("select id from items where name = N'" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            command.Dispose();
            reader.Close();
            return id;
        }
        public string getItemName(int id)
        {
            string name = "";
            command = new SqlCommand("select name from items where id = '" + id + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                name = reader.GetString(0);
            }
            command.Dispose();
            reader.Close();
            return name;
        }
        public float getItemQuantity(string name)
        {
            float qt = -1;
            command = new SqlCommand("select totalQuantity from items where name = N'" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                qt = (float)reader.GetSqlDouble(0);
            }
            command.Dispose();
            reader.Close();
            return qt;
        }
        public float getItemProfit(string name)
        {
            float profit = -1;
            command = new SqlCommand("select profit from items where name = N'" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                profit = (float)reader.GetDouble(0);
            }
            command.Dispose();
            reader.Close();
            return profit;
        }
        public void getItemsReport(CrystalDecisions.Windows.Forms.CrystalReportViewer profitViewer)
        {
            DataSet ds = new DataSet();

            command = new SqlCommand("select items.name, items.totalQuantity, units.name from items, units where items.unit = units.id", connection);

            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, "items");

            gardReport pr = new gardReport();
            pr.SetDataSource(ds);

            profitViewer.ReportSource = pr;
            profitViewer.Refresh();
     
        }
        public void getSaleBillReport(CrystalDecisions.Windows.Forms.CrystalReportViewer profitViewer, int billId)
        {
            DataSet ds = new DataSet();

            command = new SqlCommand("select * from billReport where billReport.billID = '" + billId + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, "billReport");
            command.Dispose();

            command = new SqlCommand("select * from billDetailsReport where billDetailsReport.billID = '" + billId + "'", connection);
            da = new SqlDataAdapter(command);
            da.Fill(ds, "billDetailsReport");
            command.Dispose();

            profitReport pr = new profitReport();
            pr.SetDataSource(ds);

            /// To print directly without preview
            //Reomve this
            
            profitViewer.ReportSource = pr;
            profitViewer.Refresh();
            //pr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
            
            //Add this
            /*
            pr.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;
            pr.PrintToPrinter(1, false, 0, 0);
            */
            
        }
        public void getProfitReport(CrystalDecisions.Windows.Forms.CrystalReportViewer profitViewer, int billId, float current, float paying, float customerPreviousBalance)
        {
            string name, customerName, unitName;
            float unitPrice, quantity, unitTotalPrice, billTotalPrice, discount;
            float totalDiscount = 0;
            int payMethod = -1;

            DataSet ds = new DataSet();
            command = new SqlCommand("select items.name, sales.unitPrice, sales.quantity, sales.totalPrice, saleBills.totalPrice, saleBills.customerName, saleBills.payMethod, sales.discount, sales.unitName " +
                "from items,sales,saleBills,units " +
                "where items.id=sales.itemId and sales.billId=salebills.Id and sales.billId='" + billId + "'", connection);
            reader = command.ExecuteReader();
            command.Dispose();
            

            if (reader.HasRows)
            {
                reader.Read();
                customerName = reader.GetString(5);
                payMethod = reader.GetInt32(6);
                string method = "";
                if (payMethod == 1) method = "آجل";
                else if (payMethod == 2) method = "نقدي";
                else if (payMethod == 3) method = "جزئى";
                
    
                do
                {
                    name = reader.GetString(0);
                    quantity = (float)reader.GetDouble(2);
                    unitName = reader.GetString(8);
                    unitPrice = (float)reader.GetDouble(1);
                    unitTotalPrice = (float)reader.GetDouble(3);
                    billTotalPrice = (float)reader.GetDouble(4);

                    discount = (float)reader.GetDouble(7);
                    totalDiscount += (quantity * discount);

                    command = new SqlCommand("insert into billReport values('" + billId + "', N'" + name + "', '" + quantity + "', N'" + unitName + "','" + unitPrice + "', '" + discount + "', '" + unitTotalPrice + "')", connection);
                    command.ExecuteReader();
                    command.Dispose();

                } while (reader.Read());
                
                command = new SqlCommand("insert into billDetailsReport values('" + billId + "', N'" + salesMan + "', N'" + customerName + "','" + billTotalPrice + "', '" + totalDiscount + "','" + method + "', '" + paying + "', '" + current + "', '" + customerPreviousBalance + "', '" + (customerPreviousBalance + (current-paying)) + "')", connection);
                command.ExecuteReader();
                command.Dispose();
            }
            reader.Close();
            
            command = new SqlCommand("select * from billReport where billReport.billID = '" + billId + "'", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, "billReport");
            command.Dispose();

            command = new SqlCommand("select * from billDetailsReport where billDetailsReport.billID = '" + billId + "'", connection);
            da = new SqlDataAdapter(command);
            da.Fill(ds, "billDetailsReport");
            command.Dispose();

            profitReport pr = new profitReport();
            pr.SetDataSource(ds);

            profitViewer.ResetText();
            profitViewer.ReportSource = pr;
        }

        public float getItemSalePrice(string name)
        {
            float price = -1;
            command = new SqlCommand("select salePrice from items where name = N'" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                price = (float)reader.GetDouble(0);
            }
            command.Dispose();
            reader.Close();
            return price;
        }
        public float getItemSalePrice(int id)
        {
            float price = -1;
            command = new SqlCommand("select salePrice from items where id = '" + id + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                price = (float)reader.GetDouble(0);
            }
            command.Dispose();
            reader.Close();
            return price;
        }
        public bool insertItem(string name, int kind, int unit, float quantity, float bPrice, float sPrice, string date)
        {
            try
            {
                int id = getItemId(name);
                int billId = getBillId(billNumber);

                //###=> Insert new name
                /// Profit = 0
                /// totalQuantity = new quantity
                if (id == -1)
                {
                    //Item
                    command = new SqlCommand("insert into items values( N'" + name + "','" + kind + "','" + unit + "','" + quantity + "','" + 0 + "','" + 0 + "','" + 0 + "','" + sPrice + "', @date)", connection);
                    command.Parameters.AddWithValue("@date", DateTime.Parse(date));
                    command.ExecuteReader();
                    reader.Close();
                    command.Dispose();
                    //Item details
                    int itemId = getItemId(name);
                    command = new SqlCommand("insert into itemDetails values('" + billId + "', '" + itemId + "', '" + quantity + "', '" + bPrice + "')", connection);
                    command.ExecuteReader();
                    reader.Close();
                    command.Dispose();
                    MessageBox.Show("تم إضافة صنف جديد للأصناف");
                }
                //Item name is exist & insert new details for it
                ///Update totalQuantity
                ///Update salePrice
                else
                {
                    //Item
                    command = new SqlCommand("update items set totalQuantity = totalQuantity + '" + quantity + "', salePrice = '" + sPrice + "'", connection);
                    command.ExecuteReader();
                    reader.Close();
                    command.Dispose();
                    //item details
                    command = new SqlCommand("insert into itemDetails values('" + billId + "', '" + id + "', '" + quantity + "', '" + bPrice + "')", connection);
                    command.ExecuteReader();
                    reader.Close();
                    command.Dispose();
                }
                return true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                return false;
            }


        }
        public void increaseItemProfit(string name, float amount)
        {
            command = new SqlCommand("update items set profit = profit + '" + amount + "' where name = '" + name + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }
        public void updateItemTotalQuantity(int id, float amount)
        {
            command = new SqlCommand("update items set totalQuantity = totalQuantity - '" + amount + "' where id = '" + id + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }

        public void viewItmes(DataGridView grid)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select items.name, items.totalQuantity, units.name, items.salePrice, items.totalNumberOfSales, items.totalGain, items.profit from items,units where items.unit = units.id", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                float quantity = (float)reader.GetDouble(1);
                string unit = reader.GetString(2);
                float salePrice = (float)reader.GetDouble(3);
                float salesCount = (float)reader.GetDouble(4);
                float Gain = (float)reader.GetDouble(5);
                float profit = (float)reader.GetDouble(6);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = name;
                row.Cells[1].Value = quantity;
                row.Cells[2].Value = unit;
                row.Cells[3].Value = salePrice;
                row.Cells[4].Value = salesCount;
                row.Cells[5].Value = Gain;
                row.Cells[6].Value = profit;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }
        public void viewItmesSearch(DataGridView grid)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select items.name, items.totalQuantity, units.name, items.salePrice from items,units where items.unit = units.id", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                float quantity = (float)reader.GetDouble(1);
                string unit = reader.GetString(2);
                float salePrice = (float)reader.GetDouble(3);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = name;
                row.Cells[1].Value = quantity;
                row.Cells[2].Value = unit;
                row.Cells[3].Value = salePrice;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }
        public void viewItmesX(DataGridView grid)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select name, salePrice from items", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                float salePrice = (float)reader.GetDouble(1);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = name;
                row.Cells[1].Value = salePrice;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }





        /// items details Table
        /// 
        public void updateItemDetailsQuantity(int id, float amount)
        {
            command = new SqlCommand("update itemDetails set quantity = quantity - '" + amount + "' where id = '" + id + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }
        public void deleteItemDetails(int id)
        {
            command = new SqlCommand("delete from itemDetails where id = '" + id + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }
        public void updateItemProfit(int itemId, float quantity, float buyPrice)
        {
            command = new SqlCommand("select salePrice from items where id = '" + itemId + "'", connection);
            reader = command.ExecuteReader();
            float salePrice = 0;
            if (reader.HasRows)
            {
                reader.Read();
                salePrice = (float)reader.GetDouble(0);
            }
            command.Dispose();
            reader.Close();
            command = new SqlCommand("update items set profit = profit + '" + ((quantity) * (salePrice - buyPrice)) + "', totalNumberOfSales = totalNumberOfSales + '" + quantity + "', totalGain = totalGain + '" + (quantity * salePrice) + "' where id = '" + itemId + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }
        public void subtractItemQuantity(int id, float quantity)
        {
            float neededQuantity = quantity;
            command = new SqlCommand("select id, quantity, buyPrice from itemDetails where itemId = '" + id + "' order by id asc", connection);
            mainReader = command.ExecuteReader();
            if (mainReader.HasRows)
            {
                while (mainReader.Read())
                {
                    int detailsId = mainReader.GetInt32(0);
                    float detailsQuantity = (float)mainReader.GetDouble(1);
                    float buyPrcie = (float)mainReader.GetDouble(2);
                    if (detailsQuantity > neededQuantity)
                    {
                        updateItemDetailsQuantity(detailsId, neededQuantity);
                        updateItemProfit(id, neededQuantity, buyPrcie);
                        neededQuantity = 0;
                        return;
                    }
                    else if (detailsQuantity == neededQuantity)
                    {
                        updateItemDetailsQuantity(detailsId, neededQuantity);
                        updateItemProfit(id, neededQuantity, buyPrcie);
                        neededQuantity = 0;
                        deleteItemDetails(detailsId);

                        return;
                    }
                    else
                    {
                        updateItemProfit(id, neededQuantity, buyPrcie);
                        neededQuantity -= detailsQuantity;
                        deleteItemDetails(detailsId);
                    }
                }
            }
            command.Dispose();
            mainReader.Close();
        }


        // buy Bills Table

        public int getCustomerID(string name)
        {
            int id = -1;
            command = new SqlCommand("select id from customerBalance where Name = '" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            command.Dispose();
            reader.Close();
            return id;
        }
        public float getCustomerAmount(string name)
        {
            float amount = 0;
            command = new SqlCommand("select totalAmount from customerBalance where Name = '" + name + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                amount = (float)reader.GetDouble(0);
            }
            command.Dispose();
            reader.Close();
            return amount;
        }
        public float getCustomerAmount(int id)
        {
            float amount = 0;
            command = new SqlCommand("select totalAmount from customerBalance where id = '" + id + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                amount = (float)reader.GetDouble(0);
            }
            command.Dispose();
            reader.Close();
            return amount;
        }
        [Obsolete]
        public bool insertBill(int number, string incName, float price, DateTime date, byte[] image)
        {
            try
            {
                command = new SqlCommand("insert into bills values(@number, @name, @price, @date, @image)", connection);
                command.Parameters.Add("@number", number);
                command.Parameters.Add("@name", incName);
                command.Parameters.Add("@price", price);
                command.Parameters.Add("@date", date);
                if (image == null)
                {
                    SqlParameter imageParameter = new SqlParameter("@image", SqlDbType.Image);
                    imageParameter.Value = DBNull.Value;
                    command.Parameters.Add(imageParameter);
                }
                else command.Parameters.AddWithValue("@image", image);
                command.ExecuteReader();
                command.Dispose();
                reader.Close();
                billNumber = number;
                return true;
            }
            catch
            {
                MessageBox.Show("لا يمكن تسجيل الفاتورة, يوجد فاتورة بنفس الرقم");
                return false;
            }
        }
        public void cancelBill(int number)
        {
            try
            {
                command = new SqlCommand("delete from bills where number = '"+number+"'", connection);
                command.ExecuteReader();
                command.Dispose();
            }
            catch
            {
                MessageBox.Show("!!غير قادر على حذف الفاتورة");
            }
        }
        public int getBillId(int number)
        {
            int billNumber = -1;
            command = new SqlCommand("select id from bills where number = '" + number + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                billNumber = reader.GetInt32(0);
            }
            command.Dispose();
            reader.Close();
            return billNumber;
        }

        public void viewbuyBills(DataGridView grid)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select number, incName, price, billDate from bills", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int number = reader.GetInt32(0);
                string incName = reader.GetString(1);
                float price = (float)reader.GetDouble(2);
                DateTime date = DateTime.Parse(reader.GetDateTime(3).ToString());
                string dateString = date.ToString("yyyy-MM-dd");

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = number;
                row.Cells[1].Value = incName;
                row.Cells[2].Value = price;
                row.Cells[3].Value = dateString;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }
        public void viewBillImage(PictureBox box, int billNumber)
        {
            command = new SqlCommand("select picture from bills where number = '" + billNumber + "'", connection);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader[0] != DBNull.Value)
            {
                Byte[] data = new Byte[0];
                data = (Byte[])(reader[0]);
                MemoryStream mem = new MemoryStream(data);
                box.Image = Image.FromStream(mem);
            }
        }



        public void updateCustomerBalance(float amount, int id, string name)
        {
            if(id != -1)
            {
                command = new SqlCommand("update customerBalance set totalAmount = '" + amount + "' where id = '" + id + "'", connection);
                int check = command.ExecuteNonQuery();
                command.Dispose();
            }
            else
            {
                command = new SqlCommand("insert into customerBalance values(N'" + name + "' , '" + amount + "')", connection);
                command.ExecuteReader();
                command.Dispose();
            }
        }
        public void updatePaymentMethod(string name, int code)
        {
            command = new SqlCommand("update saleBills set payMethod = '" + code + "' where customerName = '" + name + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }
        public void insertPayment(int id, float currentBill, float payingAmount, float customerDepit)
        {
            try
            {
                command = new SqlCommand("insert into paymentHistory values('" + id + "', @date, '" + currentBill + "', '" + payingAmount + "', '" + customerDepit + "')", connection);
                command.Parameters.AddWithValue("@date", DateTime.Now);
                command.ExecuteReader();
                command.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /*Sales Bills*/
        public void updateBillTotalPrice(int billId, float amount)
        {
            command = new SqlCommand("update saleBills set totalPrice = '" + amount + "' where id = '" + billId + "'", connection);
            command.ExecuteReader();
            command.Dispose();
        }
        public void prepareSale(int id, float quantity, float discount, DataGridView grid, TextBox billTotalprice)
        {
            updateItemTotalQuantity(id, quantity);

            string name = getItemName(id);
            float price = getItemSalePrice(id);
            string unit = getUnitName(id);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(grid);
            row.Cells[0].Value = name;   ///Name
            row.Cells[1].Value = quantity;   ///quantity
            row.Cells[2].Value = unit;   ///unit
            row.Cells[3].Value = price;   ///price
            row.Cells[4].Value = discount;   ///Discount
            row.Cells[5].Value = (quantity * price);   ///Total Price
            grid.Rows.Add(row);

            billTotalprice.Text = ((Double.Parse(billTotalprice.Text)) + ((quantity * price)-(quantity * discount))).ToString();
        }
        public void FinishSale(int billId, string name, float quantity, string unitName, float unitPrice, float totalPrice, float discount, float billTotalPrice)
        {
            int itemId = getItemId(name);
            subtractItemQuantity(itemId, quantity);
            insertSale(billId, itemId, quantity, unitName, unitPrice, totalPrice, discount);
            updateBillTotalPrice(billId, billTotalPrice);
        }
        public void returnItem(string name, float quantity, float totalPrice, TextBox billTotalprice)
        {
            int id = getItemId(name);
            updateItemTotalQuantity(id, -quantity);
            billTotalprice.Text = ((int.Parse(billTotalprice.Text.ToString())) - totalPrice).ToString();
        }
        public int insertSaleBill(string name, float totalPrcie, string date)
        {
            int billId = -1;
            try
            {
                command = new SqlCommand("insert into saleBills values(N'" + name + "', '" + totalPrcie + "', @date, N'" + salesMan + "', 1);select SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@date", DateTime.Parse(date));
                billId = int.Parse(command.ExecuteScalar().ToString());
                command.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            return billId;
        }
        public void deleteSaleBill(int number)
        {
            try
            {
                command = new SqlCommand("delete from saleBills where id = '" + number + "'", connection);
                command.ExecuteNonQuery();
                command.Dispose();
                int id = 0;
                command = new SqlCommand("select max(id) from saleBills", connection);
                reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    id = reader.GetInt32(0);
                }
                command.Dispose();
                command = new SqlCommand("DBCC checkident ('saleBills' , reseed , @id)", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                command.Dispose();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
        public int getSaleBillId(string customerName)
        {
            int billId = -1;
            command = new SqlCommand("select id from saleBills where customerName = N'" + customerName + "'", connection);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                billId = reader.GetInt32(0);
            }
            command.Dispose();
            reader.Close();
            return billId;
        }
        public void insertSale(int billId, int itemId, float quantity, string unitName, float unitPrice, float totalPrice, float discount)
        {
            try
            {
                command = new SqlCommand("insert into sales values('" + billId + "', '" + itemId + "', '" + quantity + "', N'" + unitName + "', '" + unitPrice + "', '" + totalPrice + "', '" + discount + "')", connection);
                command.ExecuteReader();
                command.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        public void viewSaleBills(DataGridView grid)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select id, customerName, totalPrice, billDate, salesManName from saleBills", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                float price = (float)reader.GetDouble(2);
                DateTime date = DateTime.Parse(reader.GetDateTime(3).ToString());
                string dateString = date.ToString("yyyy-MM-dd");
                string seller = reader.GetString(4);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = id;
                row.Cells[1].Value = name;
                row.Cells[2].Value = price;
                row.Cells[3].Value = dateString;
                row.Cells[4].Value = seller;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }

        public void viewSaleBillDetails(DataGridView grid, int billId)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select items.name, sales.unitPrice, sales.quantity, sales.totalPrice, sales.discount " +
                "from items,sales,saleBills " +
                "where items.id=sales.itemId and sales.billId=salebills.Id and saleBills.id='" + billId + "'", connection);

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                float unitPrice = (float)reader.GetDouble(1);
                float quantity = (float)reader.GetDouble(2);
                float totalPrice = (float)reader.GetDouble(3);
                float discount = (float)reader.GetDouble(4);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = name;
                row.Cells[1].Value = quantity;
                row.Cells[2].Value = unitPrice;
                row.Cells[3].Value = discount;
                row.Cells[4].Value = totalPrice;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }

        public void viewcustomerHistory(DataGridView grid, int customerId)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select operationDate, billPrice, payingAmount, TotalDepit from paymentHistory where customerId = '"+customerId+"'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                DateTime date = DateTime.Parse(reader.GetDateTime(0).ToString());
                string dateString = date.ToString("yyyy-MM-dd");
                float billPrice = (float)reader.GetDouble(1);
                float payingAmount = (float)reader.GetDouble(2);
                float TotalDepit = (float)reader.GetDouble(3);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = dateString;
                row.Cells[1].Value = billPrice;
                row.Cells[2].Value = payingAmount;
                row.Cells[3].Value = TotalDepit;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }





        /*Users*/
        public void addUser(string name, string userName, string password, int role)
        {
            try
            {
                string roleName = "";
                if (role == 0)
                    roleName = "Admin";
                else
                    roleName = "Worker";
                command = new SqlCommand("insert into users values(N'" + name + "', '" + userName + "', '" + password + "', '" + roleName + "')", connection);
                command.ExecuteReader();
                command.Dispose();
                MessageBox.Show("تم إضافة الأسم");
            }
            catch
            {
                MessageBox.Show("يوجد عضو بنفس أسم المستخدم");
            }
        }
        
        public void viewUsers(DataGridView grid)
        {
            grid.Rows.Clear();
            command = new SqlCommand("select name, userName, pass, userRole from users", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string userName = reader.GetString(1);
                string password = reader.GetString(2);
                string userRole = reader.GetString(3);
                if (userName == "administrator") continue;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(grid);
                row.Cells[0].Value = name;
                row.Cells[1].Value = userName;
                row.Cells[2].Value = password;
                row.Cells[3].Value = userRole;
                grid.Rows.Add(row);
            }
            command.Dispose();
            reader.Close();
        }
        public void deleteUser(string userName)
        {
            try
            {
                command = new SqlCommand("delete from users where userName = '" + userName + "'", connection);
                int success = command.ExecuteNonQuery();
                command.Dispose();
                if(success !=0) MessageBox.Show("تم الحذف");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateUser(string userName, string name, string pass, int role)
        {
            try
            {
                string roleName = "";
                if (role == 0)
                    roleName = "Admin";
                else
                    roleName = "Worker";

                command = new SqlCommand("update users set name = N'" + name + "', pass = '" + pass + "', userRole = '" + roleName + "' where userName = '" + userName + "'", connection);
                int success = command.ExecuteNonQuery();
                command.Dispose();
                if (success != 0) MessageBox.Show("تم التعديل");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}




