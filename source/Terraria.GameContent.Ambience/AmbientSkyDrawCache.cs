using Cpp2IlInjected;

namespace Terraria.GameContent.Ambience;

[Cpp2IlInjected.Token(Token = "0x200070D")]
public class AmbientSkyDrawCache
{
	[Cpp2IlInjected.Token(Token = "0x2000AC1")]
	public struct UnderworldCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F4B")]
		public float Scale;
	}

	[Cpp2IlInjected.Token(Token = "0x2000AC2")]
	public struct OceanLineCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F4C")]
		public float YScreenPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008F4D")]
		public float OceanOpacity;
	}

	[Cpp2IlInjected.Token(Token = "0x400712C")]
	public static AmbientSkyDrawCache Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400712D")]
	public UnderworldCache[] Underworld;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400712E")]
	public OceanLineCache OceanLineInfo;

	[Cpp2IlInjected.Token(Token = "0x6004606")]
	[Cpp2IlInjected.Address(RVA = "0xFAFF1C", Offset = "0xFAFF1C", VA = "0xFAFF1C")]
	public void SetUnderworldInfo(int drawIndex, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004607")]
	[Cpp2IlInjected.Address(RVA = "0xFAFF2C", Offset = "0xFAFF2C", VA = "0xFAFF2C")]
	public void SetOceanLineInfo(float yScreenPosition, float oceanOpacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004608")]
	[Cpp2IlInjected.Address(RVA = "0xFAFF38", Offset = "0xFAFF38", VA = "0xFAFF38")]
	public AmbientSkyDrawCache()
	{
	}
}
