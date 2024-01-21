using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20001B4")]
public class TalkersList_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001355")]
	public static TalkersList_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001356")]
	public ItemGrid_Layout IconGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001357")]
	public String_Layout ItemText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001358")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001359")]
	public Color IconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400135A")]
	public Texture_Layout Icon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400135B")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400135C")]
	public Vector2 BackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400135D")]
	public Vector2 BackingBROffset;

	[Cpp2IlInjected.Token(Token = "0x6000C24")]
	[Cpp2IlInjected.Address(RVA = "0x1064088", Offset = "0x1064088", VA = "0x1064088")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C25")]
	[Cpp2IlInjected.Address(RVA = "0x10640E4", Offset = "0x10640E4", VA = "0x10640E4")]
	public TalkersList_Layout()
	{
	}
}
