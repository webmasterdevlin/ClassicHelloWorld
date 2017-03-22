using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorldXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_TryExit_Onclicked(object sender, EventArgs e)
        {
            IdNameOfTheLabelElement.Text = "Good Bye Xamarin";
        }
    }
}