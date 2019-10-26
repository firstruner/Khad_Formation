namespace KhadLib1.Interfaces
{
    public interface IEncodeDecode
    {
        string Encrypt(string source, string rsaPublicKey);

        string Decrypt(string source, string rsaPrivateKey);
    }
}
