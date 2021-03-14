using System.Windows;
using kalum2021.ModelView;

namespace kalum2021.Views
{
    public partial class RoleView : Window
    {
        public RoleView(RolesViewModel RolesViewModel)
        {
            InitializeComponent();
            RoleViewModel Modelo = new RoleViewModel(RolesViewModel);
            this.DataContext = Modelo;
        }
    }
}