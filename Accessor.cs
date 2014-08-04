using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;



namespace LINQToSQL
{

    /// <summary>
    /// This class defines functions used to
    /// select, insert, update, and delete data
    /// using LINQ to SQL and the defined
    /// data context
    /// </summary>
    public class Accessor
    {


#region  Full Table

        // This section contains examples of
        // pulling back entire tables from
        // the database

        /// <summary>
        /// Displays the full Employee table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Employee> GetEmployeeTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Employee>();
        }


        /// <summary>
        /// Displays the full Shipper table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Shipper> GetShipperTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Shipper>();
        }


        /// <summary>
        /// Displays the full Order table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Order> GetOrderTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Order>();
        }


        /// <summary>
        /// Displays the full EmployeeTerritory table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<EmployeeTerritory> GetEmployeeTerritoryTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<EmployeeTerritory>();
        }


        /// <summary>
        /// Displays Territory Table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Territory> GetTerritoryTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Territory>();
        }


        /// <summary>
        /// Displays the full Region table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Region> GetRegionTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Region>();
        }


        /// <summary>
        /// Displays the full Customer table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Customer> GetCustomerTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Customer>();
        }


        /// <summary>
        /// Displays the full CustomerCustomerDemo table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<CustomerCustomerDemo> GetCustomerDemoTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<CustomerCustomerDemo>();
        }


        /// <summary>
        /// Displays the full CustomerDemographic table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<CustomerDemographic> GetCustomerDemographicTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<CustomerDemographic>();
        }


        /// <summary>
        /// Displays the full Order_Detail table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Order_Detail> GetOrderDetailsTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Order_Detail>();
        }


        /// <summary>
        /// Displays the full Product table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Product> GetProductTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Product>();
        }


        /// <summary>
        /// Displays the full Supplier table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Supplier> GetSupplierTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Supplier>();
        }


        /// <summary>
        /// Displays the full Category table
        /// </summary>
        /// <returns></returns>
        public static System.Data.Linq.Table<Category> GetCategoryTable()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.GetTable<Category>();
        }


#endregion



