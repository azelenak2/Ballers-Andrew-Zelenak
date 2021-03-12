using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchingPoint: MonoBehaviour
{
    public GameObject turret; 
    public Color hovercolor;
    public Vector3 offset;
    private Renderer rend;
    Builderscript builderscript;

    private Color StartColor;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartColor = rend.material.color;
        builderscript = Builderscript.inception;
    }
     void OnMouseDown()
    {
        if (!builderscript.Build)
            return;
        if (turret != null)
        {
            return;
        }

        builderscript.Buildaturrets(this);
    }

        
    public Vector3 buildersPos ()
    {
        return transform.position + offset;
    }
    void OnMouseEnter()
    {
        if (!builderscript. Build)
            return;
        rend.material.color = hovercolor;
    }

    void OnMouseExit()
    {
        rend.material.color = StartColor; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
