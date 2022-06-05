using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTeleport : MonoBehaviour
{
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        if (name == "RightWall")
    //        {
    //            collision.gameObject.transform.position = new Vector3(-3.19f, collision.gameObject.transform.position.y, 0f);
    //        }
    //        if (name == "LeftWall")
    //        {
    //            collision.gameObject.transform.position = new Vector3(3.19f, collision.gameObject.transform.position.y, 0f);
    //        }
    //    }
    //}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Character")
        {
            if (name == "RightWall")
            {
                collision.gameObject.transform.position = new Vector3(-3.19f, collision.gameObject.transform.position.y, 0f);
            }
            if (name == "LeftWall")
            {
                collision.gameObject.transform.position = new Vector3(3.19f, collision.gameObject.transform.position.y, 0f);
            }
        }
    }
}
