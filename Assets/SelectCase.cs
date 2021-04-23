using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SelectCase : MonoBehaviour
{
    public List<Transform> tiles;

    public Transform tileColored;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }

    void Raycast()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            if (transform.GetComponentsInChildren<Transform>().ToList().Contains(hit.transform))
            {
                print("Touche une tuile");
                if (hit.transform == tileColored) return;
                else
                {
                    print("Touche une nouvelle tuile");
                    if (tileColored != null)
                    {
                        print("On 2teint l'qnciewnne tuile");
                        tileColored.GetComponent<Renderer>().material.color = new Color(171, 171 , 171, 255);
                    }

                    hit.transform.GetComponent<Renderer>().material.color = Color.black;
                    tileColored = hit.transform;
                }
            }
        }
    }
}
