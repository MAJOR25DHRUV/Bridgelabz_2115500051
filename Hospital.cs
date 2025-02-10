using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>
        {
            new InPatient("P001", "John Doe", 45, 5),
            new OutPatient("P002", "Jane Smith", 32)
        };

        foreach (Patient patient in patients)
        {
            Console.WriteLine("Patient Details:");
            patient.GetPatientDetails();
            Console.WriteLine("Bill Amount: $" + patient.CalculateBill());
            
            // Using 'as' operator for interface checking
            IMedicalRecord medicalRecord = patient as IMedicalRecord;
            if (medicalRecord != null)
            {
                medicalRecord.AddRecord("Initial Checkup");
                Console.WriteLine("Medical Records: " + medicalRecord.ViewRecords());
            }
            Console.WriteLine();
        }
    }
}

// Abstract base class for all patients
public abstract class Patient
{
    // Private fields for encapsulation
    private string patientId;
    private string name;
    private int age;
    private List<string> medicalHistory;

    // Constructor to initialize patient details
    protected Patient(string patientId, string name, int age)
    {
        this.PatientId = patientId;
        this.Name = name;
        this.Age = age;
        this.medicalHistory = new List<string>();
    }

    // Public properties with validation
    public string PatientId
    {
        get { return patientId; }
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Patient ID cannot be empty");
            patientId = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Name cannot be empty");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 150)
                throw new ArgumentException("Invalid age");
            age = value;
        }
    }

    // Protected method to access medical history
    protected List<string> GetMedicalHistory()
    {
        return medicalHistory;
    }

    // Abstract method for bill calculation
    public abstract double CalculateBill();

    // Concrete method for displaying patient details
    public virtual void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// Interface for medical records
public interface IMedicalRecord
{
    void AddRecord(string record);
    string ViewRecords();
}

// InPatient implementation
public class InPatient : Patient, IMedicalRecord
{
    // Private fields
    private int daysStayed;
    private const double DailyRate = 100.0;

    // Constructor
    public InPatient(string patientId, string name, int age, int daysStayed)
        : base(patientId, name, age)
    {
        this.daysStayed = daysStayed;
    }

    // Implementation of abstract method
    public override double CalculateBill()
    {
        return daysStayed * DailyRate;
    }

    // Implementation of interface methods
    public void AddRecord(string record)
    {
        GetMedicalHistory().Add(record + " - Inpatient");
    }

    public string ViewRecords()
    {
        return string.Join(", ", GetMedicalHistory());
    }

    // Override to include days stayed
    public override void GetPatientDetails()
    {
        base.GetPatientDetails();
        Console.WriteLine("Days Stayed: " + daysStayed);
    }
}

// OutPatient implementation
public class OutPatient : Patient, IMedicalRecord
{
    // Private constant
    private const double ConsultationFee = 50.0;

    // Constructor
    public OutPatient(string patientId, string name, int age)
        : base(patientId, name, age) { }

    // Implementation of abstract method
    public override double CalculateBill()
    {
        return ConsultationFee;
    }

    // Implementation of interface methods
    public void AddRecord(string record)
    {
        GetMedicalHistory().Add(record + " - Outpatient");
    }

    public string ViewRecords()
    {
        return string.Join(", ", GetMedicalHistory());
    }
}