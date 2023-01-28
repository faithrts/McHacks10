using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {
    private int width;
    private int height;
    private float gridCellSize;
    public GameObject cell;

    // 2-D array 
    private int[,] gridArray;
    
    // constructor
    public Grid(int width, int height, float gridCellSize) {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];

        Debug.Log(width + " " + height);

        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                // Debug.Log(x + ", " + y);

                Spawn(x, y);
            }
        }
    }

    private Vector3 GetCell(int x, int y) 
    {
        return new Vector3(x, y) * gridCellSize;
    }

    void Spawn(int x, int y)
    {
        Vector3 position = new Vector3(x, y, 0);
        //Instantiate(cell, position, Quaternion.identity);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
