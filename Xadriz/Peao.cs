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
    class Peao : Peca
    {
        //devolve se pode jogar ou n
        public override bool jogar(Point partida, Point chegada, String nome, String nomeChegada, List<Panel> pecas)
        {
            if (nome == "PeaoPapel")
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
            //58
            if(nome == "PeaoMadeira")
            {
                if(partida.X == chegada.X)
                {
                    if (partida.Y + 58 == chegada.Y && nomeChegada == "Vazio")
                    {
                        return true;
                    }
                    else
                    {
                        if ((partida.Y + 58 + 58) == chegada.Y && partida.Y == 108 && nomeChegada == "Vazio")
                        {
                            return true;
                        }
                    }
                            
                }
                if ((partida.X == (chegada.X + 58) || partida.X == (chegada.X - 58)))
                {
                    if((partida.Y + 58) == chegada.Y && nomeChegada != "Vazio")
                    {
                        return true;
                    }
                }  
            }
            if (nome == "PeaoPapel")
            {
                
                if (partida.X == chegada.X)
                {

                    if (partida.Y - 58 == chegada.Y && nomeChegada == "Vazio")
                    {
                        return true;
                    }
                    else
                    {
                        if (partida.Y - 58 - 58 == chegada.Y && partida.Y == 398 && nomeChegada == "Vazio")
                        {
                            return true;
                        }
                    }
                     
                }
                if ((partida.X == (chegada.X + 58) || partida.X == (chegada.X - 58)))
                {
                    if ((partida.Y - 58) == chegada.Y && nomeChegada != "Vazio")
                    {
                        return true;
                    }
                } 
            }

            return false;
        }
    }
}
