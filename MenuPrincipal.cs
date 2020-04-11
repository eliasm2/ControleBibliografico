using Controle_bibliografico.Class;
using Controle_bibliografico.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_bibliografico
{
    public partial class MenuPrincial : Form
    {
        Dados Mdados = new Dados();
        public MenuPrincial()
        {
            InitializeComponent();
            Mdados.AbrirXML();
            CarregarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Referencia referencia;

            referencia = Mdados.PesquisarReferencia(txtCodBibliografico.Text);

            if (referencia != null)
            {
                txtCodBibliografico.Text = referencia.Cod;
                txtAutor1.Text = referencia.Autor1;
                txtAutor2.Text = referencia.Autor2;
                txtAutor3.Text = referencia.Autor3;
                txttitulo.Text = referencia.Titulo;
                txtEditora.Text = referencia.Editora;
                txtCidade.Text = referencia.Cidade;
                txtAno.Text = referencia.AnoPublicacao;
                txtEdição.Text = referencia.Edicao;
                txtPagina.Text = referencia.Pagina;

            }
            else { MessageBox.Show("Produto Não Encontrado!", "Controle"); }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Referencia novaReferencia = new Referencia();

            novaReferencia.Cod = txtCodBibliografico.Text;
            novaReferencia.Autor1 = txtAutor1.Text;
            novaReferencia.Autor2 = txtAutor2.Text;
            novaReferencia.Autor3 = txtAutor3.Text;
            novaReferencia.Titulo = txttitulo.Text;
            novaReferencia.Editora = txtEditora.Text;
            novaReferencia.Cidade = txtCidade.Text;
            novaReferencia.AnoPublicacao = txtAno.Text;
            novaReferencia.Edicao = txtEdição.Text;
            novaReferencia.Pagina = txtPagina.Text;

            Mdados.InserirReferencia(novaReferencia);
            MessageBox.Show("Referencia gravada com sucesso", "Controle");
            limpar();
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Referencia Alterado = new Referencia();
            Referencia MinhaReferencia;

            MinhaReferencia = Mdados.PesquisarReferencia(txtCodBibliografico.Text);
            if (MinhaReferencia != null)
            {
                Alterado.Cod = txtCodBibliografico.Text;
                Alterado.Autor1 = txtAutor1.Text;
                Alterado.Autor2 = txtAutor2.Text;
                Alterado.Autor3 = txtAutor3.Text;
                Alterado.Titulo = txttitulo.Text;
                Alterado.Editora = txtEditora.Text;
                Alterado.Cidade = txtCidade.Text;
                Alterado.AnoPublicacao = txtAno.Text;
                Alterado.Edicao = txtEdição.Text;
                Alterado.Pagina = txtPagina.Text;

                //Mdados.InserirProduto(MeuProduto);
                //Mdados.SalvarXML();

                Mdados.AlterarReferencia(MinhaReferencia, Alterado);

                MessageBox.Show("Alterado com Sucesso!", "Controle");

                txtCodBibliografico.Clear();
                txtAutor1.Clear();
                txtAutor2.Clear();
                txtAutor3.Clear();
                txttitulo.Clear();
                txtEditora.Clear();
                txtCidade.Clear();
                txtAno.Clear();
                txtEdição.Clear();
                txtPagina.Clear();

                CarregarGrid();
            }
            else { MessageBox.Show("Referencia não Encontrada!", "Controle"); }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Referencia referencia;

            referencia = Mdados.PesquisarReferencia(txtCodBibliografico.Text);
            if (referencia != null)
            {
                Mdados.ExcluirReferencia(referencia);

                txtCodBibliografico.Clear();
                txtAutor1.Clear();
                txtAutor2.Clear();
                txtAutor3.Clear();
                txttitulo.Clear();
                txtEditora.Clear();
                txtCidade.Clear();
                txtAno.Clear();
                txtEdição.Clear();
                txtPagina.Clear();

                MessageBox.Show("Referencia Excluida!", "Controle");

                CarregarGrid();
            }
            else { MessageBox.Show("Referencia não Encontrada!", "Controle"); }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Mdados.SalvarXML();

            this.Close();
        }
        public void limpar()
        {
            txtAutor1.Text="";
            txtAutor2.Text="";
            txtAutor3.Text="";
            txttitulo.Text="";
            txtEditora.Text="";
            txtCidade.Text="";
            txtAno.Text = "";
            txtEdição.Text="";
            txtPagina.Text="";

        }
        public void CarregarGrid()
        {
            dgvReferencia.DataSource = null;
            dgvReferencia.DataSource = Mdados.RetornaReferencia();

            DataGridViewCellStyle EstiloColuna = new DataGridViewCellStyle();
            EstiloColuna.BackColor = Color.Aqua;
            EstiloColuna.Font = new Font("Verdana", 8, FontStyle.Bold);

            dgvReferencia.ColumnHeadersDefaultCellStyle = EstiloColuna;

            //DataGridViewColumn Coluna = new DataGridViewColumn();

            //Coluna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvReferencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btListar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarGrid();
        }

        private void Form_arquivoImportado(object sender, EventArgs e)
        {
            Mdados = (Dados)sender;
        }

        private void MenuPrincial_Load(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            importar form = new importar();
            form.arquivoImportado += Form_arquivoImportado;
            form.FormClosed += Form_FormClosed;
            form.Show();
        }
    }
}
