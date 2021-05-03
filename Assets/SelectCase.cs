using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SelectCase : MonoBehaviour
{
    public List<Transform> tiles;

    public Transform tileColored;

    public Material color;

    public Transform rook;

    public Transform tilePiece;

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
                if (hit.transform == tileColored)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Instantiate(rook, new Vector3(hit.transform.position.x, hit.transform.position.y, hit.transform.position.z), Quaternion.identity, tilePiece);
                    }
                    else return;
                }
                else
                {
                    if (tileColored != null)
                    {
                        tileColored.GetComponent<Renderer>().material = color;
                    }

                    hit.transform.GetComponent<Renderer>().material.color = Color.black;
                    tileColored = hit.transform;
                }
            }
        }
    }
}
