using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Building goldmine;
    public Building lumberyard;
    public Building quarry;

    public Text goldText;
    public Text lumberText;
    public Text stoneText;

    private bool hassaw;
    private float timer;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            ResourcesPerSecond();
            timer -= 1f;
        }

        goldText.text = goldmine.resourcetype + ": " + goldmine.resourcequantity;
        lumberText.text = lumberyard.resourcetype + ": " + lumberyard.resourcequantity;
        stoneText.text = quarry.resourcetype + ": " + quarry.resourcequantity;
    }

    public void OnGoldMineClick()
    {
        goldmine.resourcequantity += 1;
    }
    public void OnLumberYardClick()
    {
        lumberyard.resourcequantity += 1;
    }
    public void OnQuarryClick()
    {
        quarry.resourcequantity += 1;
    }


    private void ResourcesPerSecond()
    {
        quarry.resourcequantity += GetAmountOfResourcesPerSecond(50, hassaw);
        lumberyard.resourcequantity += 1;
        goldmine.resourcequantity += 1;
    }

    private double GetAmountOfResourcesPerSecond(int Level, bool hassaw)
    {
        double persecond;
        if (hassaw)
        {
            persecond = 100;
        }
        else
        {
            persecond = Level * 0.5;
        }
        return persecond;
    }

    
    private void purchasesaw()
    {
        hassaw = true;
    }


}

