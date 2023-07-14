public class Program
{
    public static void Main(string[] args)
    {
        Stack stack = new Stack();

        // Pushing elements to the stack
        stack.Push(70);
        stack.Push(30);
        stack.Push(56);

        // Peeking the top element
        Console.WriteLine("Top element: " + stack.Peek());

        // Popping elements from the stack until it's empty
        Console.WriteLine("Elements popped from the stack:");
        while (!stack.IsEmpty())
        {
            int poppedElement = stack.Pop();
            Console.WriteLine(poppedElement);
        }
    }
}
