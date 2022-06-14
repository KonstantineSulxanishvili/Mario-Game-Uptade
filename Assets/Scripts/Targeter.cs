using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Targeter : MonoBehaviour
{
   private string myfirststring;
    // public float distance2;
    // public float distance;
    // AudioSource Jumpsound;
    // // private Rigidbody2D rigidbody;
    // // private float speed = 4;
    // // public float jump;

    // // void Start()
    // // {
    // //  Jumpsound=GetComponent<AudioSource>();
    // //  rigidbody = GetComponent<Rigidbody2D>();
    // // }

    // void FixedUpdate()
    // {
    //     if(Input.GetKeyDown(KeyCode.W))
    //     {
    // //      rigidbody.AddForce(Vector2.up * jump);
    //      Jumpsound.Play();
    //     }
    // //     if(Input.GetKey(KeyCode.D))
    // //     {
    // //      rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
    // //     }
    // //     else if(Input.GetKey(KeyCode.A))
    // //     {
    // //      rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
    // //     }
    // //     else
    // //     {
    // //      rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
    // //     }
        
    void OnTriggerEnter2D(Collider2D col)
    {   
        if(col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "Killer Flower")
        {
            SceneManager.LoadScene("Died screen");
        }
        if(col.gameObject.tag == "Void")
        {
            SceneManager.LoadScene("Died screen");
        }
        if(col.gameObject.tag == "Lucky Block")
        {
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag == "MooshromEnemy")
        {
        SceneManager.LoadScene("Died screen");
        }
        if(col.gameObject.tag == "EndWin")
        {
            SceneManager.LoadScene("Level 2");
        }
         if(col.gameObject.tag == "End Win 2")
        {
            SceneManager.LoadScene("Level 2 up part");
        }
        if(col.gameObject.tag == "You Win")
        {
          SceneManager.LoadScene("WinScane");
        }
        // if(col.gameObject.tag == "EndWin")
        // {
        // print("Next Level");
        // transform.position=new Vector2(transform.position.x,transform.position.y+distance);                 
        // }
        // if(col.gameObject.tag == "End Win 2")
        // {
        //     transform.position=new Vector2(transform.position.x,transform.position.y+distance2);
        //     myfirststring="World 1-2";
        // }
    }   
}