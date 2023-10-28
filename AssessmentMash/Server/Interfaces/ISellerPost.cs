using AssessmentMash.Shared.Models;

namespace AssessmentMash.Server.Interfaces
{
    public interface ISellerPost
    {
        public List<SellerPost> GetAllSellerPosts();

        public void AddSellerPost(SellerPost sellerPost);

        public void UpdateSellerPost(SellerPost sellerPost);

        public SellerPost GetSellerPostData(int id);

        public void DeleteSellerPost(int id);

        //public List<Register> GetUser();
    }
}
