using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000653")]
public class CustomFlagCondition : AchievementCondition
{
	[Cpp2IlInjected.Token(Token = "0x6003F86")]
	[Cpp2IlInjected.Address(RVA = "0xFA999C", Offset = "0xFA999C", VA = "0xFA999C")]
	private CustomFlagCondition(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F87")]
	[Cpp2IlInjected.Address(RVA = "0xFA99A4", Offset = "0xFA99A4", VA = "0xFA99A4")]
	public static AchievementCondition Create(string name)
	{
		return null;
	}
}
