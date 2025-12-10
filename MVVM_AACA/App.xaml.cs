using MVVM_AACA.MVVM.View;

namespace MVVM_AACA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ComandoView();
        }
    }
}
