using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000174")]
public class Logo_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E5C")]
	public static Logo_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E5D")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E5E")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E5F")]
	public Vector2 Location;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000E60")]
	public float Scale;

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x12DF7C4", Offset = "0x12DF7C4", VA = "0x12DF7C4")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B98")]
	[Cpp2IlInjected.Address(RVA = "0x12DF820", Offset = "0x12DF820", VA = "0x12DF820")]
	public Logo_Layout()
	{
	}
}
