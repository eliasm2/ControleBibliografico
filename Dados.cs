using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Controle_bibliografico.Class
{
    public class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirReferencia(Referencia x)
        {
            Cadastro.Add(x);
        }

        public Referencia PesquisarReferencia(string Cod)
        {
            foreach (Referencia x in Cadastro)
            {
                if (x.Cod == Cod)
                    return x;
            }

            return null;
        }
        public void ExcluirReferencia(Referencia x)
        {
            Cadastro.Remove(x);
        }
        public void AlterarReferencia(Referencia x, Referencia Alterado)
        {
            int Posicao;

            Posicao = Cadastro.IndexOf(x);

            Cadastro.Remove(x);
            Cadastro.Add(Alterado);
        }
        public void SalvarXML()
        {
            TextWriter MeuWriter = new StreamWriter(@"Bibliografia.xml");

            Referencia[] ListaProdutoVetor = (Referencia[])Cadastro.ToArray(typeof(Referencia));

            XmlSerializer Serializacao = new XmlSerializer(ListaProdutoVetor.GetType());

            Serializacao.Serialize(MeuWriter, ListaProdutoVetor);

            MeuWriter.Close();
        }
        public void AbrirXML()
        {


            FileStream LeArquivo = new FileStream(@"Bibliografia.xml", FileMode.OpenOrCreate);

            Referencia[] ListaProdutoVetor = (Referencia[])Cadastro.ToArray(typeof(Referencia));

            XmlSerializer Serializacao = new XmlSerializer(ListaProdutoVetor.GetType());

            if (LeArquivo.Length > 0)
            {
                ListaProdutoVetor = (Referencia[])Serializacao.Deserialize(LeArquivo);

                Cadastro.Clear();

                Cadastro.AddRange(ListaProdutoVetor);
            }

            LeArquivo.Close();
        }
        public ArrayList RetornaReferencia()
        {
            return Cadastro;
        }
    }
}
