using System.Collections;

namespace MyList{ 
    class MyLinkedList : IEnumerable<short>
    {
        private Node head;

        public MyLinkedList()
        {
            head = null;
        }

        public void Add(short data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                this.head = newNode;
                return;
            }

            Node current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }
        
            current.Next = newNode;
        }

        public void Delete(Node node)
        {
            if (head == null) throw new InvalidOperationException("You cannot delete element from an empty list");

            if (head == node)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            Node prev = null;

            while (current != node && current != null)
            {
                prev = current;
                current = current.Next;
            }

            if (current == null) return;

            prev.Next = current.Next;
        }

        public MyLinkedList Multiple(short data)
        {
            Node current = head;
            MyLinkedList result = new MyLinkedList();

            while (current != null)
            {
                if((current.Data % data) == 0)
                {
                    result.Add(current.Data);
                }
                current = current.Next;
            }
            return result;
        }

        public void EvenElementsToNull()
        {
            Node current = head;
            int count = 0;
            while (current != null)
            {
                if((count % 2) == 0)
                {
                    current.Data = 0;
                }
                count++;
                current = current.Next;
            }
        }

        public MyLinkedList GreaterThanGivenNum(short data)
        {
            MyLinkedList newList = new MyLinkedList();
            Node current = head;
            while (current != null)
            {
                if(current.Data > data)
                {
                    newList.Add(current.Data);
                }
                current = current.Next;
            }
            return newList;
        }

        public void DeleteOddElements()
        {
            Node current = head;
            int count = 0;
            while (current != null)
            {
                if ((count % 2) != 0)
                {
                    Delete(current);
                }
                count++;
                current = current.Next;
            }
        }

        public Node GetHead()
        {
            return head;
        }

        public Node GetByIndex(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            Node current = head;
            int count = 0;

            while (current != null)
            {
                if (count == index)
                    return current;

                current = current.Next;
                count++;
            }

            throw new IndexOutOfRangeException("Index out of range!");
        }

        public Node GetByValue(short value)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Data == value)
                    return current;

                current = current.Next;
            }
            throw new InvalidOperationException($"There is no element with data {value}!");
        }

        public IEnumerator<short> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


