using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x20001DA")]
[Serializable]
public class EmptyHousingSlot
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C17")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6DA8", Offset = "0x9B6DA8", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public EmptyHousingSlot()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001106")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Color BackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001107")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public Color ItemColor;

	[global::Cpp2ILInjected.Token(Token = "0x4001108")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout HeadTexture;
}
