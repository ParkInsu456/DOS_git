using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
	public class Player
	{
		public int		idx = 0;
		public int		level;
		public string?	name;
		public string?	job;
		public float	fATK;
		public float	fDEF;
		public float	fHP;
		public int		gold;
	}

	public class Warrior : Player
	{
		public Warrior()
        {
			idx = base.idx;
			base.idx++;
			level = 1;
			name = "Chad";
			job = "전사";
			fATK = 10f;
			fDEF = 5f;
			fHP = 100f;
			gold = 1500;
		}
    }

	
}
