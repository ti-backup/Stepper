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

        public Boolean Atualiza(Dinamica obj)
        {
            Boolean resp = false;
            try
            {
                ConectaBD.Instancia.ConexaoBD();
                using (SQLiteCommand cmd = ConectaBD.Instancia.Conexao.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Dinamica SET docente = @docente WHERE id = @id";
                    cmd.Parameters.AddWithValue("@docente", obj.Professor.Nome);
                    cmd.Parameters.AddWithValue("@id", obj.Id);
                    if (cmd.ExecuteNonQuery() == 1)
                        resp = true;
                }
                return resp;
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

        public Dinamica BuscaPorId(int id)
        {
            Dinamica din = new Dinamica(); ;
            try
            {
                ConectaBD.Instancia.ConexaoBD();
                using (SQLiteCommand cmd = ConectaBD.Instancia.Conexao.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Dinamica WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            din.Id = rd.GetInt32(0);
                            din.Professor = new Docente();
                            din.Professor.Nome = rd.GetString(1);
                        }
                    }
                }
                return din;
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
