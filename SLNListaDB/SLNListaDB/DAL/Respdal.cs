using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class Respdal
    {
        private SqlConnection _conexao;

        public Respdal()
        {
            _conexao = ConexaoBD.getconexao();
        }
        public List<ResponsavelModel> getTodosresponsaveis()
        {

            string sql = "select * from Responsavel";
            var dados = (List<ResponsavelModel>)_conexao.Query<ResponsavelModel>(sql);
            return dados;







        }

        public List<Alunomodel> GetAlunomodels()
        {

            string sql = "select * from Aluno";
            var alunos = (List<Alunomodel>)_conexao.Query<Alunomodel>(sql);
            return alunos;







        }



















    }
}
