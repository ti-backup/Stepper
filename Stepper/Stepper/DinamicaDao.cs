using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepper
{
    class DinamicaDao : IDao<Dinamica>
    {
        public void Adiciona(Dinamica obj)
        {
            try
            {
                ConectaBD.Instancia.ConexaoBD();
                using (SQLiteCommand cmd = ConectaBD.Instancia.Conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Dinamica (docente) VALUES (@docente)";
                    cmd.Parameters.AddWithValue("@docente", obj.Professor.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConectaBD.Instancia.Conexao.Close();
                ConectaBD.Instancia.Conexao.Dispose();
            }
        }

        public void Atualiza(Dinamica obj)
        {
            throw new NotImplementedException();
        }

        public Dinamica BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable BuscaTodos()
        {
            try
            {
                ConectaBD.Instancia.ConexaoBD();
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();

                using (SQLiteCommand cmd = ConectaBD.Instancia.Conexao.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Dinamica";
                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConectaBD.Instancia.Conexao.Close();
                ConectaBD.Instancia.Conexao.Dispose();
            }
        }

        public void Remove(int id)
        {
            try
            {
                ConectaBD.Instancia.ConexaoBD();
                using (SQLiteCommand cmd = ConectaBD.Instancia.Conexao.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Dinamica WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ConectaBD.Instancia.Conexao.Close();
                ConectaBD.Instancia.Conexao.Dispose();
            }
        }
    }
}
