using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParalaxController : MonoBehaviour
{
    [SerializeField]
    Vector2 speed = Vector2.zero;

    Material _material;

    void Awake()
    {
        _material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        Vector2 offset = speed * Time.deltaTime;
        _material.mainTextureOffset += offset;
    }
}
