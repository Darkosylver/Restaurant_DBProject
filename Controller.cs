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

        public object checktableexists(int tnumber)
        {
            string query = "SELECT COUNT(*) FROM RestaurantTable WHERE TableNumber=" + tnumber + ";";
            return dbMan.ExecuteScalar(query);
        }

        public object checktable(int tnumber)
        {
            string query = "SELECT CustomerPhoneNumber FROM RestaurantTable WHERE TableNumber=" + tnumber + ";";
            return dbMan.ExecuteScalar(query);
        }
        public void reservetable(int tnumber,string phone)
        {
            string query = "UPDATE RestaurantTable SET CustomerPhoneNumber='"+phone+"' WHERE TableNumber="+tnumber+";";
            dbMan.ExecuteNonQuery(query);
        }

        public object checkphonenumber(string phone)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE PhoneNumber='"+phone+"';";
            return dbMan.ExecuteScalar(query);
        }

        public object checklocationexist(string city, string street, string building)
        {
            string query = "SELECT LocationID FROM Locations WHERE City='" + city + "' AND Street='" + street + "' AND Building='" + building + "';";

            return dbMan.ExecuteScalar(query);
        }

        public void insertlocationid(string phone,string city,string street,string building)
        {
            string query = "INSERT INTO Locations (City, Street, Building) VALUES('" + city + "', '" + street + "', '" + building + "');";
            dbMan.ExecuteNonQuery(query);
        }

        public object checkassignedlocation(string phone, int locationid)
        {
            string query = "SELECT COUNT(*) FROM CustomerLocations WHERE PhoneNumber='"+phone+"' AND LocationID="+locationid+";";
            return dbMan.ExecuteScalar(query);
        }
        public void insertlocation(string phone, int id)
        {
            string query = "INSERT INTO CustomerLocations (PhoneNumber, LocationID) VALUES ('" + phone + "', " + id + ");";
            dbMan.ExecuteNonQuery(query);
        }

        public void deletelocation(string phone, int id)
        {
            string query = "DELETE FROM CustomerLocations WHERE PhoneNumber='" + phone + "' AND LocationID=" + id + ";";
            dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
