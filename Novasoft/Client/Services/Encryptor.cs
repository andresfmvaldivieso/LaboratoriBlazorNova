using System.Security.Cryptography;
using System.Text;

namespace Novasoft.Resources
{
    /// <summary>
    /// Clase que permite encriptar y desencriptar datos generalmente enviados a traves de una url
    /// Ej. QueryString
    /// </summary>
    public static class Encryptor
    {
        private const string strPermutation = "C@d3n@B@s3D@t0s";
        private const int bytePermutation1 = 0x19;
        private const int bytePermutation2 = 0x59;
        private const int bytePermutation3 = 0x17;
        private const int bytePermutation4 = 0x41;

        /// <summary>
        ///  Metodo que permite encriptar la string con informacion
        /// </summary>
        /// <param name="strText">string con el texto plano a encriptar</param>
        /// <returns>string encriptado</returns>
        public static string Encrypt(string strTexto)
        {
            const string PassPhrase = "@Sporiumn";        // can be any string
            const string SaltValue = "Re7urn5up";        // can be any string
            const int PasswordIterations = 100;                  // can be any number
            string initVector = String.Format("Proyec7{0}Nov@Web", Convert.ToString(DateTime.Today.Day).PadLeft(2, '0')); // must be 16 bytes
            const int KeySize = 256;

            // Convert strings into byte arrays.
            // Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(SaltValue);
            byte[] passPhraseBytes = Encoding.ASCII.GetBytes(PassPhrase);

            // Convert our plaintext into a byte array.
            // Let us assume that plaintext contains UTF8-encoded characters.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(strTexto);

            // First, we must create a password, from which the key will be derived.
            // This password will be generated from the specified passphrase and
            // salt value. The password will be created using the specified hash
            // algorithm. Password creation can be done in several iterations.
            using (Rfc2898DeriveBytes password = new Rfc2898DeriveBytes(passPhraseBytes, saltValueBytes, PasswordIterations, HashAlgorithmName.SHA256))
            {
                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(KeySize / 8);
                // Create uninitialized Rijndael encryption object.
                using (AesManaged symmetricKey = new AesManaged())
                {
                    // It is reasonable to set encryption mode to Cipher Block Chaining
                    // (CBC). Use default options for other symmetric key parameters.
                    symmetricKey.Mode = CipherMode.CBC;
                    // Generate encryptor from the existing key bytes and initialization
                    // vector. Key size will be defined based on the number of the key
                    // bytes.
                    ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                    // Define memory stream which will be used to hold encrypted data.
                    var memoryStream = new MemoryStream();
                    // Define cryptographic stream (always use Write mode for encryption).
                    var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                    // Start encrypting.
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    // Finish encrypting.
                    cryptoStream.FlushFinalBlock();
                    // Convert our encrypted data from a memory stream into a byte array.
                    byte[] cipherTextBytes = memoryStream.ToArray();
                    // Close both streams.
                    memoryStream.Close();
                    cryptoStream.Close();
                    // Convert encrypted data into a base64-encoded string.
                    string cipherText = Convert.ToBase64String(cipherTextBytes);
                    // Return encrypted string.
                    return cipherText;
                }
            }
        }

        /// <summary>
        /// Metodo utilizado para descencriptar el string recibido en el parametro strText
        /// </summary>
        /// <param name="strText">string encriptado</param>
        /// <returns>string que representa el texto original</returns>
        public static string Decrypt(string strText)
        {
            const string PassPhrase = "@Sporiumn";        // can be any string
            const string SaltValue = "Re7urn5up";        // can be any string
            const int PasswordIterations = 100;                  // can be any number
            string initVector = String.Format("Proyec7{0}Nov@Web", Convert.ToString(DateTime.Today.Day).PadLeft(2, '0')); // must be 16 bytes
            const int KeySize = 256;
            byte[] passPhraseBytes = Encoding.ASCII.GetBytes(PassPhrase);

            strText = strText.Replace(" ", "+");
            // Convert strings defining encryption key characteristics into byte
            // arrays. Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(SaltValue);

            // Convert our ciphertext into a byte array.
            byte[] cipherTextBytes = Convert.FromBase64String(strText);

            // First, we must create a password, from which the key will be
            // derived. This password will be generated from the specified
            // passphrase and salt value. The password will be created using
            // the specified hash algorithm. Password creation can be done in
            // several iterations.
            using (Rfc2898DeriveBytes password = new Rfc2898DeriveBytes(passPhraseBytes, saltValueBytes, PasswordIterations, HashAlgorithmName.SHA256))
            {
                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(KeySize / 8);
                // Create uninitialized Rijndael encryption object.
                using (AesManaged symmetricKey = new AesManaged())
                {
                    // It is reasonable to set encryption mode to Cipher Block Chaining
                    // (CBC). Use default options for other symmetric key parameters.
                    symmetricKey.Mode = CipherMode.CBC;
                    // Generate decryptor from the existing key bytes and initialization
                    // vector. Key size will be defined based on the number of the key
                    // bytes.
                    ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                    // Define memory stream which will be used to hold encrypted data.
                    var memoryStream = new MemoryStream(cipherTextBytes);
                    // Define cryptographic stream (always use Read mode for encryption).
                    var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                    // Since at this point we don't know what the size of decrypted data
                    // will be, allocate the buffer long enough to hold ciphertext;
                    // plaintext is never longer than ciphertext.
                    var plainTextBytes = new byte[cipherTextBytes.Length];
                    // Start decrypting.
                    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                    // Close both streams.
                    memoryStream.Close();
                    cryptoStream.Close();
                    // Convert decrypted data into a string.
                    // Let us assume that the original plaintext string was UTF8-encoded.
                    string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                    // Return decrypted string.
                    return plainText;
                }
            }
        }

