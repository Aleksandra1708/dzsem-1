        Console.WriteLine("Введи число и мы тебе скажем является ли число чётным (делится ли оно на два без остатка)"); 
        int a = Convert.ToInt32(Console.ReadLine());
                
        if (a%2==0)    
        {
            Console.WriteLine($"Число {a} чётное");
        }
         else 
         {
            Console.WriteLine($"Число {a} нечётное");
         }