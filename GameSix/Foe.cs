using System;

namespace GameSix
{
	public class Foe
	{

		private string name;
		private float health;
		private float shield;
		private static float numOfPowerUps;

		public Foe (string name)
		{
			SetName(name);
			health = 100;
			shield = 0;
		}

		static Foe ()
        {
			numOfPowerUps = 0;
        }

		public string GetName()
        {
			return name;
        }

		public float GetHealth()
		{
			return health;
		}

		public float GetShield()
		{
			return shield;
		}

		public static float GetNumOfPowerUps()
		{
			return numOfPowerUps;
		}

		public void SetName(string name)
		{
			string aux = "";
			char toremove = ' ';
			for (int x = 0; x < name.Length; x++)
            {
				if (name[x] == toremove)
					continue;
				else
					aux += name[x];
            }

			this.name = aux;
		}

		public void TakeDamage(float damage)
        {
			shield -= damage;

			if (shield < 0)
            {
				float damageStillToInflict = -shield;
				shield = 0;
				health -= damageStillToInflict;
				if (health < 0) health = 0;
            }
        }

		public void PickUpPowerUp(PowerUp pUType, float value)
        {

			numOfPowerUps++;
			if (pUType == PowerUp.Health)
			{
				this.health += value;
				if (this.health > 100)
					this.health = 100;
			}
			else
            {
				this.shield += value;
				if (this.shield > 100)
					this.shield = 100;
			}
        }

	}
}
