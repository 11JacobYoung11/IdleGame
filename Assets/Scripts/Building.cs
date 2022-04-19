using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Building", menuName = "Building")]
public class Building : ScriptableObject
{
    public string Name;
    public int Level;
    public string resourcetype;
    public double resourcequantity;


    public Sprite buildingsprite;

    public List<Resource> Resources;


    public double ResourcePerSecond(int level)
    {

        double rsp = level * 1;

        return rsp;
    }
}
