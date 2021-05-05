using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    [Header("Unity Setup")]
    public ParticleSystem deathParticles;
    public Image healthbar;
    public float startHealth = 100f;
    public NavMeshAgent agent;
    public Transform target;
    private float health;
    public GameObject coinsText;


    void Start() {
        health = startHealth;
    }

    void Update() {
        agent.SetDestination(target.position);
        //healthbar.transform.LookAt(Camera.main.transform.position);

        if (health <= 0) {
            Die();
        }
    }

    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "base") {
            health = 0;
        }

        if (other.gameObject.tag == "bullet") {
            health -= 15;
            healthbar.fillAmount = health / startHealth;
        }
    }

    private void Die() {
        Destroy(gameObject);
        //Faire gagner une pièce
        GameManager.Instance.shop.addCoin(1);
        Instantiate(deathParticles, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
    }

}
