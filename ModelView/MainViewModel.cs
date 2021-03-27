using System;
using System.ComponentModel;
using System.Windows.Input;
using kalum2021.Views;

namespace kalum2021.ModelView
{
    public class MainViewModel : INotifyPropertyChanged, ICommand
    {
        
        public string Fondo {get; set;} = $"{Environment.CurrentDirectory}\\Images\\img1.gif";
        public MainViewModel Instancia {get; set;}

        public event EventHandler CanExecuteChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            this.Instancia = this;
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if(parametro.Equals("Usuarios"))
            {
                try{
                    UsuariosView ventanaUsuarios = new UsuariosView();
                    ventanaUsuarios.ShowDialog();
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
            }else if(parametro.Equals("Roles"))
            {
                RolesView ventanaRoles = new RolesView();
                ventanaRoles.ShowDialog();
            }
        }
    }
}