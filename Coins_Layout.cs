using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000126")]
public class Coins_Layout : PageControllerLayoutDefinition<Coins_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40009EC")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40009ED")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40009EE")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40009EF")]
	public ItemGrid_Layout CoinGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40009F0")]
	public float ItemScale_Collapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40009F1")]
	public float ItemHighlightScale_Collapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40009F2")]
	public ItemGrid_Layout CoinGrid_Collapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40009F3")]
	public AnimationCurve ItemDragPulseScale;

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x1205340", Offset = "0x1205340", VA = "0x1205340")]
	public Coins_Layout()
	{
	}
}
