namespace backend.Models
{
    public class Square : Operation
    {
        public override long calculate(long Number)
        {
            return (long)(Number*Number);
        }
    }
}

