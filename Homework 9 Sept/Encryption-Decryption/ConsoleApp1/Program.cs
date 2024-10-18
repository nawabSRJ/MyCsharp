using System;

public interface Encryptable
{
    string Encrypt(string data);
    string Decrypt(string encryptedData);
}

public class AES : Encryptable
{
    private int shift;

    public AES(int shiftValue)
    {
        shift = shiftValue;
    }

    public string Encrypt(string data)
    {
        char[] encrypted = new char[data.Length];
        for (int i = 0; i < data.Length; i++)
        {
            char c = data[i];
            if (char.IsLetter(c))
            {
                char d = char.IsUpper(c) ? 'A' : 'a';
                encrypted[i] = (char)((c + shift - d) % 26 + d);
            }
            else
            {
                encrypted[i] = c;
            }
        }
        return new string(encrypted);
    }

    public string Decrypt(string encryptedData)
    {
        char[] decrypted = new char[encryptedData.Length];
        for (int i = 0; i < encryptedData.Length; i++)
        {
            char c = encryptedData[i];
            if (char.IsLetter(c))
            {
                char d = char.IsUpper(c) ? 'A' : 'a';
                decrypted[i] = (char)((c - shift - d + 26) % 26 + d);
            }
            else
            {
                decrypted[i] = c;
            }
        }
        return new string(decrypted);
    }
}

public class RSA : Encryptable
{
    // Don't know RSA encryption , so just adding the functions :/
    public string Encrypt(string data)
    {
        
        return "RSA encryption not implemented.";
    }

    public string Decrypt(string encryptedData)
    {
        
        return "RSA decryption not implemented.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- Encryption Program ---");
            Console.WriteLine("1. Encrypt using AES (Shift Cipher)");
            Console.WriteLine("2. Decrypt using AES (Shift Cipher)");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 1)
            {
                Console.Write("Enter text to encrypt: ");
                string text = Console.ReadLine()!;
                Console.Write("Enter shift value: ");
                int shift = int.Parse(Console.ReadLine()!);

                AES aes = new AES(shift);
                string encryptedText = aes.Encrypt(text);
                Console.WriteLine("Encrypted Text: " + encryptedText);
            }
            else if (choice == 2)
            {
                Console.Write("Enter text to decrypt: ");
                string text = Console.ReadLine()!;
                Console.Write("Enter shift value: ");
                int shift = int.Parse(Console.ReadLine()!);

                AES aes = new AES(shift);
                string decryptedText = aes.Decrypt(text);
                Console.WriteLine("Decrypted Text: " + decryptedText);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
