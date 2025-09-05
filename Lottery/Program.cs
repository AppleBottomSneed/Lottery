// See https://aka.ms/new-console-template for more information

int drawnNumbers = 5;
int[] selectedNumbers = new int[drawnNumbers];

// dummy use to allow parsing
int[] dummyNumbers = new int[drawnNumbers];


// Input range is single digits
int minNumber = 0;  
int maxNumber = 9;

// Random number generator, a random number within range up to drawnNumbers
int[] randomArray = new int[drawnNumbers];
Random rnd = new Random();





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

// Random generator loop, length the same as selectedNumbers    

for (int i = 0; i < selectedNumbers.Length; i++)
{ 
    int randomNumber = rnd.Next(minNumber, maxNumber);
    randomArray[i] = randomNumber;  
}

// Linear search for lottery, index variable must be different for each array
void LinearSearch(int[] randomArray, int[]selectedNumbers )
{
    //loop where each number of inside selectedNumber is chosen for the nested loop
    for (int i = 0; i < selectedNumbers.Length; i++)
    {
        // then this nested loop goes through each number inside randomArray
        for (int x = 0; x < randomArray.Length; x++)
        {
            // index i checks with index x as it increases each loop
            if (selectedNumbers[i] == randomArray[x])
            {
                Console.WriteLine($"Your chosen number {selectedNumbers[i]} matches with lottery number {randomArray[x]}!");
            }
        }
    }
}

// Binary search for lottery - one value at a time
int BinarySearch(int[]randomArray, int selectedValue, int low, int high )
{
    //binary search only works on sorted arrays
    Array.Sort(randomArray);
    
    //cuts search in half 
    if (high >= low)
    {
        int mid = low + (high - low) / 2;
        if (randomArray[mid] == selectedValue) return mid;

        if (randomArray[mid] > selectedValue) return BinarySearch(randomArray, selectedValue, low, mid - 1);
        return BinarySearch(randomArray, selectedValue, mid + 1, high);

    }
    return -1;
}

Console.WriteLine($"Your selected numbers: {string.Join(" ", selectedNumbers)}");
Console.WriteLine($"Your lottery  numbers: {string.Join(" ", randomArray)}");
Console.WriteLine("Using a Linear search:");
LinearSearch(randomArray, selectedNumbers);
Console.WriteLine("Using a Binary search:");

foreach (int selectedValue in selectedNumbers)
{
    // BinarySearch (randomArray, specific value of number in selectedNumbers, starting index, index -1 as index starts at 0 
    int search = BinarySearch(randomArray, selectedValue, 0, randomArray.Length - 1);
    // if not found in BinarySearch function (return -1) then:
    if (search != -1)
        Console.WriteLine($"Chosen number {selectedValue} matches the lottery number!");
    else
        Console.WriteLine($"Chosen number {selectedValue} not found");
}

// Fixed issues:
// i resets to 0 after counting 5 caused by while loop
// Check for loop to not i++ when else checks --> remove from for loop condition and put into correct input result
// random array should be made into a new int[]drawn numbers, Random instance only rolled once inside a loop

//Current issues:
// Implement double to avoid decimal input




