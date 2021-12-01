// See https://aka.ms/new-console-template for more information

// Print Santa on Sub
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@(@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#%#%&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#%*#@%&&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#&(&#&*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&#&&%/****/*/#*##*(&@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@./ (.. &@@@@@@@@@@@@@#/*(*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@% ..(@@@&&@&@@@@@@@@@/,#*@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@*@@@@@@@@&&&&&@@&&&&@@@&@&@&*#/@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@(*##*%&@@@@@&#&%*(#%%%(*%%&%@@/*/@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@&*/#(**/*#&@&&@@%#&%%%&&&&%&%&@&&&#&@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@&*(******/*%#&@@&&@@@@@&@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@%/*****(,**/#@@@&@@@@@@@&@@@&@&&@@&&@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@&/****,,*#(&@@@@@@@@#@&@&&&@@%%((/**#@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@.,*//(((*&&@&@@@&&@@@@&/***/,,*&*#@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@&/((#/. ..(/(#/*(%/%%&%#%*,(&(***/*/,(*(@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@##./#/(/* .#.,///,(%%&&@%%&%%@&/****,,*//@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@/(./%,/#/(***.. ./,(* *#&.,*%@@@@@@**/%*/@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@#/*/*(,/(,..,.(/,((@/@&.(.(( ,&&@&&(***/%@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@((#(/#%%%((*/..,.#%&%@/,,  /  *&@&&(%@@@@@@@@@@@@@@@@&(////*&%@");
Console.WriteLine("@@@@@@@@@@@@@@@%(*(.,(#..,(*.((,/**(@(@(/*. .*(%%&(,*(%#%@@@@@@@@/,.,,,,*///*/#@");
Console.WriteLine("@@@@@@@@@@@//#(/#/..(%(*,(@#/# .,/*##((#*(/#%#(*.. ./((*(#%##/(//*/(*,,///(((/%@");
Console.WriteLine("@@@@@@&/%(//.%.,....*/%*(*//(,...,*,**/*,,,,,/,./.(,*.*/*/((#(,,  ,***/&*///#(@@");
Console.WriteLine("@@@*(*,(...,.%(,/*//&#*&(.((/,,,,%(.*/. #(#**,#@@&/,#,. .,(**..,/.,*//,/(//*//&@");
Console.WriteLine("@&(*%.,,##.%((,%&,%*#(/&.#*(*/,(*#*/*,###(.,*,(/(&@*%@.,&(,,...(.#,.(,**#**,***@");
Console.WriteLine("@*//*,(%@#/&/(/&*&.*# *%%,#*# .%(%*((*&,(*&.&&,#/%@&&&@@@%*,.,*#%.,#...,**/////@");
Console.WriteLine("/*//,%(@@@%/#%(//(%/, .%.#/*(//#/..&/..(*//**/(/%&@&/&@@@&#,,* . ..,,,,..,*////*");
Console.WriteLine("@*#/*#/&%%/*(*//%#.,,,.,,,..,/%(/ . ,.. .*/#//%/* (*/,,,,.,,(*,,,%....,., ,****&");
Console.WriteLine("@@(/*#,(%&#/,,. ..((#(/*#,,... ...* .  ,  ,, %. , ,.,,,,**(&,**,,**,/#***,*****@");
Console.WriteLine("@@@&((####(##(*/((,*/./,/(*/((*((/((((#(((//*. .///*//***,,*////*(,/##*.,****/#@");
Console.WriteLine("@@@@@@%*/(((((((((((((*,,,,,.**,,,,.,,,,,,....(#%(.,//*,*********(*/.,*,,,***%@@");
Console.WriteLine("@@@@@@@@@@(//(/(#/(#(**************************((**,,,,,,,*((/*(*,*****(**//@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@&#%((***********************************,/(//%********/#*****%@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@#*///##(*****,********//(#/(/**&@@@@@@@@@@@/****/*****/@@@");

Console.WriteLine(" ");
Console.Write(".");
Console.Write(".");


Console.WriteLine(" ");
getDepthIncreaseRate();
getDepthSumIncreaseRate();


// Get Puzzle Input
List<string> GetInput()
{
    return System.IO.File.ReadAllLines(@"C:\Users\afoster\Source\Repos\NewRepo\Code\Day 1\Day1\Day1\Input.txt").ToList();
}

// Get Depth
void getDepthIncreaseRate()
{
    Console.WriteLine("Elfs! What is the Depth Increase Rate?!");
    Console.Write(".");
    Console.Write(".");
    Console.Write(".");
    Console.WriteLine(" ");

    int lastValue = 0;
    int count = 0;

    foreach (var i in GetInput())
    {

        if (lastValue > 0 && Convert.ToInt32(i) > lastValue)
        {
            Console.WriteLine("(increased)");
            count++;
        }
        else if (lastValue > 0 && Convert.ToInt32(i) <= lastValue)
        {
            Console.WriteLine("(decreased)");
        }
        else
        {
            Console.WriteLine("(N/A - no previous measurement)");
        }

        lastValue = Convert.ToInt32(i);
    }
    Console.Write("The Depth Increase rate is ** " + count.ToString() + " **");
}

void getDepthSumIncreaseRate()
{
    int count = 0;
    int currentSum = 0;
    int previousSum = 0;
    var input = GetInput();

    Console.WriteLine("Elfs! We Need the Depth Rate of the summed depths!");
    
    for(int i = 0; i < input.Count; i ++)
    {
       
        currentSum = input.Skip(i).Take(3).Sum(x => Convert.ToInt32(x));

        if (i > 0 && currentSum > previousSum)
        {
            Console.WriteLine("(increased)" +" - " + currentSum);
            count++;
        }
        else if (i > 0 && currentSum <= previousSum)
        {
            Console.WriteLine("(decreased)" +" - " + currentSum);
        }
        else
        {
            Console.WriteLine("(N/A - no previous measurement)" +" - " + currentSum);
        }

        previousSum = currentSum;
    }

    Console.WriteLine("The Depth Increase Rate is **" + count.ToString() + "**");
}