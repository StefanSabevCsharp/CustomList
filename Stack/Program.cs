using Stack;

CustomStack stack = new CustomStack();
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
stack.Push(6);
stack.Push(7);
stack.Push(8);
stack.Push(9);


Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
stack.ForEach(x => Console.WriteLine(x));