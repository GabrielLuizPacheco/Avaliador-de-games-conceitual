using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorDeGames.Model
{
    class Usuario
    {
        private static int idUsuario;
        private static string nome;
        private static string nickname;
        private static string senha;
        private static string email;

        public static int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Nickname { get => nickname; set => nickname = value; }
        public static string Senha { get => senha; set => senha = value; }
        public static string Email { get => email; set => email = value; }
    }
}
