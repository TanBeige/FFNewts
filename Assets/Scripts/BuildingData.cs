using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Building", menuName = "Building")]

public class BuildingData : ScriptableObject
{
    public string bName;
    public int health;
    public int numWindows;
    public int numFires; 
}
