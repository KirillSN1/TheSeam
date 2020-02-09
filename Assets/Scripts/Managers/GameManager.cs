using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(LevelManager))]

public class GameManager : MonoBehaviour
{
    public int currentCount;

    public static GameManager Gm;

    void Awake()
    {
        Gm = GetComponent<GameManager>();
    }

    void Update()
    {

    }

    public void Collect(int value)
    {
        currentCount = + value;
    }


}

