using Microsoft.AspNetCore.Mvc;
using Testimonials.Module.Models;

namespace Testimonials.Module
{
    public class TestimonialController : Controller
    {
        [HttpGet]
        public IActionResult Submit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save to database or Orchard ContentItem if needed
                ViewBag.Message = "Thank you for your testimonial!";
                ModelState.Clear();
            }

            return View();
        }
    }
}
