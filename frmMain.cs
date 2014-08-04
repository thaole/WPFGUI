using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace LINQToSQL
{

    /// <summary>
    /// This class is used to demonstrate each of the
    /// queries defined in the accessor class
    /// </summary>
    public partial class frmMain : Form
    {
        // used to support take/skip example
        private int OrderPosition;



#region Constructor

        public frmMain()
        {
            InitializeComponent();

            // set order position to zero
            OrderPosition = 0;
        }

#endregion



#region  Full Table Requests

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Employee> emp = Accessor.GetEmployeeTable();
            dataGridView1.DataSource = emp;
        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Shipper> ship = Accessor.GetShipperTable();
            dataGridView1.DataSource = ship;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Order> orders = Accessor.GetOrderTable();
            dataGridView1.DataSource = orders;
        }

        private void employeeTerritoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<EmployeeTerritory> empTerrs = Accessor.GetEmployeeTerritoryTable();
            dataGridView1.DataSource = empTerrs;
        }

        private void territoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Territory> terrs = Accessor.GetTerritoryTable();
            dataGridView1.DataSource = terrs;
        }

        private void regionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Region> regs = Accessor.GetRegionTable();
            dataGridView1.DataSource = regs;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Customer> cust = Accessor.GetCustomerTable();
            dataGridView1.DataSource = cust;
        }

        private void customerDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<CustomerCustomerDemo> custdemo = Accessor.GetCustomerDemoTable();
            dataGridView1.DataSource = custdemo;
        }

        private void customerDemographicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<CustomerDemographic> custdemograph = Accessor.GetCustomerDemographicTable();
            dataGridView1.DataSource = custdemograph;
        }


        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Order_Detail> ordDetails = Accessor.GetOrderDetailsTable();
            dataGridView1.DataSource = ordDetails;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Product> prods = Accessor.GetProductTable();
            dataGridView1.DataSource = prods;
        }

        private void supplierProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Supplier> prods = Accessor.GetSupplierTable();
            dataGridView1.DataSource = prods;
        }

        private void categoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Data.Linq.Table<Category> cats = Accessor.GetCategoryTable();
            dataGridView1.DataSource = cats;
        }

#endregion



