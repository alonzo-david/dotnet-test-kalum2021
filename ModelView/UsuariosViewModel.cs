using System.ComponentModel;
using System.Collections.ObjectModel;
using kalum2021.Models;
using System.Windows.Input;
using System;
using System.Windows;
using kalum2021.Views;
using MahApps.Metro.Controls.Dialogs;

namespace kalum2021.ModelView
{
    public class UsuariosViewModel : INotifyPropertyChanged, ICommand
    {
        public ObservableCollection<Usuarios> usuarios { get; set; }
        public UsuariosViewModel Instancia { get; set; }
        public Usuarios Seleccionado { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        private IDialogCoordinator dialogCoordinator;

        public UsuariosViewModel(IDialogCoordinator instance)
        {
            this.Instancia = this;
            this.dialogCoordinator = instance;
            this.usuarios = new ObservableCollection<Usuarios>();
            this.usuarios.Add(new Usuarios(1, "dalonzo", true, "David", "Alonzo", "d@gmail.com"));
            this.usuarios.Add(new Usuarios(2, "clopez", true, "Cesar", "Lopez", "cl@gmail.com"));
            this.usuarios.Add(new Usuarios(3, "jhernandez", true, "Josue", "Hernandez", "jh@gmail.com"));
        }

        public void NotificarCambio(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        public void agregarElemento(Usuarios nuevo)
        {
            this.usuarios.Add(nuevo);
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public async void Execute(object parametro)
        {
            if (parametro.Equals("Nuevo"))
            {
                this.Seleccionado = null;
                UsuarioView nuevoUsuario = new UsuarioView(Instancia);
                nuevoUsuario.Show();
                //Usuarios elemento = new Usuarios(100,"wcordero",true,"Walter","Cordero","wcordero@gmail.com");
                //agregarElemento(elemento);
            }
            else if (parametro.Equals("Eliminar"))
            {

                if (this.Seleccionado == null)
                {
                    await this.dialogCoordinator.ShowMessageAsync(this,"Usuarios", "Debe seleccionar un elemento", MessageDialogStyle.Affirmative);
                    //MessageBox.Show("Debe seleccionar un elemento");
                }
                else
                {
                    MessageDialogResult respuesta = await this.dialogCoordinator.ShowMessageAsync(this, "Eliminar Usuario",
                    "Desea eliminar este contacto?", MessageDialogStyle.AffirmativeAndNegative);

                    if (respuesta == MessageDialogResult.Affirmative)
                    {
                        this.usuarios.Remove(Seleccionado);
                    }
                }

            }
            else if (parametro.Equals("Modificar"))
            {
                if (this.Seleccionado == null)
                {
                    await this.dialogCoordinator.ShowMessageAsync(this,"Usuarios", "Debe seleccionar un elemento", MessageDialogStyle.Affirmative);
                    //MessageBox.Show("Debe seleccionar un elemento");
                }
                else
                {
                    UsuarioView modificarUsuario = new UsuarioView(Instancia);
                    modificarUsuario.ShowDialog();
                }
            }
        }
    }

}