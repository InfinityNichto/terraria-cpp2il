using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000223")]
public class WorldGenerateMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CD9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0914", Offset = "0x9D0914", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CDA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0960", Offset = "0x9D0960", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public WorldGenerateMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001551")]
	public static WorldGenerateMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001552")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x4001553")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ProgressBar_Layout Progress;

	[global::Cpp2ILInjected.Token(Token = "0x4001554")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ProgressBar_Layout StageProgress;

	[global::Cpp2ILInjected.Token(Token = "0x4001555")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout BackingCorrupt;

	[global::Cpp2ILInjected.Token(Token = "0x4001556")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Texture_Layout BackingCrimson;

	[global::Cpp2ILInjected.Token(Token = "0x4001557")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Color FillingColorCorrupt;

	[global::Cpp2ILInjected.Token(Token = "0x4001558")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public Color FillingColorCrimson;

	[global::Cpp2ILInjected.Token(Token = "0x4001559")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout GameTip;
}
