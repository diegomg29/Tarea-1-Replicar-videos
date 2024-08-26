using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Clases;

namespace WinFormsApp1.Algoritmos
{
    public class Simulacion
    {
        public Simulacion() { }
        public List<int> GeneradorValores(int n)
        {
            List<int> listaAleatorios = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaAleatorios.Add(5*(i+1));
            }
            return listaAleatorios;

        }
    }
}
