using System.Collections.Generic;

namespace Blct.Interfaces
{
    public interface IArrayOperations
    {
        IList<int> Reverse(int[] array);
        IList<int> DeletePart(int[] array, int position);
    }
}