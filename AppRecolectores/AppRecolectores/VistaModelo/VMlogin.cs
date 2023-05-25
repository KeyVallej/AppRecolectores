using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AppRecolectores.Modelo;
using AppRecolectores.Datos;
using System.Threading.Tasks;

namespace AppRecolectores.VistaModelo
{
    public class VMlogin:BaseViewModel
    {
        #region VARIABLES
        string identificacion;
        #endregion
        #region CONSTRUCTOR
        public VMlogin(INavigation navigation)
        {
            Navigation = navigation;
            Logincomamd = new Command(async () => await proceso());
        }
        #endregion
        #region OBJETOS 
        public string Identificacion
        {
            get { return identificacion; }
            set { SetValue(ref identificacion, value); }
        }

        #endregion
        #region PROCESOS
        private async Task proceso ()
        {
            
        }
        #endregion
        #region COMANDOS
        public Command Logincomamd { get; }
        #endregion
    }
}
