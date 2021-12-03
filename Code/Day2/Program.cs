
Console.WriteLine(@"      _          _     _                       ");
Console.WriteLine(@"     | |        (_)   | |                      ");
Console.WriteLine(@"  ___| |__  _ __ _ ___| |_ _ __ ___   __ _ ___");
Console.WriteLine(@" / __| '_ \| '__| / __| __| '_ ` _ \ / _` / __|");
Console.WriteLine(@"| (__| | | | |  | \__ \ |_| | | | | | (_| \__ \");
Console.WriteLine(@" \___|_| |_|_|  |_|___/\__|_| |_| |_|\__,_|___/");

GetInput();






// Get Puzzle Input
 List<string> GetInput()
{
    return System.IO.File.ReadAllLines(@"Input.txt").ToList();
}