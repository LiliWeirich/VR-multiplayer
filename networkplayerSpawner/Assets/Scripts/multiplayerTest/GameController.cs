//Lili Weirich - last edited: 28.07.2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
}
