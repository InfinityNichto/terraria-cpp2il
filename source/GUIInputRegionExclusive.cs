using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x200017C")]
public class GUIInputRegionExclusive
{
	[global::Cpp2ILInjected.Token(Token = "0x6000ACB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0EB0", Offset = "0x9A0EB0", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUIInputRegionExclusive(GUIInputRegionExclusive.IsOverHandler handler)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000ACC")]
	[global::Cpp2ILInjected.Address(RVA = "0x9A0ED8", Offset = "0x9A0ED8", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInputRegionManager), Member = "IsOverExclusiveRegion", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	public bool Over(int x, int y)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000B29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public readonly GUIInputRegionExclusive.IsOverHandler isOver;

	[global::Cpp2ILInjected.Token(Token = "0x4000B2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool Active;

	[global::Cpp2ILInjected.Token(Token = "0x200017D")]
	public delegate bool IsOverHandler(Vector2 cursorPosition);
}
