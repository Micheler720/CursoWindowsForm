using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Extencoes
{
    public static class ListExtencoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] valores)
        {
            foreach (T item in valores)
            {
                lista.Add(item);
            }

        }
    }
}
