using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001F0")]
public class Magnify_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C77")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE51C", Offset = "0x9CE51C", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C78")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE568", Offset = "0x9CE568", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public Magnify_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001202")]
	public static Magnify_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001203")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float WorldZoom;

	[global::Cpp2ILInjected.Token(Token = "0x4001204")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int BufferZone;

	[global::Cpp2ILInjected.Token(Token = "0x4001205")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Panel;
}
