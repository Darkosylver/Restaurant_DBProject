using Microsoft.SqlServer.Server;
using System;
using System.Data;

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
        //you can edit the ones below :)

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

       public void addCustomer(string phone, string fName, string lName, string passWord)
        {
            string query = "INSERT INTO CUSTOMER (PhoneNumber, FName, LName, EPassword) " +
                "VALUES ('" + phone + "', '" + fName + "', '" + lName + "', '"+ passWord +"';";
            dbMan.ExecuteNonQuery(query);
        }

       public string VerifyCustonmer(string phoneNumber, string password)  //sees if the customer exists
        {
            string query="SELECT FName FROM Customer WHERE PhoneNumber='"+phoneNumber+"' AND EPassword='"+password+"';";

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

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
