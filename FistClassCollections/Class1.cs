using System;
using System.Collections;
using System.Collections.Generic;

namespace FistClassCollections
{
    public class Class1
    {
        public void Testar()
        {
            var registro = new Registro() { Buscavel = false };

            var listaDeRegistros =  new ListaDeRegistros();
            listaDeRegistros.Add(registro);

            var listaDeRegistros2 = new ListaDeRegistros2();
            listaDeRegistros2.Contains(registro);
        }
    }

    public class ListaDeRegistros : IList<Registro>
    {
        private List<Registro> _items;

        public Registro this[int index] { get => _items[index]; set => _items[index] = value; }

        public int Count => _items.Count;

        public bool IsReadOnly => false;

        public void Add(Registro item)
        {
            // Possíveis implementações e regras

            _items.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Registro item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Registro[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Registro> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Registro item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Registro item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Registro item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class ListaDeRegistros2
    {
        private List<Registro> _items;

        public int Count => _items.Count;

        public void Add(Registro item)
        {
            // Possíveis implementações e regras

            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(Registro item)
        {
            if (!item.Buscavel)
                return false;

            return _items.Contains(item);
        }
    }

    public class Registro
    {
        public bool Buscavel { get; set; }

        public List<Registro> Filhos { get; set; }
    }
}
