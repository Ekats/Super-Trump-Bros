using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public GameObject player;
        public GameObject PlayerSpawn;
        public Manager man;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                man.LoseHealth(1);
                player.transform.position = PlayerSpawn.transform.position;
            }
        }
    }
}
