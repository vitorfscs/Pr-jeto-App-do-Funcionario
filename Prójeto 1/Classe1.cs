using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prójeto_1
{
    interface IAutentica
    {
        string usuario { get; set;} 
        
        string senha { get; set; }

        int matricula { get; set; }
        string funcao { get; set; }
        string setor { get; set; }

    }

    class Autenticacao_Usuario : IAutentica
    {
        public string usuario { get; set; }
        
        public string senha { get; set; }

        public int matricula { get; set; }

        public string funcao { get; set; }

        public string setor { get; set; }

    }

    interface Iopcoes
    {
        int opcao1 { get; set; }
        int opcao2 { get; set; }
        int opcao3 { get; set; }
    }

    class opcoes_paraentrar : Iopcoes
    {
        public int opcao1 { get; set;}
        
            
        

        public int opcao2 { get; set; }


        public int opcao3 { get; set; }

    }
}


