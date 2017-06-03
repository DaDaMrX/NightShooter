using UnityEngine;

namespace CompleteProject
{
    public class EnemyManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;
        public GameObject enemy;
        public int num = 3;
        public float appearTime = 0f;
        public float spawnTime = 3f;
        public Transform[] spawnPoints;

        int live;
        public int dead;

        void Start ()
        {
            InvokeRepeating ("Spawn", appearTime, spawnTime);
            live = 0;
            dead = 0;
        }

        void Spawn ()
        {
            if(playerHealth.currentHealth <= 0f)
            {
                return;
            }
            int spawnPointIndex = Random.Range (0, spawnPoints.Length);
            if (live < num)
            {
                Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
                live = live + 1;
            }
            if (dead == num) print ("Over");
        }
    }
}