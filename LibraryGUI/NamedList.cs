using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCodeFirst;
using Microsoft.VisualBasic;

namespace LibraryGUI
{
    public class NamedList<T> : IEnumerable<T> where T : INamable
    {
        private List<T> _items;
        public NamedList()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public IEnumerable<T> GetByName(string name)
        {
            return _items.Where(x => x.Name.Contains(name)).ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            
            foreach(var elem in _items)
                yield return elem;
            //return new NamableEnumerator<T>(_items);
            
            //yield return _items[0];
            //yield return _items[1];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class NamableEnumerator<T> : IEnumerator<T> where T : INamable
    {
        private bool disposedValue;

        private List<T> _items;

        private int index = -1;

        public NamableEnumerator(List<T> items)
        {
            _items = items;               
        }

        public T Current => _items[index];

        object IEnumerator.Current => _items[index];

        public bool MoveNext()
        {            
            if (index == _items.Count - 1)
                return false;
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~NamableEnumerator()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);            
        }
    }
}
