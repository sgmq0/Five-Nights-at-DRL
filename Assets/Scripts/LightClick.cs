using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightClick : MonoBehaviour {
    
    private void Update() 
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            RaycastHit hit; 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 1000.0f)) 
            {
                if (hit.transform != null) 
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }
    }

    private void PrintName(GameObject go) 
    {
        print(go.name);
    }

}
