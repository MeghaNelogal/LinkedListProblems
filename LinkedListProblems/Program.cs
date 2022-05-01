using System;
using LinkedListProblems;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Linked List Program");
        LinkedList list = new LinkedList();
        list.Add(56);
        list.Add(30);
        list.Add(70);
        list.Display();
        list.AddInReverseOrder(70);
        list.Display();

    }
}