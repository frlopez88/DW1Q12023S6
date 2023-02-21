using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void saludar(object sender, EventArgs e)
        {

            string nm= nmInput.Text;
            resultado.Text = $"Bienvenido {nm}, saludos!";

        }
    }
}
