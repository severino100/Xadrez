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
    class Rainha : Peca
    {
        public override bool jogar(Point partida, Point chegada , String nome, String nomeChegada, List<Panel> pecas)
        {
            if (nome == "RainhaPapel")
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
            if (chegada.X > partida.X) //andar pa direita baixo
            {
                if (chegada.Y > partida.Y)
                {
                    if ((chegada.Y - partida.Y) == (chegada.X - partida.X))//a distancia no x e no y tem de ser sempre igual
                    {

                        foreach (Panel diagonalBaixoDireita in pecas)
                        {
                            if (diagonalBaixoDireita.Name != "Vazio")
                            {
                                if ((diagonalBaixoDireita.Location.Y - partida.Y) == (diagonalBaixoDireita.Location.X - partida.X))
                                {
                                    if ((diagonalBaixoDireita.Location.Y < chegada.Y) && (diagonalBaixoDireita.Location.Y > partida.Y))//se o obstaculo esta no  meio do inico e fim no y
                                    {
                                        if ((diagonalBaixoDireita.Location.X < chegada.X) && (diagonalBaixoDireita.Location.X > partida.X))//se o obstaculo esta no  meio do inico e fim no x
                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                        return true;
                    }
                }
            }

            if (chegada.X > partida.X) //andar pa direita cima
            {
                if (chegada.Y < partida.Y)
                {
                    if ((chegada.Y - partida.Y) == (partida.X - chegada.X))
                    {
                        foreach (Panel diagonalCimaDireita in pecas)
                        {
                            if (diagonalCimaDireita.Name != "Vazio")
                            {
                                if ((diagonalCimaDireita.Location.Y - partida.Y) == (partida.X - diagonalCimaDireita.Location.X))
                                {
                                    if ((diagonalCimaDireita.Location.Y > chegada.Y) && (diagonalCimaDireita.Location.Y < partida.Y))//se o obstaculo esta no  meio do inico e fim no y
                                    {
                                        if ((diagonalCimaDireita.Location.X < chegada.X) && (diagonalCimaDireita.Location.X > partida.X))//se o obstaculo esta no  meio do inico e fim no x
                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                        return true;
                    }
                }
            }
            if (chegada.X < partida.X) //andar pa esquerda Baixo
            {
                if (chegada.Y > partida.Y)
                {
                    if ((partida.Y - chegada.Y) == (chegada.X - partida.X))
                    {
                        foreach (Panel diagonalBaixoEsquerda in pecas)
                        {
                            if (diagonalBaixoEsquerda.Name != "Vazio")
                            {
                                if ((partida.Y - diagonalBaixoEsquerda.Location.Y) == (diagonalBaixoEsquerda.Location.X - partida.X))
                                {
                                    if ((diagonalBaixoEsquerda.Location.Y < chegada.Y) && (diagonalBaixoEsquerda.Location.Y > partida.Y))//se o obstaculo esta no  meio do inico e fim no y
                                    {
                                        if ((diagonalBaixoEsquerda.Location.X > chegada.X) && (diagonalBaixoEsquerda.Location.X < partida.X))//se o obstaculo esta no  meio do inico e fim no x
                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                        return true;
                    }
                }
            }

            if (chegada.X < partida.X) //andar pa a esquerda cima
            {
                if (chegada.Y < partida.Y)
                {
                    if ((partida.Y - chegada.Y) == (partida.X - chegada.X))
                    {
                        foreach (Panel diagonalCimaEsquerda in pecas)
                        {
                            if (diagonalCimaEsquerda.Name != "Vazio")
                            {
                                if ((partida.Y - diagonalCimaEsquerda.Location.Y) == (partida.X - diagonalCimaEsquerda.Location.X))
                                {
                                    if ((diagonalCimaEsquerda.Location.Y > chegada.Y) && (diagonalCimaEsquerda.Location.Y < partida.Y))//se o obstaculo esta no  meio do inico e fim no y
                                    {
                                        if ((diagonalCimaEsquerda.Location.X > chegada.X) && (diagonalCimaEsquerda.Location.X < partida.X))//se o obstaculo esta no  meio do inico e fim no x
                                        {
                                            return false;
                                        }
                                    }
                                }
                            }
                        }
                        return true;
                    }
                }
            }
            //baixo
            if (partida.Y == chegada.Y)
            {
                if (chegada.X < partida.X)
                {
                    foreach (Panel esquerda in pecas)
                    {
                        if (esquerda.Name != "Vazio")
                        {
                            if (esquerda.Location.Y == chegada.Y)
                            {
                                if (esquerda.Location.X > chegada.X)
                                {
                                    if (esquerda.Location.X < partida.X)
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
