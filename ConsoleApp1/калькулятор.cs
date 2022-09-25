string action = "";
string first = "";
string second = "";

do
{
    Console.WriteLine("Введите желаемое действие из списка");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");

    action = Console.ReadLine();

    if (action.Equals("1")) {
        Console.WriteLine("Выбрано сложение");

        Console.WriteLine("Введите первое число");
        first = Console.ReadLine();

        Console.WriteLine("Введите второе число");
        second = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum) & Double.TryParse(second, out Double secondNum))
        {
            Double summ = firstNum + secondNum;
            Console.WriteLine("Сумма чисел " + first + " и " + second + " = " + summ);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько неверных значений. Попробуйте снова");
        }
    }

    if (action.Equals("2"))
    {
        Console.WriteLine("Выбрано вычетание");

        Console.WriteLine("Введите первое число");
        first = Console.ReadLine();

        Console.WriteLine("Введите второе число");
        second = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum) & Double.TryParse(second, out Double secondNum))
        {
            Double c = firstNum - secondNum;
            Console.WriteLine("Разность чисел " + first + " и " + second + " = " + c);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

    if (action.Equals("3"))
    {
        Console.WriteLine("Выбрано умножение");

        Console.WriteLine("Введите первое число");
        first = Console.ReadLine();

        Console.WriteLine("Введите второе число");
        second = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum) & Double.TryParse(second, out Double secondNum))
        {
            Double c = firstNum * secondNum;
            Console.WriteLine("Множитель чисел " + first + " и " + second + " = " + c);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

    if (action.Equals("4"))
    {
        Console.WriteLine("Выбрано деление");

        Console.WriteLine("Введите первое число");
        first = Console.ReadLine();

        Console.WriteLine("Введите второе число");
        second = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum) & Double.TryParse(second, out Double secondNum))
        {
            if (secondNum != 0)
            {
                Double c = firstNum / secondNum;
                Console.WriteLine("Частное чисел " + first + " и " + second + " = " + c);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

    if (action.Equals("5"))
    {
        Console.WriteLine("Выбрано возведение в степень");

        Console.WriteLine("Введите число");
        first = Console.ReadLine();

        Console.WriteLine("Введите степень");
        second = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum) & Double.TryParse(second, out Double secondNum))
        {
            Double result = 1;

            for (int i = 0; i < secondNum; i++) {
                result = result * firstNum;    
            }

            Console.WriteLine("Число " + first  + " в степени " + second + " = " + result);
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

    if (action.Equals("6"))
    {
        Console.WriteLine("Выбрано найти квадратный корень из числа");

        Console.WriteLine("Введите число");
        first = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum))
        {           
            Double a = Math.Sqrt(firstNum);
            Console.WriteLine("Квадратный корень из числа " + first + " равен " + a);
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

    if (action.Equals("7"))
    {
        Console.WriteLine("Выбрано найти 1% от числа");

        Console.WriteLine("Введите число");
        first = Console.ReadLine();

        if (Double.TryParse(first, out Double firstNum) & Double.TryParse(second, out Double secondNum))
        {
            Double a = firstNum / 100;
            Console.WriteLine("1% от числа " + first + " равен " + a);
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

    if (action.Equals("8"))
    {
        Console.WriteLine("Выбран поиск факториала");

        Console.WriteLine("Введите фактриал");
        first = Console.ReadLine();


        if (int.TryParse(first, out int firstNum)) {
            if (firstNum > 0)
            {
                Double result = 1;

                for (int i = 1; i <= firstNum; i++)
                {
                    result = result * i;
                }

                Console.WriteLine("Факториал " + first + " = " + result);
            } else {
                Console.WriteLine("Факториала из отрицательного числа не существует. Попробуйте снова");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели одно или несолько пустых значений. Попробуйте снова");
        }
    }

} while (!action.Equals("9"));
Console.WriteLine("Конец программы");