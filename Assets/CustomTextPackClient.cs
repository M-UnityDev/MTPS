using UnityEngine;

public class CustomTextPackClient : MonoBehaviour, ITextPackCustomClient
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
}
