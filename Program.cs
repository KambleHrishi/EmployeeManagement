int IS_FULL_TIME = 1;
Random random = new Random();// new object creation
int empCheck = random.Next(0, 2);//0 is inclusive,2 is exclusive: 0,1
if (empCheck == IS_FULL_TIME)
{
    Console.WriteLine("employee is Present");
}
else
{
    Console.WriteLine("employee is Absent");
}