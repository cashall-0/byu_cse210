using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new();
        bool stop = false;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while(!stop){
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            if(number == 0){
                stop = true;
                numbers.RemoveAt(numbers.Count-1);
            }
        }
        int noOfNumbers = numbers.Count;
        int sumOfNumbers = 0;
        int minNumber =  0;
        int maxNumber = numbers[0];
        int smallPositiveNumber = 10000;
        for(int i = 0; i < noOfNumbers;i++){
            sumOfNumbers+=numbers[i];
            if(numbers[i] > maxNumber){
                maxNumber = numbers[i];
            }
            if(numbers[i] < minNumber){
                minNumber = numbers[i];
            }
            if(numbers[i] > 0 && numbers[i] < smallPositiveNumber){
                smallPositiveNumber = numbers[i];
            }
        }

        float average = sumOfNumbers/noOfNumbers;

        Console.WriteLine($"The sum is: {sumOfNumbers}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine("The sorted list:");
        Console.WriteLine($"The smallest positive number is: {smallPositiveNumber}");


        numbers.Sort();
        foreach(int num in numbers){
            Console.WriteLine(num);
        }

    }
}