using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingDisplay : MonoBehaviour
{
    public Building building;
    public Text nameText;
    public Image artwork;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = building.name;
        artwork.sprite = building.buildingsprite;
    }

}
