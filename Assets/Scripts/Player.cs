using System.Collections;

using System.Collections.Generic;

public class Player
{
    public string Name;
    public List<Building> Buildings;
    public List<Resource> Resources;


    public Player()
    {
        
    }

    public void AddBuilding(Building building)
    {
        Buildings.Add(building);
    }
    public void AddResource(Resource resource)
    {
        Resources.Add(resource);
    }
}
