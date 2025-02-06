using System;
using System.Collections.Generic;

// Hospital class contains doctors and patients (Association)
class Hospital
{
    private string hospitalName; // Private field for hospital name
    private List<Doctor> doctors; // List of doctors
    private List<Patient> patients; // List of patients

    // Constructor to initialize hospital
    public Hospital(string name)
    {
        hospitalName = name;
        doctors = new List<Doctor>();
        patients = new List<Patient>();
    }

    // Method to add a doctor
    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    // Method to add a patient
    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    // Method to display hospital details
    public void DisplayHospitalDetails()
    {
        Console.WriteLine("Hospital: " + hospitalName);
        Console.WriteLine("Doctors:");
        foreach (Doctor doc in doctors)
        {
            Console.WriteLine("  - " + doc.GetDoctorName());
        }
        Console.WriteLine("Patients:");
        foreach (Patient pat in patients)
        {
            Console.WriteLine("  - " + pat.GetPatientName());
        }
    }
}

// Doctor class (Association: Can consult multiple patients)
class Doctor
{
    private string doctorName; // Private field for doctor name

    // Constructor to initialize doctor
    public Doctor(string name)
    {
        doctorName = name;
    }

    // Getter method for doctor name
    public string GetDoctorName()
    {
        return doctorName;
    }

    // Method to conduct a consultation
    public void Consult(Patient patient)
    {
        Console.WriteLine(doctorName + " is consulting " + patient.GetPatientName());
    }
}

// Patient class (Association: Can consult multiple doctors)
class Patient
{
    private string patientName; // Private field for patient name

    // Constructor to initialize patient
    public Patient(string name)
    {
        patientName = name;
    }

    // Getter method for patient name
    public string GetPatientName()
    {
        return patientName;
    }
}

class Program
{
    static void Main()
    {
        // Create a hospital
        Hospital hospital = new Hospital("City Hospital");

        // Create doctors
        Doctor doctor1 = new Doctor("Dr. Adams");
        Doctor doctor2 = new Doctor("Dr. Brown");

        // Create patients
        Patient patient1 = new Patient("Alice");
        Patient patient2 = new Patient("Bob");

        // Add doctors and patients to hospital
        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        // Perform consultations
        doctor1.Consult(patient1);
        doctor2.Consult(patient2);

        // Display hospital details
        hospital.DisplayHospitalDetails();
    }
}
