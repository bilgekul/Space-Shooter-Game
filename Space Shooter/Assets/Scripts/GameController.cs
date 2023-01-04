using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public int spawnCount;
    public float spawnWait;
    public float startSpawn;
    public float waveWait;
    public Text scoreText;
    public int score;
    public Text levelText;
    public int level;
    public Text gameOver;
    public Text restart;

    private bool gameOverb;
    private bool restarting;

    void Update()
    {
        if(restarting== true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    IEnumerator SpawnValues()
    {
        yield return new WaitForSeconds(startSpawn);
        while (true)
        {
             
             for(int i = 0; i < spawnCount; i++)
            {
                 Vector3 spawnPosition = new Vector3(Random.Range(-3,3),0,10);
                 Quaternion spawnRotation =  Quaternion.identity;

                 Instantiate(hazard, spawnPosition, spawnRotation);
                 yield return new WaitForSeconds(spawnWait);              
            }
            spawnCount = spawnCount + 5;
            yield return new WaitForSeconds(waveWait);
            level = level + 1;
            levelText.text = "Level:" + level;
            if(gameOverb == true)
            {
                restart.text = "Press 'R' to restarting";
                restarting= true;
                break;
            }
            

        }
     
        
    }
    public void GameOver()
    {
        gameOver.text = "Game Over";
        gameOverb= true;
    }
   
    public void UptadeText()
    {
        score += 10;
        scoreText.text = "Score:" + score;
       
    }
    void Start()
    {
        StartCoroutine(SpawnValues());
        gameOver.text = "";
        restart.text = "";
        gameOverb = false;
        restarting = false;





    }




}
