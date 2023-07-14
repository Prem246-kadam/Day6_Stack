public class Stack
{
    private Node top;

    public void Push(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        int poppedValue = top.Data;
        top = top.Next;
        return poppedValue;
    }

    public int Peek()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}
