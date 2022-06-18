using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TokLisApp
{
    internal class Database
    {
        public SQLiteConnection conn;

        public Database()
        {
            conn = new SQLiteConnection("Data Source=toklis.sqlite3");
            if (!File.Exists("./toklis.sqlite3"))
            {
                SQLiteConnection.CreateFile("toklis.sqlite3");
                createTable();
                Console.WriteLine("Database created");

            }
        }
        public void createTable()
        {
            SQLiteCommand command = new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS cust (cust_id integer not null primary key autoincrement, cust_name varchar(255) not null unique, cust_no number(11) not null); CREATE TABLE IF NOT EXISTS status(status_type number(1) not null unique, status_desc VARCHAR(15) not null); CREATE TABLE IF NOT EXISTS token(token_id integer not null primary key, token_no varchar(24) not null unique, token_val number(7) not null, token_cust_id integer references cust(cust_id) not deferrable, token_status_type integer references status(status_type) not deferrable); INSERT INTO cust(cust_name, cust_no) VALUES('DANU', 12345678900); INSERT INTO status(status_type, status_desc) VALUES(0, 'BELUM TERPAKAI'), (1, 'Terpakai'); ", conn);
            openConn();
            command.ExecuteNonQuery();
            closeConn();
        }
        public void openConn()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void closeConn()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
