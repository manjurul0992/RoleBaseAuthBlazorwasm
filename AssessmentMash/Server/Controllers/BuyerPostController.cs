using AssessmentMash.Shared.Models;
using AssessmentMash.Server.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AssessmentMash.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   

    public class BuyerPostController : ControllerBase
    {
        private readonly IBuyerPost _BuyerPostService;

        
        public BuyerPostController(IBuyerPost BuyerPostService)
        {
            _BuyerPostService = BuyerPostService;
        }

        [HttpGet]
        public async Task<List<BuyerPost>> Get()
        {
            return await Task.FromResult(_BuyerPostService.GetAllBuyerPosts());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            BuyerPost buyerPost = _BuyerPostService.GetBuyerPostData(id);
            if (buyerPost != null)
            {
                return Ok(buyerPost);
            }
            return NotFound();
        }

        [HttpPost]

        public void Post(BuyerPost buyerPost)
        {
            _BuyerPostService.AddBuyerPost(buyerPost);
        }

        [HttpPut]
        public void Put(BuyerPost buyerPost)
        {
            _BuyerPostService.UpdateBuyerPost(buyerPost);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _BuyerPostService.DeleteBuyerPost(id);
            return Ok();
        }

        [HttpGet]
        [Route("GetUserList")]
        public async Task<IEnumerable<Register>> UserList()
        {
            return await Task.FromResult(_BuyerPostService.GetUser());
        }
    }
}
