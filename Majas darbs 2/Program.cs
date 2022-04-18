

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 1. uzdevums - sasveicināšanās

string myGreting2 = "Kā tevi sauc?";

Console.WriteLine(myGreting2);

string userName2 = Console.ReadLine();
Console.WriteLine("Sveiks, " + userName2);


Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 2. uzdevums - int.Parse

Console.WriteLine("Kāds ir tavs vecums ?");
int userNumber = int.Parse(Console.ReadLine());
int addedToUserNumber = userNumber + 1;
bool adultNumber = addedToUserNumber >= 18;
Console.WriteLine($"Nākamgad tev paliks  {addedToUserNumber}! {adultNumber}, $Tu esi pilngadīgs";

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 3. uzdevums - Math.Max

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi ceturto skaitli");
int fourthNumber = int.Parse(Console.ReadLine());

int firstMaxNumber = Math.Max(firstNumber, secondNumber);
int secondMaxNumber = Math.Max(thirdNumber, fourthNumber);
int maxNumber = Math.Max(firstMaxNumber, secondMaxNumber);

Console.WriteLine(maxNumber);

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 4. uzdevums - Math.Min

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi trešo skaitli");
int thirdNumber = int.Parse(Console.ReadLine());

int firstMinNumber = Math.Min(firstNumber, secondNumber);
int secondMinNumber = Math.Min(secondNumber, thirdNumber);
int minNumber = Math.Min(firstMinNumber, secondMinNumber);

Console.WriteLine(minNumber);

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 5. uzdevums - %


Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi otro skaitli");
int secondNumber = int.Parse(Console.ReadLine());

int result = firstNumber % secondNumber;

Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 6. uzdevums - Odd or Even

Console.WriteLine("Lūdzu, ievadi pirmo skaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;

Console.WriteLine("Skaitlis ir pāra skaitlis:" + isEven);

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 7. uzdevums - taisnstūra laukums


Console.WriteLine("Lūdzu, ievadiet pirmo skaitli");
double firstRoundableNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadiet otro skaitli");
double secondRoundalbeNumber = double.Parse(Console.ReadLine());

double area = Math.Round((firstRoundableNumber * secondRoundalbeNumber), 2);
Console.WriteLine("Taisnstūra laukums: " + area);

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 8. uzdevums - taisnleņķa trijstūra laukuma aprēķināšana

Console.WriteLine("Lūdzu, ievadi trijstūra malas garumu");
int number = int.Parse(Console.ReadLine());

int area = number * number / 2;
Console.WriteLine(area);

Console.WriteLine();
Console.WriteLine("======================================================");
Console.WriteLine();

// 9. uzdevums - interpolācija

Console.WriteLine("Lūdzu ievadi savu vārdu");
string userName = Console.ReadLine();

Console.WriteLine("Lūdzu ievadi savu veumu");
int userAge = int.Parse(Console.ReadLine());
Console.WriteLine($"Sveiks {userName}, tavs vecums ir {userAge}.");


