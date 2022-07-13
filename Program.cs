class Program
{ 
const int IS_PART_TIME = 1;
const int IS_FULL_TIME = 2;

    public static int computeEmpWage(string company,int empRatePerHour,int numOfWorkingDays,int maxHoursPerMonth)
    {
        int empHrs = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }

            totalEmpHrs += empHrs;
            Console.WriteLine("Days: " + totalWorkingDays + "   " + "Emp Hrs: " + empHrs);
        }
        totalEmpWage = totalEmpHrs * empRatePerHour;
        Console.WriteLine("--------------------------");
        Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        return totalEmpWage;
    }
    static void Main(string[]args)
    {
        computeEmpWage("DMart",20,2,10);
        computeEmpWage("Reliance", 10, 4, 20);

    }
}