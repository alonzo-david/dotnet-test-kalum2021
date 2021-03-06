using System.Windows;
using kalum2021.ModelView;

namespace kalum2021.Views
{
    public partial class RoleView : Window
    {
        public RoleView()
        {
            InitializeComponent();
            RoleViewModel ModeloDatos = new RoleViewModel();
            this.DataContext = ModeloDatos;
        }
    }
}