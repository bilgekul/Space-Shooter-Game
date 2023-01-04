using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExpln;
    public GameController game;


    void Start()
    {
        game = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }

    void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if(other.tag == "Player")
        {
            Instantiate(playerExpln, other.transform.position, other.transform.rotation);
            game.GameOver();
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
        game.UptadeText();
    }
}
