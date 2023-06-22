using Serenity.Services;
using MyRequest = Adminio.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<Adminio.Administration.UserRow>;
using MyRow = Adminio.Administration.UserRow;

namespace Adminio.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}