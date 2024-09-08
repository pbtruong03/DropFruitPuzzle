using System;
using UnityEngine;

[Serializable]
public class FruitData
{
    [HideInInspector] public string fruitName;
    public FruitType type;

    public Sprite sprite;
    public float radiusSize;
    public float point;
}


public enum FruitType
{
    cherry = 0,
    strawberry = 1,
    lemon = 2,
    grape = 3,
    apple = 4,
    orange = 5,
    mango = 6,
    dragonFruit = 7,
    pineApple = 8,
    coconus = 9,
    waterMelon = 10
}