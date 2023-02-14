
// Напишите программу, которая будет принимать на вход два числа и выводить,
//  является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//  то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
string answerA = Console.ReadLine();
int numberA = Convert.ToInt32(answerA);

Console.WriteLine("Введите второе число");
string answerB = Console.ReadLine();
int numberB = Convert.ToInt32(answerB);
int sum = 0;

if (numberA % numberB == 0){

    Console.WriteLine ("Кратно");
}
else {

    sum = numberA % numberB; 
    Console.WriteLine (sum);   
}
