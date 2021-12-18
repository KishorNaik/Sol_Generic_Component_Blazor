using Sol_Demo.Data;
using Sol_Demo.Model;

namespace Sol_Demo.Pages.Demo
{
    public partial class Display
    {
        protected List<UserModel>? UserList { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                UserList = (await new UserData().GetUserListAsync())?.ToList();

                base.StateHasChanged();
            }
        }
    }
}