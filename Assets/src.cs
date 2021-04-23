using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class src : MonoBehaviour
{
    public GameObject enemy;
    public Transform target;
    void Start() {        
        var i = 0;
        while (i < 5) {
            StartCoroutine(EnemyCoroutine());    
            i++;
        }
    }
    public void createEnemy() {
        Enemy enemyInsta = Instantiate(enemy, gameObject.transform.position, gameObject.transform.rotation).GetComponent<Enemy>();
        enemyInsta.target = target;
        // StartCoroutine(EnemyCoroutine());
    }
    IEnumerator EnemyCoroutine() {
        for(int i=0; i<5; i++ ) { 
            yield return new WaitForSeconds(3);
            createEnemy();            
        }

    }
}
