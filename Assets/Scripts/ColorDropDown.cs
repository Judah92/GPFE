using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerColor : MonoBehaviour
{
    public Material playerMaterial;
    private Dropdown ColorDropDown;

    void Start()
    {
        ColorDropDown = GetComponent<Dropdown>();
        ColorDropDown.onValueChanged.AddListener(delegate { ColorChange(ColorDropDown); });
    }

    void ColorChange(Dropdown change)
    {
        switch (change.value)
        {
            case 0: 
                playerMaterial.color = Color.green;
                break;
            case 1: 
                playerMaterial.color = Color.blue;
                break;
            case 2: 
                playerMaterial.color = Color.yellow;
                break;
        }
    }

}