using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dacashui : MonoBehaviour
{
    public Text cash;

     void Update()
    {
        cash.text = cashmoney.dacash.ToString();
    }
}
