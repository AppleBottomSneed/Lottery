// See https://aka.ms/new-console-template for more information

int drawnNumbers = 5;
int[] selectedNumbers = new int[drawnNumbers];



// Input range is single digits
int minNumber = 0;  
int maxNumber = 9;


for (int i = 0; i<selectedNumbers.Length; i++)
{

    //User input convert to int
    while (true)
    {
        string userInputString = Console.ReadLine();
        bool parsedNumber = int.TryParse(userInputString, out convertedNumber);
        if (convertedNumber >= minNumber && convertedNumber <= maxNumber)
        {
            Console.WriteLine($"Please enter {drawnNumbers} numbers between {minNumber} - {maxNumber}. Number {selectedNumbers.Length}:");
            selectedNumbers[i] = convertedNumber;
        }
        else
        {
            Console.WriteLine($"Incorrect input, please enter number between {minNumber} and {maxNumber}");
        }
    }
}


