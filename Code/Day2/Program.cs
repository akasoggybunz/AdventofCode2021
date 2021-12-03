
Console.WriteLine(@"      _          _     _                       ");
Console.WriteLine(@"     | |        (_)   | |                      ");
Console.WriteLine(@"  ___| |__  _ __ _ ___| |_ _ __ ___   __ _ ___");
Console.WriteLine(@" / __| '_ \| '__| / __| __| '_ ` _ \ / _` / __|");
Console.WriteLine(@"| (__| | | | |  | \__ \ |_| | | | | | (_| \__ \");
Console.WriteLine(@" \___|_| |_|_|  |_|___/\__|_| |_| |_|\__,_|___/");
Console.WriteLine();

GetPosition();






// Get Puzzle Input
List<string> GetInput()
{
    return System.IO.File.ReadAllLines(@"Input.txt").ToList();
}


// Get Final Horizontal position mutiplied by final Depth Position
void GetPosition()
{
    int horizontalPosition = 0;
    int depthPosition = 0;
    int aim = 0;
    var input = GetInput();

    input.ForEach(r =>
    {

        switch (r)
        {
            case string x when x.Contains("forward"):
                horizontalPosition += Convert.ToInt32(x.Split('\u0020').LastOrDefault());
                depthPosition += (Convert.ToInt32(x.Split('\u0020').LastOrDefault()) * aim);
                break;
            case string y when y.Contains("down"):
                aim += Convert.ToInt32(y.Split('\u0020').LastOrDefault());
                break;
            case string z when z.Contains("up"):
                aim -= Convert.ToInt32(z.Split('\u0020').LastOrDefault());
                break;
            default:
                // code block
                break;
        }
        
        Console.WriteLine("HPos: " + horizontalPosition);
        Console.WriteLine("DPos: " + depthPosition);
        Console.WriteLine("Aim: " + aim);
    });

    // Print out
    Console.WriteLine("*******************");
    Console.WriteLine("HPos: " + horizontalPosition);
    Console.WriteLine("DPos: " + depthPosition);
    Console.WriteLine("Aim: " + aim);
    Console.WriteLine("final horizontal * final depth: " + horizontalPosition * depthPosition);
}
