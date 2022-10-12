using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectClickController : MonoBehaviour
{
    public TextMeshProUGUI cubeCountText;
    public int CubeCount;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        CubeCount++;
        _animator.SetTrigger("CubeIncreased");
        _animator.SetInteger("CubeCount", CubeCount % 10);
        cubeCountText.text = CubeCount.ToString(); 
        Debug.Log(CubeCount);
    }
}
