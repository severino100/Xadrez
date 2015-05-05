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
    class Guardar
    {
        Dictionary<Point, String> milinho = new Dictionary<Point,String>();

        public void preencher(List<Panel> pecas)
        {
            milinho = new Dictionary<Point, String>();
            foreach(Panel peca in pecas)
            {
                milinho.Add(peca.Location, peca.Name);
            }
        }
        public List<Panel> devolver(List<Panel> pecas)
        {
            foreach(KeyValuePair<Point, String> mili in milinho)
            {
                foreach (Panel peca in pecas)
                {
                    if( mili.Key == peca.Location)
                    {
                        peca.Name = mili.Value;
                    }
                }
            }
            return pecas;
        }
    }
}
