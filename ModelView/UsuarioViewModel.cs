using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using kalum2021.Models;
using MahApps.Metro.Controls.Dialogs;

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
        public string HeighLblPassword { get; set; } = "Auto";
        public string HeighTxtPassword { get; set; } = "Auto";
        public Usuarios Usuario { get; set; }
        private IDialogCoordinator dialogCoordinator;

        public UsuarioViewModel(UsuariosViewModel UsuariosViewModel, IDialogCoordinator instance)
        {
            Instancia = this;
            this.dialogCoordinator = instance;
            this.UsuariosViewModel = UsuariosViewModel;
            if (this.UsuariosViewModel.Seleccionado != null)
            {
                this.Usuario = new Usuarios();
                this.Usuario.Enable = this.UsuariosViewModel.Seleccionado.Enable;
                this.Apellidos = this.UsuariosViewModel.Seleccionado.Apellidos;
                this.Nombres = this.UsuariosViewModel.Seleccionado.Nombres;
                this.Email = this.UsuariosViewModel.Seleccionado.Email;
                this.Username = this.UsuariosViewModel.Seleccionado.Username;
                this.HeighLblPassword = "0";
                this.HeighTxtPassword = "0";
            }
        }
        public bool CanExecute(object parametro)
        {
            return true;
        }

        public async void Execute(object parametro)
        {
            if (parametro is Window)
            {
                if (this.UsuariosViewModel.Seleccionado == null)
                {
                    Usuarios nuevo = new Usuarios(100, Username, true, Nombres, Apellidos, Email);
                    nuevo.Password = ((PasswordBox)((Window)parametro).FindName("TxtPassword")).Password;
                    this.UsuariosViewModel.agregarElemento(nuevo);
                    await dialogCoordinator.ShowMessageAsync(this, "Agregar usuario","Elemento almacenado correctamente", MessageDialogStyle.Affirmative);
                }
                else
                {
                    this.Usuario.Apellidos = this.Apellidos;
                    this.Usuario.Nombres = this.Nombres;
                    this.Usuario.Email = this.Email;
                    this.Usuario.Username = this.Username;

                    int posicion = this.UsuariosViewModel.usuarios.IndexOf(this.UsuariosViewModel.Seleccionado);
                    this.UsuariosViewModel.usuarios.RemoveAt(posicion);
                    this.UsuariosViewModel.usuarios.Insert(posicion, this.Usuario);
                    await dialogCoordinator.ShowMessageAsync(this, "Agregar usuario","Elemento almacenado correctamente", MessageDialogStyle.Affirmative);
                
                }

                ((Window)parametro).Close();
            }
        }
    }
}