using AssessmentMash.Shared.Models;


namespace AssessmentMash.Server.Interfaces
{
    public interface IBuyerPost
    {
        public List<BuyerPost> GetAllBuyerPosts();

        public void AddBuyerPost(BuyerPost buyerPost);

        public void UpdateBuyerPost(BuyerPost buyerPost);

        public BuyerPost GetBuyerPostData(int id);

        public void DeleteBuyerPost(int id);

        public List<Register> GetUser();
    }
}
