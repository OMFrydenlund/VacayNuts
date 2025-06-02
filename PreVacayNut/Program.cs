

while (true)
{
    int num = Convert.ToInt32(Console.ReadLine());

    switch (num)
    {
        case > 0:
            Console.WriteLine(1);
            break;
        case 0:
            Console.WriteLine(num);
            break;
        case < 0:
            Console.WriteLine(-1);
            break;
        default:
            Console.WriteLine("Not valid.");
            break;
    }
}
