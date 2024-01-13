using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        int studentScore;
        string sign;
        Console.Write("Enter grade percentage: ");
        string score =  Console.ReadLine();
        studentScore = int.Parse(score);
        string letter;

        if(studentScore < 60){
            letter = "F";
        }else if(studentScore <70){
            letter = "D";
        }else if(studentScore < 80){
            letter = "C";
        }else if(studentScore < 90){
            letter = "B";
        }else{
            letter = "A";
        }
        
        if(studentScore >= 97){
            sign = "";
        }else if(studentScore < 60){
            sign = "";
        }else{
            int rem = studentScore % 10;
            if(rem < 3){
                sign = "-";
            }else if(rem >= 7){
                sign = "+";
            }else{
                sign = "";
            }
        }
        

        Console.WriteLine($"grade: {letter + sign}");
    }
}