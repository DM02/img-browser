using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace web_browser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] tab = new string[3] { @"https://img.icons8.com/ios-glyphs/344/conference-call--v1.png", @"https://img.icons8.com/ios/344/multicultural-people.png", @"https://img.icons8.com/office/344/conference-call.png" };
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i < tab.Length-1)
            {
               i++;
                img.Source = tab[i];
            }else if(i == tab.Length-1)
            {
                i = 0;
                img.Source=tab[i];
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                img.Source = tab[i];
            }else if (i == 0)
            {
                i = tab.Length-1;
                img.Source=tab[i];
            }
        }

    }
}
