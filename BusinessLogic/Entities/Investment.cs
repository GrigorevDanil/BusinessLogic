
using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogic.Entities
{
    public class Investment : Entity<int>
    {


        private Investment()
        {

        }

        public Investment(Company company, float profit)
        {
            CompanyId = company.Id;
            Profit = profit;
        }

        public static Result<Investment> Create(Company company, float profit)
        {
            return Result.Success(new Investment(company, profit));
        }

        public int CompanyId { get; private set; }
        public virtual Company? Company { get; }
        public float Profit { get; private set; }
        [NotMapped]
        public string CompanyTitle => Company!.Title;

        public void UpdateInfo(int companyId, float profit)
        {
            CompanyId = companyId;
            Profit = profit;
        }
    }
}
