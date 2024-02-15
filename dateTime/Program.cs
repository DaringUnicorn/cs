DateTime now = DateTime.Now;
System.Console.WriteLine(now);

System.Console.WriteLine(now.Date);
System.Console.WriteLine(now.Day);
System.Console.WriteLine(now.Month);
System.Console.WriteLine(now.Year);
System.Console.WriteLine(now.Hour);
System.Console.WriteLine(now.Minute);
System.Console.WriteLine(now.Second);
System.Console.WriteLine(now.Millisecond);
System.Console.WriteLine(now.DayOfWeek);
System.Console.WriteLine(now.DayOfYear);
System.Console.WriteLine(now.TimeOfDay);
System.Console.WriteLine(now.ToLongDateString());
System.Console.WriteLine(now.ToShortDateString());
System.Console.WriteLine(now.ToLongTimeString());
System.Console.WriteLine(now.ToShortTimeString());
System.Console.WriteLine(now.ToString("dd-MM-yyyy"));
System.Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm"));
System.Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm:ss"));
System.Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm:ss.fff"));
System.Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm:ss.fff zzz"));


DateTime dateTime = new DateTime(2018, 6, 10, 14, 30, 45);
System.Console.WriteLine("created date : " + dateTime.ToString("dd-MM-yyyy HH:mm:ss"));

DateTime newDateTime = dateTime.AddYears(2);

DateTime dateTime2 = dateTime.AddYears(1).AddMonths(3).AddDays(7).AddHours(10).AddMinutes(20).AddSeconds(30);

System.Console.WriteLine("new date : " + dateTime2.ToString("dd-MM-yyyy HH:mm:ss"));


var difference = now - dateTime;

System.Console.WriteLine("Difference : " + difference);
System.Console.WriteLine("Total Days : " + difference.TotalDays);
System.Console.WriteLine("Total Hours : " + difference.TotalHours);
System.Console.WriteLine("Total Minutes : " + difference.TotalMinutes);
System.Console.WriteLine("Total Seconds : " + difference.TotalSeconds);
System.Console.WriteLine("Total Milliseconds : " + difference.TotalMilliseconds);
