Console.WriteLine("Введите свой год рождения: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Введите свой месяц рождения: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Ввелите дату рождения: ");
int day = int.Parse(Console.ReadLine());
DateTime today = DateTime.Today;
DateTime birthday = new DateTime(year, month, day);
int age = today.Year - birthday.Year;
{
    if (birthday > today.AddYears(age)) age--;
    if (age >= 18) ;
    Console.WriteLine("Совершеннолетний");
                else
        Console.WriteLine("Не совершеннолетний");
}
