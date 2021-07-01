using System;
using System.Collections.Generic;
using System.Text;

namespace SORTEADOR_ONLINE_GRATIS
{
    class Item
    {
        private string _nome;
        private bool _sorteado;

        public string Nome { get => _nome; set => _nome = value; }
        public bool Sorteado { get => _sorteado; set => _sorteado = value; }

        public Item(string nome)
        {
            Nome = nome;
            Sorteado = false;
        }
    }
}

