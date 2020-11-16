using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BertoniTest.Helpers
{
    public static class MessagesHelper
    {
        public static string TextMsg { get; set; } = "Proceso ejecutado con exito.";

        public static string TextError { get; set; } = "Un error inesperado ha ocurrido.";

        public static string success { get; set; } = "success";
        public static string warning { get; set; } = "warning";
        public static string info { get; set; } = "info";
        public static string danger { get; set; } = "error";

    }
}
