using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_bibliografico.Class
{
    public class Referencia
    {

        private string cod;
        private string autor1;
        private string autor2;
        private string autor3;
        private string titulo;
        private string editora;
        private string edicao;
        private string cidade;
        private string anoPublicacao;
        private string pagina;


        
        public string Autor1 { get => autor1; set => autor1 = value; }
        public string Autor2 { get => autor2; set => autor2 = value; }
        public string Autor3 { get => autor3; set => autor3 = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Edicao { get => edicao; set => edicao = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string AnoPublicacao { get => anoPublicacao; set => anoPublicacao = value; }
        public string Pagina { get => pagina; set => pagina = value; }
        public string Cod { get => cod; set => cod = value; }
    }
}
