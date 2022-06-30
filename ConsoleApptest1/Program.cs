// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the value with space.");

try
{
    List<long> itms = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(x => Int64.Parse(x)).ToList();
    //List<int> itms = new List<int>() { 1,2,3,4,5 };
    List<long> listOfSum = new List<long>();

    for (int i = 0; i < itms.Count; i++)
    {
        listOfSum.Add(itms.Where((x, indx) => indx != i).Sum());
    }
    Console.WriteLine(String.Concat("Minimum Value:",listOfSum.Min()));
    Console.WriteLine(string.Concat("Maximum Value:", listOfSum.Max()));
    //foreach (var s in listOfSum)
    //    Console.WriteLine(s);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }

