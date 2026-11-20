using UnityEngine;

public class Health : MonoBehaviour
{
   [SerializeField] private float startingHealth;
   private float currentHealth;

   private void Awake()
   {
      currentHealth = startingHealth;
   }

   public void TakeDamage(float damage)
   {
      currentHealth = Mathf.Clamp(currentHealth - damage, 0f, startingHealth);

      if (currentHealth <= 0)
      {
         //player hurt
      }
      else
      {
         //player dead
      }
   }
}
