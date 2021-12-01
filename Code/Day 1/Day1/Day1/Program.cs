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
    int sum = 0;
    Console.WriteLine("Elfs! We Need to sumation of the Depth Increase Rate!");



    Console.WriteLine("The sumation of the Depth Increase Rate is **"+sum.ToString()+"**");
}