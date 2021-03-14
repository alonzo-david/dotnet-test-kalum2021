using System;
using System.ComponentModel;
using System.Windows.Input;
using kalum2021.Models;

namespace kalum2021.ModelView
{
    public class RoleViewModel : INotifyPropertyChanged, ICommand
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;
        public RoleViewModel Instancia {get; set;}
        public RolesViewModel RolesViewModel {get; set;}
        public string Nombre {get; set;}

        public RoleViewModel(RolesViewModel RolesViewModel)
        {
            this.Instancia = this;
            this.RolesViewModel = RolesViewModel;
        }

        public bool CanExecute(object parametro)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if(parametro.Equals("Guardar"))
            {
                Roles nuevo = new Roles(100, Nombre);
                this.RolesViewModel.agregarElemento(nuevo);
            }
        }
    }
}