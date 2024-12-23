using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("# Game Control")]
    public bool isLive;
    public float gameTime;
    public float maxGameTime = 2 * 10f;

    [Header("# Player Info")]
    public float health;
    public float maxHealth = 100;
    public int level;
    public int kill;
    public int exp;
    public int[] nextExp = { 3, 30, 60, 100, 150, 210, 280, 360, 450, 600 };

    [Header("# Game Object")]
    public MonsterSpawn pool;
    public PlayerController player;
    public GameObject uiResult;

    void Awake()
    {
        instance = this;
    }

    public void GameStart()
    {
        health = maxHealth;
        isLive = true;
    }

    public void GameOver()
    {
        StartCoroutine(GameOverRoutine());
    }

    IEnumerator GameOverRoutine()
    {
        isLive = false;
        yield return new WaitForSeconds(0.5f);
        uiResult.SetActive(true);
        Stop();
    }

    private void Update()
    {
        gameTime += Time.deltaTime;

        if (gameTime > maxGameTime) {
            gameTime = maxGameTime;
        }
    }

    public void GetExp()
    {
        exp++;
        if (exp == nextExp[level]) {
            level++;
            exp = 0;
        }
    }

    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0;
    }
    
    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1;
    }
}
