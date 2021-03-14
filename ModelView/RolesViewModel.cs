using System.ComponentModel;
using System.Collections.ObjectModel;
using kalum2021.Models;
using System.Windows.Input;
using System;
using System.Windows;
using kalum2021.Views;

namespace kalum2021.ModelView
{
    public class RolesViewModel : INotifyPropertyChanged, ICommand
    {
        public RolesViewModel Instancia { get; set; }
        public Roles Seleccionado { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public ObservableCollection<Roles> roles { get; set; }
        public RolesViewModel()
        {
            this.Instancia = this;
            roles = new ObservableCollection<Roles>();
            roles.Add(new Roles(1, "ROLE_ADMIN"));
            roles.Add(new Roles(2, "ROLE_USER"));
            roles.Add(new Roles(3, "ROLE_SUPERV"));
        }

        public void NotificarCambio(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }
        public void agregarElemento(Roles nuevo)
        {
            this.roles.Add(nuevo);
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Nuevo"))
            {
                RoleView nuevoRol = new RoleView(Instancia);
                nuevoRol.Show();
            }
            else if (parametro.Equals("Eliminar"))
            {
                if (this.Seleccionado == null)
                {
                    MessageBox.Show("Debe seleccionar algun elemento.");
                }
                else
                {
                    this.roles.Remove(Seleccionado);
                }
            }
        }

    }
}