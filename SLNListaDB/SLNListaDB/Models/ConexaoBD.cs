using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Models
{
    public class ConexaoBD
    {
        private static SqlConnection banco;

        public static SqlConnection getconexao()
        {

            if (banco == null)
            {
                banco = new SqlConnection(@"Server=.\SENAI2022;Database=ListasDB;User id =sa;Password=senai.123");

            }

            return banco;


        }













    }
}
