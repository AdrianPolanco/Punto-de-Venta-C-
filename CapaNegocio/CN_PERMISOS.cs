﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PERMISOS
    {
        private CD_PERMISOS objcd_permisos = new CD_PERMISOS();

        public List<Permisos> Listar(int IdUsuario)
        {
            return objcd_permisos.Listar(IdUsuario);
        }
    }
}
