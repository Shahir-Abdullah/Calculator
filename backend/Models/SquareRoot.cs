namespace backend.Models
{
    public class SquareRoot : Operation
    {
        public override long calculate(long Number)
        {
            return (long)Math.Sqrt(Number);
        }
    }
}

