using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTranslate : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    public string ID;

    private void Start()
    {
        textUI.text = LocalizationManager.Instance.GetTranslate(ID);
    }

}
