using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseLife : MonoBehaviour {
    public Image healthbar;

    public float startHealth = 100f;
    private float health;
    void Start() {
        health = startHealth;
    }

    void Update() {
        
    }

    private void OnTriggerEnter(Collider other) {

        if (health <= 0) {
            Die();
        }

        if (other.gameObject.tag == "enemy") {
            health -= 5;
            healthbar.fillAmount = health / startHealth;
        }
    }

    private void Die() {
        Destroy(gameObject, 3f);
    }
}
