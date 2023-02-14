// / Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// // 14 -> нет 
// // 46 -> нет 
// // 161 -> да

Console.WriteLine("Введите число");
string answer = Console.ReadLine();
int numberA = Convert.ToInt32(answer);

if (numberA % 7 == 0 && numberA % 23 == 0){
    Console.WriteLine("Кратно");
}
else {
    Console.WriteLine ("Не кратно");
}
