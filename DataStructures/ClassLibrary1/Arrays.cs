using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPart1
{
    // Arrays are reference types 
    class Arrays
    {
        char[] vowels = new char[5];    //declares of char array of 5 characters
      
        int[] a = new int[10];          // declare an int array with default value of 0 for indexed members.

        int[,] matrix = new int[3, 3];  // declares a rectangular 2 dimensional array (multi-dimension) with dimensions of 3 by 3.
       
        int[][] mat = new int[3][];     // Declaring a jagged 2 dim array (multi-dimension) with outermost dimension as 3.

    }
}
