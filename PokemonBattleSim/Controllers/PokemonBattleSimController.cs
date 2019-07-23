using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PokemonBattleSim.Controllers
{
    public class PokemonBattleSimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {

           // MessageBox.Show("You are in the Form.Shown event.");

        }
    }
}