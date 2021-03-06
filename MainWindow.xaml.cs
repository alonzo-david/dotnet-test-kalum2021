using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using kalum2021.Models;
using kalum2021.Views;

namespace kalum2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**public void Saludar(Object sender, RoutedEventArgs e)
        {
            Student estudiante = new Student("20210001","Juan Alberto", "De Leon", "jalberto@gmail.com", new DateTime(1980,3,30),"Masculino","24876395");
            //estudiante.FirstName = "Juan Alberto";
            //estudiante.LastName = "De Leon";
            //estudiante.Email = "jalberto@gmail.com";
            //estudiante.Birthday = new DateTime(1980,3,30);
            //estudiante.Gender = "Masculino";
            //estudiante.Phone = "24876395";
            //estudiante.StudentId = "20210001";

            Teacher profesor = new Teacher("FK-0001", "Raul Antonio","Perez Polanco", "emailprofe@gmail.com", new DateTime(1972,01,01),"Masculino","55125252");
            //profesor.FirstName = "Raul Antonio";
            //profesor.LastName = "Perez Polanco";
            //profesor.Email = "emailprofe@gmail.com";
            //profesor.Birthday = new DateTime(1972,01,01);
            //profesor.Gender = "Masculino";
            //profesor.Phone = "55125252";
            //profesor.EmployeeId = "FK-0001";

            MessageBox.Show(estudiante.ToString(), "Estudiante");
            MessageBox.Show(profesor.ToString(),"Profesor");
        }*/
        public void VentanaUsuario(Object sender, RoutedEventArgs e)
        {
            UsuarioView VentanaUsuario  = new UsuarioView();
            VentanaUsuario.ShowDialog();
        }

        public void VentanaRoles(Object sender, RoutedEventArgs e)
        {
            RoleView VentanaRoles = new RoleView();
            VentanaRoles.ShowDialog();
        }
    }
}
