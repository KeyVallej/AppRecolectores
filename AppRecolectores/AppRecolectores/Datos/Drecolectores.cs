using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppRecolectores.Conexiones;
using AppRecolectores.Datos;
using AppRecolectores.Modelo;

namespace AppRecolectores.Datos
{
    public class Drecolectores
    {
        public async Task<List<Mrecolectores>>Mostrarrecolectores(Mrecolectores parametrospedir) 
        {
            return (await Constantes.firebase
                 .Child("Recolectores")
                 .OnceAsync<Mrecolectores>()).Where(a => a.Object.Correo == parametrospedir.Correo).Select(item => new Mrecolectores
                 {
                     Nombre = item.Object.Nombre,
                     Idrecolectror=item.key
                 }).ToList();
        }


    }
}
