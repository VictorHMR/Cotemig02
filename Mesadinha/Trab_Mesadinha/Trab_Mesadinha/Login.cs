using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Trab_Mesadinha
{
    class Login
    {
        private static string nome;
        private static string codigo;
        private static string pass;
        public bool validarusuario(string usuario, string senha)
        {
            ConexaoBD bd = new ConexaoBD();
            string sql = string.Format("select * from usuarios where email = '{0}' and senha = '{1}'", usuario, senha);
            DataTable dt = new DataTable();
            dt = bd.ConsultarDados(sql);
            if(dt.Rows.Count > 0)
            {
                nome = dt.Rows[0]["Nome"].ToString();
                codigo = dt.Rows[0]["codigo"].ToString();
                pass = dt.Rows[0]["senha"].ToString();

                return true;
            }
            else
            {
                return false;
            }
        }
        public string UsuarioLogado()
        {
            return nome;
        }
        public string CodLogado()
        {
            return codigo;
        }
        public string SenhaLogado()
        {
            return pass;
        }

    }

}
