using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public PanelSpawner panel;
    private int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        int jumlahSpawn = Random.Range(7, 10);
        for(var i=0; i < jumlahSpawn; i++)
        {
            Vector2 position = new Vector2(Random.Range(600f, -600f), Random.Range(-300f, 300f));
            panel.spawnBox(position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addScore()
    {
        score += 1;
        scoreText.text = ": " + score.ToString();
    }
}
