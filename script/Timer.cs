using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text time;
    private int secs;
    private int min;
    private int hour;
    public float timeLeft;
    public Text startText;

    // Start is called before the first frame update


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }

    public void UpdateTimerUI()
    {


    }
}
