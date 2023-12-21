using UnityEngine;
using TMPro;

public class Showpassword : MonoBehaviour
{
    private TMP_InputField inputField;
    private void Awake()
    {
        inputField = GetComponent<TMP_InputField>();
    }

    public void ShowHide()
    {
        inputField.contentType = (inputField.contentType == TMP_InputField.ContentType.Standard) ? TMP_InputField.ContentType.Password : TMP_InputField.ContentType.Standard;
        inputField.ForceLabelUpdate();
    }
}
