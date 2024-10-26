using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text scoreText;
    //public Text scoreText;
    private int score;

    private Image[] life;

    private Blade blade;
    private Spawner spawner;

    private void Awake()
    {
        blade = FindObjectOfType<Blade>();
        spawner = FindObjectOfType<Spawner>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = score.ToString();
    }

    public void DecreaseLife()
    {
        
    }

    public void Explode()
    {
        blade.enabled = false;
        spawner.enabled = false;
    }
}
