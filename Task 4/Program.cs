int[] favNums = [1,2,3,4,5];

//sorting using array.sort();
Array.Sort(favNums);

//reversing the sorted array
Array.Reverse(favNums);

//printing each element in the array using a for loop
System.Console.WriteLine("Printing each element in the array: ");
for (int i = 0; i < favNums.Length; i++)
{
    System.Console.WriteLine(favNums[i]);
}

// finding position of an element in the array using .IndexoF()

int targetNum = 3;

System.Console.WriteLine($"The index of the target number: {targetNum} is {Array.IndexOf(favNums, targetNum)}");