#region Queries

        // This region contains examples of some
        // of the sorts of queries that can be
        // executed using LINQ to SQL

        /// <summary>
        /// Example:  Where Clause
        /// Returns an employee where the
        /// employee ID matches the value
        /// passed in as empID
        /// </summary>
        /// <param name="empId"></param>
        /// <returns>The single matching or default value</returns>
        public static Employee GetEmployeeById(int empId)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from e in dc.GetTable<Employee>()
                    where (e.EmployeeID == empId)
                    select e).SingleOrDefault<Employee>();
        }
        public static Customer GetCustomerById(string cusId)
        {
            NorthWindDataClassesDataContext northwind = 
                new NorthWindDataClassesDataContext();

            var query = (from c in northwind.Customers
                    where (c.CustomerID == cusId)
                    select c).SingleOrDefault<Customer>();

            return query;
        }


        /// <summary>
        /// Example:  Select to a single returned object
        /// using a Where Clause
        /// 
        /// Returns the first matching order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns>The single matching or default value</returns>
        public static Order GetOrderById(int orderId)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from ord in dc.GetTable<Order>()
                    where (ord.OrderID == orderId)
                    select ord).SingleOrDefault<Order>();
        }



        /// <summary>
        /// Example:  Select to a typed List
        /// using a Where Clause
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static List<Order> GetOrdersById(int orderId)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from ord in dc.GetTable<Order>()
                    where (ord.OrderID == orderId)
                    select ord).ToList<Order>();
        }



        /// <summary>
        /// Example:  Return an ordered list
        /// 
        /// Converts the returned value to a List
        /// of type Employee; the list is ordered
        /// by hire date
        /// </summary>
        /// <returns></returns>
        public static List<Employee> GetEmployeesByHireDate()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return (from emp in dc.GetTable<Employee>()
                    orderby emp.HireDate ascending
                    select emp).ToList<Employee>();
        }




        /// <summary>
        /// This class is used to define the return type
        /// for the next function - OrdersAndDetails
        /// 
        /// When results are extracted from multiple tables
        /// you can either return the results as anonymous
        /// or as a type; this class defines the return
        /// type used by OrdersAndDetails
        /// </summary>
        public class OrdersAndDetailsResult
        {
            public System.String CustomerID
            { get; set; }
            public System.Nullable<System.DateTime> OrderDate
            { get; set; }
            public System.Nullable<System.DateTime> RequiredDate
            { get; set; }
            public System.String ShipAddress
            { get; set; }
            public System.String ShipCity
            { get; set; }
            public System.String ShipCountry
            { get; set; }
            public System.String ShipZip
            { get; set; }
            public System.String ShippedTo
            { get; set; }
            public System.Int32 OrderID
            { get; set; }
            public System.String NameOfProduct
            { get; set; }
            public System.String QtyPerUnit
            { get; set; }
            public System.Nullable<System.Decimal> Price
            { get; set; }
            public System.Int16 QtyOrdered
            { get; set; }
            public System.Single Discount
            { get; set; }
        }



        /// <summary>
        /// Example:  Joins
        /// Joining using the join keyword
        /// 
        /// The values are set to each of the
        /// properties contained in the 
        /// OrdersAndDetailsResult class
        /// 
        /// The value returned is converted
        /// to a list of the specified type
        /// </summary>
        /// <returns></returns>
        public static List<OrdersAndDetailsResult> OrdersAndDetails()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from ords in dc.GetTable<Order>()
                    join dets in dc.GetTable<Order_Detail>()
                        on ords.OrderID equals dets.OrderID
                    orderby ords.CustomerID ascending
                        select new OrdersAndDetailsResult
                        {
                            CustomerID = ords.CustomerID,
                            OrderDate = ords.OrderDate,
                            RequiredDate = ords.RequiredDate,
                            ShipAddress = ords.ShipAddress,
                            ShipCity = ords.ShipCity,
                            ShipCountry = ords.ShipCountry,
                            ShipZip = ords.ShipPostalCode,
                            ShippedTo = ords.ShipName,
                            OrderID = ords.OrderID,
                            NameOfProduct = dets.Product.ProductName,
                            QtyPerUnit = dets.Product.QuantityPerUnit,
                            Price = dets.Product.UnitPrice,
                            QtyOrdered = dets.Quantity,
                            Discount = dets.Discount
                        }
                    ).ToList <OrdersAndDetailsResult>();
        }


        /// <summary>
        /// Defined to support following function:
        /// GetOrderAndPricingInformation - this class
        /// supplies the return type for that function
        /// </summary>
        public class OrderandPricingResult
        {
            public System.Int32 OrderID
            { get; set; }
            public System.String Company
            { get; set; }
            public System.String OrderCountry
            { get; set; }
            public System.String ProductName
            { get; set; }
            public System.Nullable<System.Decimal> UnitPrice
            { get; set; }
            public System.Int16 UnitsOrder
            { get; set; }
            public System.String ShipperName
            { get; set; }
            public System.String SalesFirstName
            { get; set; }
            public System.String SalesLastName
            { get; set; }
            public System.String SalesTitle
            { get; set; }
        }


        /// <summary>
        /// Example:  Query across an entity ref
        /// This example collections information from the orders table
        /// and the order_details table through the orders table
        /// entity association to the orders_details table.  
        /// 
        /// An entity is a representation in the model of a table
        /// in the database, foreign key relationships are maintained
        /// as entity references to the related tables in the model.
        /// It is possible to query across tables through this
        /// relationship in LINQ to SQL
        /// </summary>
        /// <returns></returns>
        public static List<OrderandPricingResult> GetOrderAndPricingInformation()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from ords in dc.Orders			    // orders table
                    from dets in ords.Order_Details	    // entity set in orders table
                    select new OrderandPricingResult
                    { 
                        OrderID = ords.OrderID, 
                        Company =ords.Customer.CompanyName,   
                        OrderCountry = ords.Customer.Country,
                        ProductName = dets.Product.ProductName,
                        UnitPrice = dets.Product.UnitPrice,
                        UnitsOrder = dets.Quantity,
                        ShipperName = ords.Shipper.CompanyName,
                        SalesFirstName = ords.Employee.FirstName,
                        SalesLastName = ords.Employee.LastName,
                        SalesTitle = ords.Employee.Title
                    }).ToList < OrderandPricingResult>();
        }



        /// <summary>
        /// Example:  Query across entity ref with Where class
        /// Same as previous function with added where clause
        /// 
        /// An entity is a representation in the model of a table
        /// in the database, foreign key relationships are maintained
        /// as entity references to the related tables in the model.
        /// It is possible to query across tables through this
        /// relationship in LINQ to SQL
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public static List<OrderandPricingResult> GetOrderAndPricingInformationByOrderId(int orderId)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from ords in dc.Orders			    // orders table
                    from dets in ords.Order_Details	    // entity set in orders table
                    where ords.OrderID == orderId
                    select new OrderandPricingResult
                    {
                        OrderID = ords.OrderID,
                        Company = ords.Customer.CompanyName,
                        OrderCountry = ords.Customer.Country,
                        ProductName = dets.Product.ProductName,
                        UnitPrice = dets.Product.UnitPrice,
                        UnitsOrder = dets.Quantity,
                        ShipperName = ords.Shipper.CompanyName,
                        SalesFirstName = ords.Employee.FirstName,
                        SalesLastName = ords.Employee.LastName,
                        SalesTitle = ords.Employee.Title
                    }).ToList<OrderandPricingResult>();
        }


        /// <summary>
        /// Example:  Aggregation
        /// 
        /// Returns the total sum of the order 
        /// selected by order ID by selecting
        /// unit price multiplied by quantity
        /// ordered and then calling sum for 
        /// the total
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public static decimal? GetOrderValueByOrderId(int orderID)
        {

            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            var matches = 
                (from od in dc.GetTable<Order_Detail>()
                where od.OrderID == orderID
                select od.Product.UnitPrice * od.Quantity).Sum();

            return matches;
            
        }



        /// <summary>
        /// Example:  Using Take to get a limited
        /// number of returned values for display and 
        /// using Skip to sequence to a different 
        /// starting point within the returned values -
        /// can be used to navigate through a large
        /// list
        /// </summary>
        /// <param name="SkipNumber"></param>
        /// <returns></returns>
        public static List<Order> GetTopFiveOrdersById(int SkipNumber)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            return (from ord in dc.GetTable<Order>()
                    orderby ord.OrderID ascending
                    select ord).Skip(SkipNumber).Take(5).ToList<Order>();
        }



