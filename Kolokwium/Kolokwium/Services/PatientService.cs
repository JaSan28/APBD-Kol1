namespace Kolokwium.Services;
using Kolokwium.Models;

public class PatientService : IPatientService
{
    private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";

    public async Task<Patient> GetPatientInfo(int patientId)
    {
        var patient = new Patient();
        
        return await Task.FromResult(patient);
        
    }

    public Task<Appointment> AddAppointmentAsync(int patientId, Appointment appointment)
    {
        throw new NotImplementedException();
    }
}