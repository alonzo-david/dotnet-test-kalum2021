using System.ComponentModel;
using System.Collections.ObjectModel;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class RoleViewModel : INotifyPropertyChanged
    {
        public RoleViewModel()
        {
            roles = new ObservableCollection<Roles>() ;
            roles.Add(new Roles(1, "ROLE_ADMIN"));
            roles.Add(new Roles(2, "ROLE_USER"));
            roles.Add(new Roles(3, "ROLE_SUPERV"));
        }

        public void NotificarCambio(string propiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Roles> roles {get; set;}
    }
}