using System;

class NumsToEnter
{
    
    public static int InputNums()
    {
        //int a = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        bool isNum = int.TryParse(s, out int st);
        while (!isNum)
        {
            Console.WriteLine("Вам нужно ввести целое число");
            s = Console.ReadLine();
            isNum = int.TryParse(s, out st);
        }
        return st;
    }

    
}