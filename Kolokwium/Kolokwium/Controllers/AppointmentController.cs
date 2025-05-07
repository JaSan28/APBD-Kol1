using Kolokwium.Services;
using Microsoft.AspNetCore.Http.HttpResults;
namespace Kolokwium.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Kolokwium.Models;
using Kolokwium.Services;

[Route("api/[controller]")]
    [ApiController]
	public class AppointmentController
	{
    
		private readonly IPatientService _patientService;

		public AppointmentController(IPatientService PatientService)
		{
			_patientService = PatientService;
		}
		
		
		[HttpGet("appointments/{id}")]
		public async Task<IActionResult> GetAppointments(int id)
		{
			try
			{
				var response = await _patientService.GetPatientInfo(id);
				return Ok(response);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Patient with id {id} not found");
				throw;
			}
		}
		
		
		[HttpPost("appointments")]
		public async Task<IActionResult> AddAppointments<AddAppointment>(int id, Appointment AddAppointme)
		{
			try
			{
				await _patientService.AddAppointmentAsync(id, AddAppointme);
				return CreatedAtAction(AddAppointme, new { id }, null);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
		}

		private IActionResult CreatedAtAction(Appointment addAppointme, object o, object o1)
		{
			throw new NotImplementedException();
		}
	}
