namespace ETModel
{
	[Config((int)( AppType.Gate | AppType.Map))]
	public partial class SkillConfigCategory : ACategory<SkillConfig>
	{
	}

	public class SkillConfig: IConfig
	{
		public long Id { get; set; }
		public string Name;
		public float castTime;
		public float cooldown;
		public float castRange;
		public int manaCosts;
        public bool learnDefault;
        public bool cancelCastIfTargetDied;
        public bool followupDefaultAttack;
        public bool allowMovement;
        public int maxLevel;
        public string requiredWeaponCategory;
        public int requiredLevel;
        public long requiredExperience;
        public bool isPassive;
        public bool showCastBar;
        public int damage;
        public string type;
        public float stunChance; 
        public float stunTime;  

	}
}
