using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;
	public GameObject hero;

	public HealthBar healthBar;

	public Collided collided;

	public Destroy destroy1;
	public Destroy destroy2;
	public Destroy destroy3;


	public void Damage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}
	void DestroyObject()
	{
		Destroy(hero);
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (collided.bool1)
		{
			collided.bool1 = false;
			Damage(10);
			destroy1.DestroyGameObject();
		}
		else if (collided.bool2)
		{
			collided.bool2 = false;
			Damage(20);
			destroy2.DestroyGameObject();
		}
		else if (collided.bool3)
		{
			collided.bool3 = false;
			Damage(40);
			destroy3.DestroyGameObject();
		}
		/*if (currentHealth <= 0)
		{
			DestroyObject();
		}*/
	}
}
