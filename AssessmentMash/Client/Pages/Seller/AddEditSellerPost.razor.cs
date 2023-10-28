
using AssessmentMash.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AssessmentMash.Client.Pages
{
    public class AddEditSellerPostBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int buyerID { get; set; }

        protected string Title1 = "Add";
        public SellerPost buyer = new();
        protected List<Register> userList = new();

        protected override async Task OnInitializedAsync()
        {
            await GetUserList();
        }

        protected override async Task OnParametersSetAsync()
        {
            if (buyerID != 0)
            {
                Title1 = "Edit";
                buyer = await Http.GetFromJsonAsync<SellerPost>("api/SellerPost/" + buyerID);
            }
        }

        protected async Task GetUserList()
        {
            userList = await Http.GetFromJsonAsync<List<Register>>("api/SellerPost/GetUserList");
        }

        protected async Task SaveBuyerPost()
        {
            if (buyer.SellerPostId != 0)
            {
                await Http.PutAsJsonAsync("api/SellerPost", buyer);
            }
            else
            {
                await Http.PostAsJsonAsync("api/SellerPost", buyer);
            }
            Cancel();
        }

        public void Cancel()
        {
            NavigationManager.NavigateTo("/fetchsellerpost");
        }
    }
}
