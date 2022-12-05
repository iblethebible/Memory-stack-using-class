namespace memorystackClass
{
    internal class Program
    {
        class Stack
        {
            //max size of stack
            static int maxstack = 5;
            //top of stack for functions
            public int top;
            //create stack array
            int[] stack = new int[maxstack];


            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }
            internal bool Push(int data)
            {
                if (top >= 3)
                {
                    //check for overflow
                    Console.WriteLine("Stack Overflow");

                    return false;
                }
                else
                {
                    stack[top++] = data;
                    return true;
                }
            }
            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("stack underflow error");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }
            internal void Peek()
            {
                if (top<0)
                {
                    Console.WriteLine("Stack underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("The top element is: {0}", stack[top]);
                }
            }
            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return ;
                }
                else
                {
                    Console.WriteLine("Items in stack: ");
                    for (int i = top; i >=0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            //Create stack and give options

            Console.WriteLine("|   Stack   |");
            Stack newStack = new Stack();

            //while loop

            int go = 1;
            while (go == 1)
            {
                Console.WriteLine("1 = Pop, 2 = Push, 3 = Peak, 4 = View Stack");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Item popped from Stack : {0}", newStack.Pop());
                }
                if (input == 2)
                {
                    Console.WriteLine("Enter integer to push to stack");
                    int userPushInput = Convert.ToInt32(Console.ReadLine());
                    newStack.Push(userPushInput);
                }
                if (input == 3)
                {
                    newStack.Peek();
                }
                if (input == 4)
                {
                    newStack.PrintStack();
                }
                if (input == 5)
                {
                    go = 0;
                }
            }
        }
    }
}