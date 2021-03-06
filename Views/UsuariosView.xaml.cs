using System.Windows;
using kalum2021.ModelView;

namespace kalum2021.Views
{
    public partial class UsuarioView : Window
    {
        public UsuarioView()
        {
            InitializeComponent();
            UsuarioViewModel ModeloDatos = new UsuarioViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}