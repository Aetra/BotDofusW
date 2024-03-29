﻿using Bot_Dofus_1._29._1.Otros.Game.Personaje.Inventario.Enums;
using System.Collections.Generic;

namespace Bot_Dofus_1._29._1.Otros.Game.Personaje.Inventario
{
    public static class InventarioUtiles
    {
        private static Dictionary<int, List<InventarioPosiciones>> possibles_posiciones = new Dictionary<int, List<InventarioPosiciones>>
        {
            { 1,  new List<InventarioPosiciones>()
            { InventarioPosiciones.AMULETO } },

            { 2,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 3,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 4,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 5,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 6,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 7,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 8,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ARMA } },

            { 9,  new List<InventarioPosiciones>()
            { InventarioPosiciones.ANILLO_IZQUIERDA, InventarioPosiciones.ANILLO_DERECHA } },

            { 10,  new List<InventarioPosiciones>()
            { InventarioPosiciones.CINTURON } },

            { 11,  new List<InventarioPosiciones>()
            { InventarioPosiciones.BOTAS } },

            { 16,  new List<InventarioPosiciones>()
            { InventarioPosiciones.SOMBRERO } },

            { 17,  new List<InventarioPosiciones>()
            { InventarioPosiciones.CAPA } },

            { 18, new List<InventarioPosiciones>()
            { InventarioPosiciones.MASCOTA } },

            { 19, new List<InventarioPosiciones>()//hacha
            { InventarioPosiciones.ARMA } },

            { 20, new List<InventarioPosiciones>()//herramienta
            { InventarioPosiciones.ARMA } },

            { 21, new List<InventarioPosiciones>()//pico
            { InventarioPosiciones.ARMA } },

            { 22, new List<InventarioPosiciones>()//Guadaña
            { InventarioPosiciones.ARMA } },

            { 23, new List<InventarioPosiciones>()
            { InventarioPosiciones.DOFUS1, InventarioPosiciones.DOFUS2, InventarioPosiciones.DOFUS3, InventarioPosiciones.DOFUS4, InventarioPosiciones.DOFUS5, InventarioPosiciones.DOFUS6 } },

            { 82, new List<InventarioPosiciones>()
            { InventarioPosiciones.ESCUDO } },

            { 83, new List<InventarioPosiciones>()//piedra de alma
            { InventarioPosiciones.ARMA } },
        };

        public static List<InventarioPosiciones> get_Posibles_Posiciones(int tipo_objeto) => possibles_posiciones.ContainsKey(tipo_objeto) ? possibles_posiciones[tipo_objeto] : null;

        public static TipoObjetosInventario get_Objetos_Inventario(byte tipo)
        {
            switch (tipo)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 83:
                    return TipoObjetosInventario.EQUIPAMIENTO;

                case 12:
                case 13:
                case 85:
                case 86:
                    return TipoObjetosInventario.VARIOS;

                case 15:
                case 33:
                case 34:
                case 35:
                case 36:
                case 38:
                case 41:
                case 46:
                case 47:
                case 48:
                case 50:
                case 51:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 65:
                case 68:
                case 84:
                case 96:
                case 98:
                case 100:
                case 103:
                case 104:
                case 105:
                case 106:
                case 107:
                case 108:
                case 109:
                case 111:
                    return TipoObjetosInventario.RECURSOS;

                case 24:
                    return TipoObjetosInventario.OBJETOS_MISION;

                default:
                    return TipoObjetosInventario.DESCONOCIDO;
            }
        }
    }
}
