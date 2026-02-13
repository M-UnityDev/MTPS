using UnityEngine;

public class CustomTextPackClient : MonoBehaviour, ITextPackClient
{
    [SerializeField]
    private string Key1;

    [SerializeField]
    private string Key2;

    public string[] GetKeys()
    {
        string[] strings = { Key1, Key2 };
        return strings;
    }

    public void TextPackUpdate()
    {
        print(Key1);
    }
}
