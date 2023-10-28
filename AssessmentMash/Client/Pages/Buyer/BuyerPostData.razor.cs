using AssessmentMash.Shared.Models;

using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace AssessmentMash.Client.Pages
{
    public class BuyerPostDataBase : ComponentBase
    {
        [Inject]
        HttpClient Http { get; set; }

        protected List<BuyerPost> buyerList = new();
        protected List<BuyerPost> searchBuyerData = new();
        protected BuyerPost buyer = new();
        protected string SearchString { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            await Getbuyer();
        }

        protected async Task Getbuyer()
        {
            buyerList = await Http.GetFromJsonAsync<List<BuyerPost>>("api/BuyerPost");
            searchBuyerData = buyerList;
        }

        protected void FilterBuyer()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                buyerList = searchBuyerData
                    .Where(x => x.Title.IndexOf(SearchString, StringComparison.OrdinalIgnoreCase) != -1)
                    .ToList();
            }
            else
            {
                buyerList = searchBuyerData;
            }
        }

        //protected void DeleteConfirm(int buyerID)
        //{
        //    buyer = buyerList.FirstOrDefault(x => x.BuyerPostId == buyerID);
        //}

        //protected async Task DeleteBuyerPost(int buyerID)
        //{
        //    await Http.DeleteAsync("api/BuyerPost/" + buyerID);
        //    await Getbuyer();
        //}

        public void ResetSearch()
        {
            SearchString = string.Empty;
            buyerList = searchBuyerData;
        }
    }
}
