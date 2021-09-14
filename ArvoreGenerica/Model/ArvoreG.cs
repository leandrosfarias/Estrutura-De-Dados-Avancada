using System;
using System.Collections.Generic;
using System.Text;

namespace ArvoreGenerica.Model
{
    public static class ArvoreG
    {
        // Profundidade do nó
        public static int Profundidade(No<string> no)
        {
            if (no.EhRaiz())
                return 0;
            return 1 + Profundidade(no.Pai);
        }

        // Nivel do nó
        public static void Nivel(No<string> no)
        {
            ArvoreG.Profundidade(no);
        }

        
    }
}
