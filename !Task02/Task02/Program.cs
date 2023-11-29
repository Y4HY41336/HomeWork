using Algorithms;

CustomList<int> customList = new CustomList<int>();
customList.Add(1);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(2);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(3);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(4);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(5);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(6);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(7);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(8);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
customList.Add(9);
//Console.WriteLine(customList.Capacity);
//Console.WriteLine(customList.Count);
Console.WriteLine(customList.FindAll(x => x % 2 == 0));
//Console.WriteLine(customList.Find(x => x % 2 == 0));
//Console.WriteLine(customList.Contains(4));
//Console.WriteLine(customList.Remove(5));
//Console.WriteLine(customList.Exists(x => x==12));
for (int i = 0; i < customList.Count; i++)
{
    Console.WriteLine(customList.list[i]);

}
//Console.WriteLine(customList.FindAll(x => x == 1));



List<int> ints = new List<int>();
//ints.Add(1);
//ints.Add(2);
//ints.Add(3);
//ints.Add(4);
//ints.Add(5);
//ints.Add(6);
//ints.Add(7);
////ints.Find(x => x == 1);
//Console.WriteLine(ints.Remove(0));
////ints.Remove(5);
//foreach (int x in ints)
//{
//    Console.WriteLine(x);
//}
//Console.WriteLine(ints.Remove(0));
//Console.WriteLine(ints.Exists(x => x == 2));

//ints.Exists(x => x == 2);
