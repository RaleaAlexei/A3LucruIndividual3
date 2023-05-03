using Prob1.Classes;
using System.Data.SQLite;
using System.Data;

namespace Prob1
{
    public partial class Form1 : Form
    { 
        private Database dataBase = new Database();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bool isOpen = dataBase.Open();
            if (!isOpen)
            {
                MessageBox.Show("Baza de date nu s-a putut conecta!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Salariati", dataBase.sqlite_conn);
            da.Fill(dt);
            dgwSalariati.DataSource = dt.DefaultView;
        }

        private void btInsereaza_Click(object sender, EventArgs e)
        {
            var salariat = new Salariat(this);
            salariat.Citire();
            var success = dataBase.scrieSalariat(salariat);
            if (success)
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Salariati", dataBase.sqlite_conn);
                da.Fill(dt);
                dgwSalariati.DataSource = dt.DefaultView;
            }
        }
        private void digitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if(Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand da = dataBase.sqlite_conn.CreateCommand();
            da.CommandText = "SELECT OreLucrate, PlataPeOra, CNP FROM Salariati";
            SQLiteDataReader reader = da.ExecuteReader();
            int minSalariu = int.MinValue;
            string CNP = "";
            while(reader.Read())
            {
                int OreLucrate = reader.GetInt32(0);
                int PlataPeOra = reader.GetInt32(1);
                int Salariu = OreLucrate * PlataPeOra;
                if(Salariu > minSalariu)
                {
                    minSalariu = Salariu;
                    CNP = reader.GetString(2);
                }
            }
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM Salariati WHERE CNP = {CNP}", dataBase.sqlite_conn);
            adapter.Fill(dt);
            dgwSalariati.DataSource = dt.DefaultView;
        }
    }
}