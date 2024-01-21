using Cpp2IlInjected;
using Terraria.Achievements;

namespace Terraria.Initializers;

[Cpp2IlInjected.Token(Token = "0x20003BC")]
public class AchievementInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6002F33")]
	[Cpp2IlInjected.Address(RVA = "0x12562F8", Offset = "0x12562F8", VA = "0x12562F8")]
	public static void Load()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F34")]
	[Cpp2IlInjected.Address(RVA = "0x125B290", Offset = "0x125B290", VA = "0x125B290")]
	private static void OnAchievementCompleted(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F35")]
	[Cpp2IlInjected.Address(RVA = "0x125B3D0", Offset = "0x125B3D0", VA = "0x125B3D0")]
	public AchievementInitializer()
	{
	}
}
