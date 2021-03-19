using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    GameObject Player;
    Animator anim;

    bool isAlive = true;

    public int score; 

    private SpriteRenderer sr;
    private CircleCollider2D circle;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
        circle = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Player != null && isAlive)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
            
        }

        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            anim.SetTrigger("Dead");
            isAlive = false;
            Destroy(gameObject, 0.1f);
            sr.enabled = false;

            GameController.instance.totalScore += score;
            GameController.instance.UpDateScoreText();
            circle.enabled = false;

            Destroy(gameObject, 0.1f);
        }

        
    }



    
}
