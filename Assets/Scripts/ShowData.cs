using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text NameText;

    public void Awake()
    {
        NameText.text = SaveData.PlayerName;
    }
}
