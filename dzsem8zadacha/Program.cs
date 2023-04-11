         Console.Write("ВВедите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("ВВедите втрое число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
         
        
