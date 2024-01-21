using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000496")]
public class ConditionsCompletedTracker : ConditionIntTracker
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006537")]
	private List<AchievementCondition> _conditions;

	[Cpp2IlInjected.Token(Token = "0x6003373")]
	[Cpp2IlInjected.Address(RVA = "0x106AA40", Offset = "0x106AA40", VA = "0x106AA40")]
	public void AddCondition(AchievementCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003374")]
	[Cpp2IlInjected.Address(RVA = "0x106D4DC", Offset = "0x106D4DC", VA = "0x106D4DC")]
	private void OnConditionCompleted(AchievementCondition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003375")]
	[Cpp2IlInjected.Address(RVA = "0x106D584", Offset = "0x106D584", VA = "0x106D584", Slot = "9")]
	protected override void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003376")]
	[Cpp2IlInjected.Address(RVA = "0x106A9C0", Offset = "0x106A9C0", VA = "0x106A9C0")]
	public ConditionsCompletedTracker()
	{
	}
}
