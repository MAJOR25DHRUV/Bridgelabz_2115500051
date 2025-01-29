using System;

namespace OTPGeneratorQuestion7
{
    public class OTPGenerator
    {
        // Method to generate a 6-digit OTP
        public static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }

        // Method to generate multiple OTPs and store in array
        public static int[] GenerateMultipleOTPs(int count)
        {
            int[] otps = new int[count];
            
            for (int i = 0; i < count; i++)
            {
                otps[i] = GenerateOTP();
            }
            
            return otps;
        }

        // Method to check if OTPs are unique
        public static bool AreOTPsUnique(int[] otps)
        {
            // Compare each OTP with all others
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                        return false;
                }
            }
            return true;
        }
    }

    class GenerateOTP
    {
        static void TestOTPGenerator()
        {
            const int OTP_COUNT = 10;
            
            // Generate 10 OTPs
            Console.WriteLine("Generating " + OTP_COUNT + " OTPs...");
            int[] otps = OTPGenerator.GenerateMultipleOTPs(OTP_COUNT);
            
            // Display OTPs
            Console.WriteLine("\nGenerated OTPs:");
            for (int i = 0; i < otps.Length; i++)
            {
                Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
            }
            
            // Check uniqueness
            bool areUnique = OTPGenerator.AreOTPsUnique(otps);
            Console.WriteLine("\nAll OTPs are unique: " + areUnique);
        }

        static void Main(string[] args)
        {
            TestOTPGenerator();
        }
    }
}