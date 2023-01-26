using AgeCalculator;

#region Task1
DateOnly planned = new DateOnly(2023, 1, 31);
DateOnly actual= new DateOnly(2023, 1, 1);
if (planned == actual)
{
    // On time
}
else if (planned > actual)
{
    // Before deadline
}
else
{
    // After deadline
}
#endregion

#region Task2
DateTime date1 = new DateTime(2023, 1, 31, 0, 0, 1);
DateTime date2 = new DateTime(2023, 1, 31, 0, 0, 59);
Console.Write($"The dates match: ");
if (date1.Year == date2.Year)
{
    Console.Write($"year ({date1.Year}); ");
}
if (date1.Month == date2.Month)
{
    Console.Write($"month ({date1.Month}); ");
}
if (date1.Day == date2.Day)
{
    Console.Write($"day ({date1.Day}); ");
}
if (date1.Hour == date2.Hour)
{
    Console.Write($"hour ({date1.Hour}); ");
}
if (date1.Minute == date2.Minute)
{
    Console.Write($"minute ({date1.Minute}); ");
}
if (date1.Second == date2.Second)
{
    Console.Write($"second ({date1.Second}); ");
}
Console.WriteLine("\n");
#endregion

#region Task3
DateTime dateOfBirth = new DateTime(1997, 5, 19);
DateTime futureDateOfBirth;
if (dateOfBirth > DateTime.Now)
{
    throw new ArgumentException("Date of birth cannot be greater than the current date.");
}
else
{
    Age age = new Age(dateOfBirth, DateTime.Now);
    Console.WriteLine($"Age: {age.Years} years, {age.Months} months, {age.Days} days.");

    if (dateOfBirth >= DateTime.Now)
    {
        futureDateOfBirth = new DateTime(DateTime.Now.Year + 1, dateOfBirth.Month, dateOfBirth.Day);
    }
    else
    {
        futureDateOfBirth = new DateTime(DateTime.Now.Year, dateOfBirth.Month, dateOfBirth.Day);
    }

    Console.WriteLine($"Days until next birthday: {(int)(futureDateOfBirth - DateTime.Now).TotalDays}.");
    Console.WriteLine($"The next birthday fell on a {futureDateOfBirth.DayOfWeek}.\n");
}
#endregion

#region Task4
DateTime alarm = DateTime.Now.AddDays(1).AddHours(1).AddMinutes(1).AddSeconds(1);
if (alarm <= DateTime.Now)
{
    throw new ArgumentException("The alarm time must not be less than the current time.");
}
else
{
    TimeSpan timeToAlarm = alarm - DateTime.Now;
    Console.WriteLine($"Time to alarm {timeToAlarm.Hours} hours {timeToAlarm.Minutes} minutes {timeToAlarm.Seconds} seconds.");
}
    
Console.WriteLine();
#endregion

#region Task5
Console.WriteLine($"The date and time in Moscow is now {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Russian Standard Time")}.");
Console.WriteLine($"The date and time in London is now {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "GMT Standard Time")}.");
Console.WriteLine($"The date and time in New York is now {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "US Eastern Standard Time")}.");
Console.WriteLine($"The date and time in Tokyo is now {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "Tokyo Standard Time")}.");
Console.WriteLine($"The date and time in Beijing is now {TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "China Standard Time")}.");
#endregion