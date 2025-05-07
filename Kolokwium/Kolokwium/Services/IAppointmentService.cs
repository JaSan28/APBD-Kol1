using Kolokwium.Models;

namespace Kolokwium.Services;

public interface IAppointmentService
{
    Task<Appointment> AddAppointmentAsync(int patientId, Appointment appointment);
    Task<Appointment> CreatedAtAction(string actionName, object actionArgument); 
}
