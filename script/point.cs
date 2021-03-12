using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public static Transform[] pnts;

    void Awake()
    {
        pnts = new Transform[transform.childCount];
        for(int i = 0; i < pnts.Length; i++ )
        {
            pnts[i] = transform.transform.GetChild(i);
        }
    }
}
