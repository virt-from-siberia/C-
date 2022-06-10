using System.Collections.Generic;

namespace OOP
{
    public interface IBaseCollection
    {
        void Add(object obj);
        void Remove(object obj);
    }

    public static class BaseCollectionExtention
    {
        public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
        {
            foreach (var item in objects)
            {
                collection.Add(item);
            }
        }
    }

public class BaseList : IBaseCollection
    {
        private object[] items;
        private int counter = 0;
        
        public BaseList(int initialCapacity )
        {
            items = new object[initialCapacity];
        }
        public void Add(object obj)
        {
            items[counter] = obj;
            counter++;
        }

        public void Remove(object obj)
        {
            items[counter] = null;
            counter--;
        }
    }
}