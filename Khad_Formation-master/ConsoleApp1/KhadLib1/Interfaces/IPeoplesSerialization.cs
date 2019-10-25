using KhadLib1.Classes;

namespace KhadLib1.Interfaces
{
    public interface IPeoplesSerialization
    {
        string[] Serialize(People[] peoples);

        People[] Deserialize(string[] encryptedString);
    }
}
