using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName  = "ScriptableObjects/BuildingType")]
public class BuildingTypeSO : ScriptableObject
{
    public string nameString;
    public Transform prefab;
    public bool hasResourceGeneratorData;
    public ResourceGeneratorData resourceGeneratorData;
    public Sprite sprite;
    public float minConstructionRadius;
    public ResourceAmount[] constructionResourceCostArray;
    public int healthAmountMax;
    public float constructionTimerMax;

    public string GetConstructionResourceCostString()
    {
        string tmp = "";
        foreach (ResourceAmount resourceAmount in constructionResourceCostArray)
        {
            tmp += $"<color=#{resourceAmount.resourceType.colorHex}>{resourceAmount.resourceType.nameShort}{resourceAmount.amount}</color> ";
        }

        return tmp;
    }
}
