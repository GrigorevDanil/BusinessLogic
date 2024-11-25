
using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.Entities
{
    public class Investment : Entity<int>
    {


        private Investment()
        {

        }

        public Investment(Company company, float amount, float profit)
        {
            CompanyId = company.Id;
            Amount = amount;
            Profit = profit;
        }

        public static Result<Investment> Create(Company company, float amount, float profit)
        {
            return Result.Success(new Investment(company, amount, profit));
        }

        public int CompanyId { get; private set; }
        public virtual Company? Company { get; }
        public float Amount { get; private set; }
        public float Profit { get; private set; }
        [NotMapped]
        public string CompanyTitle => Company!.Title;

        public void UpdateInfo(int companyId, float amount, float profit)
        {
            CompanyId = companyId;
            Amount = amount;
            Profit = profit;
        }
    }
}
