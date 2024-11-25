using CSharpFunctionalExtensions;

namespace BusinessLogic.Entities
{
    public class Company : Entity<int>
    {
        public const int MAX_TITLE_LENGHT = 100;
        private readonly List<Investment> _investments = [];

        private Company()
        {
        }

        private Company(string title, float profit, IEnumerable<Investment> investments)
        {
            Title = title;
            Profit = profit;
            _investments = investments.ToList();
        }

        public static Result<Company> Create(string title, float profit, IEnumerable<Investment> investments)
        {
            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGHT) return Result.Failure<Company>($"`{nameof(title)}` не может быть пустым или превышать длину в {MAX_TITLE_LENGHT} символов");

            return Result.Success(new Company(title, profit, investments));
        }


        public string Title { get; private set; } = string.Empty;
        public float Profit { get; private set; }
        public IReadOnlyList<Investment> Investments => _investments;

        public void UpdateInfo(string title, float profit)
        {
            Title = title;
            Profit = profit;
        }
    }
}
