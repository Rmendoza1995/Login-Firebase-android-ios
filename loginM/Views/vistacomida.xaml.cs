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
    public partial class vistacomida : Rg.Plugins.Popup.Pages.PopupPage
    {
        public vistacomida()
        {
            InitializeComponent();
        }

        private void _ordenquesadilla3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var stepper_obj = (Stepper)sender;
            Double totalfinal = stepper_obj.Value;
            int xsuma = (int)totalfinal;
            int totalfinal1 = (total.Text != null) ? int.Parse(total.Text) : 0;   



            ////if (xsuma < totalfinal1)
            ////{
            ////    total.Text = (totalfinal1 - totalfinal).ToString();
            ////}

            ////else
            ////{
            ////    total.Text = (totalfinal1 + totalfinal).ToString();

            ////}




        }
    }

}