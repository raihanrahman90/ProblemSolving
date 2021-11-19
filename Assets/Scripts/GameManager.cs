using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public PanelSpawner panel;
    private int score;
    public Text scoreText;
    private int jumlahBox;
    private float jumlahBoxNow;
    private float _collectSecond;
    private List<GameObject> listBox;
    // Start is called before the first frame update
    void Start()
    {
        listBox = new List<GameObject>();
        _collectSecond = 0;
        int jumlahSpawn = Random.Range(7, 10);
        jumlahBox = jumlahSpawn;
        jumlahBoxNow = jumlahSpawn;
        for(var i=0; i < jumlahSpawn; i++)
        {
            Vector2 position = new Vector2(Random.Range(600f, -600f), Random.Range(-300f, 300f));
            panel.spawnBox(position);
        }
    }
    public void addBox(GameObject box)
    {

        listBox.Add(box);
    }
    // Update is called once per frame
    void Update()
    {

        if (jumlahBoxNow < jumlahBox)
        {
            _collectSecond += Time.unscaledDeltaTime;
            scoreText.text = ": " + _collectSecond.ToString();

            if (_collectSecond >= 3f)
            {
                Vector2 position = new Vector2(Random.Range(600f, -600f), Random.Range(-300f, 300f));
                panel.spawnBox(position);
                jumlahBoxNow += 1;
                _collectSecond = 0;
            }
        }

    }
    public void addScore(GameObject box)
    {
        score += 1;

        scoreText.text = ": " + score.ToString();
        jumlahBoxNow -= 1;
    }
}
