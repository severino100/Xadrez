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
    abstract class Peca
    {

        public abstract bool jogar(Point partida, Point chegada, String nome, String nomeChegada, List<Panel> pecas);
    }
}
