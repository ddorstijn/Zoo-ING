using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField]
    protected GameObject balloon;
    [SerializeField]
    protected Text text;
    protected string message;
    public string Name;

    public void SayHello()
    {
        balloon.SetActive(true);
        text.text = message;
    }
}
