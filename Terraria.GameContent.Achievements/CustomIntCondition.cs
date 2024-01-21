using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000655")]
public class CustomIntCondition : AchievementCondition
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CA9")]
	[JsonProperty]
	private int _value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CAA")]
	private int _maxValue;

	[Cpp2IlInjected.Token(Token = "0x17000779")]
	public int Value
	{
		[Cpp2IlInjected.Token(Token = "0x6003F90")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F28", Offset = "0xFA9F28", VA = "0xFA9F28")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F91")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F30", Offset = "0xFA9F30", VA = "0xFA9F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F92")]
	[Cpp2IlInjected.Address(RVA = "0xFAA098", Offset = "0xFAA098", VA = "0xFAA098")]
	private CustomIntCondition(string name, int maxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F93")]
	[Cpp2IlInjected.Address(RVA = "0xFAA0C0", Offset = "0xFAA0C0", VA = "0xFAA0C0", Slot = "6")]
	public override void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F94")]
	[Cpp2IlInjected.Address(RVA = "0xFAA0D0", Offset = "0xFAA0D0", VA = "0xFAA0D0", Slot = "4")]
	public override void Load(JObject state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F95")]
	[Cpp2IlInjected.Address(RVA = "0xFAA230", Offset = "0xFAA230", VA = "0xFAA230", Slot = "8")]
	protected override IAchievementTracker CreateAchievementTracker()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F96")]
	[Cpp2IlInjected.Address(RVA = "0xFAA2A0", Offset = "0xFAA2A0", VA = "0xFAA2A0")]
	public static AchievementCondition Create(string name, int maxValue)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F97")]
	[Cpp2IlInjected.Address(RVA = "0xFAA31C", Offset = "0xFAA31C", VA = "0xFAA31C", Slot = "7")]
	public override void Complete()
	{
	}
}
