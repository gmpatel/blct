using System;
using System.Collections.Generic;
using Blct.Interfaces;

namespace Blct.Concretes.Extensions
{
    public static class ArrayExtensions 
    {
        public static IList<int> DeletePart(this int[] input, int position)
        {
            var output = new List<int>();
            
            if(input.Validate() && input.Length > 0) 
            {
                for(var i = 1; i <= input.Length; i++) 
                {
                    if (i == position) 
                        continue;
                        
                    output.Add(input[i - 1]);
                }
            }

            return output;
        }

        public static IList<int> Reverse(this int[] input)
        {
            var output = new List<int>(input.Length);
            
            if(input.Validate() && input.Length > 0) 
            {
                for(var i = input.Length - 1; i >= 0; i--) 
                {
                    output.Add(input[i]);
                }
            }

            return output;
        }

        public static bool Validate(this int[] input)
        {
            if (input == null) 
            {
                throw new NullReferenceException("Array 'int[]' passed to be processed is null reference!");
            }

            return true;
        }
    }
}
