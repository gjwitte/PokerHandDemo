using Microsoft.AspNetCore.Mvc;
using PokerHandDemo.Handlers;
using PokerHandDemo.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace PokerHandDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CreateRound(int numberOfHands)
        {
            if (numberOfHands == 0 || numberOfHands > 10) //0 players or more players than cards in one deck
                return BadRequest(ModelState);

            var pokerRound = new List<FiveCardPokerHand>();

            var dealer = new FiveCardPokerDealer();
            var deck = dealer.BuildDeck();
            pokerRound.AddRange(dealer.Deal<FiveCardPokerHand>(deck, numberOfHands));

            var handler = new FiveCardPokerRankHandHandler();

            handler.Calculate(pokerRound);

            return View(pokerRound);
        }
    }
}
