using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    
    static public int timeLeft;
    public Text countdown;
   
    void Start()
    {
        
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }
    void Update()
    {
        countdown.text = ("" + timeLeft);

    }
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft < 0)
            {
                
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(3);
                break;
            }
        }
    }
   
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);

    }

}
