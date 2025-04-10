using Microsoft.Maui.Controls;

namespace Trabalho2pam
{
    public partial class ListaProdutosPage : ContentPage
    {
        public ListaProdutosPage()
        {
            InitializeComponent();
            produtosListView.ItemsSource = MainPage.Produtos;
        }
    }
}
