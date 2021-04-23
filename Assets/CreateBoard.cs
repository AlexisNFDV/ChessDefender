using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    public GameObject tileBlack;
    public GameObject tileWhite;
    public Transform tileParent;

    // Start is called before the first frame update
    void Start()
    {
        /*for (var i = 0; i < 10; i++)
        {
            for (var j = 0; j < 10; j++)
            {
                    Instantiate(tileWhite, new Vector3(i, 1, j), Quaternion.identity, tileParent);
            }
        }*/
    }
}
