using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class comida : ContentPage
    {
        public comida()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
           
                await Rg.Plugins.Popup.Services.PopupNavigation.Instance.PushAsync(new vistacomida());

            
        }
    }
}