namespace backend.Models
{
    public class Factorial : Operation
    {
        public override long calculate(long Number)
        {
            long result = 1;
            for(long i = 1; i <= Number; i++){
                result *= i;
            }
            return result;
        }
    }
}

