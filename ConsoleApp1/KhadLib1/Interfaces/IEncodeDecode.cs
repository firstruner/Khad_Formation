namespace KhadLib1.Interfaces
{
     interface IEncodeDecode
    {
        string Encrypt(string source);
        
        string Decrypt(string source);
    }
}
