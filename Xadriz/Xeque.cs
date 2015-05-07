using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Xadriz
{
    class Xeque
    {
        public bool xequie(Panel partida, Panel chegada, bool tuno, List<Panel> pecas)
        {
            /*
            foreach(Panel simili in pecas)//simula a jogada
            {
                if(simili.Location == chegada.Location)//procura pelo panel de chegada
                {
                    simili.Location = partida.Location;
                    simili.Name = partida.Name;
                    partida.Name = "Vazio";
                }
            }*/

            foreach(Panel rei in pecas)
            {
                if(rei.Name == "ReiPapel")
                {
                    foreach(Panel procuraPeaoPapel in pecas)
                    {
                        if(procuraPeaoPapel.Name == "PeaoMadeira")
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y - 58) // Peao esquerda e direita
                            {
                                if (procuraPeaoPapel.Location.X == rei.Location.X - 58)// Peao esquerda
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.X == rei.Location.X + 58)// Peao direita
                                {
                                    return true;
                                }
                            }
                        }

                        //-------------------------------------------------------------------------------------------------
                        if (procuraPeaoPapel.Name == "CavaloMadeira")
                        {
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y - 58 - 58) // Cavlo cima direita e esquerda
                            {
                                if (procuraPeaoPapel.Location.X == rei.Location.X - 58)// Cavlo cima direita
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.X == rei.Location.X + 58)// Cavlo cima esquerda
                                {
                                    return true;
                                }
                            }
                            if (procuraPeaoPapel.Location.Y == rei.Location.Y + 58 + 58) //Cavlo baixo direita e esquerda
                            {
                                if (procuraPeaoPapel.Location.X == rei.Location.X - 58)//Cavlo baixo direita 
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoPapel.Location.X == rei.Location.X + 58)//Cavlo baixo esquerda
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
                else if(rei.Name == "ReiMadeira")
                {
                    foreach (Panel procuraPeaoMadeira in pecas)
                    {
                        if (procuraPeaoMadeira.Name == "PeaoPapel")
                        {
                            if (procuraPeaoMadeira.Location.Y == rei.Location.Y + 58) // Peao esquerda e direita
                            {
                                if (procuraPeaoMadeira.Location.X == rei.Location.X + 58)// Peao esquerda
                                {
                                    //MessageBox.Show("jsadfhblkufgbasdlkjbfasdjbh");
                                    return true;
                                }

                                if (procuraPeaoMadeira.Location.X == rei.Location.X - 58)// Peao direita
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