#region Queries


        /// <summary>
        /// Find and display an employee by 
        /// the employee's ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Employee emp = Accessor.GetEmployeeById(1);

            StringBuilder sb = new StringBuilder();
            sb.Append("Employee 1: " + Environment.NewLine);
            sb.Append("Name: " + emp.FirstName + " " + emp.LastName + Environment.NewLine);
            sb.Append("Hire Date: " + emp.HireDate + Environment.NewLine);
            sb.Append("Home Phone: " + emp.HomePhone + Environment.NewLine);

            MessageBox.Show(sb.ToString(), "Employee ID Search");
        }


        /// <summary>
        /// Gets an Order by the order ID and
        /// displays information about the first
        /// single matching order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order ord = Accessor.GetOrderById(10248);

            StringBuilder sb = new StringBuilder();
            sb.Append("Order: " + Environment.NewLine);
            sb.Append("Order ID: " + ord.OrderID + Environment.NewLine);
            sb.Append("Date Shipped: " + ord.ShippedDate + Environment.NewLine);
            sb.Append("Shipping Address: " + ord.ShipAddress + Environment.NewLine);
            sb.Append("         City: " + ord.ShipCity + Environment.NewLine);
            sb.Append("         Region: " + ord.ShipRegion + Environment.NewLine);
            sb.Append("         Country: " + ord.ShipCountry + Environment.NewLine);
            sb.Append("         Postal Code: " + ord.ShipPostalCode + Environment.NewLine);
            sb.Append("Shipping Name: " + ord.ShipName + Environment.NewLine);

            MessageBox.Show(sb.ToString(), "Shipping Information");
        }



        /// <summary>
        /// Displays a list of employeess ordered by
        /// their dates of hire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeesByHireDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Employee> emps = Accessor.GetEmployeesByHireDate();
            dataGridView1.DataSource = emps;
        }


        /// <summary>
        /// Displays all orders that match
        /// on Order ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Order> orders = Accessor.GetOrdersById(10248);
            dataGridView1.DataSource = orders;
        }

        /// <summary>
        /// Returns values based on joining the Order and
        /// Order_Details tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersAndDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Accessor.OrdersAndDetailsResult> oad = Accessor.OrdersAndDetails();
            dataGridView1.DataSource = oad;
        }


        /// <summary>
        /// Query across entity set
        /// This example collections information from the orders table
        /// and the order_details table through the orders table
        /// entity reference to orders_details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersAndDetailsEntityRefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Accessor.OrderandPricingResult> opr = Accessor.GetOrderAndPricingInformation();
            dataGridView1.DataSource = opr;
        }



        /// <summary>
        /// Retrieves values across an entity set to 
        /// display both order and pricing information 
        /// by filtering for an order ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersAndDetailsByOrderIDEntityRefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Accessor.OrderandPricingResult> opr = Accessor.GetOrderAndPricingInformationByOrderId(10248);
            dataGridView1.DataSource = opr;
        }



        /// <summary>
        /// Displays to total dollar value of the selected order
        /// by multiplying each order product's unit cost by
        /// the units ordered, and then summing the total of each
        /// individual cost.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderValueByOrderIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the dollar value
            decimal? d = Accessor.GetOrderValueByOrderId(10248);

            // convert the decimal value to currency
            string dollarValue = string.Format("{0:c}", d);
            
            // display the dollar value
            MessageBox.Show("The total dollar value of order 10248 is " +
                dollarValue, "Order 10248 Value");
        }



        /// <summary>
        /// Displays the top five orders in the order table
        /// on first selection and then increments up by
        /// five orders to show the list five orders
        /// at a time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getTopFiveOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // get the top five orders starting at the current position
                List<Order> ords = Accessor.GetTopFiveOrdersById(OrderPosition);
                dataGridView1.DataSource = ords;

                // increment the formwide variable used to
                // keep track of the position within the 
                // list of orders
                OrderPosition += 5;

                // change the text in the menu strip item
                // to show that it will retrieve the next
                // five values after the current position 
                // of th last value shown in the grid
                getTopFiveOrdersToolStripMenuItem.Text = "Get Next Five Orders";
            }
            catch
            {
                MessageBox.Show("Cannot increment an higher, starting list over.");
                OrderPosition = 0;
            }
        }

#endregion



#region Insert Update Delete


        private void insertOrUpdateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Accessor.InsertOrUpdateCustomer("AAAAA", "BXSW", "Mookie Carbunkle", "Chieftain",
                    "122 North Main Street", "Wamucka", "DC", "78888", "USA", "244-233-8977",
                    "244-438-2933");
                loadCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NorthWindDataClassesDataContext dbNorthwind
                = new NorthWindDataClassesDataContext();
                var matchedCustomer = (from c in dbNorthwind.GetTable<Customer>()
                                       where c.CustomerID == "ABABA"
                                       select c).Single();
                dbNorthwind.Customers.DeleteOnSubmit(matchedCustomer);
                dbNorthwind.SubmitChanges();
                MessageBox.Show("Customer successfully deleted!");
                loadCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


#endregion



#region Stored Procedures

        /// <summary>
        /// Execute stored procedure: Sales By Year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesByYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(1990, 1, 1);
            DateTime end = new DateTime(2000, 1, 1);

            List<Sales_by_YearResult> result = Accessor.SalesByYear(start, end);
            dataGridView1.DataSource = result;
        }



        /// <summary>
        /// Execute stored procedure: Ten Most Expensive Products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tenMostExpensiveProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Ten_Most_Expensive_ProductsResult> result = Accessor.TenMostExpensiveProducts();
            dataGridView1.DataSource = result;
        }


#endregion


#region Housekeeping

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

