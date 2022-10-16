using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Main : Form
    {
        private List<Panel> panels = new List<Panel>();
        DB db;

        bool buyIsOpen = false;
        bool salesIsOpen = false;

        string masterRole = "none";

        int masterBillNumber = 0;
        Int64 parseInt;
        float parsefloat;

        [Obsolete]
        public Main()
        {
            InitializeComponent();
        }

        
        public void buyLamps(int lamp)
        {
            if (lamp == 1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                endBill.Enabled = false;
                cancelBuyBill.Enabled = false;
                billLamp.BackColor = Color.Lime;
                detailsLamp.BackColor = Color.Red;

            }
            else if (lamp == 2)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                endBill.Enabled = true;
                cancelBuyBill.Enabled = true;
                billLamp.BackColor = Color.Red;
                detailsLamp.BackColor = Color.Lime;
            }
        }
        public void salesLamps(int lamp)
        {
            if (lamp == 1)
            {
                groupBox4.Enabled = true;
                groupBox3.Enabled = false;
                continueSaleBill.Enabled = false;
                cancelSaleBill.Enabled = false;
                saleBillNumber.Text = "";
                saleTotalPrice.Text = "0";
                customerName.Text = "";

            }
            else if (lamp == 2)
            {
                groupBox4.Enabled = false;
                groupBox3.Enabled = true;
                continueSaleBill.Enabled = true;
                cancelSaleBill.Enabled = true;
                saleItemName.Text = "";
                saleQuantity.Text = "";
            }
        }
        public void manageRoles()
        {

            // lock buttons for worker role
            if (masterRole == "Worker")
            {
                سعرصنفToolStripMenuItem.Enabled = false;
                المستخدمونToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                toolStripMenuItem2.Enabled = false;
            }
            else
            {
                سعرصنفToolStripMenuItem.Enabled = true;
                المستخدمونToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = true;
                toolStripMenuItem2.Enabled = true;
            }
        }
        public void showPanels(int panel)
        {
            background.Visible = false;
            addItem.Visible = false;
            sale.Visible = false;
            reports.Visible = false;
            itemSearch.Visible = false;
            buyBillSearch.Visible = false;
            buyBillSearchDetails.Visible = false;
            saleBillSearch.Visible = false;
            saleBillSearchDetails.Visible = false;
            itemWithoutBill.Visible = false;
            login.Visible = false;
            updateNames.Visible = false;
            updatePrice.Visible = false;
            users.Visible = false;
            units.Visible = false;
            payments.Visible = false;
            itemsDetails.Visible = false;
            customersPayments.Visible = false;

            if (panel == 1)
                login.Visible = true;

        }
        private void Main_Load(object sender, EventArgs e)
        {

            ///Panels
            ///
            panels.Add(background);           //0
            panels.Add(addItem);             //1
            panels.Add(sale);                //2
            panels.Add(reports);             //3
            panels.Add(itemSearch);          //4
            panels.Add(buyBillSearch);       //5
            panels.Add(buyBillSearchDetails);//6
            panels.Add(saleBillSearch);      //7
            panels.Add(saleBillSearchDetails);//8
            panels.Add(itemWithoutBill);        //9
            panels.Add(login);                  //10
            panels.Add(updateNames);          //11
            panels.Add(updatePrice);          //12
            panels.Add(users);                //13
            panels.Add(units);                //14
            panels.Add(payments);                //15
            panels.Add(itemsDetails);           // 16
            panels.Add(customersPayments);      //17
            panels[10].BringToFront();
            
            //showPanels(1);
            userName.Focus();
            statusStrip1.Visible = false;
            


            /*
            addItem.Visible = false;
            sale.Visible = false;
            reports.Visible = false;
            itemSearch.Visible = false;
            saleBillSearch.Visible = false;
            */

            // Auto complete to any text box
            /*
            db.autoCompleteItemsName(itemName);
            db.autoCompleteItemsName(saleItemName);
            db.autoCompleteCustomersName(customerName);
            */
        }

        private void صنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
            /*
            addItem.Visible = true;
            reports.Visible = false;
            sale.Visible = false;
            itemSearch.Visible = false;
            saleBillSearch.Visible = false;
            */
            if (buyIsOpen == false) buyLamps(1);
            unit.Items.Clear();
            unit.Items.AddRange(db.getAllUnits().ToArray());
        }

        [Obsolete]
        private void addBill_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int number = -1;
            string name = "";
            float price = -1;


            if (String.IsNullOrEmpty(billNumber.Text) || String.IsNullOrWhiteSpace(billNumber.Text) || !Int64.TryParse(billNumber.Text, out parseInt))
            {
                MessageBox.Show("أدخل رقم الفاتورة");
            }
            else if (String.IsNullOrEmpty(incName.Text) || String.IsNullOrWhiteSpace(incName.Text))
            {
                MessageBox.Show("أدخل إسم الشركة");
            }
            else if (!Int64.TryParse(billPrice.Text, out parseInt) && !float.TryParse(billPrice.Text, out parsefloat))
            {
                MessageBox.Show("خانة السعر خانة أرقام فقط");
            }
            else
            {
                number = int.Parse(billNumber.Text);
                name = incName.Text;
                price = float.Parse(billPrice.Text);
                flag = true;
            }

            if (flag == true)
            {
                bool inserted;
                MemoryStream ms = new MemoryStream();
                ms.Position = 0;

                //Bill Image
                if (picture == null || picture.Image == null)
                    inserted = db.insertBill(number, name, price, billDate.Value, null);
                else
                {
                    Image img = picture.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    inserted = db.insertBill(number, name, price, billDate.Value, arr);//photo_aray);
                }
                //=========

                if (inserted)
                {
                    MessageBox.Show("تم إضافة الفاتورة, أدخل التفاصيل");
                    itemName.Focus();
                    flag = false;
                    buyIsOpen = true;
                    buyLamps(2);
                }
;
            }
        }
        private void itemBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemName.Text) || String.IsNullOrWhiteSpace(itemName.Text))
            {
                MessageBox.Show("أدخل إسم الصنف");
            }
            else if ((!Int64.TryParse(bPrice.Text, out parseInt) && !float.TryParse(bPrice.Text, out parsefloat)) || (!Int64.TryParse(sPrice.Text, out parseInt) && !float.TryParse(sPrice.Text, out parsefloat)))
            {
                MessageBox.Show("خانة السعر خانة أرقام فقط");
            }
            else if (unit.SelectedIndex == -1)
            {
                MessageBox.Show("أختر الوحدة");
            }
            else if ((!Int64.TryParse(quantity.Text, out parseInt) && !float.TryParse(quantity.Text, out parsefloat)) || String.IsNullOrEmpty(quantity.Text) || String.IsNullOrWhiteSpace(quantity.Text))
            {
                MessageBox.Show("أدخل الكمية بشكل صحيح");
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(buyItemsDG);
                row.Cells[0].Value = itemName.Text;
                row.Cells[1].Value = quantity.Text;
                row.Cells[2].Value = unit.Text;
                row.Cells[3].Value = bPrice.Text;
                row.Cells[4].Value = sPrice.Text;
                buyItemsDG.Rows.Add(row);

                buyTotalPriceCheck.Text = (float.Parse(buyTotalPriceCheck.Text) + (float.Parse(quantity.Text) * float.Parse(bPrice.Text))).ToString();

                itemName.Text = "";
                unit.SelectedIndex = -1;
                quantity.Text = "";
                bPrice.Text = "";
                sPrice.Text = "";
                db.autoCompleteItemsName(itemName);
                db.autoCompleteItemsName(saleItemName);

            }
        }

        private void endBill_Click(object sender, EventArgs e)
        {
            if(float.Parse(buyTotalPriceCheck.Text) < float.Parse(billPrice.Text) || float.Parse(buyTotalPriceCheck.Text) > float.Parse(billPrice.Text))
            {
                MessageBox.Show("يجب أن يكون سعر المشتريات مساوى لسعر الفاتورة");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("     هل أنت متأكد من إنهاء الفاتورة ؟" + "\n" + "      .لا يمكن إضافة أصناف مرة أخرى", "إنهاء الفاتورة", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in buyItemsDG.Rows)
                    {
                        string name = row.Cells[0].Value.ToString();
                        float itemQuantity = float.Parse(row.Cells[1].Value.ToString());
                        string itemUnit = row.Cells[2].Value.ToString();
                        float buyPrice = float.Parse(row.Cells[3].Value.ToString());
                        float salePrice = float.Parse(row.Cells[4].Value.ToString());

                        int unitId = db.getUnitId(itemUnit);
                        bool inserted = db.insertItem(name, 1, unitId, itemQuantity, buyPrice, salePrice, billDate.Text);

                    }
                    billNumber.Text = "";
                    billPrice.Text = "";
                    incName.Text = "";
                    buyTotalPriceCheck.Text = "0";
                    buyItemsDG.Rows.Clear();
                    picture.Image = null;
                    buyIsOpen = false;
                    buyLamps(1);
                }
            }

        }
        private void billImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(dialog.FileName); ;
            }
        }

        private void addSaleBill_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerName.Text) || String.IsNullOrWhiteSpace(customerName.Text))
            {
                MessageBox.Show("أدخل إسم العميل");
            }
            else
            {
                int billID = db.insertSaleBill(customerName.Text, 0, saleBillDate.Text);
                salesIsOpen = true;
                salesLamps(2);
                saleBillNumber.Text = billID.ToString();
                saleItemName.Focus();
            }
        }

        private void printSaleBill_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            payingAmount.Value = 0;
            if (saleBillGrid.Rows.Count == 0)
            {
                MessageBox.Show("أضف أصناف أولاً");
            }
            else
            {
                panels[15].BringToFront();

                string name = customerName.Text;
                string bill = saleTotalPrice.Text;

                previousAmount.Text = db.getCustomerAmount(name).ToString();
                currentBill.Text = bill;
                payingAmount.Maximum = (decimal)float.Parse(currentBill.Text);

            }
        }

        private void saleAddItem_Click(object sender, EventArgs e)
        {
            float discountBox = 0;
            if (String.IsNullOrEmpty(saleItemName.Text) || String.IsNullOrWhiteSpace(saleItemName.Text))
            {
                MessageBox.Show("أدخل إسم الصنف");
            }
            else if ( String.IsNullOrEmpty(saleQuantity.Text) || String.IsNullOrWhiteSpace(saleQuantity.Text) || (!Int64.TryParse(saleQuantity.Text, out parseInt) && !float.TryParse(saleQuantity.Text, out parsefloat)))
            {
                MessageBox.Show("أدخل الكمية بشكل صحيح");
            }
            else if ((!String.IsNullOrEmpty(discount.Text) || !String.IsNullOrWhiteSpace(discount.Text))  && (!Int64.TryParse(discount.Text, out parseInt) && !float.TryParse(discount.Text, out parsefloat)))
            {
                MessageBox.Show("الخصم رقم أو 0");
            }
            else
            {
                if (!String.IsNullOrEmpty(discount.Text) || !String.IsNullOrWhiteSpace(discount.Text))
                {
                    discountBox = float.Parse(discount.Text);
                }
                int id;
                id = db.getItemId(saleItemName.Text);
                if (id == -1)
                {
                    MessageBox.Show("لا يوجد صنف بهذا الأسم");
                }
                else
                {
                    float quantity = float.Parse(saleQuantity.Text);
                    float dbQuantity = db.getItemQuantity(saleItemName.Text);

                    if (quantity > dbQuantity)
                    {
                        MessageBox.Show("كمية المخزن غير كافية");
                    }
                    else
                    {
                        db.prepareSale(id, quantity, discountBox , saleBillGrid, saleTotalPrice);
                        saleItemName.Text = "";
                        saleQuantity.Text = "";
                        discount.Text = "";
                        saleItemName.Focus();
                    }

                }

            }
        }

        private void toolStripDropDownButton6_Click(object sender, EventArgs e)
        {
            panels[2].BringToFront();
            /*
            addItem.Visible = false;
            reports.Visible = false;
            sale.Visible = true;
            itemSearch.Visible = false;
            saleBillSearch.Visible = false;
            */
            if (salesIsOpen == false) salesLamps(1);
            else salesLamps(2);
        }

        private void cancelSaleBill_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in saleBillGrid.Rows)
            {
                string name = row.Cells[0].Value.ToString();
                float quantity = (float)row.Cells[1].Value;
                float totalprice = (float)row.Cells[5].Value;
                db.returnItem(name, quantity, totalprice, saleTotalPrice);
            }
            db.deleteSaleBill(int.Parse(saleBillNumber.Text.ToString()));
            saleBillGrid.Rows.Clear();
            salesLamps(1);
            salesIsOpen = false;
        }

        private void saleBillGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string name = saleBillGrid.SelectedRows[0].Cells[0].Value.ToString();
            float itemQuantity = float.Parse(saleBillGrid.SelectedRows[0].Cells[1].Value.ToString());
            float salePrice = float.Parse(saleBillGrid.SelectedRows[0].Cells[3].Value.ToString());
            float itemDiscount = float.Parse(saleBillGrid.SelectedRows[0].Cells[4].Value.ToString());

            int id = db.getItemId(name);
            db.updateItemTotalQuantity(id, -itemQuantity);
            saleTotalPrice.Text = (float.Parse(saleTotalPrice.Text) - ((itemQuantity * salePrice) - (itemQuantity * itemDiscount))).ToString();
        }

        private void بالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[4].BringToFront();
            /*
            addItem.Visible = false;
            sale.Visible = false;
            reports.Visible = false;
            itemSearch.Visible = true;
            saleBillSearch.Visible = false;*/

            //AutoView data
            db.viewItmesSearch(itemsSearchGrid);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            itemsSearchGrid.CurrentCell = null;

            foreach (DataGridViewRow row in itemsSearchGrid.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(textBox1.Text.ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void برقمالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[5].BringToFront();
            /*
            addItem.Visible = false;
            sale.Visible = false;
            reports.Visible = false;
            itemSearch.Visible = false;
            saleBillSearch.Visible = true;
            */
            //AutoView data
            db.viewbuyBills(buyBillSearchGrid);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            buyBillSearchGrid.CurrentCell = null;

            foreach (DataGridViewRow row in buyBillSearchGrid.Rows)
            {
                if (row.Cells[0].Value.ToString().StartsWith(buyBillNumberSearch.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void buyBillincNameSearch_TextChanged(object sender, EventArgs e)
        {
            buyBillSearchGrid.CurrentCell = null;

            foreach (DataGridViewRow row in buyBillSearchGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().StartsWith(buyBillincNameSearch.Text.ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }




        private void buySaleSearchGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panels[6].BringToFront();
                statusStrip1.Visible = false;
                int billNumber = (int)buyBillSearchGrid.Rows[e.RowIndex].Cells[0].Value;
                db.viewBillImage(buyBillImage, billNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panels[5].BringToFront();
            statusStrip1.Visible = true;
        }

        private void فاتورةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[7].BringToFront();
            db.viewSaleBills(saleBillSearchGrid);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            saleBillSearchGrid.CurrentCell = null;

            foreach (DataGridViewRow row in saleBillSearchGrid.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().StartsWith(textBox3.Text.ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void saleBillSearchGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panels[8].BringToFront();
                statusStrip1.Visible = false;
                int billNumber = (int)saleBillSearchGrid.Rows[e.RowIndex].Cells[0].Value;
                db.viewSaleBillDetails(saleBillSearchDetailsGrid, billNumber);
                masterBillNumber = billNumber;
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panels[7].BringToFront();
            statusStrip1.Visible = true;
        }

        private void مشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[9].BringToFront();
            itemUnitX.Items.Clear();
            itemUnitX.Items.AddRange(db.getAllUnits().ToArray());
        }

        private void addItemBtnX_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemNameX.Text) || String.IsNullOrWhiteSpace(itemNameX.Text))
            {
                MessageBox.Show("أدخل إسم الصنف");
            }
            else if ((!Int64.TryParse(itemBuyPriceX.Text, out parseInt) && !float.TryParse(itemBuyPriceX.Text, out parsefloat)) || (!Int64.TryParse(itemSalePriceX.Text, out parseInt) && !float.TryParse(itemSalePriceX.Text, out parsefloat)))
            {
                MessageBox.Show("خانة السعر خانة أرقام فقط");
            }
            else if (itemUnitX.SelectedIndex == -1)
            {
                MessageBox.Show("أختر الوحدة");
            }
            else if (itemQuantityX.Value == 0)
            {
                MessageBox.Show("أدخل الكمية");
            }
            else
            {
                //Kind not recognized yet
                int unitId = db.getUnitId(itemUnitX.Text);
                bool inserted = db.insertItem(itemNameX.Text, 1, unitId, (float)itemQuantityX.Value, float.Parse(itemBuyPriceX.Text.ToString()), float.Parse(itemSalePriceX.Text.ToString()), itemDateX.Text);
                if (inserted)
                {
                    itemNameX.Text = "";
                    itemUnitX.SelectedIndex = -1;
                    itemQuantityX.Value = 0;
                    itemBuyPriceX.Text = "";
                    itemSalePriceX.Text = "";
                    MessageBox.Show("تم إضافة الصنف");
                    db.autoCompleteItemsName(itemNameX);
                    db.autoCompleteItemsName(saleItemName);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label34.Visible == false)
            {
                label34.Visible = true;
                dbSource.Visible = true;
                editDB.Visible = true;
            }
            else
            {
                label34.Visible = false;
                dbSource.Visible = false;
                editDB.Visible = false;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(userName.Text) || String.IsNullOrWhiteSpace(userName.Text) || String.IsNullOrEmpty(password.Text) || String.IsNullOrWhiteSpace(password.Text))
                {
                    MessageBox.Show("!! أحد المدخلات فارغة");
                }
                else
                {
                    db = new DB();
                    string user = userName.Text;
                    string pass = password.Text;
                    string role = db.checkLogin(user, pass);
                    if (role != "none")
                    {
                        masterRole = role;
                        panels[0].BringToFront();
                        statusStrip1.Visible = true;

                        manageRoles();
                        /// Auto complete all boxs
                        db.autoCompleteItemsName(itemName);
                        db.autoCompleteItemsName(itemNameX);
                        db.autoCompleteItemsName(saleItemName);
                        db.autoCompleteCustomersName(customerName);
                        db.autoCompleteCompanyName(incName);

                        userName.Text = "";
                        password.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("خطأ في أسم المستخدم أو كلمة المرور");
                        userName.Text = "";
                        password.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
                MessageBox.Show("غير قادر على الإتصال بقاعدة البيانات");
            }

        }

        private void editDB_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dbSource.Text) || String.IsNullOrWhiteSpace(dbSource.Text))
            {
                MessageBox.Show("أدخل قاعدة البيانات ");
            }
            else
            {
                Properties.Settings.Default.source = dbSource.Text;
                Properties.Settings.Default.Save();
                dbSource.Text = "";
                MessageBox.Show("تم تغيير قاعدة البيانات");
                dbSource.Visible = false;
                label34.Visible = false;
                editDB.Visible = false;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(saleBillNumber.Text) && !String.IsNullOrWhiteSpace(saleBillNumber.Text))
                cancelSaleBill_Click(sender, e);
            panels[10].BringToFront();
            statusStrip1.Visible = false;
        }

        private void أسمصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[11].BringToFront();
            db.autoCompleteItemsName(itemOldName);

        }

        private void updateItemName_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemOldName.Text) || String.IsNullOrWhiteSpace(itemOldName.Text) || String.IsNullOrEmpty(itemNewName.Text) || String.IsNullOrWhiteSpace(itemNewName.Text))
            {
                MessageBox.Show("!!أحد المدخلات فارغة");
            }
            else
            {
                int cases = db.updateItemName(itemOldName.Text, itemNewName.Text, itemOldName);
                if (cases == 1)
                {
                    itemOldName.Text = "";
                    itemNewName.Text = "";
                }
                else if (cases == 2)
                {
                    itemNewName.Text = "";
                }
                else
                {
                    itemOldName.Text = "";
                }
            }
        }

        private void printAgain_Click(object sender, EventArgs e)
        {
            panels[3].BringToFront();
            statusStrip1.Visible = true;
            db.getSaleBillReport(CRViewer, masterBillNumber);
        }


        private void سعرصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[12].BringToFront();

            db.viewItmesX(updatePriceDG);
        }

        private void itemFilter_TextChanged(object sender, EventArgs e)
        {
            updatePriceDG.CurrentCell = null;

            foreach (DataGridViewRow row in updatePriceDG.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(itemFilter.Text.ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }


        private void updatePriceDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            float itemPrice = (float)updatePriceDG.Rows[e.RowIndex].Cells[1].Value;
            string itemName = updatePriceDG.Rows[e.RowIndex].Cells[0].Value.ToString();
            curentPrice.Text = itemPrice.ToString();
            currcentName.Text = itemName;
        }

        private void updatePriceBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(currcentName.Text) || String.IsNullOrWhiteSpace(currcentName.Text))
            {
                MessageBox.Show("أختر صنف أولاً");
            }
            else if (String.IsNullOrEmpty(newPrice.Text) || String.IsNullOrWhiteSpace(newPrice.Text) || (!Int64.TryParse(newPrice.Text, out parseInt) && !float.TryParse(newPrice.Text, out parsefloat)))
            {
                MessageBox.Show("أدخل السعر بطريقة صحيحة");
            }
            else
            {
                db.updateItemPrice(currcentName.Text, float.Parse(newPrice.Text), curentPrice);
                db.viewItmesX(updatePriceDG);
                newPrice.Text = "";
                itemFilter.Text = "";

            }
        }

        private void المستخدمونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[13].BringToFront();
            db.viewUsers(usersDG);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userRealName.Text) || String.IsNullOrWhiteSpace(userRealName.Text))
            {
                MessageBox.Show("أدخل أسم العضو");
            }
            else if (String.IsNullOrEmpty(userNameB.Text) || String.IsNullOrWhiteSpace(userNameB.Text))
            {
                MessageBox.Show("أدخل أسم المستخدم");
            }
            else if (String.IsNullOrEmpty(passwordB.Text) || String.IsNullOrWhiteSpace(passwordB.Text))
            {
                MessageBox.Show("أدخل كلمة السر");
            }
            else if (userRole.SelectedIndex == -1)
            {
                MessageBox.Show("أختر درجة العضو");
            }
            else
            {
                db.addUser(userRealName.Text, userNameB.Text, passwordB.Text, userRole.SelectedIndex);
                db.viewUsers(usersDG);
                userRealName.Text = "";
                userNameB.Text = "";
                passwordB.Text = "";
                userRole.SelectedIndex = -1;
            }
        }

        private void usersDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = usersDG.Rows[e.RowIndex].Cells[0].Value.ToString();
            string userName = usersDG.Rows[e.RowIndex].Cells[1].Value.ToString();
            string password = usersDG.Rows[e.RowIndex].Cells[2].Value.ToString();
            string role = usersDG.Rows[e.RowIndex].Cells[3].Value.ToString();

            textBox2.Text = name;
            textBox5.Text = userName;
            textBox7.Text = password;
            textBox4.Text = role;

            userRealNameX.Text = name;
            passwordBX.Text = password;
            userRoleX.Text = role;

        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("أختر أسم أولاً");
            }
            else if (String.IsNullOrEmpty(userRealNameX.Text) || String.IsNullOrWhiteSpace(userRealNameX.Text))
            {
                MessageBox.Show("أدخل الأسم الجديد");
            }
            else if (String.IsNullOrEmpty(passwordBX.Text) || String.IsNullOrWhiteSpace(passwordBX.Text))
            {
                MessageBox.Show("أدخل الباسورد الجديد");
            }
            else if (userRoleX.SelectedIndex == -1)
            {
                MessageBox.Show("أختر الدرجة الجديدة");
            }
            else
            {
                db.updateUser(textBox5.Text, userRealNameX.Text, passwordBX.Text, userRoleX.SelectedIndex);
                db.viewUsers(usersDG);

                textBox2.Text = userRealNameX.Text;
                textBox7.Text = passwordBX.Text;
                textBox4.Text = userRoleX.Text;

                userRealNameX.Text = "";
                passwordBX.Text = "";
                userRoleX.Text = "";

            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("أختر أسم أولاً");
            }
            else
            {
                db.deleteUser(textBox5.Text);
                db.viewUsers(usersDG);
                textBox2.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox4.Text = "";

                userRealNameX.Text = "";
                passwordBX.Text = "";
                userRoleX.Text = "";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripDropDownButton7_Click(object sender, EventArgs e)
        {
            panels[0].BringToFront();
        }

        private void itemsReport_Click(object sender, EventArgs e)
        {
            panels[3].BringToFront();
            statusStrip1.Visible = true;
            db.getItemsReport(CRViewer);
        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AunitName.Text) || String.IsNullOrWhiteSpace(AunitName.Text))
            {
                MessageBox.Show("أضف أسم أولاً");
            }
            else
            {
                db.insertUnit(AunitName.Text);
                MessageBox.Show("تم إضافة الوحدة");
                AunitName.Text = "";
            }
        }

        private void updateUnitBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UunitOldName.Text) || String.IsNullOrWhiteSpace(UunitOldName.Text) || String.IsNullOrEmpty(UunitNewName.Text) || String.IsNullOrWhiteSpace(UunitNewName.Text))
            {
                MessageBox.Show("أحد المدخلات فارغة");
            }
            else
            {
                db.updateUnit(UunitOldName.Text, UunitNewName.Text);
                MessageBox.Show("تم تعديل الوحدة");
                UunitOldName.Text = "";
                UunitNewName.Text = "";
            }
        }

        private void الوحدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panels[14].BringToFront();
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown)
            {
                if (salesIsOpen == true)
                    cancelSaleBill_Click(sender, e);
                    salesIsOpen = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                payingAmount.Enabled = false;
                float previous = float.Parse(previousAmount.Text);
                float current = float.Parse(currentBill.Text);

                previousAmount.Text = (previous + current).ToString();
            }
            if (checkBox1.Checked == false)
            {
                payingAmount.Enabled = true;
                float previous = float.Parse(previousAmount.Text);
                float current = float.Parse(currentBill.Text);

                previousAmount.Text = (previous - current).ToString();
            }
        }

        private void printSaleBill_Click_1(object sender, EventArgs e)
        {
            string cName = customerName.Text;
            float previousCustomerBalance = db.getCustomerAmount(cName);
            int id = -1; 
            float current = float.Parse(currentBill.Text);
            float paying = 0;
            float previous = float.Parse(previousAmount.Text);
            ///Proccess payment
            if (checkBox1.Checked == false && payingAmount.Value == 0)
            {
                MessageBox.Show("حدد إذا كان الدفع آجر أو نقدي");
                return;
            }
            else if (checkBox1.Checked == true)
            {
                id = db.getCustomerID(cName);
                db.updateCustomerBalance(float.Parse(previousAmount.Text), id, cName);
                if(id == -1) id = db.getCustomerID(cName); // first time customer => call update to set id for customer then get it
                db.updatePaymentMethod(cName,1); // آجل
                db.insertPayment(id, current, 0 , previous);
            }
            else
            {
                previous = float.Parse(previousAmount.Text);
                current = float.Parse(currentBill.Text);
                paying = (float)payingAmount.Value;
                previous = (previous + (current - paying));
                id = db.getCustomerID(cName);
                db.updateCustomerBalance(previous, id, cName);
                if (id == -1) id = db.getCustomerID(cName);
                if (paying == current)
                {
                    db.updatePaymentMethod(cName, 2); // نقدى
                }
                else
                {
                    db.updatePaymentMethod(cName, 3); // جزئى
                }
                db.insertPayment(id, current, paying, previous);
            }

            foreach (DataGridViewRow row in saleBillGrid.Rows)
            {
                string name = row.Cells[0].Value.ToString();
                float unitPrice = (float)row.Cells[3].Value;
                float quantity = (float)row.Cells[1].Value;
                string unitName = row.Cells[2].Value.ToString(); ;
                float totalprice = (float)row.Cells[5].Value;
                float discount = (float)row.Cells[4].Value;
                int billId = int.Parse(saleBillNumber.Text);
                db.FinishSale(billId, name, quantity, unitName, unitPrice, totalprice, discount, float.Parse(saleTotalPrice.Text));
            }
            saleBillGrid.Rows.Clear();

            panels[3].BringToFront();
            ///                                                       الفاتورة الحالية
            db.getProfitReport(CRViewer, int.Parse(saleBillNumber.Text), current, paying, previousCustomerBalance); // الدفع + الفاتورة السابقة
            salesIsOpen = false;
            salesLamps(1);


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panels[16].BringToFront();
            db.viewItmes(dataGridView3);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.CurrentCell = null;

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().StartsWith(textBox6.Text.ToLower()))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panels[17].BringToFront();
            db.autoCompleteCustomersName(textBox8);
            groupBox13.Enabled = false;
            textBox8.Enabled = true;
            dataGridView4.Rows.Clear();
            textBox9.Clear();
            payMoney.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox8.Text.ToString();
            int  id = db.getCustomerID(name);
            if(id == -1)
            {
                MessageBox.Show("لا يوجد عميل بهذا الأسم");
            }
            else
            {
                textBox8.Enabled = false;
                groupBox13.Enabled = true;
                float depit = db.getCustomerAmount(id);
                db.viewcustomerHistory(dataGridView4, id);
                textBox9.Text = depit.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float previousBalance = float.Parse(textBox9.Text);
            if ((!Int64.TryParse(payMoney.Text, out parseInt) && !float.TryParse(payMoney.Text, out parsefloat)))
            {
                MessageBox.Show("أدخل قيمة الدفع بشكل صحيح");
            }
            else if(float.Parse(payMoney.Text) > previousBalance)
            {
                MessageBox.Show("أدخل مبلغ أصغر من أو مساوى لحساب العميل");
            }
            else
            {
                int id = db.getCustomerID(textBox8.Text);
                float paying = float.Parse(payMoney.Text);
                float newBalance = (previousBalance - paying);
                db.updateCustomerBalance(newBalance, id , (textBox8.Text).ToString());
                db.insertPayment(id, 0, paying, newBalance);

                //Update current page
                textBox9.Text = newBalance.ToString();
                db.viewcustomerHistory(dataGridView4, id);
                payMoney.Text = "";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Enabled = true;
            dataGridView4.Rows.Clear();
            textBox9.Clear();
            payMoney.Clear();
            groupBox13.Enabled = false;
        }

        private void buyItemsDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = buyItemsDG.Rows[e.RowIndex].Cells[0].Value.ToString();
            float itemQuantity = float.Parse(buyItemsDG.Rows[e.RowIndex].Cells[1].Value.ToString());
            string itemUnit = buyItemsDG.Rows[e.RowIndex].Cells[2].Value.ToString();
            float buyPrice = float.Parse(buyItemsDG.Rows[e.RowIndex].Cells[3].Value.ToString());
            float salePrice = float.Parse(buyItemsDG.Rows[e.RowIndex].Cells[4].Value.ToString());

            buyTotalPriceCheck.Text = (float.Parse(buyTotalPriceCheck.Text) - (itemQuantity * buyPrice)).ToString();
            buyItemsDG.Rows.RemoveAt(e.RowIndex);

            itemName.Text = name;
            quantity.Text = itemQuantity.ToString();
            unit.Text = itemUnit;
            bPrice.Text = buyPrice.ToString();
            sPrice.Text = salePrice.ToString();
        }

        private void buyItemsDG_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            float itemQuantity = float.Parse(buyItemsDG.SelectedRows[0].Cells[1].Value.ToString());
            float buyPrice = float.Parse(buyItemsDG.SelectedRows[0].Cells[3].Value.ToString());
            buyTotalPriceCheck.Text = (float.Parse(buyTotalPriceCheck.Text) - (itemQuantity * buyPrice)).ToString();
        }

        private void saleBillGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = saleBillGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            float itemQuantity = float.Parse(saleBillGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            string itemUnit = saleBillGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            float salePrice = float.Parse(saleBillGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
            float itemDiscount = float.Parse(saleBillGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

            saleTotalPrice.Text = (float.Parse(saleTotalPrice.Text) - ((itemQuantity * salePrice)-(itemQuantity * itemDiscount))).ToString();
            saleBillGrid.Rows.RemoveAt(e.RowIndex);

            saleItemName.Text = name;
            saleQuantity.Text = itemQuantity.ToString();
            discount.Text = itemDiscount.ToString();

            int id = db.getItemId(name);
            db.updateItemTotalQuantity(id , -itemQuantity);
        }


        private void cancelBuyBill_Click(object sender, EventArgs e)
        {
            int number = int.Parse(billNumber.Text);
            db.cancelBill(number);
            billNumber.Text = "";
            billPrice.Text = "";
            incName.Text = "";
            buyTotalPriceCheck.Text = "0";
            buyItemsDG.Rows.Clear();
            picture.Image = null;
            buyIsOpen = false;
            buyLamps(1);
        }
    }
}
