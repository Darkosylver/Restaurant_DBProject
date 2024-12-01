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
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
