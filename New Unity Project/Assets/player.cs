using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{


   



    private Rigidbody2D playerRb;
    private SpriteRenderer playerSprite;
    public float velocidade;
    public bool flipX;

   





    // Start is called before the first frame update
    void Start()
    {

        

            playerRb = GetComponent<Rigidbody2D>();
            playerSprite = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            velocidade = velocidade * -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }

        playerRb.velocity = new Vector2(velocidade, playerRb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "espinho") {

           
            SceneManager.LoadScene("GameOver");
          



        }
          

    }



void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.tag == "espinho") {
            
        SceneManager.LoadScene("GameOver");
           

        }
}
   






}








