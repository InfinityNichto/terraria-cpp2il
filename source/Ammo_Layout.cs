using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000119")]
public class Ammo_Layout : PageControllerLayoutDefinition<Ammo_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400090E")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400090F")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000910")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000911")]
	public ItemGrid_Layout AmmoGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000912")]
	public float ItemScale_Collapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000913")]
	public float ItemHighlightScale_Collapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000914")]
	public ItemGrid_Layout AmmoGrid_Collapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000915")]
	public AnimationCurve ItemDragPulseScale;

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x11FD250", Offset = "0x11FD250", VA = "0x11FD250")]
	public Ammo_Layout()
	{
	}
}
