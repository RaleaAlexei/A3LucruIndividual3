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
        private static string dbName = "Salariati.db";
        private static string payload = $"Data Source={dbName}";
        private static string dbCreation = @"
            CREATE TABLE ""Salariati"" (
	""Nume""	TEXT NOT NULL,
	""Prenume""	TEXT NOT NULL,
	""AnulNasterii""	INTEGER NOT NULL,
	""CNP""	VARCHAR(13) NOT NULL UNIQUE,
	""OreLucrate""	INTEGER NOT NULL,
	""PlataPeOra""	INTEGER NOT NULL,
	""AnulAngajarii""	INTEGER NOT NULL
);
        ";
        //SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Inventar", "Data Source=Inventar.db");
        public bool Open()
        {
            sqlite_conn = CreateConnection();
            SQLiteCommand command = sqlite_conn.CreateCommand();
            command.CommandText = "SELECT Nume FROM Salariati";
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
        public bool scrieSalariat(Salariat salariat)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Salariati(Nume, Prenume, AnulNasterii, CNP, OreLucrate, PlataPeOra, AnulAngajarii) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7);";
            sqlite_cmd.Parameters.AddWithValue("@param1", salariat.Nume);
            sqlite_cmd.Parameters.AddWithValue("@param2", salariat.Prenume);
            sqlite_cmd.Parameters.AddWithValue("@param3", salariat.Anul);
            sqlite_cmd.Parameters.AddWithValue("@param4", salariat.CNP);
            sqlite_cmd.Parameters.AddWithValue("@param5", salariat.numarOreLucrat);
            sqlite_cmd.Parameters.AddWithValue("@param6", salariat.platePeOra);
            sqlite_cmd.Parameters.AddWithValue("@param7", salariat.anulAngajarii);

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
