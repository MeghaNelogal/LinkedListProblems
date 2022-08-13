namespace LinkedListProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Linked List Problems");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.AddInReverseOrder(70);
            list.Display();
        }
    }
}
  