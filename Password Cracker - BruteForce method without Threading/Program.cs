//Currently This Code Only Checks Numerics.
class BruteForcePasswordCracker
{
    public static void Main()
    {
        Console.WriteLine("Enter your password");
        string userInput_String = Console.ReadLine();
        bool isValid = int.TryParse(userInput_String, out int userInput_Integer);

        if (!isValid)
        {
            Console.WriteLine("Enter Proper Value");
        }

        int passwordLength = userInput_String.Length;

        int passwordValue = 0;
        bool passwordCracked = false;
        while (!passwordCracked)
        {
            passwordValue += 1;

            string passwordValue_String = Convert.ToString(passwordValue);
            string referenceString_Zeroes = "";
            for (int zeroIndex = 0; zeroIndex < (passwordLength - passwordValue_String.Length); zeroIndex++)
            {
                referenceString_Zeroes += "0";
            }

            string finalPassword = referenceString_Zeroes + passwordValue_String;
            
            Console.WriteLine();
            Console.WriteLine($"Trying Password is {finalPassword}");

            if (finalPassword == userInput_String)
            {
                passwordCracked = true;
                Console.WriteLine("Password Cracked");
            }
        }
    }
}