using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Models
{
     public class Advogado
    {


        public string nome { get; set; }    
        public string Sobrenome { get; set; }

        public int idade { get; set; }  
        
        public string SEXO { get; set; }

        public pais Pais { get; set; }

        

        public List<Advogado> gettodosadv()
        {
            return null;
        }

       public string   Getnomecompleto()
        {
            return this.nome+""+this.Sobrenome;

        }

        public Advogado getAdvogadoporID(int pcodigo)
        {
            return null;

        }
        public List<Advogado> getadvogadoporpais(int ppais)
        {

            return null;

        }




















 










    }
}
