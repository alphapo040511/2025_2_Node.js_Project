using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameVIew gameView;
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = gameView.AddComponent<GameController>();
        gameController.gameView = gameView;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
