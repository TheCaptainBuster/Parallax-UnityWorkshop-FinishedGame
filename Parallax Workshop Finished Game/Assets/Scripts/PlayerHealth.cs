using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;

    public HealthBar healthBarScript;
    private void Start()
    {
        currentHealth = maxHealth;
        healthBarScript.SetMaxHealth(maxHealth);
    }
    private void Update()
    {
        //action due to which player will lose health
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage (int damageAmt)
    {
        currentHealth -= damageAmt;
        healthBarScript.SetPlayerHealth(currentHealth);
    }
}
