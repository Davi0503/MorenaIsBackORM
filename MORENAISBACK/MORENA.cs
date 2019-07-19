using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MORENAISBACK
{
    public class MORENA
    {
        private string connectionString = "Data Source= DESKTOP-JR0T6JP; Initial Catalog= MORENAISBACK; integrated security=true";

        public List<string> Select(string nomeTabela)
        {


            string query = "SELECT NOME FROM " + nomeTabela + ";";
            List<string> lista = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //cmd.Parameters.AddWithValue("@NOMETABELA", nomeTabela);

                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        string pao = sdr["NOME"].ToString();
                        lista.Add(pao);
                    }    
                }
            } 

                return lista;
        }
        

    }
}
