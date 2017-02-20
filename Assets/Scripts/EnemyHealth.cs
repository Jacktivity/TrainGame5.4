using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

		public const int maxHealth = 3; // the max health for the train , it has been set to three so that the projectile can be set to have a damage of one and after 3 hits the train health has been depleted
		public int currentHealth = maxHealth;

public void TakeDamage(int amount) // this part of the code is for the damage taken
	{
		currentHealth -= amount;
		if (currentHealth <= 0) // indicates that if the player (train) health is at 0 then the following piece of code runs
		{
			currentHealth = 0; // this states that id the player(train) health reaches 0 they are then dead
			Destroy (gameObject);
		}
	}
}
