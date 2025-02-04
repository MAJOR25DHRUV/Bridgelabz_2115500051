using System;

class Patient
{
    // Static variable shared by all patients to store the hospital name
    static string HospitalName = "City General Hospital";
    
    // Instance variables for Name, Age, and Ailment
    public string Name;
    public int Age;
    public string Ailment;

    // Readonly variable for PatientID to ensure it is unique and cannot be changed once assigned
    public readonly int PatientID;

    // Static variable to keep track of the total number of patients admitted
    private static int totalPatients = 0;

    // Static method to get the total number of patients admitted
    public static void GetTotalPatients()
    {
        // Printing the total number of patients admitted
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    // Constructor to initialize Name, Age, and Ailment using 'this' keyword
    public Patient(int patientID, string name, int age, string ailment)
    {
        // Initializing instance variables using constructor parameters
        this.PatientID = patientID;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;

        // Incrementing the total number of patients whenever a new patient is created
        totalPatients++;
    }

    // Instance method to display patient details
    public void DisplayDetails()
    {
        // Checking if the current object is an instance of the Patient class using 'is' operator
        if (this is Patient)
        {
            // Printing patient details including PatientID, Name, Age, Ailment, and HospitalName
            Console.WriteLine("Patient ID: " + PatientID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine("Hospital: " + HospitalName);
        }
    }

    static void Main(string[] args)
    {
        // Creating patient objects with unique PatientID
        Patient patient1 = new Patient(101, "John Doe", 45, "Fever");
        Patient patient2 = new Patient(102, "Jane Smith", 30, "Cough");

        // Displaying patient details
        patient1.DisplayDetails();
        patient2.DisplayDetails();

        // Displaying the total number of patients admitted
        Patient.GetTotalPatients();
    }
}
