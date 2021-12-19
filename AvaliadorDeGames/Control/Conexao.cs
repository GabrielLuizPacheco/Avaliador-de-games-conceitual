using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliadorDeGames.Control
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gabriel.lparaujo\Desktop\solution_AvaliadorDeGames_Gabriel\AvaliadorDeGames\DBavalidorDeGames.mdf;Integrated Security=True";
        }
    }
}
