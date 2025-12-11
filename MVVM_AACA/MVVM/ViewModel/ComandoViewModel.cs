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

        public ICommand SearchCommand { get; }

        public string SearchData { get; set; }

        public ComandoViewModel()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Titulo", "Mensaje", "OK");
            });

            SearchCommand = new Command((s) =>
            {
                var data = s;


            });
        }

        private void alert()
        {
            
        }
            
          

    }
}
