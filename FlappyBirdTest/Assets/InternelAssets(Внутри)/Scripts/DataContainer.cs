using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataContainer : MonoBehaviour
{
    /// <summary>
    /// трубы
    /// </summary>
    public GameObject pipe;
    /// <summary>
    /// птица
    /// </summary>
    public GameObject bird;
    [Space]
    public int coins;
    public float powerJump;
    public float pipeSpeed;
    public float timeSpawnPipe = 4;
    public Text scoreText;


}
