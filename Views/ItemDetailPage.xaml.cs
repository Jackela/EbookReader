using EbookReader.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EbookReader.Views
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