        /// <summary>
        ///  Metodo que permite encriptar la string con informacion
        /// </summary>
        /// <param name="strText">string con el texto plano a encriptar</param>
        /// <returns>string encriptado</returns>
        public static string EncryptAct(string strTexto)
        {
            const string PassPhrase = "@Sporiumn";        // can be any string
            const string SaltValue = "Re7urn5up";        // can be any string
            const string HashAlgorithm = "SHA1";             // can be "MD5"
            const int PasswordIterations = 1;                  // can be any number
            string initVector = "Proyec701Nov@Web"; // must be 16 bytes
            const int KeySize = 128;

            // Convert strings into byte arrays.
            // Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(SaltValue);

            // Convert our plaintext into a byte array.
            // Let us assume that plaintext contains UTF8-encoded characters.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(strTexto);

            // First, we must create a password, from which the key will be derived.
            // This password will be generated from the specified passphrase and
            // salt value. The password will be created using the specified hash
            // algorithm. Password creation can be done in several iterations.
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(PassPhrase, saltValueBytes, HashAlgorithm, PasswordIterations))
            {
                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(KeySize / 8);
                // Create uninitialized Rijndael encryption object.
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    // It is reasonable to set encryption mode to Cipher Block Chaining
                    // (CBC). Use default options for other symmetric key parameters.
                    symmetricKey.Mode = CipherMode.CBC;
                    // Generate encryptor from the existing key bytes and initialization
                    // vector. Key size will be defined based on the number of the key
                    // bytes.
                    ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                    // Define memory stream which will be used to hold encrypted data.
                    var memoryStream = new MemoryStream();
                    // Define cryptographic stream (always use Write mode for encryption).
                    var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                    // Start encrypting.
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    // Finish encrypting.
                    cryptoStream.FlushFinalBlock();
                    // Convert our encrypted data from a memory stream into a byte array.
                    byte[] cipherTextBytes = memoryStream.ToArray();
                    // Close both streams.
                    memoryStream.Close();
                    cryptoStream.Close();
                    // Convert encrypted data into a base64-encoded string.
                    string cipherText = Convert.ToBase64String(cipherTextBytes);
                    // Return encrypted string.
                    return cipherText;
                }
            }
        }

        /// <summary>
        /// Metodo utilizado para descencriptar el string recibido en el parametro strText
        /// </summary>
        /// <param name="strText">string encriptado</param>
        /// <returns>string que representa el texto original</returns>
        public static string DecryptAct(string strText)
        {
            const string PassPhrase = "@Sporiumn";        // can be any string
            const string SaltValue = "Re7urn5up";        // can be any string
            const string HashAlgorithm = "SHA1";             // can be "MD5"
            const int PasswordIterations = 1;                  // can be any number
            string initVector = "Proyec701Nov@Web"; // must be 16 bytes
            const int KeySize = 128;

            strText = strText.Replace(" ", "+");
            // Convert strings defining encryption key characteristics into byte
            // arrays. Let us assume that strings only contain ASCII codes.
            // If strings include Unicode characters, use Unicode, UTF7, or UTF8
            // encoding.
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(SaltValue);

            // Convert our ciphertext into a byte array.
            byte[] cipherTextBytes = Convert.FromBase64String(strText);

            // First, we must create a password, from which the key will be
            // derived. This password will be generated from the specified
            // passphrase and salt value. The password will be created using
            // the specified hash algorithm. Password creation can be done in
            // several iterations.
            using (PasswordDeriveBytes password = new PasswordDeriveBytes(PassPhrase, saltValueBytes, HashAlgorithm, PasswordIterations))
            {
                // Use the password to generate pseudo-random bytes for the encryption
                // key. Specify the size of the key in bytes (instead of bits).
                byte[] keyBytes = password.GetBytes(KeySize / 8);
                // Create uninitialized Rijndael encryption object.
                using (RijndaelManaged symmetricKey = new RijndaelManaged())
                {
                    // It is reasonable to set encryption mode to Cipher Block Chaining
                    // (CBC). Use default options for other symmetric key parameters.
                    symmetricKey.Mode = CipherMode.CBC;
                    // Generate decryptor from the existing key bytes and initialization
                    // vector. Key size will be defined based on the number of the key
                    // bytes.
                    ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                    // Define memory stream which will be used to hold encrypted data.
                    var memoryStream = new MemoryStream(cipherTextBytes);
                    // Define cryptographic stream (always use Read mode for encryption).
                    var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                    // Since at this point we don't know what the size of decrypted data
                    // will be, allocate the buffer long enough to hold ciphertext;
                    // plaintext is never longer than ciphertext.
                    var plainTextBytes = new byte[cipherTextBytes.Length];
                    // Start decrypting.
                    int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                    // Close both streams.
                    memoryStream.Close();
                    cryptoStream.Close();
                    // Convert decrypted data into a string.
                    // Let us assume that the original plaintext string was UTF8-encoded.
                    string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                    // Return decrypted string.
                    return plainText;
                }
            }
        }

       
    }
}