using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSpawner : MonoBehaviour
{
    public GameObject blackBox;
    public GameObject panel;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnBox(Vector2 position)
    {
        GameObject blackbox = Instantiate(blackBox, position, Quaternion.identity);
        blackbox.transform.SetParent(panel.transform, false);
        gameManager.addBox(blackBox);
    }
}
