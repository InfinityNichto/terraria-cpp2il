using Cpp2IlInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.Achievements;

namespace Terraria.GameContent.Achievements;

[Cpp2IlInjected.Token(Token = "0x2000654")]
public class CustomFloatCondition : AchievementCondition
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006CA7")]
	[JsonProperty]
	private float _value;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006CA8")]
	private float _maxValue;

	[Cpp2IlInjected.Token(Token = "0x17000778")]
	public float Value
	{
		[Cpp2IlInjected.Token(Token = "0x6003F88")]
		[Cpp2IlInjected.Address(RVA = "0xFA9A10", Offset = "0xFA9A10", VA = "0xFA9A10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6003F89")]
		[Cpp2IlInjected.Address(RVA = "0xFA9A18", Offset = "0xFA9A18", VA = "0xFA9A18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003F8A")]
	[Cpp2IlInjected.Address(RVA = "0xFA9B94", Offset = "0xFA9B94", VA = "0xFA9B94")]
	private CustomFloatCondition(string name, float maxValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F8B")]
	[Cpp2IlInjected.Address(RVA = "0xFA9BBC", Offset = "0xFA9BBC", VA = "0xFA9BBC", Slot = "6")]
	public override void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F8C")]
	[Cpp2IlInjected.Address(RVA = "0xFA9BCC", Offset = "0xFA9BCC", VA = "0xFA9BCC", Slot = "4")]
	public override void Load(JObject state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F8D")]
	[Cpp2IlInjected.Address(RVA = "0xFA9D2C", Offset = "0xFA9D2C", VA = "0xFA9D2C", Slot = "8")]
	protected override IAchievementTracker CreateAchievementTracker()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F8E")]
	[Cpp2IlInjected.Address(RVA = "0xFA9D9C", Offset = "0xFA9D9C", VA = "0xFA9D9C")]
	public static AchievementCondition Create(string name, float maxValue)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F8F")]
	[Cpp2IlInjected.Address(RVA = "0xFA9E20", Offset = "0xFA9E20", VA = "0xFA9E20", Slot = "7")]
	public override void Complete()
	{
	}
}
