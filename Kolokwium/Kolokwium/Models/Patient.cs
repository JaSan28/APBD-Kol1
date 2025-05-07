namespace Kolokwium.Models;

public class Patient
{
    int patient_id { get; set; }
    string first_name { get; set; }
    string last_name { get; set; }
    DateTime date_of_birth { get; set; }
}