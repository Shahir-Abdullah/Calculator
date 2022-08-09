namespace backend.Models
{
    public class Fibonacci : Operation
    {
        public override long calculate(long Number)
        {
            //get list of fibonacci numbers
            List<long> fibonacci = new List<long>();
            fibonacci.Add(1);
            fibonacci.Add(1);
            for(long i = 2; i < Number; i++){
                fibonacci.Add(fibonacci[(int)i-1] + fibonacci[(int)i-2]);
            }
            return fibonacci[(int)Number-1];
        }
    }
}

