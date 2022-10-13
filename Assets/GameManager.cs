using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public int CubeCount = 0;
    
    public TextMeshProUGUI cubeCountText;
    public TextMeshProUGUI cubeProducerAmountText;

    public int CubeProducerAmount = 0;
    private int CubeProducerPrice = 15;
    
    private float passedProduceTime = 0;

    public void IncreaseCubeCount(int increaseAmount)
    {
        CubeCount += increaseAmount;
        cubeCountText.text = CubeCount.ToString();
    }

    public void IncreaseBasicCubeProducer()
    {
        if (CubeCount >= CubeProducerPrice)
        {
            SetBasicCubeProducerAmount(CubeProducerAmount + 1);
            IncreaseCubeCount(-CubeProducerPrice);
        }
    }

    private void Update()
    {
        passedProduceTime += Time.deltaTime;
        
        if (passedProduceTime > 5)
        {
            passedProduceTime = 0;
            IncreaseCubeCount(CubeProducerAmount);
        }
    }

    public void SetBasicCubeProducerAmount(int amount)
    {
        CubeProducerAmount = amount;
        cubeProducerAmountText.text = "Producer Count: " + CubeProducerAmount;
    }
}
