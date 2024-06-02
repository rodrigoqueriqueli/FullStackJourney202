namespace SmartFinancial.Core.Requests.Transactions
{
    public class GetTransactionByIdRequest : BaseRequest
    {
        public long Id { get; set; }
    }
}
