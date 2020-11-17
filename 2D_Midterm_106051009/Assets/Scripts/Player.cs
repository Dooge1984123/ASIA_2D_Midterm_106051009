using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
    public GameObject final;

    public Text textcount;
    public int count;
    private  void   OnTriggerEnter2D(Collider2D collision)
    { if (collision.name == "Particle System")
        {
         
            final.SetActive(true);
        }
        if (collision.tag == "蘋果")
        {
           Destroy(collision.gameObject);
            count ++ ;
        }
    }

}
