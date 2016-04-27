using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour
{
    public Text healthText;
    private int health;
    private int damageAmount;

	void Start ()
    {
        healthText.text = "Player Health";
        health = 10;
        damageAmount = 1;
	}

    void OnCollisionEnter(Collision struck)
    {
        if(struck.transform.tag == "Enemy")
        {

            health = damage(damageAmount);
            healthText.text = "Player Health " + health.ToString();
        }
        else if(struck.transform.tag == "Killzone")
        {
            Application.LoadLevel("midtermProject_Scene1");
        }
    }
    
	int damage(int playerDamage)
    {
        playerDamage = health - damageAmount;
        if (health == 0)
        {
            Application.LoadLevel("midtermProject_Scene1");
        }
        return playerDamage;
    }
}
