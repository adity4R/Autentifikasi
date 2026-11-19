using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSchoolApp
{
    internal class Connection
    {
        public MySqlConnection ConnectionToSQL()
        {
            string strConnection = "Server=localhost;Database=pi_school;Uid=root;Pwd";
            MySqlConnection conn = new MySqlConnection(strConnection);
            return conn;
        }
    }
}
