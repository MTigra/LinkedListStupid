using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CircularLinkedList<T>
    {
        
            List<LinkedListNode<T>> list = new List<LinkedListNode<T>>();
        private int curindx = -1;

        public LinkedListNode<T> Current
        {
            get;
            private set;
        }

        public CircularLinkedList(List<T> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.list.Add(new LinkedListNode<T>(list[i]));
            }
        }

        public CircularLinkedList()
        {

        }

        public void Add(T el)
        {
            list.Add(new LinkedListNode<T>(el));

        }


        public void Shift()
        {
            if (++curindx >= list.Count)
            {
                curindx = 0;
            }
            if (list.Count <= 0) Current = default(LinkedListNode<T>);
            else
            { Current = list[curindx]; }


        }

        public T Remove()
        {
            if(Current == null) throw new IndexOutOfRangeException("список пуст");
            T temp = Current.Value;
            list.Remove(Current);
            if (curindx >= list.Count)
            {
                Shift();
            }
            else
            {

                Current = list[curindx];
            }
            return temp;
        }
    }
}
