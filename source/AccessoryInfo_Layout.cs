using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200018C")]
public class AccessoryInfo_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B45")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB69C", Offset = "0x9AB69C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B46")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB6E8", Offset = "0x9AB6E8", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public AccessoryInfo_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000BEA")]
	public static AccessoryInfo_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000BEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout IconGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000BEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout IconGridSecondary;

	[global::Cpp2ILInjected.Token(Token = "0x4000BED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public String_Layout ItemText;

	[global::Cpp2ILInjected.Token(Token = "0x4000BEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public String_Layout DisabledItemText;

	[global::Cpp2ILInjected.Token(Token = "0x4000BEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public String_Layout CritterItemText;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color IconColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Color DisabledIconColour;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Vector2 BackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000BF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Vector2 BackingBROffset;
}
