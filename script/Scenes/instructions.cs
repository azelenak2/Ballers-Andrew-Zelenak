using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instructions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartPressed()
    {
        SceneManager.LoadScene("Instructions");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
