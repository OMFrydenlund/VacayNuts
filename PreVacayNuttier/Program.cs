

int maxCount = 101;

for (int count = 0; count < maxCount; count++)
{
    Console.WriteLine(OfWhatEquivalent(count));
}


string OfWhatEquivalent(int num)
{
    string textToReturn = "";

    if(num % 3 == 0 || num.ToString().Contains("3"))
    {
        textToReturn += "Fizz";
    }
    if (num % 5 == 0 || num.ToString().Contains("5"))
    {
        textToReturn += "Buzz";
    }

    if(textToReturn == "")
    {
        textToReturn = num.ToString();
    }

    return textToReturn;
}
