﻿using gestiMed_Medico.viewmodels;
using gestiMed_Medico.vistas;
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

namespace gestiMed_Medico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm;
        public MainWindow()
        {
            vm = new MainWindowVM();
            this.DataContext = vm;
            vm.setVentana(this);
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            string dni = dniTextBox.Text;
            string pass = passTextBox.Text;
            vm.aceptar(dni,pass);
        }

        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            vm.cancelar();
        }
    }
}
