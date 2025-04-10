using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace Trabalho2pam
{
    public partial class MainPage : ContentPage
    {
        public static List<Produto> Produtos { get; private set; } = new();

        public MainPage()
        {
            InitializeComponent();
        }

        private void AdicionarProduto_Clicked(object sender, EventArgs e)
        {
            string nome = nomeEntry.Text;
            string descricao = descricaoEntry.Text;
            string categoria = categoriaEntry.Text;
            DateTime? validade = validadePicker.Date;

            if (double.TryParse(precoEntry.Text, out double preco) && !string.IsNullOrWhiteSpace(nome))
            {
                Produtos.Add(new Produto
                {
                    Nome = nome,
                    Preco = preco,
                    Descricao = descricao,
                    Categoria = categoria,
                    Validade = validade
                });

                mensagemLabel.Text = "Produto cadastrado com sucesso!";
                nomeEntry.Text = precoEntry.Text = descricaoEntry.Text = categoriaEntry.Text = "";
            }
            else
            {
                mensagemLabel.Text = "Preencha os campos corretamente!";
            }
        }

        private async void IrParaLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaProdutosPage());
        }
    }
}
