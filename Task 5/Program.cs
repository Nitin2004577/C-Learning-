//Create a DateTime variable representing your birthdate.
DateTime birthday = new DateTime(2003, 07, 21);

//Create another DateTime variable representing the current date and time
DateTime currDateTime = DateTime.Now;

//Calculate your age using TimeSpan (you'll need to subtract the two DateTime values).
TimeSpan ageDiff = currDateTime - birthday;

double totalDays = ageDiff.TotalDays;
int ageInYears = (int)(totalDays/365.25);

//Printing birthdate, current date and age in years
System.Console.WriteLine($"Birthdate: {birthday.Year}");
System.Console.WriteLine($"Current Year: {currDateTime.Year}");
System.Console.WriteLine($"Age in Year: {ageInYears}");

//adding 10 days to my birthday and printing it
DateTime addTenDaysToBday = birthday.AddDays(10);
System.Console.WriteLine($"10 days added to my bday: {addTenDaysToBday.ToShortDateString()}");

