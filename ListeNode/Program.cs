using ListeNode;

List l1 = new List();
Console.WriteLine("*****T1");
l1.Add(17);
Console.WriteLine(l1.ToString());
Console.WriteLine("*****T2");
l1.Add(22);
Console.WriteLine(l1.ToString());
List l2 = new List();
Console.WriteLine("*****T3");
Console.WriteLine(l2.ToString());
Console.WriteLine("*****T4");
Console.WriteLine(l2.Count);
Console.WriteLine("**");
Console.WriteLine(l1.Count);
//Count nisam bas razumeo kako readonly ali su mi rekli da ste pricali o property na bloku kad nisam bio tu,
//ovako sam jedino znao da ga izvedem
Console.WriteLine("****T5");
l2.Add(3);
l2.Add(4);
l2.Add(5);
Console.WriteLine(l2.Count);
l2.RemoveAt(1);
Console.WriteLine(l2.ToString());
Console.WriteLine("****T6");
List l3 = new List();
l3.RemoveAt(1);
Console.WriteLine(l3.ToString());
Console.WriteLine("****T7");
l3.Add(10);
l3.Add(11);
l3.RemoveAt(0);
Console.WriteLine(l3.ToString());
Console.WriteLine("****T8");
List l4 = new List();
l4.Add(10);
l4.Add(11);
l4.Add(12);
l4.RemoveAt(2);
Console.WriteLine(l4.ToString());

