using Azure.Core;
using Microsoft.SqlServer.Server;
using System;
using System.Data;
using System.Windows.Forms;


namespace Restaurant_DB
{
    public class Controller
    {
        DBManager dbMan;
        
        public Controller()
        {
            dbMan = new DBManager();
        }
        //SQL Queries to be added here, just like back in ~nam~ labs

        public object findPassword(string userName)
        {
            string query = "SELECT EPASSWORD " +
                "FROM EMPLOYEE " +
                "WHERE EMPLOYEE.SSN = '" + userName + "';";
            if (dbMan.ExecuteScalar(query) != null)
            {
                return dbMan.ExecuteScalar(query);
            }
            else
            {
                query = "SELECT EPASSWORD " +
                    "FROM CUSTOMER " +
                    "WHERE CUSTOMER.PHONENUMBER = '" + userName + "';";
                return dbMan.ExecuteScalar(query);
            }
        }

        public object findPosition(string userName)
        {
            string query = "SELECT POSITION " +
                "FROM EMPLOYEE " +
                "WHERE SSN = '" + userName + "';";
           if (dbMan.ExecuteScalar(query) != null)
           {
                return dbMan.ExecuteScalar(query);
           }
           else
           {
                object position = "Customer";
                return position;
           }
        }

        //dont touch keep scrolling >:(
        public object checktableexists(int tnumber) //checks if table exists returns 1 if it does and 0 if it doesnt
        {
            string query = "SELECT COUNT(*) FROM RestaurantTable WHERE TableNumber=" + tnumber + ";";
            return dbMan.ExecuteScalar(query);
        }

        public object checktable(int tnumber) //returns the id of the table if it exists and null if it doesnt (could be used instead of the above)
        {
            string query = "SELECT CustomerPhoneNumber FROM RestaurantTable WHERE TableNumber=" + tnumber + ";";
            return dbMan.ExecuteScalar(query);
        }
        public void reservetable(int tnumber,string phone) //reserves a table by setting a phone number next to the table number
        {
            string query = "UPDATE RestaurantTable SET CustomerPhoneNumber='"+phone+"' WHERE TableNumber="+tnumber+";";
            dbMan.ExecuteNonQuery(query);
        }

        public object checktablereserved(int tno) // checks if the table is reserved by our customer... he better not be trolling the restaurant
        {
            string query = "SELECT COUNT(*) FROM RestaurantTable WHERE TableNumber=" + tno + " AND CustomerPhoneNumber IS NOT NULL;";
            return dbMan.ExecuteScalar(query);
        }
        public void freetable(int tnumber) // frees a reserved table
        {
            string query = "UPDATE RestaurantTable SET CustomerPhoneNumber=NULL WHERE TableNumber=" + tnumber + ";";
            dbMan.ExecuteNonQuery(query);
        }

        public void inserttable() //adds a new table to the restaurant congratulations
        {
            string query = "INSERT INTO RestaurantTable (CustomerPhoneNumber) VALUES(NULL);";
            dbMan.ExecuteNonQuery(query);
        }

        public DataTable gettables() // get all tables inside the restaurant... to help the lazy waiter to keep track of the table
        {
            string query = "SELECT * FROM RestaurantTable;";
            return dbMan.ExecuteReader(query);
        }
        
