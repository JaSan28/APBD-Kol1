using Kolokwium.Models;

namespace Kolokwium.Services;

public interface IPatientService
{
    Task<Patient> GetPatientInfo(int patientId);
    Task<Appointment> AddAppointmentAsync(int patientId, Appointment appointment);
    
}