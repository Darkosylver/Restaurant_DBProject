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
            string query = "SELECT * FROM CustomerOrder WHERE CustomerPhoneNumber = '" + phoneNumber + "' AND (OrderStatus = 'Pending' OR OrderStatus = 'Approved' OR OrderStatus = 'Cooking');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("No Orders found for the given Phone Number.");
                return null;
            }
        }

        public DataTable LoadWaiterOrdersCurret(string waiterSSN)  //loads the orders of the waiter
        {
            string query = "SELECT * FROM CustomerOrder WHERE WaiterSSN = '" + waiterSSN + "' AND (OrderStatus = 'Pending' OR OrderStatus = 'Approved' OR OrderStatus = 'Cooking');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("No Orders found for the given Phone Number.");
                return null;
            }
        }

        public DataTable loadCustomerOrdersPrevious(string phoneNumber)
        {
            string query = "SELECT * FROM CustomerOrder WHERE CustomerPhoneNumber = '" + phoneNumber + "' AND (OrderStatus = 'Delivered' OR OrderStatus = 'Rejected');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("No Orders found for this Waiter.");
                return null;
            }
        }

        public DataTable loadWaiterOrdersPrevious(string waiterSSN)
        {
            string query = "SELECT * FROM CustomerOrder WHERE WaiterSSN = '" + waiterSSN + "' AND (OrderStatus = 'Delivered' OR OrderStatus = 'Rejected');";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt;
            }
            else
            {
                MessageBox.Show("No Orders found for this Waiter.");
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
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
