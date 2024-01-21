using Cpp2IlInjected;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000495")]
public class ConditionIntTracker : AchievementTracker<int>
{
	[Cpp2IlInjected.Token(Token = "0x600336F")]
	[Cpp2IlInjected.Address(RVA = "0x106D33C", Offset = "0x106D33C", VA = "0x106D33C")]
	public ConditionIntTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003370")]
	[Cpp2IlInjected.Address(RVA = "0x106D39C", Offset = "0x106D39C", VA = "0x106D39C")]
	public ConditionIntTracker(int maxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003371")]
	[Cpp2IlInjected.Address(RVA = "0x106D404", Offset = "0x106D404", VA = "0x106D404", Slot = "8")]
	public override void ReportUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003372")]
	[Cpp2IlInjected.Address(RVA = "0x106D4D8", Offset = "0x106D4D8", VA = "0x106D4D8", Slot = "9")]
	protected override void Load()
	{
	}
}
