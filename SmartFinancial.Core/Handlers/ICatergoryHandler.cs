using SmartFinancial.Core.Models;
using SmartFinancial.Core.Requests.Categories;
using SmartFinancial.Core.Requests.Transactions;
using SmartFinancial.Core.Responses;

namespace SmartFinancial.Core.Handlers
{
    public interface ICatergoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateTransactionRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request);

    }
}
