using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class RestarterSmash : MonoBehaviour
    {
        public GameObject player1;
        public GameObject player2;
        public GameObject Player1Spawn;
        public GameObject Player2Spawn;
        public ManagerSmash man;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player1")
            {
                man.LoseHealthT(1);
                player1.transform.position = Player1Spawn.transform.position;
            }
            if (other.tag == "Player2")
            {
                man.LoseHealthC(1);
                player2.transform.position = Player2Spawn.transform.position;
            }
        }
    }
}
