 Console.WriteLine("Введи 3 числа и мы тебе скажем какое из них максимально");
            int a, b, c;
            Console.WriteLine("Введи свое первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое третье число - ");
            c= Convert.ToInt32(Console.ReadLine());
 

           if (a > b)
           {
            Console.WriteLine($"Число {b} максимально");
           }
           else if (b < c)
           {
            Console.WriteLine($"Число {c} максимально");
           }
           else if (c < b)
            {
            Console.WriteLine($"Число {b} максимально");
           }
           else if (a > c)
            {
            Console.WriteLine($"Число {a} максимально");
           }
