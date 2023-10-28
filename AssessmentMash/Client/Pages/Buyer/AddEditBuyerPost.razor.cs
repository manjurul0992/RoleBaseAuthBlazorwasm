
using AssessmentMash.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AssessmentMash.Client.Pages
{
    public class AddEditBuyerPostBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int buyerID { get; set; }

        protected string Title1 = "Add";
        public BuyerPost buyer = new();
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
                buyer = await Http.GetFromJsonAsync<BuyerPost>("api/BuyerPost/" + buyerID);
            }
        }

        protected async Task GetUserList()
        {
            userList = await Http.GetFromJsonAsync<List<Register>>("api/BuyerPost/GetUserList");
        }

        protected async Task SaveBuyerPost()
        {
            if (buyer.BuyerPostId != 0)
            {
                await Http.PutAsJsonAsync("api/BuyerPost", buyer);
            }
            else
            {
                await Http.PostAsJsonAsync("api/BuyerPost", buyer);
            }
            Cancel();
        }

        public void Cancel()
        {
            NavigationManager.NavigateTo("/fetchbuyerpost");
        }
    }
}
