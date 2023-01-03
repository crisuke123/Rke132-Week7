//Kirjutage programm, mis teisendab Fahrenheiti kraadi Celsiuse järgi ja vastupidi.
//* Programm võimaldab kasutajal valida, kas teisendada väärtuse Celciusesse või Farenheiti.
//*Kui kasutaja on oma valiku teinud, programm küsib sisendit, teostab arvutusi ja kuvab tulemuse.
//* fahrenheit = (celsius * 9) / 5 + 32;
//*celsius = (fahrenheit - 32) * 5 / 9;

//NB! Programmis peab olema kaks funktsiooni:

//    static void ConverToCelsius(argument) { }
//    static void ConvertToFahrenheit(argument) { }

//    Jaga programmi koodi siin(programmi koodi võib, aga ei pea, githubisse üles laadida).
Console.WriteLine("Vali teisendav ühik kas fahrenheit või Celsius (f/c)");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Arv mida teisendadakse:");
int arv = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case 'f':
        ConverToCelsius(arv);
        break;
    case 'c':
        ConvertToFahrenheit(arv);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}
static void ConvertToFahrenheit(int arv)
{
    Console.WriteLine($"{arv}C = {(arv * 9) / 5 + 32}F");
}
static void ConverToCelsius(int arv)
{
    Console.WriteLine($"{arv}F = {(arv - 32) * 5 / 9}C");
}