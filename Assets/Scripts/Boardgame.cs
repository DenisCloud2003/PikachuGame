using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boardgame : MonoBehaviour
{
    public int rows, cols;
    private int[,] matrix;

    public GameObject prefabItem;

    public List<int> listOfItems;

    public Sprite[] sprites;

    void Start()
    {
        CreateData();

        InitGrid();
    }

    private void CreateData()
    {
        listOfItems = new List<int>();
        int numberofitems = (rows - 2) * (cols - 2);
        int pair = numberofitems / 2;
        int numberoficon = 14;

        for (int i = 0; i < pair; i++)
        {
            int ran = UnityEngine.Random.Range(0, numberoficon);
            listOfItems.Add(ran);
            listOfItems.Add(ran);
        }

        Shuffle();
    }

    private void InitGrid()
    {
        matrix = new int[rows, cols];

        for (int i =0; i < rows; i++)
        {
            for (int j =0; j < cols; j++)
            {
                if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    matrix[i, j] = 1;

                    Vector3 vec = new Vector3((i + 1 - rows + rows / 2) * 100 - 50, (j + 1 - cols + cols / 2) * 100 - 50, 0);
                    
                    GameObject obj = Instantiate(prefabItem, vec, Quaternion.identity);
                    obj.transform.SetParent(this.transform, false);
                }
            }
        }
    }

    private void Shuffle()
    {

    }
}
