using CustomList;

MyList list = new MyList();
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
Console.WriteLine(list.Contains(6));
int a = list[1];
Console.WriteLine(a);

list.RemoveAt(1);
Console.WriteLine(list[1]);
