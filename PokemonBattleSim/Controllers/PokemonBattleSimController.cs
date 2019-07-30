using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonBattleSim.Models;

namespace PokemonBattleSim.Controllers
{
    public class PokemonBattleSimController : Controller
    {
        private PokemonContext db = new PokemonContext();
        public IActionResult Index()
        {
            GenAllPk.LoadData();
            List<Pokemon> allPkmn = GenAllPk.allPokemon;

            foreach(Pokemon p in allPkmn)
            {
                db.Add(p);
            }
            db.SaveChanges();

            return View();
        }

        [HttpPost]
        public IActionResult IndexPost()
        {

            return View();
        }
    }
}