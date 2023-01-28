using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private int width;
    private int height;

    // 2-D array 
    private int[,] gridArray;
    
    // constructor
    public Grid(int width, int height) {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];

        Debug.Log(width + " " + height);

        for (int x = 0; x < width; x++){
            for (int y = 0; y < height; y++){
                Debug.Log(x + ", " + y);
            }
        }
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
