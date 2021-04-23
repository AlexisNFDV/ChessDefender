using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {
    [Header("Unity Setup")]
    public ParticleSystem deathParticles;
    public Image healthbar;
    public NavMeshAgent agent;
    public Transform target;
    


    void Update() {
        agent.SetDestination(target.position);
        //healthbar.transform.LookAt(Camera.main.transform.position);
    }

    private void OnTriggerEnter(Collider other) {
        print("trigger");
        if (other.gameObject.tag == "base") {
            print("Dans la base");
            Instantiate(deathParticles, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