#endregion

        private void customerByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = Accessor.GetCustomerById("ALFKI");

            StringBuilder sb = new StringBuilder();
            sb.Append("Customer 1: " + Environment.NewLine);
            sb.Append("Contact Name: " + cust.ContactName + Environment.NewLine);
            sb.Append("Company Name: " + cust.CompanyName + Environment.NewLine);
            sb.Append("Address     : " + cust.Address + Environment.NewLine);

            MessageBox.Show(sb.ToString(), "Customer ID Search");
        }

        private void insertCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NorthWindDataClassesDataContext dbNorthwind 
                    = new NorthWindDataClassesDataContext();
                Customer cust = new Customer();
                cust.CustomerID = "ABABA";
                cust.CompanyName = "Enclave";
                cust.ContactName = "Hue";
                cust.ContactTitle = "Hue.NGUEN";
                cust.Address = "127-Huynh Thuc Khang-Hai Chau";
                cust.City = "Da Nang";
                cust.Region = "Middle";
                cust.PostalCode = "70000";
                cust.Country = "Viet Nam";
                cust.Phone = "0975544516";
                cust.Fax = "i don't know :D";
                dbNorthwind.Customers.InsertOnSubmit(cust);
                dbNorthwind.SubmitChanges();

                MessageBox.Show("Customer successfully inserted!");
                loadCustomer();
                
            }
            catch (Exception)
            {
                
                throw;
            }
                        
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            NorthWindDataClassesDataContext dbNorthwind 
                = new NorthWindDataClassesDataContext();
            var matchedCustomer = (from c in dbNorthwind.GetTable<Customer>()
                                   where c.CustomerID == "ABABA"
                                   select c).SingleOrDefault();
            if (matchedCustomer!=null)
            {
                matchedCustomer.ContactName = "Hoa";
                matchedCustomer.ContactTitle = "Hoa.PHAN";
                dbNorthwind.SubmitChanges();
                MessageBox.Show("Customer successfully changed!");
                loadCustomer();
            }}
            
            catch (Exception)
            {
                
                throw;
            }

            

        }

        private void insertMultilFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NorthWindDataClassesDataContext dbNorthwind
                    = new NorthWindDataClassesDataContext();                
                List<Customer> cus = new List<Customer>();
                cus.Add(
                    new Customer
                    {
                        CustomerID = "ABBBB",CompanyName = "Enclave",
                        ContactName = "Linh",ContactTitle = "Linh.DINH",
                        Address = "127-Huynh Thuc Khang-Hai Chau",
                        City = "Da Nang",Region = "Middle",
                        PostalCode = "70000",Country = "Viet Nam",  
                        Phone = "0975544516",Fax = "i don't know :D"
                    }                    
                    );
                cus.Add(
                    new Customer
                    {
                        CustomerID = "ABCCC",CompanyName = "Enclave",
                        ContactName = "Hoa",ContactTitle = "Hoa.PHAN",
                        Address = "127-Huynh Thuc Khang-Hai Chau",
                        City = "Da Nang",Region = "Middle",
                        PostalCode = "70000",Country = "Viet Nam",
                        Phone = "0975544516",Fax = "i don't know :D"
                    }
                    );
                dbNorthwind.Customers.InsertAllOnSubmit(cus);
                dbNorthwind.SubmitChanges();
                MessageBox.Show("Customers successfully inserted!");
                loadCustomer();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void deleteManyFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NorthWindDataClassesDataContext dbNorthwind
                = new NorthWindDataClassesDataContext();
                var matchedCustomer = (from c in dbNorthwind.GetTable<Customer>()
                                       where c.CustomerID.StartsWith("AB")
                                       select c);
                dbNorthwind.Customers.DeleteAllOnSubmit(matchedCustomer);
                dbNorthwind.SubmitChanges();
                MessageBox.Show("Customer successfully deleted!");
                loadCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void getProductByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            List<Product> prd = dc.GetProductsByCategory(1).ToList();
            dataGridView1.DataSource = prd;
        }

        private void handlelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? count = 0;
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            List<GetProductNameByCategoryIDResult> prd
                = dc.GetProductNameByCategoryID(1, ref count).ToList();
            dataGridView1.DataSource = prd;
            MessageBox.Show("Records found: "+ count);
        }

        private void supportingUserDefinedFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            var products = from p in dc.Products
                           select new
                           {
                               NAME = dc.MyUpperFunction(p.ProductName)
                           };
            dataGridView1.DataSource = products;  
        }
        public void loadCustomer()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            var cust = from c in dc.Customers
                       orderby c.CustomerID
                       select c;
            dataGridView1.DataSource = cust;
        }

    }
}
