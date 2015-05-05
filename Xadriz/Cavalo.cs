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
    class Cavalo : Peca
    {
        public override bool jogar(Point partida, Point chegada, String nome, String nomeChegada, List<Panel> pecas)
        {
            if (nome == "CavaloPapel")
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
            //------------------------------BAIXO----------------------------------------
            //duas baixo 1 esquerda
            if (((partida.X - 58) == chegada.X) && ((partida.Y + 58 + 58) == chegada.Y))
            {
                return true;
            }
            //duas baixo 1 direita
            if (((partida.X + 58) == chegada.X) && ((partida.Y + 58 + 58) == chegada.Y))
            {
                return true;
            }

            //-------------------------------CIMA---------------------------------------
            //duas cima 1 esquerda
            if (((partida.X - 58) == chegada.X) && ((partida.Y - 58 - 58) == chegada.Y))
            {
                return true;
            }
            //duas cima 1 direita
            if (((partida.X + 58) == chegada.X) && ((partida.Y - 58 - 58) == chegada.Y))
            {
                return true;
            }


            //duas esquerda 1 baixo
            if (((partida.X - 58 - 58) == chegada.X) && ((partida.Y + 58) == chegada.Y))
            {
                return true;
            }
            //duas direita 1 baixo
            if (((partida.X + 58 + 58) == chegada.X) && ((partida.Y - 58) == chegada.Y))
            {
                return true;
            }

            //duas esquerda 1 cima
            if (((partida.X - 58 - 58) == chegada.X) && ((partida.Y - 58) == chegada.Y))
            {
                return true;
            }
            //duas direita 1 baixo
            if (((partida.X + 58 + 58) == chegada.X) && ((partida.Y + 58) == chegada.Y))
            {
                return true;
            }

            return false;
        }
    }
}
