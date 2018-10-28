

// STEP 2

namespace Strategy
{
    public class OperationMultiply : IStrategy
    {
        public int DoOperation(int no1, int no2)
        {
            return no1 * no2;
        }
    }
}
