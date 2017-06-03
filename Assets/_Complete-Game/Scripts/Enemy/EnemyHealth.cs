using UnityEngine;

namespace CompleteProject
{
    public class EnemyHealth : MonoBehaviour
    {
        public int startingHealth = 100;
        public int currentHealth;
        public float sinkSpeed = 2.5f;
        public int scoreValue = 10;
        public AudioClip deathClip;
        public string strManager = "/EnemyManager";
        
        GameObject manager;
        EnemyCount enemyCount;

        Animator anim;
        AudioSource enemyAudio;
        ParticleSystem hitParticles;
        CapsuleCollider capsuleCollider;
        bool isDead;
        bool isSinking;

        void Awake ()
        {
            manager = GameObject.Find(strManager);
            enemyCount = manager.GetComponent <EnemyCount> ();
            anim = GetComponent <Animator> ();
            enemyAudio = GetComponent <AudioSource> ();
            hitParticles = GetComponentInChildren <ParticleSystem> ();
            capsuleCollider = GetComponent <CapsuleCollider> ();
            currentHealth = startingHealth;
        }

        void Update ()
        {
            if(isSinking)
            {
                transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);
            }
        }

        public void TakeDamage (int amount, Vector3 hitPoint)
        {
            if(isDead)
                return;
            enemyAudio.Play ();
            currentHealth -= amount;
            
            hitParticles.transform.position = hitPoint;
            hitParticles.Play();
            if(currentHealth <= 0)
            {
                Death ();
            }
        }

        void Death ()
        {
            enemyCount.dead = enemyCount.dead + 1;
            isDead = true;
            capsuleCollider.isTrigger = true;
            anim.SetTrigger ("Dead");
            enemyAudio.clip = deathClip;
            enemyAudio.Play ();
        }
        
        public void StartSinking ()
        {
            GetComponent <UnityEngine.AI.NavMeshAgent> ().enabled = false;
            GetComponent <Rigidbody> ().isKinematic = true;
            isSinking = true;
            ScoreManager.score += scoreValue;
            Destroy (gameObject, 2f);
        }
    }
}