using Store.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Store.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}