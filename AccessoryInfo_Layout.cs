using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000115")]
public class AccessoryInfo_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40008D1")]
	public static AccessoryInfo_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40008D2")]
	public ItemGrid_Layout IconGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40008D3")]
	public ItemGrid_Layout IconGridSecondary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40008D4")]
	public String_Layout ItemText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40008D5")]
	public String_Layout DisabledItemText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40008D6")]
	public String_Layout CritterItemText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40008D7")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40008D8")]
	public Color IconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40008D9")]
	public Color DisabledIconColour;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40008DA")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40008DB")]
	public Vector2 BackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40008DC")]
	public Vector2 BackingBROffset;

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x11FC188", Offset = "0x11FC188", VA = "0x11FC188")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x11FC1E4", Offset = "0x11FC1E4", VA = "0x11FC1E4")]
	public AccessoryInfo_Layout()
	{
	}
}
