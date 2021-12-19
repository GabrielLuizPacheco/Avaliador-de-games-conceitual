using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AvaliadorDeGames.Model
{
    class Jogo
    {
        private static string nomeJogo;
        private static string desenvJogo;
        private static DateTime dataLanc;
        private static string categoria;
        private static string sinopse;
        private static string plataforma;
        private static byte[] capaJogo;
        private static string notaJogo;
        private static int idJogo;
        private static int darNotaJogo;
        private static string nomejogoBox;
        private static string dataLancMostrar;

        public static string NomeJogo { get => nomeJogo; set => nomeJogo = value; }
        public static string DesenvJogo { get => desenvJogo; set => desenvJogo = value; }
        public static string Categoria { get => categoria; set => categoria = value; }
        public static string Sinopse { get => sinopse; set => sinopse = value; }
        public static string Plataforma { get => plataforma; set => plataforma = value; }
        public static byte[] CapaJogo { get => capaJogo; set => capaJogo = value; }
        public static string NotaJogo { get => notaJogo; set => notaJogo = value; }
        public static int IdJogo { get => idJogo; set => idJogo = value; }
        public static int DarNotaJogo { get => darNotaJogo; set => darNotaJogo = value; }
        public static string NomejogoBox { get => nomejogoBox; set => nomejogoBox = value; }
        public static DateTime DataLanc { get => dataLanc; set => dataLanc = value; }
        public static string DataLancMostrar { get => dataLancMostrar; set => dataLancMostrar = value; }
    }
}
