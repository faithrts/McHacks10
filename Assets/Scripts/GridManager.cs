using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Cell cellPrefab;
    [SerializeField] private Transform camera;
 
    static private Dictionary<Vector2, Cell> cells;
    public static Dictionary<Vector2, Cell> chosenCells;

    void Start() {
        GenerateGrid();
        chosenCells = new Dictionary<Vector2, Cell>();
    }

    void GenerateGrid() {

        cells = new Dictionary<Vector2, Cell>();

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {

                float new_x = (float) (x - 8.55);
                float new_y = (float) (y - 3.96);

                var spawnedCell = Instantiate(cellPrefab, new Vector3(new_x, new_y), Quaternion.identity);
                spawnedCell.name = $"Cell {x} {y}";

                //spawnedCell.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

                // is x even and y is not event or vice versa
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedCell.Init(isOffset, new Vector2(x, y));

                cells[new Vector2(x, y)] = spawnedCell;
            }
        }

        //camera.transform.position = new Vector3((float)width/2 - 0.5f, (float)height/2 - 0.5f, -10);
    }

    static public Cell getCellAtPosition(Vector2 position) {
        if(cells.TryGetValue(position, out var cell)) {
            return cell;
        }

        return null;
    }

    static public GameObject[] findCells() {
        GameObject[] cells = GameObject.FindGameObjectsWithTag("Cell");
        return cells;
    }
}
