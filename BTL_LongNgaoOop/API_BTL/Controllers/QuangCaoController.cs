using BussinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API_BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuangCaoController : ControllerBase
    {
        public IQuangCaoBUSS _quangcaoBUSS;


        public QuangCaoController (IQuangCaoBUSS quangcaoBUSS)
        {
            _quangcaoBUSS=quangcaoBUSS    ;
        }
        [Route("get-all-quangcao")]
        [ HttpGet]
        public IEnumerable<QuangCaoModel> GetQuangCaoModel()
        {
            return _quangcaoBUSS.GetallQuangCao();
        }
    }
}
