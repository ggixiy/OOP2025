using Microsoft.VisualBasic.FileIO;
using MyList;

class Program
{
    public static void Print(MyLinkedList list)
    {
        Node current = list.GetHead();
        while (current != null)
        {
            Console.Write(current.Data);

            if (current.Next == null) break;

            current = current.Next;
            Console.Write(" -> ");
        }
        Console.WriteLine();
    }


    public static void Main(string[] args)
    {
        MyLinkedList A = new MyLinkedList();
        for (short i = 1; i < 10; i++)
        {
            A.Add(i);
        }

        Console.WriteLine("List A:");
        Print(A);
        Print(A.GreaterThanGivenNum(5));

        foreach (short i in A)
        {
            Console.Write(i + 1 + ", ");
        }
       Console.WriteLine();

        MyLinkedList B = new MyLinkedList();
        Random random = new Random();
        for (int i = 1; i < 20; i++)
        {
            B.Add(Convert.ToInt16(random.Next(1,20)));
        }

        Console.WriteLine("List B:");
        Print(B);
        B.EvenElementsToNull();
        Print(B);

        MyLinkedList C = new MyLinkedList();
        for (int i = 1; i < 20; i++)
        {
            C.Add(Convert.ToInt16(random.Next(-10, 15)));
        }

        Console.WriteLine("List C:");
        Print(C);
        C.DeleteOddElements();
        Print(C);

        MyLinkedList D = new MyLinkedList();
        for (int i = 1; i < 10; i++)
        {
            D.Add(Convert.ToInt16(random.Next(10, 100)));
        }
        Console.WriteLine("List D:");
        Print(D);
        Print(D.Multiple(1));

        D.Delete(D.GetByIndex(0));
        Print(D);

        Console.WriteLine("List A:");
        A.Delete(A.GetByValue(0));
        Print(A);

        

    }
}
