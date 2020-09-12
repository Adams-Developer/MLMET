using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarehouseStockPredictionML.Model;

namespace WarehouseStockPrediction.Controllers
{
    public class StockPredictionController : Controller
    {
       [HttpGet]
       public IActionResult StockPrediction()
       {
            return View();
       }

        [HttpPost]
        public ActionResult StockPrediction(ModelInput modelInput)
        {
            ViewBag.Result = "";

            var stockPredictions = ConsumeModel.Predict(modelInput);
            ViewBag.Result = stockPredictions;

            ViewData["ItemId"] = modelInput.ItemId;
            ViewData["LocationCode"] = modelInput.LocationCode;

            return View();

        }

    }
}
