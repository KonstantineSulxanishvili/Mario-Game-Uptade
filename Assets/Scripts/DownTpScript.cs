using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTpScript : MonoBehaviour
{   public float distance;

    public void ButtonPress()
    {
        transform.position=new Vector2(transform.position.x,transform.position.y+distance); 
    }
}
