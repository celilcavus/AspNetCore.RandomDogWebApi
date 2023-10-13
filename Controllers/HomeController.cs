using celilcavus.models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


namespace celilcavus.controller;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        using var client = new HttpClient();
        var result =  client.GetStringAsync("https://dog.ceo/api/breeds/image/random");
        var model = JsonSerializer.Deserialize<DogPicture>(result.Result);
        return View(model);
    }
}