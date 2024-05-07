using UnityEngine;
using UnityEngine.UI;  

public class SliderSize : MonoBehaviour
{
    public Transform Player;  

   
    public void AdjustSize(float size)
    {
        Player.localScale = new Vector3(size, size, size);
        
    }
}