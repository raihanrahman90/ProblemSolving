using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public PanelSpawner panel;
    // Start is called before the first frame update
    void Start()
    {
        int jumlahSpawn = Random.Range(1, 10);
        for(var i=0; i < jumlahSpawn; i++)
        {
            Vector2 position = new Vector2(Random.Range(600f, -600f), Random.Range(-400f, 400f));
            panel.spawnBox(position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
