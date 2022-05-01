using System;
using LinkedListProblems;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Linked List Program");
        LinkedList list = new LinkedList();
        list.Add(56);
        list.Add(70);     
        int num = list.Search(56);
        list.InsertAtParticularPosition(num + 1, 30);
        list.Display();
    }

}
