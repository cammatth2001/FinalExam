using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{

    public static float currentSpeed;

    public Text speedText;


    public void Start()
    {
        speedText.text = currentSpeed.ToString();
    }

    public void Update()
    {
        speedText.text = currentSpeed.ToString();
    }
}
