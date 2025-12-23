Console.WriteLine("*** Welcome to the Flooring CostCalculator Program ***");
Console.WriteLine("This program calculates the cost to cover the area specified with the flooring");
Console.WriteLine("\n");

const int TEAM_AVERAGE_FLOORING_SPEED_PER_HOUR = 20;
const int TEAM_COST_PER_HOUR = 86;
const int RECTANGLE_FLOOR = 1;
const int TRIANGLE_FLOOR = 2;
const int CIRCLE_FLOOR = 3;
const int EXIT = 0;

int choiceNumber = 5;
double costOfFlooring;
double areaOfTheFloor = 0.0;
double timeRequiredForFlooring;

while (choiceNumber != EXIT)
{
    Console.WriteLine("Choose the shape of the floor from the list below: ");
    Console.WriteLine(" 1 - Rectangle");
    Console.WriteLine(" 2 - Triangle");
    Console.WriteLine(" 3 - Circle");
    Console.WriteLine(" 0 - Exit");

    choiceNumber = Convert.ToInt32(Console.ReadLine());

    if (choiceNumber != EXIT && choiceNumber != RECTANGLE_FLOOR &&  choiceNumber != CIRCLE_FLOOR && choiceNumber != TRIANGLE_FLOOR)
    {
        Console.WriteLine("Wrong Input, please try again");
        continue;
    }

    if (choiceNumber == RECTANGLE_FLOOR)
    {
        Console.WriteLine("Enter the width of the Rectangular floor: ");
        int width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of the Rectangular floor: ");
        int length = Convert.ToInt32(Console.ReadLine());

        areaOfTheFloor = width * length;
    }

    if (choiceNumber == TRIANGLE_FLOOR)
    {
        Console.WriteLine("Enter the base of the Triangular floor: ");
        int baseLength = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the height of the Triangular floor: ");
        int height = Convert.ToInt32(Console.ReadLine());

        areaOfTheFloor = 0.5 * baseLength * height;
    }

    if (choiceNumber == CIRCLE_FLOOR)
    {
        Console.WriteLine("Enter the radius of the Circular floor in centimeters: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        areaOfTheFloor = Math.PI * radius * radius;
    }

    timeRequiredForFlooring = areaOfTheFloor / TEAM_AVERAGE_FLOORING_SPEED_PER_HOUR;
    costOfFlooring = TEAM_COST_PER_HOUR * timeRequiredForFlooring;

    Console.WriteLine($"Cost for flooring: $ {costOfFlooring.ToString("F2")}");
}

Console.WriteLine("Thanks for using the Flooring CostCalculator Program");