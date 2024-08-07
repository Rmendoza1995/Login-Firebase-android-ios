using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loginM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void guarda_Clicked(object sender, EventArgs e)
        {
            //Convercion explicita
            var objButton = (Button)sender;
            Console.WriteLine(objButton.Text);

            if(usuario.Text != null && contrasenia.Text != null)
            {

                

            }
            else
            {
                DisplayAlert(title: "Error", message: "No puede haber campos vacios", "Aceptar");
            }
        }
    }
}
