using System.Windows;
using kalum2021.ModelView;

namespace kalum2021.Views
{
    public partial class RolesView : Window
    {
        public RolesView()
        {
            InitializeComponent();
            RolesViewModel ModeloDatos = new RolesViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}