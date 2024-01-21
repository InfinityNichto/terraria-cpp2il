using Cpp2IlInjected;

namespace Terraria.GameContent.ItemDropRules;

[Cpp2IlInjected.Token(Token = "0x20005E2")]
public class Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20009B1")]
	public class NeverTrue : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004E87")]
		[Cpp2IlInjected.Address(RVA = "0xE75B34", Offset = "0xE75B34", VA = "0xE75B34", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E88")]
		[Cpp2IlInjected.Address(RVA = "0xE75B3C", Offset = "0xE75B3C", VA = "0xE75B3C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E89")]
		[Cpp2IlInjected.Address(RVA = "0xE75B44", Offset = "0xE75B44", VA = "0xE75B44", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E8A")]
		[Cpp2IlInjected.Address(RVA = "0xE75B4C", Offset = "0xE75B4C", VA = "0xE75B4C")]
		public NeverTrue()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B2")]
	public class IsUsingSpecificAIValues : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CD0")]
		public int aiSlotToCheck;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CD1")]
		public float valueToMatch;

		[Cpp2IlInjected.Token(Token = "0x6004E8B")]
		[Cpp2IlInjected.Address(RVA = "0xE750CC", Offset = "0xE750CC", VA = "0xE750CC")]
		public IsUsingSpecificAIValues(int aislot, float valueToMatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E8C")]
		[Cpp2IlInjected.Address(RVA = "0xE750F4", Offset = "0xE750F4", VA = "0xE750F4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E8D")]
		[Cpp2IlInjected.Address(RVA = "0xE7511C", Offset = "0xE7511C", VA = "0xE7511C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E8E")]
		[Cpp2IlInjected.Address(RVA = "0xE75124", Offset = "0xE75124", VA = "0xE75124", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B3")]
	public class FrostMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004E8F")]
		[Cpp2IlInjected.Address(RVA = "0xE73CC0", Offset = "0xE73CC0", VA = "0xE73CC0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E90")]
		[Cpp2IlInjected.Address(RVA = "0xE73E24", Offset = "0xE73E24", VA = "0xE73E24", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E91")]
		[Cpp2IlInjected.Address(RVA = "0xE73E2C", Offset = "0xE73E2C", VA = "0xE73E2C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E92")]
		[Cpp2IlInjected.Address(RVA = "0xE73E84", Offset = "0xE73E84", VA = "0xE73E84")]
		public FrostMoonDropGatingChance()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B4")]
	public class PumpkinMoonDropGatingChance : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004E93")]
		[Cpp2IlInjected.Address(RVA = "0xE76388", Offset = "0xE76388", VA = "0xE76388", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E94")]
		[Cpp2IlInjected.Address(RVA = "0xE764E4", Offset = "0xE764E4", VA = "0xE764E4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E95")]
		[Cpp2IlInjected.Address(RVA = "0xE764EC", Offset = "0xE764EC", VA = "0xE764EC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E96")]
		[Cpp2IlInjected.Address(RVA = "0xE76544", Offset = "0xE76544", VA = "0xE76544")]
		public PumpkinMoonDropGatingChance()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B5")]
	public class FrostMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004E97")]
		[Cpp2IlInjected.Address(RVA = "0xE73B34", Offset = "0xE73B34", VA = "0xE73B34", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E98")]
		[Cpp2IlInjected.Address(RVA = "0xE73CA8", Offset = "0xE73CA8", VA = "0xE73CA8", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E99")]
		[Cpp2IlInjected.Address(RVA = "0xE73CB0", Offset = "0xE73CB0", VA = "0xE73CB0", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9A")]
		[Cpp2IlInjected.Address(RVA = "0xE73CB8", Offset = "0xE73CB8", VA = "0xE73CB8")]
		public FrostMoonDropGateForTrophies()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B6")]
	public class PumpkinMoonDropGateForTrophies : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004E9B")]
		[Cpp2IlInjected.Address(RVA = "0xE761FC", Offset = "0xE761FC", VA = "0xE761FC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9C")]
		[Cpp2IlInjected.Address(RVA = "0xE76370", Offset = "0xE76370", VA = "0xE76370", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9D")]
		[Cpp2IlInjected.Address(RVA = "0xE76378", Offset = "0xE76378", VA = "0xE76378", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E9E")]
		[Cpp2IlInjected.Address(RVA = "0xE76380", Offset = "0xE76380", VA = "0xE76380")]
		public PumpkinMoonDropGateForTrophies()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B7")]
	public class IsPumpkinMoon : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004E9F")]
		[Cpp2IlInjected.Address(RVA = "0xE7503C", Offset = "0xE7503C", VA = "0xE7503C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA0")]
		[Cpp2IlInjected.Address(RVA = "0xE750B4", Offset = "0xE750B4", VA = "0xE750B4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA1")]
		[Cpp2IlInjected.Address(RVA = "0xE750BC", Offset = "0xE750BC", VA = "0xE750BC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA2")]
		[Cpp2IlInjected.Address(RVA = "0xE750C4", Offset = "0xE750C4", VA = "0xE750C4")]
		public IsPumpkinMoon()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B8")]
	public class FromCertainWaveAndAbove : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CD2")]
		public int neededWave;

		[Cpp2IlInjected.Token(Token = "0x6004EA3")]
		[Cpp2IlInjected.Address(RVA = "0xE739F8", Offset = "0xE739F8", VA = "0xE739F8")]
		public FromCertainWaveAndAbove(int neededWave)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA4")]
		[Cpp2IlInjected.Address(RVA = "0xE73A18", Offset = "0xE73A18", VA = "0xE73A18", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA5")]
		[Cpp2IlInjected.Address(RVA = "0xE73AA4", Offset = "0xE73AA4", VA = "0xE73AA4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA6")]
		[Cpp2IlInjected.Address(RVA = "0xE73AAC", Offset = "0xE73AAC", VA = "0xE73AAC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009B9")]
	public class IsBloodMoonAndNotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EA7")]
		[Cpp2IlInjected.Address(RVA = "0xE74498", Offset = "0xE74498", VA = "0xE74498", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA8")]
		[Cpp2IlInjected.Address(RVA = "0xE74574", Offset = "0xE74574", VA = "0xE74574", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EA9")]
		[Cpp2IlInjected.Address(RVA = "0xE7457C", Offset = "0xE7457C", VA = "0xE7457C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAA")]
		[Cpp2IlInjected.Address(RVA = "0xE74584", Offset = "0xE74584", VA = "0xE74584")]
		public IsBloodMoonAndNotFromStatue()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009BA")]
	public class DownedAllMechBosses : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EAB")]
		[Cpp2IlInjected.Address(RVA = "0xE7375C", Offset = "0xE7375C", VA = "0xE7375C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAC")]
		[Cpp2IlInjected.Address(RVA = "0xE73844", Offset = "0xE73844", VA = "0xE73844", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAD")]
		[Cpp2IlInjected.Address(RVA = "0xE7384C", Offset = "0xE7384C", VA = "0xE7384C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EAE")]
		[Cpp2IlInjected.Address(RVA = "0xE73854", Offset = "0xE73854", VA = "0xE73854")]
		public DownedAllMechBosses()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009BB")]
	public class DownedPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EAF")]
		[Cpp2IlInjected.Address(RVA = "0xE7385C", Offset = "0xE7385C", VA = "0xE7385C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB0")]
		[Cpp2IlInjected.Address(RVA = "0xE738D4", Offset = "0xE738D4", VA = "0xE738D4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB1")]
		[Cpp2IlInjected.Address(RVA = "0xE738DC", Offset = "0xE738DC", VA = "0xE738DC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB2")]
		[Cpp2IlInjected.Address(RVA = "0xE738E4", Offset = "0xE738E4", VA = "0xE738E4")]
		public DownedPlantera()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009BC")]
	public class IsHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EB3")]
		[Cpp2IlInjected.Address(RVA = "0xE74E64", Offset = "0xE74E64", VA = "0xE74E64", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB4")]
		[Cpp2IlInjected.Address(RVA = "0xE74EDC", Offset = "0xE74EDC", VA = "0xE74EDC", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB5")]
		[Cpp2IlInjected.Address(RVA = "0xE74EE4", Offset = "0xE74EE4", VA = "0xE74EE4", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB6")]
		[Cpp2IlInjected.Address(RVA = "0xE74EEC", Offset = "0xE74EEC", VA = "0xE74EEC")]
		public IsHardmode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009BD")]
	public class FirstTimeKillingPlantera : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EB7")]
		[Cpp2IlInjected.Address(RVA = "0xE73960", Offset = "0xE73960", VA = "0xE73960", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB8")]
		[Cpp2IlInjected.Address(RVA = "0xE739E0", Offset = "0xE739E0", VA = "0xE739E0", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EB9")]
		[Cpp2IlInjected.Address(RVA = "0xE739E8", Offset = "0xE739E8", VA = "0xE739E8", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBA")]
		[Cpp2IlInjected.Address(RVA = "0xE739F0", Offset = "0xE739F0", VA = "0xE739F0")]
		public FirstTimeKillingPlantera()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009BE")]
	public class MechanicalBossesDummyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EBB")]
		[Cpp2IlInjected.Address(RVA = "0xE756B0", Offset = "0xE756B0", VA = "0xE756B0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBC")]
		[Cpp2IlInjected.Address(RVA = "0xE756B8", Offset = "0xE756B8", VA = "0xE756B8", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBD")]
		[Cpp2IlInjected.Address(RVA = "0xE756C0", Offset = "0xE756C0", VA = "0xE756C0", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EBE")]
		[Cpp2IlInjected.Address(RVA = "0xE756C8", Offset = "0xE756C8", VA = "0xE756C8")]
		public MechanicalBossesDummyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009BF")]
	public class PirateMap : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EBF")]
		[Cpp2IlInjected.Address(RVA = "0xE75F7C", Offset = "0xE75F7C", VA = "0xE75F7C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC0")]
		[Cpp2IlInjected.Address(RVA = "0xE76114", Offset = "0xE76114", VA = "0xE76114", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC1")]
		[Cpp2IlInjected.Address(RVA = "0xE7611C", Offset = "0xE7611C", VA = "0xE7611C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC2")]
		[Cpp2IlInjected.Address(RVA = "0xE76174", Offset = "0xE76174", VA = "0xE76174")]
		public PirateMap()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C0")]
	public class IsChristmas : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EC3")]
		[Cpp2IlInjected.Address(RVA = "0xE7458C", Offset = "0xE7458C", VA = "0xE7458C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC4")]
		[Cpp2IlInjected.Address(RVA = "0xE74604", Offset = "0xE74604", VA = "0xE74604", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC5")]
		[Cpp2IlInjected.Address(RVA = "0xE7460C", Offset = "0xE7460C", VA = "0xE7460C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC6")]
		[Cpp2IlInjected.Address(RVA = "0xE74664", Offset = "0xE74664", VA = "0xE74664")]
		public IsChristmas()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C1")]
	public class NotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EC7")]
		[Cpp2IlInjected.Address(RVA = "0xE75B54", Offset = "0xE75B54", VA = "0xE75B54", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC8")]
		[Cpp2IlInjected.Address(RVA = "0xE75BCC", Offset = "0xE75BCC", VA = "0xE75BCC", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EC9")]
		[Cpp2IlInjected.Address(RVA = "0xE75C44", Offset = "0xE75C44", VA = "0xE75C44", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECA")]
		[Cpp2IlInjected.Address(RVA = "0xE75C9C", Offset = "0xE75C9C", VA = "0xE75C9C")]
		public NotExpert()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C2")]
	public class NotMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004ECB")]
		[Cpp2IlInjected.Address(RVA = "0xE75D1C", Offset = "0xE75D1C", VA = "0xE75D1C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECC")]
		[Cpp2IlInjected.Address(RVA = "0xE75D94", Offset = "0xE75D94", VA = "0xE75D94", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECD")]
		[Cpp2IlInjected.Address(RVA = "0xE75E0C", Offset = "0xE75E0C", VA = "0xE75E0C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ECE")]
		[Cpp2IlInjected.Address(RVA = "0xE75E64", Offset = "0xE75E64", VA = "0xE75E64")]
		public NotMasterMode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C3")]
	public class MissingTwin : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004ECF")]
		[Cpp2IlInjected.Address(RVA = "0xE759E4", Offset = "0xE759E4", VA = "0xE759E4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED0")]
		[Cpp2IlInjected.Address(RVA = "0xE75A74", Offset = "0xE75A74", VA = "0xE75A74", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED1")]
		[Cpp2IlInjected.Address(RVA = "0xE75A7C", Offset = "0xE75A7C", VA = "0xE75A7C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED2")]
		[Cpp2IlInjected.Address(RVA = "0xE75A84", Offset = "0xE75A84", VA = "0xE75A84")]
		public MissingTwin()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C4")]
	public class EmpressOfLightIsGenuinelyEnraged : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004ED3")]
		[Cpp2IlInjected.Address(RVA = "0xE738EC", Offset = "0xE738EC", VA = "0xE738EC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED4")]
		[Cpp2IlInjected.Address(RVA = "0xE738F8", Offset = "0xE738F8", VA = "0xE738F8", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED5")]
		[Cpp2IlInjected.Address(RVA = "0xE73900", Offset = "0xE73900", VA = "0xE73900", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED6")]
		[Cpp2IlInjected.Address(RVA = "0xE73958", Offset = "0xE73958", VA = "0xE73958")]
		public EmpressOfLightIsGenuinelyEnraged()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C5")]
	public class PlayerNeedsHealing : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004ED7")]
		[Cpp2IlInjected.Address(RVA = "0xE7617C", Offset = "0xE7617C", VA = "0xE7617C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED8")]
		[Cpp2IlInjected.Address(RVA = "0xE76194", Offset = "0xE76194", VA = "0xE76194", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004ED9")]
		[Cpp2IlInjected.Address(RVA = "0xE7619C", Offset = "0xE7619C", VA = "0xE7619C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EDA")]
		[Cpp2IlInjected.Address(RVA = "0xE761F4", Offset = "0xE761F4", VA = "0xE761F4")]
		public PlayerNeedsHealing()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C6")]
	public class MechdusaKill : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x4008CD3")]
		private static int[] _targetList;

		[Cpp2IlInjected.Token(Token = "0x6004EDB")]
		[Cpp2IlInjected.Address(RVA = "0xE756D0", Offset = "0xE756D0", VA = "0xE756D0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EDC")]
		[Cpp2IlInjected.Address(RVA = "0xE7588C", Offset = "0xE7588C", VA = "0xE7588C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EDD")]
		[Cpp2IlInjected.Address(RVA = "0xE75944", Offset = "0xE75944", VA = "0xE75944", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EDE")]
		[Cpp2IlInjected.Address(RVA = "0xE7594C", Offset = "0xE7594C", VA = "0xE7594C")]
		public MechdusaKill()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C7")]
	public class LegacyHack_IsBossAndExpert : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE0")]
		[Cpp2IlInjected.Address(RVA = "0xE7526C", Offset = "0xE7526C", VA = "0xE7526C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE1")]
		[Cpp2IlInjected.Address(RVA = "0xE752F8", Offset = "0xE752F8", VA = "0xE752F8", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE2")]
		[Cpp2IlInjected.Address(RVA = "0xE7536C", Offset = "0xE7536C", VA = "0xE7536C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE3")]
		[Cpp2IlInjected.Address(RVA = "0xE753C4", Offset = "0xE753C4", VA = "0xE753C4")]
		public LegacyHack_IsBossAndExpert()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C8")]
	public class LegacyHack_IsBossAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE4")]
		[Cpp2IlInjected.Address(RVA = "0xE753CC", Offset = "0xE753CC", VA = "0xE753CC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE5")]
		[Cpp2IlInjected.Address(RVA = "0xE7545C", Offset = "0xE7545C", VA = "0xE7545C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE6")]
		[Cpp2IlInjected.Address(RVA = "0xE754D4", Offset = "0xE754D4", VA = "0xE754D4", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE7")]
		[Cpp2IlInjected.Address(RVA = "0xE7552C", Offset = "0xE7552C", VA = "0xE7552C")]
		public LegacyHack_IsBossAndNotExpert()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009C9")]
	public class LegacyHack_IsABoss : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EE8")]
		[Cpp2IlInjected.Address(RVA = "0xE7524C", Offset = "0xE7524C", VA = "0xE7524C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EE9")]
		[Cpp2IlInjected.Address(RVA = "0xE75254", Offset = "0xE75254", VA = "0xE75254", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEA")]
		[Cpp2IlInjected.Address(RVA = "0xE7525C", Offset = "0xE7525C", VA = "0xE7525C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEB")]
		[Cpp2IlInjected.Address(RVA = "0xE75264", Offset = "0xE75264", VA = "0xE75264")]
		public LegacyHack_IsABoss()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009CA")]
	public class IsExpert : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EEC")]
		[Cpp2IlInjected.Address(RVA = "0xE74CD4", Offset = "0xE74CD4", VA = "0xE74CD4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EED")]
		[Cpp2IlInjected.Address(RVA = "0xE74D48", Offset = "0xE74D48", VA = "0xE74D48", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEE")]
		[Cpp2IlInjected.Address(RVA = "0xE74DBC", Offset = "0xE74DBC", VA = "0xE74DBC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EEF")]
		[Cpp2IlInjected.Address(RVA = "0xE74E5C", Offset = "0xE74E5C", VA = "0xE74E5C")]
		public IsExpert()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009CB")]
	public class IsMasterMode : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EF0")]
		[Cpp2IlInjected.Address(RVA = "0xE74EF4", Offset = "0xE74EF4", VA = "0xE74EF4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF1")]
		[Cpp2IlInjected.Address(RVA = "0xE74F68", Offset = "0xE74F68", VA = "0xE74F68", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF2")]
		[Cpp2IlInjected.Address(RVA = "0xE74FDC", Offset = "0xE74FDC", VA = "0xE74FDC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF3")]
		[Cpp2IlInjected.Address(RVA = "0xE75034", Offset = "0xE75034", VA = "0xE75034")]
		public IsMasterMode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009CC")]
	public class IsCrimson : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EF4")]
		[Cpp2IlInjected.Address(RVA = "0xE749A4", Offset = "0xE749A4", VA = "0xE749A4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF5")]
		[Cpp2IlInjected.Address(RVA = "0xE74A1C", Offset = "0xE74A1C", VA = "0xE74A1C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF6")]
		[Cpp2IlInjected.Address(RVA = "0xE74A94", Offset = "0xE74A94", VA = "0xE74A94", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF7")]
		[Cpp2IlInjected.Address(RVA = "0xE74AEC", Offset = "0xE74AEC", VA = "0xE74AEC")]
		public IsCrimson()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009CD")]
	public class IsCorruption : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EF8")]
		[Cpp2IlInjected.Address(RVA = "0xE7466C", Offset = "0xE7466C", VA = "0xE7466C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EF9")]
		[Cpp2IlInjected.Address(RVA = "0xE746EC", Offset = "0xE746EC", VA = "0xE746EC", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFA")]
		[Cpp2IlInjected.Address(RVA = "0xE7476C", Offset = "0xE7476C", VA = "0xE7476C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFB")]
		[Cpp2IlInjected.Address(RVA = "0xE747C4", Offset = "0xE747C4", VA = "0xE747C4")]
		public IsCorruption()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009CE")]
	public class IsCrimsonAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004EFC")]
		[Cpp2IlInjected.Address(RVA = "0xE74AF4", Offset = "0xE74AF4", VA = "0xE74AF4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFD")]
		[Cpp2IlInjected.Address(RVA = "0xE74BB4", Offset = "0xE74BB4", VA = "0xE74BB4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFE")]
		[Cpp2IlInjected.Address(RVA = "0xE74C74", Offset = "0xE74C74", VA = "0xE74C74", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004EFF")]
		[Cpp2IlInjected.Address(RVA = "0xE74CCC", Offset = "0xE74CCC", VA = "0xE74CCC")]
		public IsCrimsonAndNotExpert()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009CF")]
	public class IsCorruptionAndNotExpert : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F00")]
		[Cpp2IlInjected.Address(RVA = "0xE747CC", Offset = "0xE747CC", VA = "0xE747CC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F01")]
		[Cpp2IlInjected.Address(RVA = "0xE74888", Offset = "0xE74888", VA = "0xE74888", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F02")]
		[Cpp2IlInjected.Address(RVA = "0xE74944", Offset = "0xE74944", VA = "0xE74944", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F03")]
		[Cpp2IlInjected.Address(RVA = "0xE7499C", Offset = "0xE7499C", VA = "0xE7499C")]
		public IsCorruptionAndNotExpert()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D0")]
	public class HalloweenWeapons : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F04")]
		[Cpp2IlInjected.Address(RVA = "0xE7420C", Offset = "0xE7420C", VA = "0xE7420C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F05")]
		[Cpp2IlInjected.Address(RVA = "0xE74430", Offset = "0xE74430", VA = "0xE74430", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F06")]
		[Cpp2IlInjected.Address(RVA = "0xE74438", Offset = "0xE74438", VA = "0xE74438", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F07")]
		[Cpp2IlInjected.Address(RVA = "0xE74490", Offset = "0xE74490", VA = "0xE74490")]
		public HalloweenWeapons()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D1")]
	public class SoulOfNight : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F08")]
		[Cpp2IlInjected.Address(RVA = "0xE76A04", Offset = "0xE76A04", VA = "0xE76A04", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F09")]
		[Cpp2IlInjected.Address(RVA = "0xE76A74", Offset = "0xE76A74", VA = "0xE76A74", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0A")]
		[Cpp2IlInjected.Address(RVA = "0xE76A7C", Offset = "0xE76A7C", VA = "0xE76A7C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0B")]
		[Cpp2IlInjected.Address(RVA = "0xE76AD4", Offset = "0xE76AD4", VA = "0xE76AD4")]
		public SoulOfNight()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D2")]
	public class SoulOfLight : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F0C")]
		[Cpp2IlInjected.Address(RVA = "0xE7694C", Offset = "0xE7694C", VA = "0xE7694C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0D")]
		[Cpp2IlInjected.Address(RVA = "0xE7699C", Offset = "0xE7699C", VA = "0xE7699C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0E")]
		[Cpp2IlInjected.Address(RVA = "0xE769A4", Offset = "0xE769A4", VA = "0xE769A4", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F0F")]
		[Cpp2IlInjected.Address(RVA = "0xE769FC", Offset = "0xE769FC", VA = "0xE769FC")]
		public SoulOfLight()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D3")]
	public class NotFromStatue : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F10")]
		[Cpp2IlInjected.Address(RVA = "0xE75CA4", Offset = "0xE75CA4", VA = "0xE75CA4", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F11")]
		[Cpp2IlInjected.Address(RVA = "0xE75CB4", Offset = "0xE75CB4", VA = "0xE75CB4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F12")]
		[Cpp2IlInjected.Address(RVA = "0xE75CBC", Offset = "0xE75CBC", VA = "0xE75CBC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F13")]
		[Cpp2IlInjected.Address(RVA = "0xE75D14", Offset = "0xE75D14", VA = "0xE75D14")]
		public NotFromStatue()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D4")]
	public class HalloweenGoodieBagDrop : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F14")]
		[Cpp2IlInjected.Address(RVA = "0xE740CC", Offset = "0xE740CC", VA = "0xE740CC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F15")]
		[Cpp2IlInjected.Address(RVA = "0xE741A4", Offset = "0xE741A4", VA = "0xE741A4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F16")]
		[Cpp2IlInjected.Address(RVA = "0xE741AC", Offset = "0xE741AC", VA = "0xE741AC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F17")]
		[Cpp2IlInjected.Address(RVA = "0xE74204", Offset = "0xE74204", VA = "0xE74204")]
		public HalloweenGoodieBagDrop()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D5")]
	public class XmasPresentDrop : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F18")]
		[Cpp2IlInjected.Address(RVA = "0xE76DC8", Offset = "0xE76DC8", VA = "0xE76DC8", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F19")]
		[Cpp2IlInjected.Address(RVA = "0xE76EA0", Offset = "0xE76EA0", VA = "0xE76EA0", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1A")]
		[Cpp2IlInjected.Address(RVA = "0xE76EA8", Offset = "0xE76EA8", VA = "0xE76EA8", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1B")]
		[Cpp2IlInjected.Address(RVA = "0xE76F00", Offset = "0xE76F00", VA = "0xE76F00")]
		public XmasPresentDrop()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D6")]
	public class LivingFlames : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F1C")]
		[Cpp2IlInjected.Address(RVA = "0xE75534", Offset = "0xE75534", VA = "0xE75534", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1D")]
		[Cpp2IlInjected.Address(RVA = "0xE75648", Offset = "0xE75648", VA = "0xE75648", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1E")]
		[Cpp2IlInjected.Address(RVA = "0xE75650", Offset = "0xE75650", VA = "0xE75650", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F1F")]
		[Cpp2IlInjected.Address(RVA = "0xE756A8", Offset = "0xE756A8", VA = "0xE756A8")]
		public LivingFlames()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D7")]
	public class NamedNPC : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CD4")]
		public string neededName;

		[Cpp2IlInjected.Token(Token = "0x6004F20")]
		[Cpp2IlInjected.Address(RVA = "0xE75A8C", Offset = "0xE75A8C", VA = "0xE75A8C")]
		public NamedNPC(string neededName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F21")]
		[Cpp2IlInjected.Address(RVA = "0xE75AAC", Offset = "0xE75AAC", VA = "0xE75AAC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F22")]
		[Cpp2IlInjected.Address(RVA = "0xE75AD4", Offset = "0xE75AD4", VA = "0xE75AD4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F23")]
		[Cpp2IlInjected.Address(RVA = "0xE75ADC", Offset = "0xE75ADC", VA = "0xE75ADC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D8")]
	public class HallowKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F24")]
		[Cpp2IlInjected.Address(RVA = "0xE73FAC", Offset = "0xE73FAC", VA = "0xE73FAC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F25")]
		[Cpp2IlInjected.Address(RVA = "0xE74064", Offset = "0xE74064", VA = "0xE74064", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F26")]
		[Cpp2IlInjected.Address(RVA = "0xE7406C", Offset = "0xE7406C", VA = "0xE7406C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F27")]
		[Cpp2IlInjected.Address(RVA = "0xE740C4", Offset = "0xE740C4", VA = "0xE740C4")]
		public HallowKeyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009D9")]
	public class JungleKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F28")]
		[Cpp2IlInjected.Address(RVA = "0xE7512C", Offset = "0xE7512C", VA = "0xE7512C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F29")]
		[Cpp2IlInjected.Address(RVA = "0xE751E4", Offset = "0xE751E4", VA = "0xE751E4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2A")]
		[Cpp2IlInjected.Address(RVA = "0xE751EC", Offset = "0xE751EC", VA = "0xE751EC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2B")]
		[Cpp2IlInjected.Address(RVA = "0xE75244", Offset = "0xE75244", VA = "0xE75244")]
		public JungleKeyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009DA")]
	public class CorruptKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F2C")]
		[Cpp2IlInjected.Address(RVA = "0xE731D0", Offset = "0xE731D0", VA = "0xE731D0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2D")]
		[Cpp2IlInjected.Address(RVA = "0xE73288", Offset = "0xE73288", VA = "0xE73288", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2E")]
		[Cpp2IlInjected.Address(RVA = "0xE73290", Offset = "0xE73290", VA = "0xE73290", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F2F")]
		[Cpp2IlInjected.Address(RVA = "0xE732E8", Offset = "0xE732E8", VA = "0xE732E8")]
		public CorruptKeyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009DB")]
	public class CrimsonKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F30")]
		[Cpp2IlInjected.Address(RVA = "0xE732F0", Offset = "0xE732F0", VA = "0xE732F0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F31")]
		[Cpp2IlInjected.Address(RVA = "0xE733A8", Offset = "0xE733A8", VA = "0xE733A8", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F32")]
		[Cpp2IlInjected.Address(RVA = "0xE733B0", Offset = "0xE733B0", VA = "0xE733B0", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F33")]
		[Cpp2IlInjected.Address(RVA = "0xE73408", Offset = "0xE73408", VA = "0xE73408")]
		public CrimsonKeyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009DC")]
	public class FrozenKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F34")]
		[Cpp2IlInjected.Address(RVA = "0xE73E8C", Offset = "0xE73E8C", VA = "0xE73E8C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F35")]
		[Cpp2IlInjected.Address(RVA = "0xE73F44", Offset = "0xE73F44", VA = "0xE73F44", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F36")]
		[Cpp2IlInjected.Address(RVA = "0xE73F4C", Offset = "0xE73F4C", VA = "0xE73F4C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F37")]
		[Cpp2IlInjected.Address(RVA = "0xE73FA4", Offset = "0xE73FA4", VA = "0xE73FA4")]
		public FrozenKeyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009DD")]
	public class DesertKeyCondition : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F38")]
		[Cpp2IlInjected.Address(RVA = "0xE73410", Offset = "0xE73410", VA = "0xE73410", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F39")]
		[Cpp2IlInjected.Address(RVA = "0xE734E4", Offset = "0xE734E4", VA = "0xE734E4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3A")]
		[Cpp2IlInjected.Address(RVA = "0xE734EC", Offset = "0xE734EC", VA = "0xE734EC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3B")]
		[Cpp2IlInjected.Address(RVA = "0xE73544", Offset = "0xE73544", VA = "0xE73544")]
		public DesertKeyCondition()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009DE")]
	public class BeatAnyMechBoss : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F3C")]
		[Cpp2IlInjected.Address(RVA = "0xE730F0", Offset = "0xE730F0", VA = "0xE730F0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3D")]
		[Cpp2IlInjected.Address(RVA = "0xE73168", Offset = "0xE73168", VA = "0xE73168", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3E")]
		[Cpp2IlInjected.Address(RVA = "0xE73170", Offset = "0xE73170", VA = "0xE73170", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F3F")]
		[Cpp2IlInjected.Address(RVA = "0xE731C8", Offset = "0xE731C8", VA = "0xE731C8")]
		public BeatAnyMechBoss()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009DF")]
	public class YoyoCascade : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F40")]
		[Cpp2IlInjected.Address(RVA = "0xE76F08", Offset = "0xE76F08", VA = "0xE76F08", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F41")]
		[Cpp2IlInjected.Address(RVA = "0xE77080", Offset = "0xE77080", VA = "0xE77080", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F42")]
		[Cpp2IlInjected.Address(RVA = "0xE77088", Offset = "0xE77088", VA = "0xE77088", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F43")]
		[Cpp2IlInjected.Address(RVA = "0xE770E0", Offset = "0xE770E0", VA = "0xE770E0")]
		public YoyoCascade()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E0")]
	public class YoyosAmarok : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F44")]
		[Cpp2IlInjected.Address(RVA = "0xE770E8", Offset = "0xE770E8", VA = "0xE770E8", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F45")]
		[Cpp2IlInjected.Address(RVA = "0xE771D8", Offset = "0xE771D8", VA = "0xE771D8", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F46")]
		[Cpp2IlInjected.Address(RVA = "0xE771E0", Offset = "0xE771E0", VA = "0xE771E0", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F47")]
		[Cpp2IlInjected.Address(RVA = "0xE77238", Offset = "0xE77238", VA = "0xE77238")]
		public YoyosAmarok()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E1")]
	public class YoyosYelets : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F48")]
		[Cpp2IlInjected.Address(RVA = "0xE775A0", Offset = "0xE775A0", VA = "0xE775A0", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F49")]
		[Cpp2IlInjected.Address(RVA = "0xE776D0", Offset = "0xE776D0", VA = "0xE776D0", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4A")]
		[Cpp2IlInjected.Address(RVA = "0xE776D8", Offset = "0xE776D8", VA = "0xE776D8", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4B")]
		[Cpp2IlInjected.Address(RVA = "0xE77730", Offset = "0xE77730", VA = "0xE77730")]
		public YoyosYelets()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E2")]
	public class YoyosKraken : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F4C")]
		[Cpp2IlInjected.Address(RVA = "0xE77408", Offset = "0xE77408", VA = "0xE77408", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4D")]
		[Cpp2IlInjected.Address(RVA = "0xE77538", Offset = "0xE77538", VA = "0xE77538", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4E")]
		[Cpp2IlInjected.Address(RVA = "0xE77540", Offset = "0xE77540", VA = "0xE77540", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F4F")]
		[Cpp2IlInjected.Address(RVA = "0xE77598", Offset = "0xE77598", VA = "0xE77598")]
		public YoyosKraken()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E3")]
	public class YoyosHelFire : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F50")]
		[Cpp2IlInjected.Address(RVA = "0xE77240", Offset = "0xE77240", VA = "0xE77240", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F51")]
		[Cpp2IlInjected.Address(RVA = "0xE773A0", Offset = "0xE773A0", VA = "0xE773A0", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F52")]
		[Cpp2IlInjected.Address(RVA = "0xE773A8", Offset = "0xE773A8", VA = "0xE773A8", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F53")]
		[Cpp2IlInjected.Address(RVA = "0xE77400", Offset = "0xE77400", VA = "0xE77400")]
		public YoyosHelFire()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E4")]
	public class WindyEnoughForKiteDrops : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F54")]
		[Cpp2IlInjected.Address(RVA = "0xE76CEC", Offset = "0xE76CEC", VA = "0xE76CEC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F55")]
		[Cpp2IlInjected.Address(RVA = "0xE76D60", Offset = "0xE76D60", VA = "0xE76D60", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F56")]
		[Cpp2IlInjected.Address(RVA = "0xE76D68", Offset = "0xE76D68", VA = "0xE76D68", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F57")]
		[Cpp2IlInjected.Address(RVA = "0xE76DC0", Offset = "0xE76DC0", VA = "0xE76DC0")]
		public WindyEnoughForKiteDrops()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E5")]
	public class RemixSeedEasymode : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F58")]
		[Cpp2IlInjected.Address(RVA = "0xE7664C", Offset = "0xE7664C", VA = "0xE7664C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F59")]
		[Cpp2IlInjected.Address(RVA = "0xE76704", Offset = "0xE76704", VA = "0xE76704", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5A")]
		[Cpp2IlInjected.Address(RVA = "0xE767BC", Offset = "0xE767BC", VA = "0xE767BC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5B")]
		[Cpp2IlInjected.Address(RVA = "0xE767C4", Offset = "0xE767C4", VA = "0xE767C4")]
		public RemixSeedEasymode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E6")]
	public class RemixSeedHardmode : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F5C")]
		[Cpp2IlInjected.Address(RVA = "0xE767CC", Offset = "0xE767CC", VA = "0xE767CC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5D")]
		[Cpp2IlInjected.Address(RVA = "0xE76884", Offset = "0xE76884", VA = "0xE76884", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5E")]
		[Cpp2IlInjected.Address(RVA = "0xE7693C", Offset = "0xE7693C", VA = "0xE7693C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F5F")]
		[Cpp2IlInjected.Address(RVA = "0xE76944", Offset = "0xE76944", VA = "0xE76944")]
		public RemixSeedHardmode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E7")]
	public class RemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F60")]
		[Cpp2IlInjected.Address(RVA = "0xE7654C", Offset = "0xE7654C", VA = "0xE7654C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F61")]
		[Cpp2IlInjected.Address(RVA = "0xE765C4", Offset = "0xE765C4", VA = "0xE765C4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F62")]
		[Cpp2IlInjected.Address(RVA = "0xE7663C", Offset = "0xE7663C", VA = "0xE7663C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F63")]
		[Cpp2IlInjected.Address(RVA = "0xE76644", Offset = "0xE76644", VA = "0xE76644")]
		public RemixSeed()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E8")]
	public class NotRemixSeed : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F64")]
		[Cpp2IlInjected.Address(RVA = "0xE75E6C", Offset = "0xE75E6C", VA = "0xE75E6C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F65")]
		[Cpp2IlInjected.Address(RVA = "0xE75EEC", Offset = "0xE75EEC", VA = "0xE75EEC", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F66")]
		[Cpp2IlInjected.Address(RVA = "0xE75F6C", Offset = "0xE75F6C", VA = "0xE75F6C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F67")]
		[Cpp2IlInjected.Address(RVA = "0xE75F74", Offset = "0xE75F74", VA = "0xE75F74")]
		public NotRemixSeed()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009E9")]
	public class TenthAnniversaryIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F68")]
		[Cpp2IlInjected.Address(RVA = "0xE76BEC", Offset = "0xE76BEC", VA = "0xE76BEC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F69")]
		[Cpp2IlInjected.Address(RVA = "0xE76C64", Offset = "0xE76C64", VA = "0xE76C64", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6A")]
		[Cpp2IlInjected.Address(RVA = "0xE76CDC", Offset = "0xE76CDC", VA = "0xE76CDC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6B")]
		[Cpp2IlInjected.Address(RVA = "0xE76CE4", Offset = "0xE76CE4", VA = "0xE76CE4")]
		public TenthAnniversaryIsUp()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009EA")]
	public class TenthAnniversaryIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F6C")]
		[Cpp2IlInjected.Address(RVA = "0xE76ADC", Offset = "0xE76ADC", VA = "0xE76ADC", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6D")]
		[Cpp2IlInjected.Address(RVA = "0xE76B5C", Offset = "0xE76B5C", VA = "0xE76B5C", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6E")]
		[Cpp2IlInjected.Address(RVA = "0xE76BDC", Offset = "0xE76BDC", VA = "0xE76BDC", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F6F")]
		[Cpp2IlInjected.Address(RVA = "0xE76BE4", Offset = "0xE76BE4", VA = "0xE76BE4")]
		public TenthAnniversaryIsNotUp()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009EB")]
	public class DontStarveIsUp : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F70")]
		[Cpp2IlInjected.Address(RVA = "0xE7365C", Offset = "0xE7365C", VA = "0xE7365C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F71")]
		[Cpp2IlInjected.Address(RVA = "0xE736D4", Offset = "0xE736D4", VA = "0xE736D4", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F72")]
		[Cpp2IlInjected.Address(RVA = "0xE7374C", Offset = "0xE7374C", VA = "0xE7374C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F73")]
		[Cpp2IlInjected.Address(RVA = "0xE73754", Offset = "0xE73754", VA = "0xE73754")]
		public DontStarveIsUp()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009EC")]
	public class DontStarveIsNotUp : IItemDropRuleCondition, IProvideItemConditionDescription
	{
		[Cpp2IlInjected.Token(Token = "0x6004F74")]
		[Cpp2IlInjected.Address(RVA = "0xE7354C", Offset = "0xE7354C", VA = "0xE7354C", Slot = "4")]
		public bool CanDrop(DropAttemptInfo info)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F75")]
		[Cpp2IlInjected.Address(RVA = "0xE735CC", Offset = "0xE735CC", VA = "0xE735CC", Slot = "5")]
		public bool CanShowItemDropInUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004F76")]
		[Cpp2IlInjected.Address(RVA = "0xE7364C", Offset = "0xE7364C", VA = "0xE7364C", Slot = "6")]
		public string GetConditionDescription()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004F77")]
		[Cpp2IlInjected.Address(RVA = "0xE73654", Offset = "0xE73654", VA = "0xE73654")]
		public DontStarveIsNotUp()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003D1C")]
	[Cpp2IlInjected.Address(RVA = "0xE72F08", Offset = "0xE72F08", VA = "0xE72F08")]
	public static bool SoulOfWhateverConditionCanDrop(DropAttemptInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D1D")]
	[Cpp2IlInjected.Address(RVA = "0xE730E8", Offset = "0xE730E8", VA = "0xE730E8")]
	public Conditions()
	{
	}
}
