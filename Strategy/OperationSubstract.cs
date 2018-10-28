
// STEP 2

namespace Strategy
{
    public class OperationSubstract :IStrategy
    {
        public int DoOperation(int no1, int no2)
        {
            return no2 - no1;
        }
    }
}
