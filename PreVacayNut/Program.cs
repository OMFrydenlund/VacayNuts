TheProgram();

int MustReturnSomething(int sentNum)
{
    int num = 0;

    switch (sentNum)
    {
        case > 0:
            num = 1;
            break;
        case 0:
            num = sentNum;
            break;
        case < 0:
            num = -1;
            break;
        default:
            Console.WriteLine("Not valid.");
            break;
    }
    return num;
}

void TheProgram()
{
    while (true)
    {
        int queried = Convert.ToInt32(Console.ReadLine());
        int toPrint = MustReturnSomething(queried);
        Console.WriteLine(toPrint + "\n");
    }
}
