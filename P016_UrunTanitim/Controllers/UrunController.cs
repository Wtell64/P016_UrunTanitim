using Microsoft.AspNetCore.Mvc;
using P016_UrunTanitim.Models;
namespace P016_UrunTanitim.Controllers
{
	public class UrunController : Controller
	{
		//Context -> veri tabanim verde ve bu veritabaninda hangi tablolarim var?

		private string tedarikciIsim = "";
		

		//public UrunController(string tedarikciIsim)
		//{
		//	this.tedarikciIsim=tedarikciIsim;
		//}
		public IActionResult Index() //sag click Add View > Razor View > Razor View - Empty. Isimler ayni olucak Index mesela burda 
		{
			Urun u1 = new Urun { Id = 1, UrunKodu = "K001", UrunTanim = "105 Tuslu klavye", UrunTur = "PC", Miktar = 56 };
			Urun u2 = new Urun { Id = 2, UrunKodu = "K002", UrunTanim = "106 Tuslu klavye", UrunTur = "PC", Miktar = 26 };
			Urun u3 = new Urun { Id = 3, UrunKodu = "K003", UrunTanim = "107 Tuslu klavye", UrunTur = "PC", Miktar = 45 };

			List<Urun> list = new List<Urun>();

			list.Add(u1);
			list.Add(u2);
			list.Add(u3);


			return View(list);
		}


	}
}
