using UnityEngine;
using TMPro;

public class DetectPassword : MonoBehaviour
{
    [SerializeField] private string password;
    private TMP_InputField inputField;

    private void Awake()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void Detect()
    {
        if(inputField.text == password)
        {
            Debug.Log("RIGHT PASSWORD!");
        }
        else
        {
            Debug.Log("WRONG PASSWORD!");
        }
    }
}
