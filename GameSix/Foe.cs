using System;

namespace GameSix
{
	public class Foe
	{

		private string name;
		private float health;
		private float shield;

		public Foe (string name)
		{
			SetName(name);
			health = 100;
			shield = 0;
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
		}

		public void TakeDamage(float damage)
        {
			if (shield < 0)
            {
				float damageStillToInflict = -shield;
				shield = 0;
				health -= damageStillToInflict;
				if (health < 0) health = 0;
            }
        }

	}
}
