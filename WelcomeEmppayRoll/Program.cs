namespace WelcomeEmppayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to EmppayRoll");
            Console.WriteLine("console option \n 1.Check absent/present \n 2.DailyWage  \n 3. Add PartTime Wage  \n 4.Daily Wage Using Case  \n 5. calculate Wage For Month  \n 6.Calculate Wage for Max Hour");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UC1PresorAbsent.Random();
                    break;
                    case 2:
                    UC2DailyWage.CalDailyWage();  
                    break;
                case 3:
                    UC3AddParttimewage.DailyPartTimeWage();    
                    break;
                    case 4:
                    UC4DailyWageUsingCase.DailyWageUsingCase();
                    break;
                case 5:
                    UC5CalculateWageForMonth.MonthWage();
                    break;
                case 6:
                    UC6CalculateWageForMaxHour.CalculateWage();
                    break;
            }
           
        }
    }
}