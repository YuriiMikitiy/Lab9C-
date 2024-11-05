using Microsoft.AspNetCore.Mvc;

namespace Lab9C_.Controllers
{
    public class DevicesController : Controller
    {
        List<string> GetListdevices()
        {
            List<string> devices = new List<string>();
            devices.Add("Телевізор");
            devices.Add("Телефон");
            devices.Add("Навушники");
            devices.Add("Мишка");
            devices.Add("Холодильник");
            devices.Add("Приставка");

            return devices;
        }
        public IActionResult FirstViewMethod()
        {
            List<string> devices = GetListdevices();
            return View(devices);
        }

        public IActionResult SecondViewMethod()
        {
            List<string> devices = GetListdevices();

            return View(GetListdevices().OrderBy(x=>x).ToList());
        }
        public IActionResult ThirdViewMethod() 
        {
            List<string> devices = GetListdevices();

            return View(GetListdevices().OrderBy(x => x).ToList());
        }
    }
}
