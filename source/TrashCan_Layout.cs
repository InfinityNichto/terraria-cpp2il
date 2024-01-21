using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001B5")]
public class TrashCan_Layout : PageControllerLayoutDefinition<TrashCan_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400135E")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400135F")]
	public ItemGrid_Layout TrashGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001360")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001361")]
	public Color BackingColour;

	[Cpp2IlInjected.Token(Token = "0x6000C26")]
	[Cpp2IlInjected.Address(RVA = "0x10D28E4", Offset = "0x10D28E4", VA = "0x10D28E4")]
	public TrashCan_Layout()
	{
	}
}
