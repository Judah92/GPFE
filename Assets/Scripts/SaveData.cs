using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveData : MonoBehaviour
{
    public static string PlayerName;
    public InputField NameInputField;
  

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update() 
    {
    }
    public void UpdateName() 
    {
        PlayerName = NameInputField.text; 

    }


 

 
 



}
