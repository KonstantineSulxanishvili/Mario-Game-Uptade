using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovmentScript : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
        {transform.Translate(Vector2.left * speed);}
    
}
