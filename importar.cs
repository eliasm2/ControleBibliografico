using Controle_bibliografico.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_bibliografico.Forms
{
    public partial class importar : Form
    {
        string caminho;
        Dados Mdados = new Dados();
        Referencia mReferencia = new Referencia();
        public event EventHandler arquivoImportado;

        public importar()
        {
            InitializeComponent();
            Mdados.AbrirXML();
        }


        private void bt_fecharImportarArquivo_Click(object sender, EventArgs e)
        {
            this.arquivoImportado(Mdados, new EventArgs());
            this.Close();
        }

        private void bt_uploadImportarArquivo_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "C:\\";
            openFile.Filter = "TXT Files (*.txt)|*.txt";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;

            //browserDialog_ImportarArquivo openFile = new FolderBrowserDialog
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tb_diretorioImportarArquivo.Text = openFile.FileName;
                caminho = openFile.FileName;
                bt_uploadImportarArquivo.Enabled = false;
                bt_processarImportarArquivo.Enabled = true;
            }

        }

        private void bt_processarImportarArquivo_Click_1(object sender, EventArgs e)
        {
            System.IO.StreamReader arquivo = new System.IO.StreamReader(caminho);//Instancia e armazena o arquivo
            string linha = "";//Cria a variavel que vai receber linha por linha
            string[] dados;
            linha = arquivo.ReadLine();//lê cada linha

            while (linha != null)
            {

                //if (linha != null)
                //{
                dados = linha.Split(';');//Lê a linha até achar o ponto e virgula para separar os dados.

                mReferencia.Cod = dados[0];
                mReferencia.Autor1 = dados[1];
                mReferencia.Autor2 = dados[2];
                mReferencia.Autor3 = dados[3];
                mReferencia.Titulo = dados[4];
                mReferencia.Cidade = dados[5];
                mReferencia.Editora = dados[6];
                mReferencia.Edicao = dados[7];
                mReferencia.AnoPublicacao = dados[8];
                mReferencia.Pagina = dados[9];


                Mdados.InserirReferencia(mReferencia);

                linha = arquivo.ReadLine();//lê cada linha
                //}

            }

            MessageBox.Show("Arquivo importado com sucesso!", "Controle");
            bt_uploadImportarArquivo.Enabled = true;
            bt_processarImportarArquivo.Enabled = false;
        }
    }
}
