using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1.Classes
{
    internal class Database
    {

        public SQLiteConnection? sqlite_conn;
        private static string dbName = "Soferi.db";
        private static string payload = $"Data Source={dbName}";
        private static string dbCreation = @"
            CREATE TABLE ""Soferi"" (
	""Nume""	TEXT NOT NULL,
	""Prenume""	TEXT NOT NULL,
	""AnulNasterii""	INTEGER NOT NULL,
	""CNP""	VARCHAR(13) NOT NULL UNIQUE,
	""DistantaParcursa""	INTEGER NOT NULL,
	""PlatePerKM""	INTEGER NOT NULL
);
        ";
        //SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Inventar", "Data Source=Inventar.db");
        public bool Open()
        {
            sqlite_conn = CreateConnection();
            SQLiteCommand command = sqlite_conn.CreateCommand();
            command.CommandText = "SELECT Nume FROM Soferi";
            try
            {
                command.ExecuteScalar();
            }
            catch(Exception ex)
            {
                command.CommandText = dbCreation;
                command.ExecuteNonQuery();
            }
            return sqlite_conn != null;
        }
        private SQLiteConnection? CreateConnection()
        {

            SQLiteConnection? sqlite_conn;
            sqlite_conn = new SQLiteConnection(payload);
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                sqlite_conn = null;
            }
            return sqlite_conn;
        }
        public bool scrieSalariat(Sofer sofer)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Soferi(Nume, Prenume, AnulNasterii, CNP, DistantaParcursa, PlatePerKM) VALUES(@param1, @param2, @param3, @param4, @param5, @param6);";
            sqlite_cmd.Parameters.AddWithValue("@param1", sofer.Nume);
            sqlite_cmd.Parameters.AddWithValue("@param2", sofer.Prenume);
            sqlite_cmd.Parameters.AddWithValue("@param3", sofer.Anul);
            sqlite_cmd.Parameters.AddWithValue("@param4", sofer.CNP);
            sqlite_cmd.Parameters.AddWithValue("@param5", sofer.distantaParcursa);
            sqlite_cmd.Parameters.AddWithValue("@param6", sofer.platePerKM);

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
