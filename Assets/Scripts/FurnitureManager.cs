using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{

    [SerializeField] private FurnitureItem furnitureItem;
    public static Dictionary<string, FurnitureItem> furnitureItems;

    // Start is called before the first frame update
    void Start()
    {   
        furnitureItems = new Dictionary<string, FurnitureItem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
