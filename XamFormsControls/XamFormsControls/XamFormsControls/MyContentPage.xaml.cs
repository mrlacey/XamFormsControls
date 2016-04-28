using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamFormsControls
{
    public partial class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            InitializeComponent();
        }

        private void MasterDetailClicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new MyMasterDetailPage());
        }

        private void TabbedClicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new MyTabbedPage());
        }

        private void TabbedItemsClicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new MyTabbedItemsPage());
        }

        private void CarouselClicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new MyCarouselPage());
        }
    }
}
