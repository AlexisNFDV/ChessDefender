using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int coins;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.coinsText.text = "Pieces : 0";
    }

    public void addCoin(int coin)
    {
        coins += coin;
        GameManager.Instance.coinsText.text = "Pieces : " + coins.ToString();
    }
}
