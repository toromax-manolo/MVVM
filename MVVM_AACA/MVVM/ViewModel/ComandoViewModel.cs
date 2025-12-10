using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_AACA.MVVM.ViewModel
{
    public class ComandoViewModel
    {

        public ICommand ClickCommand { get; }


        public ComandoViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Titulo", "Mensaje", "OK");
            });
            
        }

        private void alert()
        {
            
        }
            
          

    }
}
