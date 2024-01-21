using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000616")]
public struct BestiaryUnlockProgressReport
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006C3B")]
	public int EntriesTotal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006C3C")]
	public float CompletionAmountTotal;

	[Cpp2IlInjected.Token(Token = "0x17000765")]
	public float CompletionPercent
	{
		[Cpp2IlInjected.Token(Token = "0x6003E77")]
		[Cpp2IlInjected.Address(RVA = "0x39CC4C", Offset = "0x39CC4C", VA = "0x39CC4C")]
		get
		{
			return default(float);
		}
	}
}
