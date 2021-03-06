using System.ComponentModel;
using System.Collections.ObjectModel;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        public UsuarioViewModel()
        {
            this.usuarios = new ObservableCollection<Usuarios>();
            this.usuarios.Add(new Usuarios(1, "dalonzo", true, "David", "Alonzo", "d@gmail.com"));
            this.usuarios.Add(new Usuarios(2, "clopez", true, "Cesar", "Lopez", "cl@gmail.com"));
            this.usuarios.Add(new Usuarios(3, "jhernandez", true, "Josue", "Hernandez", "jh@gmail.com"));
        }

        public void NotificarCambio(string propiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        public ObservableCollection<Usuarios> usuarios { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}