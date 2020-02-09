﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameBlack : MonoBehaviour
{
    public LevelManager levelManager;
    public Image img; 
    public AnimationCurve curve; 
    float t;

    public bool Faded;

    private void Awake()
    {
        StartCoroutine(FadeIn());
        img.gameObject.SetActive(true);
    }

    IEnumerator FadeIn()
    {
        float t = 1f;

        while (t > 0f)
        {
            t -= 0.005f * 1.5f;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }
        if (t <= 0)
        {
            img.gameObject.SetActive(false);
            img.color = new Color(0, 0, 0, 100);
        }
    }

    IEnumerator FadeOut() //Одновременно загружает следущий уровень
    {
        float t = 0f;
        img.color = new Color(0, 0, 0, 0);
        while (t < 1f)
        {
            t += 0.005f * 1.5f;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }
        if (t >= 1)
        {
            levelManager.LoadNextLevel();
        }
    }

    public void ActiveFading()
    {
        img.gameObject.SetActive(true);
        StartCoroutine(FadeOut());
    }
}
