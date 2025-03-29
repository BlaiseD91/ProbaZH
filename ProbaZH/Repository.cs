using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbaZH
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Find(Func<T, bool> predicate)
        {
            return items.First(predicate);
        }

        public List<T> GetAll()
        {
            return new List<T>(items); // Visszaadja a lista másolatát, hogy a belső lista ne legyen közvetlenül módosítható
        }
    }


}
