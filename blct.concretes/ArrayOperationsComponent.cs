using System;
using System.Collections.Generic;
using Blct.Concretes.Extensions;
using Blct.Interfaces;

namespace Blct.Concretes
{
    public class ArrayOperationsComponent : IArrayOperations
    {
        public IList<int> DeletePart(int[] array, int position)
        {
            return array.DeletePart(position);
        }

        public IList<int> Reverse(int[] array)
        {
            return array.Reverse();
        }
    }
}
