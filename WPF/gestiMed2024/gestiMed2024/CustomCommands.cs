using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace gestiMed2024
{
    class CustomCommands
    {
        public static readonly RoutedUICommand Cancelar = new RoutedUICommand(
           "Cancelar",
           "Cancelar",
           typeof(CustomCommands),
           new InputGestureCollection
           {
                new KeyGesture(Key.C,ModifierKeys.Control)
           }
           );
        public static readonly RoutedUICommand Salir = new RoutedUICommand(
            "Salir",
            "Salir",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.S,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand HabNueva = new RoutedUICommand(
            "HabNueva",
            "HabNueva",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.H,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand EliminarHabitacion = new RoutedUICommand(
            "EliminarHabitacion",
            "EliminarHabitacion",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.A,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand TratNuevo = new RoutedUICommand(
            "TratNuevo",
            "TratNuevo",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.T,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand EliminarTratamiento = new RoutedUICommand(
            "EliminarTratamiento",
            "EliminarTratamiento",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.R,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand MedicamentoNuevo = new RoutedUICommand(
            "MedicamentoNuevo",
            "MedicamentoNuevo",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.M,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand EliminarMedicamento = new RoutedUICommand(
            "EliminarMedicamento",
            "EliminarMedicamento",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.D,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand MedicoNuevo = new RoutedUICommand(
            "MedicoNuevo",
            "MedicoNuevo",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.E,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand EliminarMedico = new RoutedUICommand(
            "EliminarMedico",
            "EliminarMedico",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.I,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand PacienteNuevo = new RoutedUICommand(
            "PacienteNuevo",
            "PacienteNuevo",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.P,ModifierKeys.Control)
            }
            );
        public static readonly RoutedUICommand EliminarPaciente = new RoutedUICommand(
            "EliminarPaciente",
            "EliminarPaciente",
            typeof(CustomCommands),
            new InputGestureCollection
            {
                new KeyGesture(Key.N,ModifierKeys.Control)
            }
            );
    }
}
