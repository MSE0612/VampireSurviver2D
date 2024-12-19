using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public MonsterSpawn pool;
    public PlayerController player;

    void Awake()
    {
        instance = this;
    }
}