using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej16_VisualizarNumeros
{
    class Visualizacion
    {
        public void Figuras (ListBox lista)
        {
            string n = "";
            int m = 3;
            for (int i = 1; i <= 7; i++)
            {
                if (i <= 4)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        n = n + j;
                    }
                }
                if (i>=5)
                {
                    for (int x = 1; x <= m; x++)
                    {
                       n = n + x;
                    }
                  m--;
                }
                lista.Items.Add(n);
                n = "";
            }
        }
    }
}
