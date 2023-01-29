using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{

    [SerializeField] private FurnitureItem furnitureItem;
    public static Dictionary<string, List<FurnitureItem>> furnitureItems;

    // Start is called before the first frame update
    void Start()
    {   
        // list of beds
        List<FurnitureItem> bedList = new List<FurnitureItem>(); 

        // list of seatings
        List<FurnitureItem> seatingList = new List<FurnitureItem>(); 

        // list of tables
        List<FurnitureItem> tableList = new List<FurnitureItem>(); 

        furnitureItems = new Dictionary<string, List<FurnitureItem>>();
        furnitureItems["beds"] = bedList;
        furnitureItems["seatings"] = seatingList;
        furnitureItems["tables"] = tableList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
