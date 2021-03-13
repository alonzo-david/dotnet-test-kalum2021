using System;
using System.ComponentModel;
using System.Windows.Input;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class UsuarioViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public UsuarioViewModel Instancia { get; set; }
        public UsuariosViewModel UsuariosViewModel { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public UsuarioViewModel(UsuariosViewModel UsuariosViewModel)
        {
            Instancia = this;
            this.UsuariosViewModel = UsuariosViewModel;
        }
        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Guardar"))
            {
                Usuarios nuevo = new Usuarios(100, Username, true, Nombres, Apellidos, Email);
                this.UsuariosViewModel.agregarElemento(nuevo);
            }
        }
    }
}