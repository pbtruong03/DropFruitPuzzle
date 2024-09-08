using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SOFruit : ScriptableObject
{
    [Header("List Fruit Data")]
    public List<FruitData> fruitsData = new List<FruitData>();

    private void Reset()
    {
        fruitsData.Clear();

        foreach (FruitType type in Enum.GetValues(typeof(FruitType)))
        {
            FruitData fruitData = new FruitData
            {
                fruitName = type.ToString(),
                type = type
            };

            fruitsData.Add(fruitData);
        }
    }
}
