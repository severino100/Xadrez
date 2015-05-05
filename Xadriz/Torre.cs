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
    class Torre : Peca
    {
        public override bool jogar(Point partida, Point chegada, String nome, String nomeChegada, List<Panel> pecas)
        {
            if (nome == "TorrePapel")
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
            //baixo
            if (partida.Y == chegada.Y)
            {
                if(chegada.X < partida.X)
                {
                    foreach(Panel esquerda in pecas)
                    {
                        if(esquerda.Name != "Vazio")
                        {
                            if(esquerda.Location.Y == chegada.Y)
                            {
                                if(esquerda.Location.X > chegada.X)
                                {
                                    if(esquerda.Location.X < partida.X)
                                    {
                                        return false;
                                    }
                                }
                            }

                        }
                    }
                }
                if (chegada.X > partida.X)
                {
                    foreach (Panel esquerda in pecas)
                    {
                        if (esquerda.Name != "Vazio")
                        {
                            if (esquerda.Location.Y == chegada.Y)
                            {
                                if (esquerda.Location.X < chegada.X)
                                {
                                    if (esquerda.Location.X > partida.X)
                                    {
                                        return false;
                                    }
                                }
                            }

                        }
                    }
                }
                return true;
            }
            if (partida.X == chegada.X)
            {
                if (chegada.Y < partida.Y)
                {
                    foreach (Panel esquerda in pecas)
                    {
                        if (esquerda.Name != "Vazio")
                        {
                            if (esquerda.Location.X == chegada.X)
                            {
                                if (esquerda.Location.Y > chegada.Y)
                                {
                                    if (esquerda.Location.Y < partida.Y)
                                    {
                                        return false;
                                    }
                                }
                            }

                        }
                    }
                }
                if (chegada.Y > partida.Y)
                {
                    foreach (Panel esquerda in pecas)
                    {
                        if (esquerda.Name != "Vazio")
                        {
                            if (esquerda.Location.X == chegada.X)
                            {
                                if (esquerda.Location.Y < chegada.Y)
                                {
                                    if (esquerda.Location.Y > partida.Y)
                                    {
                                        return false;
                                    }
                                }
                            }

                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
