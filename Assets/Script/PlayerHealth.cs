using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image HealthBar;
    public GameManagerScript gameManager;
    private bool isDead;
    public AudioSource audioPlayer;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if(health <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();
            Destroy(gameObject);
            Debug.Log("Dead :]");
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ennemy")
        {
            audioPlayer.Play();
        }
    }
}
