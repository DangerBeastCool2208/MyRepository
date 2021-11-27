using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary_dll.MyCollection
{
    public class KeeperList<T> : IEnumerable
    { 
        MemorySlot<T> head;
        MemorySlot<T> tail;
        private int count;

        public int Count { get { return count; } }

        public void Add(T obj)
        {
            var slot = new MemorySlot<T>(obj);
            if (head == null) { head = slot; }
            else { tail.Next = slot; }
            tail = slot;
            count++;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contain(T date)
        {
            MemorySlot<T> current = head;
            while (current != null)
            {
                if (current.slot.Equals(date)) return true;
                current = current.Next;
            }
            return false;
        }

       
        public T LastGet()
        {
            MemorySlot<T> current = head;
            MemorySlot<T> isk = tail;
            if (head == null) return default(T);
            if (count == 1)
            {
                Clear();
                return current.slot;
            }
            
            while ((current.Next != null) && !current.Next.slot.Equals(tail.slot))
            {
                current = current.Next;
            }
            tail = current;
            tail.Next = null;
            count--;
            return isk.slot;
        }
        public bool Remove(T date)
        {
            MemorySlot<T> current = head;
            MemorySlot<T> previous = null;
            while (current != null)
            {
                if (current.slot.Equals(date))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null) tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public T FirstGet()
        {
            MemorySlot<T> current = head;
            head = head.Next;
            count--;
            return current.slot;
        }
        //IEnumerator<T> IEnumerable<T>.GetEnumerator()
        //{
        //    MemorySlot<T> current = head;
        //    while (current != null)
        //    {
        //        yield return current.slot;
        //        current = current.Next;
        //    }
        //}

        public IEnumerator GetEnumerator()
        {
            MemorySlot<T> current = head;
            while (current != null)
            {
                yield return current.slot;
                current = current.Next;
            }
        }
    }

    public class MemorySlot<T>
    {
        public override string ToString()
        {
            return slot.ToString();
        }
        public MemorySlot(T data)
        {
            slot = data;
        }
        public T slot { get; set; }

        public MemorySlot<T> Next { get; set; }
    }
}
