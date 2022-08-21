using u20576766_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20576766_HW04.Controllers
{
    public class MerchandiseController : Controller
    {
        // GET: Merchandise
        public ActionResult Merchandise()
        {
            List<Merchandise> merch = GetTestData();
            return View(merch);
        }

        private List<Merchandise> GetTestData()
        {
            List<Merchandise> merch = new List<Merchandise>();
            HatViewModel hat3 = new HatViewModel(212703, "Hat", "White-Black", "ALL AVAILABLE", 20, "ALL AVAILABLE");
            TopViewModel top1 = new TopViewModel(812502, "T-shirt", "White", "ALL AVAILABLE", 100, "ALL AVAILABLE");
            HoodieViewModel hood1 = new HoodieViewModel(412601, "Hoodie", true, "Blue", "ALL AVAILABLE", 150, "ALL AVAILABLE");
            HatViewModel hat2 = new HatViewModel(212702, "Hat", "Brown", "ALL AVAILABLE", 80, "ALL AVAILABLE");
            TopViewModel top3 = new TopViewModel(812504, "T-shirt", "Grey", "ALL AVAILABLE", 157, "ALL AVAILABLE");
            HoodieViewModel hood3 = new HoodieViewModel(412603, "Hoodie", true, "White", "ALL AVAILABLE", 120, "ALL AVAILABLE");
            HatViewModel hat1 = new HatViewModel(212701, "Hat", "Blue", "ALL AVAILABLE", 120, "ALL AVAILABLE");
            TopViewModel top2 = new TopViewModel(812503, "T-shirt", "Black", "ALL AVAILABLE", 80, "ALL AVAILABLE");
            HoodieViewModel hood2 = new HoodieViewModel(412602, "Hoodie", true, "Black", "ALL AVAILABLE", 150, "ALL AVAILABLE");

            merch.Add(top1);
            merch.Add(top2);
            merch.Add(top3);
            merch.Add(hood1);
            merch.Add(hood2);
            merch.Add(hood3);
            merch.Add(hat1);
            merch.Add(hat2);
            merch.Add(hat3);
            return merch;
        }
    }
}