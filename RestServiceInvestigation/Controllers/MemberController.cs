using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestServiceInvestigation.Data;
using RestServiceInvestigation.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace RestServiceInvestigation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        MembershipDbContext _context;

        public MemberController(MembershipDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Member> Index()
        {
            return _context.Members.ToList<Member>();
        }


        [HttpGet("{id}")]
        public Member MemberGet(int id)
        {

            return _context.Members.Find(id); 

        }

        [HttpPost]
        public Member CreateMember(Member memberToAdd)
        {

            Console.WriteLine(memberToAdd);
            _context.Add(memberToAdd);
            _context.SaveChanges();
            return memberToAdd;
        }

        [HttpDelete("{id}")]
        public void DeleteMember(int id)
        {
            Member memberToDelete = _context.Members.Find(id);

            _context.Remove(memberToDelete);
            _context.SaveChanges();
        }


    }
}
