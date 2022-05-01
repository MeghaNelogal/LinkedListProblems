using System;
using LinkedListProblems;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("WELCOME IN THE DATA STRUCTURE");
        LinkedList list = new LinkedList();
        bool check = true;
        Console.WriteLine("\n1. Display Linked List Data\n2. Dislpay Appeded Element list\n3. Adding Data at the perticular Position\n4. Delete Data At Perticular Position\n5. Deleting Last Index Elements");
        while (check)
        {
            Console.WriteLine("ENTER THE ABOVE OPTION TO EXECUTE THE METHODS");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("DISPLAYING ELEMENT OF THE LINKED LIST");
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                case 2:
                    Console.WriteLine("DISPLAYING ELEMENT OF THE LINKED LIST");
                    list.Add(56);
                    list.Append(30);
                    list.Append(70);
                    break;
                case 3:
                    Console.WriteLine("ADDING  ELEMENT ON PERTICULAR POSITION IN THE LINKED LIST");
                    list.Add(56);
                    list.Add(70);
                    int a = list.Search(56);
                    list.InsertAtPerticularPosition(a + 1, 30);
                    list.Display();
                    break;
                case 4:
                    Console.WriteLine("DELETING ELEMENT AT PERTICULAR POSITION IN THE LINKED LIST");
                    Console.WriteLine("Enter the position of the Element");
                    int index = Convert.ToInt32(Console.ReadLine());
                    list.DeleteNodeAtPerticularPosition(index);
                    list.Display();
                    break;
                case 5:
                    Console.WriteLine("DELETING  AT POSITION ELEMENT IN THE LINKED LIST");
                    list.DeleteLastIndex();
                    list.Display();
                    break;
                case 0:
                    check = false;
                    break;
            }
        }
    }
}