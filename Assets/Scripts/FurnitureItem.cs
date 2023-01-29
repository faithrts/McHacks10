using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureItem : MonoBehaviour
{

    [SerializeField] private FurnitureItem furnitureItem;
    public static Dictionary<string, FurnitureItem> furnitureItems;

    public void GenerateFurniture()
    {   
        var spawnedItem = Instantiate(furnitureItem, new Vector3(0, 0), Quaternion.identity);
        spawnedItem.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
