using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLibrary
{
    public static class ReverseStack
    {
        // Method to reverse a Stack
        public static Stack Reverse(Stack input)
        {
            // Creating temp stack to store revesed Stack.
            Stack temp = new Stack();

            // Fetches and stores the Stack values in new temp Stack from passed one.
            while(input.Count != 0)
            {
                temp.Push(input.Pop()); 
            }
            return temp;
        }
    }
}
