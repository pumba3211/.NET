using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PruebaWPF.AccesoDatos;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        AccesoDatos.AccesoDatos Acceso = AccesoDatos.AccesoDatos.Instance;
       
    }
}
