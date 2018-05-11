using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Global : MonoBehaviour {

    public TextMesh score;
    public TextMesh lives;
    public TextMesh gameOverText;
    public static int currentscore = 0;
    public static int currentlives = 5;
    bool gameOver;
    GameObject[] moles = new GameObject[4];

    // Use this for initialization
    void Start () {
        gameOver = false;
        currentscore = 0;
        currentlives = 5;
        score = GameObject.Find("Puntuacion").GetComponent<TextMesh>();
        lives = GameObject.Find("Vidas").GetComponent<TextMesh>();
        gameOverText = GameObject.Find("GameOver").GetComponent<TextMesh>();
        score.fontSize = 14;
        gameOverText.text = "";
        score.text = currentscore.ToString();
        lives.text = "❤❤❤❤❤";
        moles[0] = GameObject.Find("resetti_model");
        moles[1] = GameObject.Find("resetti_model (1)");
        moles[2] = GameObject.Find("resetti_model (2)");
        moles[3] = GameObject.Find("resetti_model (3)");
    }
	
	// Update is called once per frame
	void Update () {
        if(gameOver && Input.anyKeyDown)
        {
            gameOver = false;
            gameOverText.text = "";
            currentscore = 0;
            currentlives = 5;
            //score.alignment = TextAnchor.UpperRight;
            score.text = currentscore.ToString();
            lives.text = "❤❤❤❤❤";
            moles[0].SetActive(true);
            moles[1].SetActive(true);
            moles[2].SetActive(true);
            moles[3].SetActive(true);
        }
    }

    public void IncreaseScore(int increase)
    {
        currentscore++;
        score.text = currentscore.ToString();
    }

    public void DecreaseLive(int decrease)
    {
        if(currentlives == 1)
        {
            gameOverText.text = "Game Over \nPoints: \nTap to restart";
            lives.text = "";
            //score.alignment = TextAnchor.MiddleCenter;
            moles[0].SetActive(false);
            moles[1].SetActive(false);
            moles[2].SetActive(false);
            moles[3].SetActive(false);
            gameOver = true;
        } else {
            currentlives--;
            lives.text = new String('❤', currentlives) + new String('♡', 5-currentlives);
        }
    }
}
