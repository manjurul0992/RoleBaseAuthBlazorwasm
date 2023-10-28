using AssessmentMash.Shared.Models;
using AssessmentMash.Server.Interfaces;

using Microsoft.EntityFrameworkCore;
using AssessmentMash.Server.Data;

namespace AssessmentMash.Server.DataAccess
{
    public class AssessmentDataAccessLayer : IBuyerPost, ISellerPost
    {
        readonly AppDbContext _dbContext;
        public AssessmentDataAccessLayer(AppDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void AddBuyerPost(BuyerPost buyerPost)
        {
            try
            {
                _dbContext.BuyerPosts.Add(buyerPost);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void AddSellerPost(SellerPost sellerPost)
        {
            try
            {
                _dbContext.SellerPosts.Add(sellerPost);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteBuyerPost(int id)
        {
            try
            {
                BuyerPost? employee = _dbContext.BuyerPosts.Find(id);

                if (employee != null)
                {
                    _dbContext.BuyerPosts.Remove(employee);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public void DeleteSellerPost(int id)
        {
            try
            {
                SellerPost? employee = _dbContext.SellerPosts.Find(id);

                if (employee != null)
                {
                    _dbContext.SellerPosts.Remove(employee);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<BuyerPost> GetAllBuyerPosts()
        {
            try
            {
                return _dbContext.BuyerPosts.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<SellerPost> GetAllSellerPosts()
        {
            try
            {
                return _dbContext.SellerPosts.ToList();
            }
            catch
            {
                throw;
            }
        }

        public BuyerPost GetBuyerPostData(int id)
        {
            try
            {
                BuyerPost? employee = _dbContext.BuyerPosts.Find(id);

                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public SellerPost GetSellerPostData(int id)
        {
            try
            {
                SellerPost? employee = _dbContext.SellerPosts.Find(id);

                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Register> GetUser()
        {
            try
            {
                return _dbContext.Registers.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateBuyerPost(BuyerPost buyerPost)
        {
            try
            {
                _dbContext.Entry(buyerPost).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateSellerPost(SellerPost sellerPost)
        {
            try
            {
                _dbContext.Entry(sellerPost).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
