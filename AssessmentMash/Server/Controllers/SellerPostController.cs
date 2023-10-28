using AssessmentMash.Server.Interfaces;
using AssessmentMash.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentMash.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   


    public class SellerPostController : ControllerBase
    {
        private readonly ISellerPost _SellerPostService;
        private readonly IBuyerPost _BuyerPostService;


        public SellerPostController(ISellerPost SellerPostService, IBuyerPost buyerPostService)
        {
            _SellerPostService = SellerPostService;
            _BuyerPostService = buyerPostService;
        }

        [HttpGet]
        public async Task<List<SellerPost>> Get()
        {
            return await Task.FromResult(_SellerPostService.GetAllSellerPosts());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            SellerPost sellerPost = _SellerPostService.GetSellerPostData(id);
            if (sellerPost != null)
            {
                return Ok(sellerPost);
            }
            return NotFound();
        }

        [HttpPost]

        public void Post(SellerPost sellerPost)
        {
            _SellerPostService.AddSellerPost(sellerPost);
        }

        [HttpPut]
        public void Put(SellerPost sellerPost)
        {
            _SellerPostService.UpdateSellerPost(sellerPost);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _SellerPostService.DeleteSellerPost(id);
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
