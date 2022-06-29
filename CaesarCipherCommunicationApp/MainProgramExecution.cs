using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherCommunicationApp
{
    public static class MainProgramExecution
    {
        public static void Execute()
        {
            Console.WriteLine("Enter your secret message: ");
            string SeceretMessage = Console.ReadLine();

            //This will be the key used to encrypt and decrypt the secret message
            Console.WriteLine("Enter the shift value. This will be the key used to encrypt and decrypt your secret message");
            int shiftValue = Convert.ToInt32(Console.ReadLine());

            var encryptedMessage = EncryptionAndDecryptionService.EncryptMessage(SeceretMessage, shiftValue);
            var decryptedMessage = EncryptionAndDecryptionService.DecryptMessage(encryptedMessage, shiftValue);

            Console.WriteLine("The message encrypted is: \n" + encryptedMessage);
            Console.WriteLine();
            Console.WriteLine("The message Decrypted is: \n" + decryptedMessage);
        }
    }
}
