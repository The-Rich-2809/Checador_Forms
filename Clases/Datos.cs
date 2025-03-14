﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Checador_Forms.Clases
{
    public static class Datos
    {
        public static DateTime HoraEntrada { get; set; }
        public static DateTime HoraSalida { get; set; }
        public static string NombreSite {  get; set; }
        public static int IdSite { get; set; }
        public static string NombreEmpleado { get; set; }
        public static string Apellido1 { get; set; }
        public static string Apellido2 { get; set; }
        public static byte[] HuellaSring { get; set; }
        public static int IdEncargado { get; set; }
        public static string Encargado { get; set; }
        public static string TipoUsuario { get; set; }
        public static string Hash { get; set; }
        public static string[] Usuarios = { "Empleado", "Manager", "Administrador" };
        public static string IdEmpleado { get; set; }
        public static DateTime Registro { get; set; }
    }
}
