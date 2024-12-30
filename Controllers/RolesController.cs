using Microsoft.AspNetCore.Mvc;

namespace PartyRoleInfoApp.Controllers;

public class RolesController : Controller
{
    public IActionResult Skipper()
    {
        if (!CanAccessRole(nameof(Skipper)))
        {
            return RedirectToAction("Index", "Home");
        }

        return View();
    }

    public IActionResult Wishlister()
    {
        if (!CanAccessRole(nameof(Wishlister)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }
    
    public IActionResult FreeBather()
    {
        if (!CanAccessRole(nameof(FreeBather)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }

    public IActionResult Instaxer()
    {
        if (!CanAccessRole(nameof(Instaxer)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }

    public IActionResult BeerpongFriend()
    {
        if (!CanAccessRole(nameof(BeerpongFriend)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }

    public IActionResult FreeBeerer()
    {
        if (!CanAccessRole(nameof(FreeBeerer)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }

    public IActionResult Playlister()
    {
        if (!CanAccessRole(nameof(Playlister)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }

    public IActionResult Cheerser()
    {
        if (!CanAccessRole(nameof(Cheerser)))
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }
    
    private bool CanAccessRole(string role)
    {
        if (!Request.Cookies.TryGetValue("Role", out string? cookieValue))
        {
            Response.Cookies.Append("Role", role, new CookieOptions()
            {
                Expires = DateTimeOffset.Now.AddDays(31)
            });
        }
        else
        {
            if (cookieValue != role)
            {
                return false;
            }
        }

        return true;
    }
}