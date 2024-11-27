using CSharpFunctionalExtensions;

namespace BusinessLogic.Entities
{
    public class Sale : Entity<int>
    {

        private Sale()
        {

        }

        public Sale(double value, DateOnly date)
        {
            Value = value;
            Date = date;
        }

        public static Result<Sale> Create(double value, DateOnly date)
        {
            return Result.Success(new Sale(value, date));
        }


        public double Value { get; private set; } = 0;
        public DateOnly Date { get; private set; } = DateOnly.FromDateTime(DateTime.Now);

        public void UpdateInfo(double value, DateOnly date)
        {
            Value = value;
            Date = date;
        }
    }
}
