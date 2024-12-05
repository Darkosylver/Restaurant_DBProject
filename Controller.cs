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
                "FROM PASSWORDS " +
                "WHERE PASSWORDS.SSN = '" + userName + "';";
            return dbMan.ExecuteScalar(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
