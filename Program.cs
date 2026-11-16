using System;
using System.Globalization;
using System.Net;
class Program
{
    static void Main()
    {
       //handshake
//bruteforce method O(n^2)
// for(var i=1;i<=4;i++){
//     for(var j = i+1; j <= 4; j++)
//     {
//         Console.WriteLine("Person"+i+"shakes hand with Person"+j);
//     }    
// }
//optimised solution O(1)
//let person=4 then each shakes 4*3=12(except them) but 
//in this case there is duplicacy so we chop by 2
//n(n-1)/2 
// long n=4;
// long totalHandShakes=n*(n-1)/2;
//     Console.WriteLine("Total Handshakes"+totalHandShakes);


//hashmap which is called Dictionary in C#
//it is a data structure that stores data in key-value pairs.
//we can quickly add,look and remove values very quickly

// Dictionary<string,string>toyLocations = new Dictionary<string, string>();
// toyLocations.Add("Batman","Under the bed");
// toyLocations.Add("Car"," in the closet");
// toyLocations.Add("Ball","in the garden");

// string loc=toyLocations["Batman"];
// Console.WriteLine("Loctaion of toy"+loc);


//Tow sum
int[] num=[2,7,11,15];
int target=9;

Dictionary<int,int> keyVal= new Dictionary<int, int>(); 

for(int i = 0; i < num.Length; i++)
        
            int currentNumber= num[i]
            int neededNumber=target-currentNumber;

            if (keyVal.ContainsKey(neededNumber))
            {
                int targetedNumber=keyVal[neededNumber];
                Console.WriteLine("Found it! The locations are: " + targetedNumber + " and " + i);
                return;
            }
            else
            {
                Console.WriteLine("There is no such number");
                keyVal[currentNumber]=i;
            }
        }   
} 
}


