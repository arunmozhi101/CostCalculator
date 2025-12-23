Console.WriteLine("*** Welcome to the Flooring CostCalculator Program ***");
Console.WriteLine("This program calculates the cost to cover the area specified with the flooring");
Console.WriteLine("\n");

const int TEAM_AVERAGE_FLOORING_SPEED_PER_HOUR = 20;
const int TEAM_COST_PER_HOUR = 86;
const double PI = 3.14159265358979;

int choiceNumber = 5;
double cost_for_flooring;
double area_of_the_floor;
double time_required_for_flooring;

while (choiceNumber != 0)
{
    Console.WriteLine("Choose the shape of the floor from the list below: ");
    Console.WriteLine(" 1 - Rectangle");
    Console.WriteLine(" 2 - Triangle");
    Console.WriteLine(" 3 - Circle");
    Console.WriteLine(" 0 - Exit");

    choiceNumber = Convert.ToInt32(Console.ReadLine());

    if (choiceNumber == 1)
    {
        Console.WriteLine("Enter the width of the Rectangular floor: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of the Rectangular floor: ");
        int length = Convert.ToInt32(Console.ReadLine());

        area_of_the_floor = width * length;
        time_required_for_flooring = area_of_the_floor / TEAM_AVERAGE_FLOORING_SPEED_PER_HOUR;
        cost_for_flooring = TEAM_COST_PER_HOUR * time_required_for_flooring;

        Console.WriteLine($"Cost for flooring: $ {cost_for_flooring.ToString("F2")}");
    }

    if (choiceNumber == 2)
    {
        Console.WriteLine("Enter the base of the Triangular floor: ");
        int baseLength = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the height of the Triangular floor: ");
        int height = Convert.ToInt32(Console.ReadLine());

        area_of_the_floor = 0.5 * baseLength * height;
        time_required_for_flooring = area_of_the_floor / TEAM_AVERAGE_FLOORING_SPEED_PER_HOUR;
        cost_for_flooring = TEAM_COST_PER_HOUR * time_required_for_flooring;

        Console.WriteLine($"Cost for flooring: $ {cost_for_flooring.ToString("F2")}");
    }

    if (choiceNumber == 3)
    {
        Console.WriteLine("Enter the radius of the Circular floor in centimeters: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        area_of_the_floor = PI * radius * radius;
        time_required_for_flooring = area_of_the_floor / TEAM_AVERAGE_FLOORING_SPEED_PER_HOUR;
        cost_for_flooring = TEAM_COST_PER_HOUR * time_required_for_flooring;

        Console.WriteLine($"Cost for flooring: $ {cost_for_flooring.ToString("F2")}");
    }

    if (choiceNumber < 0 || choiceNumber > 3)
    {
        Console.WriteLine("Wrong Input, please try again");
    }
}

Console.WriteLine("Thanks for using the Flooring CostCalculator Program");