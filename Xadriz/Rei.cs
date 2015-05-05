using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Xadriz
{
    [Serializable]
    class Rei : Peca
    {

        public override bool jogar(Point partida, Point chegada, String nome, String nomeChegada, List<Panel> pecas)
        {
            if (nome == "ReiPapel")
            {
                if (nomeChegada == "PeaoPapel" || nomeChegada == "TorrePapel" || nomeChegada == "CavaloPapel" || nomeChegada == "BispoPapel" || nomeChegada == "ReiPapel" || nomeChegada == "RainhaPapel")
                {
                    return false;
                }
            }
            else
            {
                if (nomeChegada == "PeaoMadeira" || nomeChegada == "TorreMadeira" || nomeChegada == "CavaloMadeira" || nomeChegada == "BispoMadeira" || nomeChegada == "ReiMadeira" || nomeChegada == "RainhaMadeira")
                {
                    return false;
                }
            }
            if (partida.Y - 58 == chegada.Y && partida.X == chegada.X)
            {
                return true;
            }
            if (partida.Y + 58 == chegada.Y && partida.X == chegada.X)
            {
                return true;
            }
            if (partida.X - 58 == chegada.X && partida.Y == chegada.Y)
            {
                return true;
            }
            if (partida.X + 58 == chegada.X && partida.Y == chegada.Y)
            {
                return true;
            }
            if (partida.Y - 58 == chegada.Y && partida.X - 58 == chegada.X)
            {
                return true;
            }
            if (partida.Y + 58 == chegada.Y && partida.X - 58 == chegada.X)
            {
                return true;
            }
            if (partida.Y - 58 == chegada.Y && partida.X + 58 == chegada.X)
            {
                return true;
            }
            if (partida.Y + 58 == chegada.Y && partida.X + 58 == chegada.X)
            {
                return true;
            }
            return false;
        }
    }
}
