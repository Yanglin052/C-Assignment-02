/*02 Arrays and Strings
Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
    If a string is going to remain constant throughout the program, then use String class object because a String object is immutable.
    If a string can be changed, then using StringBuilder.
2. What is the base class for all arrays in C#?
    Array class.
3. How do you sort an array in C#?
    We can use Array.Sort() method to sort an array ascending order and reverse it using Array.Reverse() method.
4. What property of an array object can be used to get the total number of elements in an array?
    Array.Length Property is used to get the total number of elements in all the dimensions of the Array. 
5. Can you store multiple data types in System.Array?
    No. We can only store similar data type in an Array.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
    The Clone() method returns a new array object containing all the elements in the original array. 
    The CopyTo() method copies the elements into another existing array. 
*/

/*Practice Arrays
1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. 
(You can use whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it.Use the things we’ve discussed to put some values in the array.
Now create a second array variable. Give it a new array with the same length as the first.
Instead of using a number for this length, use the Lengthproperty to get the size of the original array.
Use a loop to read values from the original array and place them in the new array.
Also print out the contents of both arrays, to be sure everything copied correctly.

int[] initialArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
int[] secondArray = new int[initialArray.Length];

for (int i = 0; i < initialArray.Length; i++)
{
    secondArray[i] = initialArray[i];
}

for (int i = 0; i < initialArray.Length; i++)
{
    Console.Write(initialArray[i]+",");
}
Console.WriteLine("--Initial Array");

for (int i = 0; i < secondArray.Length; i++)
{
    Console.Write(secondArray[i]+",");
}
Console.WriteLine("--Second Array");

2. Write a simple program that lets the user manage a list of elements. It can be a grocery list, "to do" list, etc. 
Each time through the loop, ask the user to perform an operation, and then show the current contents of their list. 
The operations available should be Add, Remove, and Clear.

string[] morningRoutine = new string[] { "brush teeth", "wash face", "have breakfast", "get dressed" };
Console.WriteLine("Morning Routine Begins!");
for (int i = 0; i < morningRoutine.Length; i++)
{
    Console.WriteLine("Please " + morningRoutine[i]);
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string entry = Console.ReadLine();
    if (entry == "+")
    {
        Console.WriteLine("What do you want to add: ");
    }
    else if (entry == "-")
    {
        Console.WriteLine("What do you want to remove: ");
    }
    else if (entry == "--")
    {
        Console.WriteLine("Morning routine ends.");
        break;
    }
}

3. Write a method that calculates all prime numbers in given range and returns them as array of integers

int ctr;
int startNum = 1;
int endNum = 10;
for (int num = startNum; num <= endNum; num++)
{
    ctr = 0;

    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            ctr++;
            break;
        }

    }

    if (ctr == 0 && num != 1)
        Console.Write("{0} ", num);
}

4. Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
After r rotations the element at position I goes to position (I + r) % n.
The sum[] array can be calculated by two nested loops: for r = 1 ... k; for I = 0 ... n-1.

5. Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one

int[] numbers = new[] {2,1,1,2,3,3,2,2,2,1};
int count = 1;
int longestNum = numbers[0];
int longestCount = 1;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] != numbers[i-1])
    {
        count = 0;
    }

    count++;
    if (count > longestCount)
    {
        longestCount = count;
        longestNum = numbers[i];
    }
}
Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));
int[] result = new int[longestCount];
Array.Fill(result, longestNum);

6.Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them*/


/* Practice Strings
1. Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
Write in two ways: 
-1-Convert the string to char array, reverse it, then convert it to string again:

Console.WriteLine("Enter a String: ");
string str = Console.ReadLine();
char[] charArr = str.ToCharArray();
Array.Reverse(charArr);
Console.WriteLine("After reverse: " + new string(charArr));

-2-Print the letters of the string in back direction (from the last to the first) in a for-loop:

Console.WriteLine("Enter a String: ");
string str = Console.ReadLine();
string Reversestr = string.Empty;
for (int i = str.Length - 1; i >= 0; i--)
{
    Reversestr += str[i];
}
Console.WriteLine($"The string in Reverse  Order Is : {Reversestr}");

2. Write a program that reverses the words in a given sentence without changing the punctuation and spaces
Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
All other characters are considered part of words, e.g. C++, a+b, and a77 are considered valid words.
The sentences always start by word and end by separator.

3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted

4. Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional.
*/