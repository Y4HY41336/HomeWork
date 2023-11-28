using Algorithms;

CustomList<int> customList = new CustomList<int>();
customList.Add(1);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(2);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(3);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(4);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(5);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(6);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(7);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(8);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.Add(9);
Console.WriteLine(customList.Capacity);
Console.WriteLine(customList.Count);
customList.FindAll(x => x % 2 == 0);
Console.WriteLine(customList.Contains(0));

//for (int i = 0; i < customList.Count; i++)
//{

//}




List<int> ints = new List<int>();

ints.Exists();