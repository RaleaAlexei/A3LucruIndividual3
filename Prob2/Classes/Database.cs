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
        private static string dbName = "Scoala.db";
        private static string payload = $"Data Source={dbName}";
        private static string dbCreation = @"
            CREATE TABLE ""Studenti"" (
	""Nume""	TEXT NOT NULL,
	""Prenume""	TEXT NOT NULL,
	""AnulNasterii""	INTEGER NOT NULL,
	""CNP""	VARCHAR(13) NOT NULL UNIQUE,
	""MediaNotelor""	INTEGER NOT NULL,
	""Grupa""	TEXT NOT NULL
);
        ";
        //SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Inventar", "Data Source=Inventar.db");
        public bool Open()
        {
            sqlite_conn = CreateConnection();
            SQLiteCommand command = sqlite_conn.CreateCommand();
            command.CommandText = "SELECT Nume FROM Studenti";
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
        public bool scrieSalariat(Student student)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Studenti(Nume, Prenume, AnulNasterii, CNP, MediaNotelor, Grupa) VALUES(@param1, @param2, @param3, @param4, @param5, @param6);";
            sqlite_cmd.Parameters.AddWithValue("@param1", student.Nume);
            sqlite_cmd.Parameters.AddWithValue("@param2", student.Prenume);
            sqlite_cmd.Parameters.AddWithValue("@param3", student.Anul);
            sqlite_cmd.Parameters.AddWithValue("@param4", student.CNP);
            sqlite_cmd.Parameters.AddWithValue("@param5", student.mediaNotelor);
            sqlite_cmd.Parameters.AddWithValue("@param6", student.grupa);

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
