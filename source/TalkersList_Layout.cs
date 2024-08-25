using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000242")]
public class TalkersList_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D2B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D57A0", Offset = "0x9D57A0", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D2C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D57EC", Offset = "0x9D57EC", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public TalkersList_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001801")]
	public static TalkersList_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001802")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public ItemGrid_Layout IconGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001803")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout ItemText;

	[global::Cpp2ILInjected.Token(Token = "0x4001804")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001805")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Color IconColour;

	[global::Cpp2ILInjected.Token(Token = "0x4001806")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout Icon;

	[global::Cpp2ILInjected.Token(Token = "0x4001807")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001808")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 BackingTLOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001809")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Vector2 BackingBROffset;
}
