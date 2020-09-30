using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class TamagotchiController : Controller
  {
    [HttpGet("/tamagotchi")]
    public ActionResult Index()
    {
      List<VirtualPet> allVirtualPets = VirtualPet.GetAll();
      return View(allVirtualPets);
    }
    [HttpPost("/tamagotchi")]
    public ActionResult Create(string name, string breed)
    {
      VirtualPet myVirtualPet = new VirtualPet(name, breed);
      return RedirectToAction("Index");
    }
    [HttpGet("/tamagotchi/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/tamagotchi/{id}")]
    public ActionResult Show(int id)
    {
      VirtualPet foundVirtualPet = VirtualPet.Find(id);
      return View(foundVirtualPet);
    }
  }
}