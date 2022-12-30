#region Task1
int[] numbers = new int[3];
Random random= new Random();
for (int i = 0; i < 3; i++)
{
    numbers[i] = random.Next(100);
}
int maxNumber = numbers.Max();
int minNumber = numbers.Min();
#endregion

#region Task2
int year = 1997;
int month = 5;
int numberOfCompletedYears = GetNumberOfCompletedYears(year,month);
static int GetNumberOfCompletedYears(int year, int month)
{
    int currentYear = DateTime.Today.Year, currentMonth = DateTime.Today.Month;

    if ((year > currentYear) || (year == currentYear && month > currentMonth) || (month < 1 || month > 12))
    {
        throw new ArgumentException("Year of birth and month of birth should not be greater than the current.");
    }

    if (month <= currentMonth)
    {
        return currentYear - year;
    }
    else
    {
        return currentYear - year - 1;
    }
}
#endregion

#region Task3
int dayNumber = 256;
bool isItDayOff = IsItDayOff(dayNumber);
static bool IsItDayOff(int dayNumber)
{
    if (dayNumber < 1 || dayNumber > 365)
    {
        throw new ArgumentException("The day must be between 1 and 365.");
    }

    dayNumber = dayNumber % 7;

    switch (dayNumber)
    {
        case >= 1 and <= 5:
            return false;
        case 6 or 0:
            return true;
        default:
            return false;
    }
}
#endregion

#region Task4
int gamePoints = 3;
string resultOfGame = GetResultOfGame(gamePoints);
static string GetResultOfGame(int points)
{
    switch (points)
    {
        case 3:
            return "Win";
        case 1:
            return "Draw";
        case 0:
            return "Lose";
        default:
            throw new ArgumentException("Invalid points value.");
    }
}
#endregion

#region Task5
int monthNumber = random.Next(1, 13);
string season;
switch (monthNumber)
{
    case 1 or 2 or 12:
        season = "winter";
        break;
    case >= 3 and <= 5:
        season = "spring";
        break;
    case >= 6 and <= 8:
        season = "summer";
        break;
    case >= 9 and <= 11:
        season = "autumn";
        break;
    default:
        throw new ArgumentException("The month number must be greater than or equal to 1 and less than or equal to 12.");
}
DateTime date = new DateTime(1999, monthNumber, 1);
Console.WriteLine($"It is {date.ToString("MMMM")}, {season}. {date.ToString("MMMM")} has {DateTime.DaysInMonth(1999, 5)} days.");
#endregion