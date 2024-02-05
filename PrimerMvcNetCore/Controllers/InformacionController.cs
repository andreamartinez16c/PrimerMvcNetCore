using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
	public class InformacionController : Controller
	{
		[HttpGet]
		
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult VistaControladorPost(Persona persona, string aficiones)
		{
			ViewData["DATOS"] = "Nombre: " + persona.Nombre + ", Email: " + persona.Email + ", Edad: " + persona.Edad + ", Aficiones: " + aficiones;
			return View();
		}

		public IActionResult VistaControladorPost()
		{
			return View();
		}

		public IActionResult ControladorVista()
		{
			//VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
			ViewData["NOMBRE"] = "Alumno";
			ViewData["EDAD"] = 24;
			ViewBag.DiaSemana = "Lunes";
			Persona persona = new Persona();
			persona.Nombre = "Persona Model";
			persona.Email = "email@email.es";
			persona.Edad = 10;
			return View(persona);
		}

		//VAMOS A RECIBIR 2 PARAMS
		public IActionResult VistaControladorGet(string app, int? version)
		{
			if (version is null)
			{

			}
			//DIBUJAMOS EN LA VISTA LOS PARAMETROS RECIBIDOS
			ViewData["DATOS"] =  "Application:" + app + ", Version: " + version.GetValueOrDefault();
			return View();
		}
	}
}
