using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Cell cellPrefab;
    [SerializeField] private Transform camera;
 
    private Dictionary<Vector2, Cell> cells;

    void Start() {
        GenerateGrid();
    }

    void GenerateGrid() {

        cells = new Dictionary<Vector2, Cell>();

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                var spawnedCell = Instantiate(cellPrefab, new Vector3(x, y), Quaternion.identity);
                spawnedCell.name = $"Cell {x} {y}";

                //spawnedCell.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);

                // is x even and y is not event or vice versa
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedCell.Init(isOffset);

                cells[new Vector2(x, y)] = spawnedCell;
            }
        }

        camera.transform.position = new Vector3((float)width/2 - 0.5f, (float)height/2 - 0.5f, -10);
    }

    public Cell getCellAtPosition(Vector2 position) {
        if(cells.TryGetValue(position, out var cell)) {
            return cell;
        }

        return null;
    }
}
