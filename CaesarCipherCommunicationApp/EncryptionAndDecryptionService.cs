using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherCommunicationApp
{
    public static class EncryptionAndDecryptionService
    {
        //Code to encrypt a message
        public static string EncryptMessage(string input, int shiftValue)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g',
           'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            char[] secretMessage = input.ToLower().ToCharArray();


            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];

                int letterPosition = Array.IndexOf(alphabet, letter);
                if (letterPosition is -1)
                {
                    encryptedMessage[i] += letter;
                }
                else
                {
                    int newLetterPosition = (letterPosition + shiftValue) % 26;

                    char letterEncoded = alphabet[newLetterPosition];

                    encryptedMessage[i] = letterEncoded;
                }
            }
            string encodedString = String.Join("", encryptedMessage);
            return encodedString;
        }

        //Code to decrypt a message
        public static string DecryptMessage(string encryptedMessage, int shiftValue)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g',
           'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            char[] secretMessage = encryptedMessage.ToLower().ToCharArray();


            char[] decryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];

                int letterPosition = Array.IndexOf(alphabet, letter);
                if (letterPosition is -1)
                {
                    decryptedMessage[i] += letter;
                }
                else
                {
                    int newLetterPosition = (letterPosition - shiftValue) % 26;
                    if (newLetterPosition < 0)
                    {
                        newLetterPosition = (26 + newLetterPosition);
                    }
                    char letterEncoded = alphabet[newLetterPosition];
                    decryptedMessage[i] = letterEncoded;

                }
            }
            string decodedString = String.Join("", decryptedMessage);
            return decodedString;
        }
    }
}
