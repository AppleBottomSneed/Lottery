// See https://aka.ms/new-console-template for more information

int drawnNumbers = 5;
int[] selectedNumbers = new int[drawnNumbers];



// Input range is single digits
int minNumber = 0;  
int maxNumber = 9;

// Random number generator
/*
Random rnd = new Random();
int randomNumber = rnd.next(minNumber, maxNumber);
*/


// while loop to repeat for loop if wrong input
while (true)
{
    
    for ( int i = 0; i<selectedNumbers.Length; i++)
    {
        //User input convert to int - while loop to repeat validation
        Console.WriteLine($"Please enter {drawnNumbers} numbers between {minNumber} - {maxNumber}.");
        string userInputString = Console.ReadLine();
        bool parsedNumber = int.TryParse(userInputString, out selectedNumbers[i]);

        // if parsedNumber test is true and selectedNumbers is within range then:
        if (parsedNumber == true && selectedNumbers[i] >= minNumber && selectedNumbers[i] <= maxNumber)
        {
            int.TryParse(userInputString, out selectedNumbers[i]);
        }
        else
        {
            Console.WriteLine($"Incorrect input, please enter number between {minNumber} and {maxNumber}");
            break;
            
        }
    }

    // Current issue: numbers outside the range trigger input error + i resets to 0 after counting 5 caused by while loop
    // Check for loop to not i++ when else checks


}


