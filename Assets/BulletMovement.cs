using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    public float bulletSpeed;
    int score;

    // Start is called before the first frame update
    /* void Start()
     {

     } */

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletSpeed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        /*score = score++;
        print("The score is" + score);
        Destroy(collision.gameObject);
        if (score==10)
        {
            print("You have won the Game");
        } */
    }
}
