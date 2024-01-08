using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace SayHello.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    [Route("{userName}")]
    public string AddUserName(string userName)
    {
        var adminList = new string[] { "Isaiah", "Jessie", "Maddie", "Jacob", "Ken", "Tony" };
        if (adminList.Contains(userName))
        {
            return $"Ah, hello Admin {userName}! Send Master Leo my regards.";
        }
        if (userName == "Leo"){
            return $"Hello, Master {userName}...";
        }
        return $"Hello, {userName}.";
    }

}