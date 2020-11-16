using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject final;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(true)
        print("碰到傳送們");
        final.SetActive(true);
    }

}
