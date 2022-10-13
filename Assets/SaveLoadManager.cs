using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    public GameManager _gameManager;

    private void Start()
    {
        LoadData();
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("CubeCount", _gameManager.CubeCount);
        PlayerPrefs.SetInt("ProducerAmount", _gameManager.CubeProducerAmount);
    }

    public void LoadData()
    {
        _gameManager.CubeCount = 0;
        _gameManager.IncreaseCubeCount(PlayerPrefs.GetInt("CubeCount", 0));
        
        _gameManager.SetBasicCubeProducerAmount(PlayerPrefs.GetInt("ProducerAmount", 0));
    }
}
