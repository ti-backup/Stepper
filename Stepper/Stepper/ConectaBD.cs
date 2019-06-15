using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    class ConectaBD
    {
        public static readonly ConectaBD Instancia = new ConectaBD();
        public SQLiteConnection Conexao;

        private ConectaBD()
        {
            CriarBDSQLite();
            CriarTabelasSQLite();
        }

        private void CriarBDSQLite()
        {
            try
            {
                if (!File.Exists(@"StepperBD.sqlite"))
                    SQLiteConnection.CreateFile(@"StepperBD.sqlite");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CriarTabelasSQLite()
        {
            try
            {
                ConexaoBD();
                using (SQLiteCommand cmd = Conexao.CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Dinamica(id INTEGER PRIMARY KEY AUTOINCREMENT, docente VARCHAR(50))";
                    cmd.ExecuteNonQuery();
                }
                Conexao.Close();
                Conexao.Dispose();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void ConexaoBD()
        {
            StreamReader str = new StreamReader("conexao.ini");
            Conexao = new SQLiteConnection(str.ReadLine() + " Version=3;");
            Conexao.Open();
        }
    }
}