        public object checkcustomerexist(string phone) // check if our beloved customer is in our dumb system
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE PhoneNumber='" + phone + "';";
            return dbMan.ExecuteScalar(query);
        }
        public object checkphonenumber(string phone) //check if the phone number exists (returns 1 if it does and 0 if it doesnt)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE PhoneNumber='"+phone+"';";
            return dbMan.ExecuteScalar(query);
        }

        public object checklocationexist(string city, string street, string building) //returns locationid if that location alrdy exists in our system and null if it doesnt
        {
            string query = "SELECT LocationID FROM Locations WHERE City='" + city + "' AND Street='" + street + "' AND Building='" + building + "';";

            return dbMan.ExecuteScalar(query);
        }

        public void insertlocationid(string city,string street,string building)//insert the locationid in case it doesnt
        {
            string query = "INSERT INTO Locations (City, Street, Building) VALUES('" + city + "', '" + street + "', '" + building + "');";
            dbMan.ExecuteNonQuery(query);
        }

        public object checkassignedlocation(string phone, int locationid) //returns 1 if our beloved customer has the location with the following id assigned to him
        {
            string query = "SELECT COUNT(*) FROM CustomerLocations WHERE PhoneNumber='"+phone+"' AND LocationID="+locationid+";";
            return dbMan.ExecuteScalar(query);
        }
        public void insertlocation(string phone, int id) //insert a new location to our customer... why did you have to move out
        {
            string query = "INSERT INTO CustomerLocations (PhoneNumber, LocationID) VALUES ('" + phone + "', " + id + ");";
            dbMan.ExecuteNonQuery(query);
        }

        public void deletelocation(string phone, int id) //removes a location from our beloved customer after he moved out... just why
        {
            string query = "DELETE FROM CustomerLocations WHERE PhoneNumber='" + phone + "' AND LocationID=" + id + ";";
            dbMan.ExecuteNonQuery(query);
        }

        public void deletetable(int tableno) //remove a table from the restaurant.. who broke that table???
        {
            string query = "DELETE FROM RestaurantTable WHERE TableNumber="+tableno+";";
            dbMan.ExecuteNonQuery(query);
        }

        public DataTable getlocations(string phone)
        {
            string query = "SELECT LocationID, City, Street, Building FROM Locations WHERE LocationID IN (SELECT LocationID FROM CustomerLocations WHERE PhoneNumber='" + phone + "');";
            return dbMan.ExecuteReader(query);
        }
        public void deletelocationwid(string phone, object id)
        {
            string query = "DELETE FROM CustomerLocations WHERE PhoneNumber='" + phone + "' AND LocationID=" + Convert.ToInt32(id) + ";";
            dbMan.ExecuteNonQuery(query);
        }
        public DataTable getcustomerinfo(string phone)
        {
            string query = "SELECT * FROM Customer WHERE PhoneNumber='"+phone+"';";
            return dbMan.ExecuteReader(query);
        }

        public void cancelorder(int orderid) 
        {
            string query = "UPDATE CustomerOrder SET OrderState = 'Cancelled' WHERE OrderID ="+orderid+";";
            dbMan.ExecuteNonQuery(query);
        }

        public void deliverorder(int orderid)
        {
            string query = "UPDATE CustomerOrder SET OrderState = 'Delivered' WHERE OrderID =" + orderid + ";";
            dbMan.ExecuteNonQuery(query);
        }
        //you can edit the ones below :)

        //----------------- ABDELRAHMAN ZAKARIA ---------------------
        public string GetCustomerFName(string phoneNumber)  //returns the first name of the customer
        {
            string query = "SELECT FName FROM Customer WHERE PhoneNumber='" + phoneNumber + "';";
            object fname = dbMan.ExecuteScalar(query);
            if (fname != null)
            {
                return fname.ToString();
            }
            else
            {
                return "";
            }
        
        }

        public string getEmployeeName(string SSN)
        {
            string query = "SELECT FName FROM Employee WHERE SSN = '" + SSN + "';";
            return dbMan.ExecuteScalar(query).ToString();
        }

       public void addCustomer(string phone, string fName, string lName, string passWord)
        {
            string query = "INSERT INTO CUSTOMER (PhoneNumber, FName, LName, EPassword) " +
                "VALUES ('" + phone + "', '" + fName + "', '" + lName + "', '"+ passWord +"');";
            dbMan.ExecuteNonQuery(query);
        }

       public string VerifyCustomer(string phoneNumber)  //sees if the customer exists
        {
            string query="SELECT FName FROM Customer WHERE PhoneNumber='"+phoneNumber+"';";

            object fname = dbMan.ExecuteScalar(query);

            if (fname != null)
            {
                return fname.ToString();
            }
            else
            {
                return "";
            }
        }

        public DataTable LoadCustomerOrdersCurret(string phoneNumber)  //loads the orders of the customer
        {
            string query = "SELECT * FROM CustomerOrder WHERE CustomerPhoneNumber = '" + phoneNumber + "' AND (OrderState = 'Pending' OR OrderState = 'Approved' OR OrderState = 'Cooking' OR OrderState = 'Ready');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable LoadWaiterOrdersCurret(string waiterSSN)  //loads the orders of the waiter
        {
            string query = "SELECT * FROM CustomerOrder WHERE WaiterSSN = '" + waiterSSN + "' AND (OrderState = 'Pending' OR OrderState = 'Approved' OR OrderState = 'Cooking' OR OrderState = 'Ready');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable loadCustomerOrdersPrevious(string phoneNumber)
        {
            string query = "SELECT * FROM CustomerOrder WHERE CustomerPhoneNumber = '" + phoneNumber + "' AND (OrderState = 'Delivered' OR OrderState = 'Rejected' OR OrderState = 'Cancelled');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public DataTable loadWaiterOrdersPrevious(string waiterSSN)
        {
            string query = "SELECT * FROM CustomerOrder WHERE WaiterSSN = '" + waiterSSN + "' AND (OrderState = 'Delivered' OR OrderState = 'Rejected' Or OrderState = 'Cancelled');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }

        public object MakeOrder(string orderstate, DateTime orderDate, string phonenumber, string WaiterSSN)  //inserts the order of the customer
        {
            string query = "INSERT INTO CustomerOrder (OrderState, OrderDate, CustomerPhoneNumber, WaiterSSN) VALUES('" + orderstate + "', '" + orderDate + "', '" + phonenumber + "','" + WaiterSSN +"');";
            dbMan.ExecuteNonQuery(query);
            query = "SELECT OrderID FROM CustomerOrder WHERE CustomerPhoneNumber = '" + phonenumber + "' AND OrderDate = '" + orderDate + "';";
            return dbMan.ExecuteScalar(query);
        }
        
        public object makeOrderOnline (DateTime orderDate, string phoneNumber)
        {
            string query = "INSERT INTO CustomerOrder (OrderDate, CustomerPhoneNumber) VALUES('" + orderDate + "', '" + phoneNumber + "');";
            dbMan.ExecuteNonQuery(query);
            query = "SELECT OrderID FROM CustomerOrder WHERE CustomerPhoneNumber = '" + phoneNumber + "' AND OrderDate = '" + orderDate + "';";
            return dbMan.ExecuteScalar(query);
        }

        public void addToOrder(int orderID, int itemID, int Quantity)
        {
            string query = "INSERT INTO Order_Contains_MenuItem (OrderID, ItemID, Quantity) VALUES(" + orderID + "," + itemID + "," + Quantity + ");";
            dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetMenuItems()  //loads the menu of the restaurant
        {  
            string query = "SELECT ItemID, ItemName, ItemStatus, CookingTime FROM MenuItem;";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("No Menu Items found.");
                return null;
            }
        }

        public DataTable GetMenuItemPrice()  //returns the price of the menu item
        {
            string query = "SELECT MenuItem.*, SUM(IngredientPrice) as TotalPrice " +
            "FROM MenuItem, ContainsIngredient, Ingredient " +
            "WHERE MenuItem.ItemID = ContainsIngredient.ItemID AND Ingredient.IngredientID = ContainsIngredient.IngredientID " +
            "GROUP BY MenuItem.ItemID, MenuItem.ItemName, MenuItem.CookingTime, MenuItem.ItemStatus, MenuItem.ChefSSN " +
            "ORDER BY ItemName";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("Failed to get menu item price.");
                return null;
            }
        }

        public DataTable getIngredients()
        {
            string query = "SELECT * FROM Ingredient";
            return dbMan.ExecuteReader(query);
        }

        public void addIngredientToItem(int ingredientID, int itemID, int count)
        {
            string query = "INSERT INTO ContainsIngredient (ItemID, IngredientID, Quantity) VALUES (" + itemID + "," + ingredientID + "," + count + ")";
            dbMan.ExecuteNonQuery(query);
        }

        public DataTable getCustomerLocations(string phone) //returns locationid if that location alrdy exists in our system and null if it doesnt
        {
            string query = "SELECT * FROM Locations WHERE LocationID IN (SELECT LocationID FROM CustomerLocations WHERE PhoneNumber = '" + phone + "');";

            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("Failed to get addresses of the customer.");
                return null;
            }
        }

        public void UpdateCustomerName(string phone, string fname, string lname) //updates the name of the customer
        {
            string query = "UPDATE Customer SET FName='" + fname + "', LName='" + lname + "' WHERE PhoneNumber='" + phone + "';";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Name updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update name.");
            }
        }
        
        
        public void UpdateAddress(string phone, int oldlocationid, int newlocationid) //updates the address of the customer
        { 
            //update customer location
            string query = "UPDATE CustomerLocations SET LocationID = " + newlocationid + " WHERE PhoneNumber = '" + phone + "' AND LocationID = " + oldlocationid + ";";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Address updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update address.");
            }
        }

        public DataTable GetTotalSpendings(string phone)
        {
            string query = "SELECT co.CustomerPhoneNumber, SUM(ocmi.Quantity * ci.Quantity * i.IngredientPrice) AS TotalSpendings " +
            "FROM CustomerOrder co " +
            "JOIN Order_Contains_MenuItem ocmi ON co.OrderID = ocmi.OrderID " +
            "JOIN MenuItem mi ON ocmi.ItemID = mi.ItemID " +
            "JOIN ContainsIngredient ci ON mi.ItemID = ci.ItemID " +
            "JOIN Ingredient i ON ci.IngredientID = i.IngredientID " +
            "WHERE co.CustomerPhoneNumber = '" + phone + "' " +
            "GROUP BY co.CustomerPhoneNumber";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSpendingPerItem(string phone)
        {
            string query = "SELECT mi.ItemName, SUM(ocmi.Quantity * ci.Quantity * i.IngredientPrice) AS TotalSpent " +
            "FROM CustomerOrder co " +
            "JOIN Order_Contains_MenuItem ocmi ON co.OrderID = ocmi.OrderID " +
            "JOIN MenuItem mi ON ocmi.ItemID = mi.ItemID " +
            "JOIN ContainsIngredient ci ON mi.ItemID = ci.ItemID " +
            "JOIN Ingredient i ON ci.IngredientID = i.IngredientID " +
            "WHERE co.CustomerPhoneNumber = '" + phone + "' " +
            "GROUP BY mi.ItemName " +
            "ORDER BY TotalSpent DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMostBoughtItem(string phone)
        {
            string query ="SELECT mi.ItemName, SUM(ocmi.Quantity) AS TotalQuantity " +
            "FROM CustomerOrder co " +
            "JOIN Order_Contains_MenuItem ocmi ON co.OrderID = ocmi.OrderID " +
            "JOIN MenuItem mi ON ocmi.ItemID = mi.ItemID " +
            "WHERE co.CustomerPhoneNumber = '" + phone + "' " +
            "GROUP BY mi.ItemName " +
            "ORDER BY TotalQuantity DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetEmployeesByWorkingHours()
        {
            string query = "SELECT FName, LName, WorkingHours " +
            "FROM Employee " +
            "ORDER BY WorkingHours DESC;";

            return dbMan.ExecuteReader(query);
        }


        public DataTable GetRestaurantIncome()
        {
            string query = "SELECT SUM(ocmi.Quantity * ci.Quantity * i.IngredientPrice) AS TotalIncome " +
                "FROM Order_Contains_MenuItem ocmi " +
                "JOIN MenuItem mi ON ocmi.ItemID = mi.ItemID " +
                "JOIN ContainsIngredient ci ON mi.ItemID = ci.ItemID " +
                "JOIN Ingredient i ON ci.IngredientID = i.IngredientID;";
            return dbMan.ExecuteReader(query);
        }

        public float GetRestaurantSpendingOnIngredients()
        {
            string query = "SELECT SUM(r.Quantity * i.IngredientPrice) AS TotalSpending " +
                "FROM Request r " +
                "JOIN Ingredient i ON r.IngredientID = i.IngredientID;";
            return Convert.ToSingle(dbMan.ExecuteScalar(query));
        }

        public float GetTotalSalaries()
        {
            string query = "SELECT SUM(Salary) AS TotalSalaries " +
                "FROM Employee;";
            return Convert.ToSingle(dbMan.ExecuteScalar(query));
        }

        public DataTable GetTopThreeMostOrderedItems()
        {
            string query =
                "SELECT TOP 3 mi.ItemName, COUNT(ocmi.OrderID) AS OrderCount " +
                "FROM MenuItem mi " +
                "JOIN Order_Contains_MenuItem ocmi ON mi.ItemID = ocmi.ItemID " +
                "GROUP BY mi.ItemName " +
                "ORDER BY OrderCount DESC;";

            return dbMan.ExecuteReader(query);
        }
        

        //--------------------ALAA HAYTHAM----------------------
        public int UpdateEmployee(long ssn, string fname, string lname,string position,long hours,decimal salary,string city,string street,string building,string password)
        {
            string query = "UPDATE Employee SET  FName = '"+fname+ "',LName = '"+lname+"', Position = '"+position+"',   WorkingHours = "+hours+",   Salary = "+salary+",  City = '"+city+"',  Street = '"+street+"',  Building = '"+building+"', EPassword = '"+password+"'" +
                "WHERE   SSN = "+ssn+";";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update Data.");
            }
            return rowsAffected;
        }
        public DataTable ReviewOrder()
        {
            string query = "SELECT CO.OrderID,  CO.OrderDate, CO.OrderState, CO.OrderFeedback,c.FName AS CustomerFirstName,  c.LName AS CustomerLastName,  e.FName AS WaiterFirstName,  e.LName AS WaiterLastName,  mi.ItemName,    ocm.Quantity FROM  CustomerOrder  CO  JOIN   Customer c ON CO.CustomerPhoneNumber = c.PhoneNumber LEFT JOIN    Employee e ON CO.WaiterSSN = e.SSN JOIN   Order_Contains_MenuItem ocm ON CO.OrderID = ocm.OrderID JOIN   MenuItem mi ON ocm.ItemID = mi.ItemID JOIN  ContainsIngredient ci ON mi.ItemID = ci.ItemID JOIN  Ingredient i ON ci.IngredientID = i.IngredientID ORDER BY   CO.OrderDate DESC, CO.OrderID;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable viewPendingOrder()
        {
            string query = "SELECT e.FName AS ChefFirstName,  e.LName AS ChefLastName, i.IngredientName,   r.RequestStatus FROM     Request r JOIN    Employee e ON r.ChefSSN = e.SSN JOIN   Ingredient i ON r.IngredientID = i.IngredientID WHERE    r.RequestStatus = 'Pending';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable selectPosition()
        {
            string query = "select distinct Position from Employee";
            return dbMan.ExecuteReader(query);
        }
        public DataTable selectitempending()
        {
            string query = "SELECT i.IngredientName, r.ID FROM Request r JOIN Ingredient i ON r.IngredientID = i.IngredientID WHERE r.RequestStatus = 'Pending'";
            return dbMan.ExecuteReader(query);
        }

        public void approvepending(int id)
        {
            string query = "UPDATE Request SET RequestStatus='Approved'" +
              "WHERE ID="+id+";";
            dbMan.ExecuteNonQuery(query);
        }

        public int insertEmployee(long ssn, string fname, string lname, string position, long hours, decimal salary,string Superssn, string city, string street, string building, string password)
        {
            string query = "INSERT INTO Employee (SSN, FName, LName, Position, WorkingHours, Salary, SuperSSN, City, Street, Building,EPassword) VALUES   ("+ssn+", '"+fname+"', '"+lname+"', '"+position+"', "+hours+", "+salary+", "+Superssn+", '"+city+"', '"+street+"', '"+building+"', '"+password+"');";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Inserted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to insert Data.");
            }
            return rowsAffected;
        }
        public void changepending(string IngredientName)
        {
            //still not done (I HATE QUEREYS )
            string query = "UPDATE Request" +
                "SET RequestStatus = 'Approved'" +
                "WHERE  IngredientName= '"+ IngredientName + "' ";

        }
        public DataTable GetAllEmployees()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetEmployeeDetails(string ssn)
        {
            string query = "SELECT FName, LName, Position, WorkingHours, Salary, City, Street, Building FROM Employee WHERE SSN='" + ssn + "';";
            return dbMan.ExecuteReader(query);
        }

        public void deleteEmployee(long EMPSSN)
        {
            string query = "DELETE FROM Employee WHERE SSN = "+EMPSSN+";";
            dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetEmpSSN()
        {
            string query = " select ssn from Employee";
            return dbMan.ExecuteReader(query);
        }
        //---------------------chef form functionalities-----------------------------
        public DataTable OrdersToBeMade()
        {
            string query = "SELECT  mi.ItemName AS MenuItemName,   co.OrderID AS OrderID FROM    CustomerOrder co  JOIN    Order_Contains_MenuItem ocm ON co.OrderID = ocm.OrderID JOIN  MenuItem mi ON ocm.ItemID = mi.ItemID WHERE     co.OrderState = 'Pending';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectedPendingID()
        {
            string query = "SELECT OrderID FROM    CustomerOrder WHERE    OrderState = 'Pending';";
            return dbMan.ExecuteReader(query);
        }
        public void ServedOrder(string id)
        {
            string query = "UPDATE CustomerOrder SET OrderState = 'Served' WHERE OrderID = "+id+";";
            dbMan.ExecuteNonQuery(query);

        }
        public void CancelledOrder(int id)
        {
            string query = "UPDATE CustomerOrder SET OrderState = 'Cancelled' WHERE OrderID = " + id + ";";
            dbMan.ExecuteNonQuery(query);

        }
        public DataTable showstock()
        {
            string query = "SELECT  IngredientName FROM   Ingredient WHERE   IngredientStock = 0;";
            return dbMan.ExecuteReader(query);
        }
        public int MakeRequest(string item,string ssn)
        {
            string query = "INSERT INTO Request (IngredientID, ChefSSN, RequestDate, RequestStatus, ManagerSSN)" +
                "VALUES   ((SELECT IngredientID FROM Ingredient WHERE IngredientName = '" + item + "'), '" + ssn + "', GETDATE(), 'Pending', '23456789012');";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Requested successfully!");
            }
            else
            {
                MessageBox.Show("Failed  to request Data.");
            }
            return rowsAffected;
        }
        public DataTable SlectChefSSN()
        {
            string query = "SELECT SSN FROM  Employee WHERE   Position = 'Chef';";
            return dbMan.ExecuteReader(query);
        }
        //MenuItem (ItemName, CookingTime, ItemStatus, ChefSSN)
        public int insertMenuItem(string item,string time,string ssn)
        {
            string query = "INSERT INTO MenuItem (ItemName, CookingTime, ItemStatus, ChefSSN)" +
                "VALUES    ('"+item+"', '"+item+"', 'Available', '"+ssn+"')";
            int rowsAffected = dbMan.ExecuteNonQuery(query);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data Inserted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to insert Data.");
            }
            return rowsAffected;
        }
        
        public object getMenuItemID(string itemName)
        {
            string query = "SELECT ItemID FROM MenuItem WHERE ItemName = '" + itemName + "';";
            return dbMan.ExecuteScalar(query);
        }

        public void deleteMenuItem(int itemID)
        {
            string query = "DELETE FROM MenuItem WHERE ItemID = " + itemID + ";";
            dbMan.ExecuteNonQuery(query);
        }

        public void deleteIngredient(int ingredientID)
        {
            string query = "DELETE FROM Ingredient WHERE IngredientID = " + ingredientID + ";";
            dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
