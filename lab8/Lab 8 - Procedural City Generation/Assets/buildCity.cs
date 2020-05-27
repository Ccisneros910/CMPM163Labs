using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 30;
    public int mapHeight = 30;
    int buildingFootprint = 3;
    int bldg1, bldg2, bldg3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        float seed = Random.Range(0, 100);
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                int result = (int)(Mathf.PerlinNoise(w/15.0f, h/15.0f) * 13);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h *buildingFootprint);
                if (result < 1)
                    Instantiate(buildings[0], pos, Quaternion.identity);
                else if (result < 2)
                    Instantiate(buildings[1], pos, Quaternion.identity);
                else if (result < 5)
                    Instantiate(buildings[2], pos, Quaternion.identity);
                else if (result < 6)
                    Instantiate(buildings[3], pos, Quaternion.identity);
                else if (result < 7)
                { 
                    if(bldg1%30 == 0)
                        Instantiate(buildings[4], pos, Quaternion.identity);
                    else
                        Instantiate(buildings[7], pos, Quaternion.identity);
                    bldg1++;
                }
                else if (result < 8)
                {
                    if(bldg2%70 == 0)
                        Instantiate(buildings[5], pos, Quaternion.identity);
                    else
                        Instantiate(buildings[7], pos, Quaternion.identity);
                    bldg2++;
                }
                else if (result < 9)
                {
                    if(bldg3%150 == 0)
                        Instantiate(buildings[6], pos, Quaternion.identity);
                    else
                        Instantiate(buildings[7], pos, Quaternion.identity);
                    bldg3++;
                }
                else if (result < 13)
                    Instantiate(buildings[7], pos, Quaternion.identity);
            }
        }
    }
}
