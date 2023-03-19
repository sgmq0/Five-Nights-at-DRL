using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfGMovement : MonoBehaviour
{
    float[,] matrix;
    Vector3[] dic;
    int currLoc;

    // Start is called before the first frame update
    void Start()
    {
        matrix = new float[5,5] { { 1f, 0f, 0f, 0f, 0f }, 
                                  { 0.6f, 0.0f, 0.4f, 0f, 0f}, 
                                  { 0f, 0.6f, 0.0f, 0.4f, 0f}, 
                                  { 0f, 0f, 0.5f, 0.0f, 0.5f}, 
                                  { 0f, 0f, 0f, 0.4f, 0.6f} };
        dic = new Vector3[5]{
              new Vector3(1.0f, 0.0f, 0.0f),
              new Vector3(2.0f, 0.0f, 0.0f),
              new Vector3(3.0f, 0.0f, 0.0f),
              new Vector3(4.0f, 0.0f, 0.0f),
              new Vector3(5.0f, 0.0f, 0.0f)};
        currLoc = 4;
        System.Random random = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        float randomValue = Random.Range(0.0f, 1.0f);
        if ( randomValue < 0.001 ) {
            float random = Random.Range(0.0f, 1.0f);
            int i = -1;
            while (random > 0) {
                i++;
                random -= matrix[currLoc, i];
            }
            transform.position = dic[i];
            currLoc = i;
        }
    }
}
