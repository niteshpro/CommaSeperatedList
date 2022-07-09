//Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
class List
{
    public static void Main()
    {
        string[] elements;

        while (true)
        {
            Console.WriteLine("Enter a List with more then 5 elements");
            var input = Console.ReadLine();
            if (!String.IsNullOrEmpty(input))
            {
                elements = input.Split(',');
                if(elements.Length >= 5)
                {
                    break;
                }

            }
            Console.WriteLine("Invalid List");
        }
        var numbers = new List<int>();
        foreach (var element in elements)
        {
            numbers.Add(Convert.ToInt32(element));
        }

        numbers.Sort();

        var smallest = new List<int>();
        for(int i = 0; i < 3; i++)
        {
            smallest.Add(numbers[i]);
        }

        Console.WriteLine("3 smallest numbers are");
        foreach(var element in smallest)
        {
            Console.WriteLine(element);
        }
    }
}