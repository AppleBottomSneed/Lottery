// See https://aka.ms/new-console-template for more information

int drawnNumbers = 5;
int[] selectedNumbers = new int[drawnNumbers];

// dummy use to allow parsing
int[] dummyNumbers = new int[drawnNumbers];



// Input range is single digits
int minNumber = 0;  
int maxNumber = 9;

// Random number generator
/*
Random rnd = new Random();
int randomNumber = rnd.next(minNumber, maxNumber);
*/




for ( int i = 0; i<selectedNumbers.Length;)
{
    //User input convert to int - while loop to repeat validation
    Console.WriteLine($"Please enter {drawnNumbers} numbers between {minNumber} - {maxNumber}.");
    string userInputString = Console.ReadLine();
    // dont want parse check to add input to selectedNumbers yet
    bool parsedNumber = int.TryParse(userInputString, out dummyNumbers[i]);
         
    // if parsedNumber test is true and selectedNumbers is within range then:
    if (parsedNumber == true && dummyNumbers[i] >= minNumber && dummyNumbers[i] <= maxNumber)
    {
        int.TryParse(userInputString, out selectedNumbers[i]);
        i++;
    }
    else
    {
        Console.WriteLine($"Incorrect input, please enter number between {minNumber} and {maxNumber}");
        continue;
            
    }
}


// Fixed issues:
// i resets to 0 after counting 5 caused by while loop
// Check for loop to not i++ when else checks --> remove from for loop condition and put into correct input result