#endregion



#region Inserting, Updating, Deleting Data


        /// <summary>
        /// Insert or Update a Customer Record
        /// 
        /// If the customer ID exists, the existing
        /// customer record is updated.
        /// 
        /// If the customer ID does not exist, the
        /// new customer record is inserted into
        /// the database
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="companyName"></param>
        /// <param name="contactName"></param>
        /// <param name="contactTitle"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="postalCode"></param>
        /// <param name="country"></param>
        /// <param name="phone"></param>
        /// <param name="fax"></param>
        public static void InsertOrUpdateCustomer(string customerId, string companyName, 
            string contactName, string contactTitle, string address, string city, 
            string region, string postalCode, string country, string phone, string fax)
        {

            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            var matchedCustomer = (from c in dc.GetTable<Customer>()
                                   where c.CustomerID == customerId
                                   select c).SingleOrDefault();

            if(matchedCustomer == null)
            {
                try
                {
                    // create new customer record since customer ID
                    // does not exist
                    Table<Customer> customers = Accessor.GetCustomerTable();
                    Customer cust = new Customer();

                    cust.CustomerID = customerId;
                    cust.CompanyName = companyName;
                    cust.ContactName = contactName;
                    cust.ContactTitle = contactTitle;
                    cust.Address = address;
                    cust.City = city;
                    cust.Region = region;
                    cust.PostalCode = postalCode;
                    cust.Country = country;
                    cust.Phone = phone;
                    cust.Fax = fax;

                    customers.InsertOnSubmit(cust);
                    customers.Context.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }  
            }
            else
            {
                try
                {
                    matchedCustomer.CompanyName = companyName;
                    matchedCustomer.ContactName = contactName;
                    matchedCustomer.ContactTitle = contactTitle;
                    matchedCustomer.Address = address;
                    matchedCustomer.City = city;
                    matchedCustomer.Region = region;
                    matchedCustomer.PostalCode = postalCode;
                    matchedCustomer.Country = country;
                    matchedCustomer.Phone = phone;
                    matchedCustomer.Fax = fax;

                    dc.SubmitChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }


        /// <summary>
        /// Delete a customer by customer ID
        /// </summary>
        /// <param name="customerID"></param>
        public static void DeleteCustomer(string customerID)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();

            var matchedCustomer = (from c in dc.GetTable<Customer>()
                                   where c.CustomerID == customerID
                                   select c).SingleOrDefault();

            try
            {
                dc.Customers.DeleteOnSubmit(matchedCustomer);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


#endregion



#region Stored Procedures


        /// <summary>
        /// Stored Procedure:  Sales By Year
        /// </summary>
        /// <param name="beginningYear"></param>
        /// <param name="endingYear"></param>
        /// <returns></returns>
        /// Thomas
        public static List<Sales_by_YearResult> SalesByYear(DateTime? beginningYear, DateTime? endingYear)
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.Sales_by_Year(beginningYear, endingYear).ToList<Sales_by_YearResult>();
        }



        /// <summary>
        /// Stored Procedure:  Ten Most Expenisve Products
        /// </summary>
        /// <returns></returns>
        public static List<Ten_Most_Expensive_ProductsResult> TenMostExpensiveProducts()
        {
            NorthWindDataClassesDataContext dc = new NorthWindDataClassesDataContext();
            return dc.Ten_Most_Expensive_Products().ToList<Ten_Most_Expensive_ProductsResult>();

        }


#endregion


    }
}
