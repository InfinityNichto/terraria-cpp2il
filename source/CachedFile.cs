using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000069")]
public class CachedFile
{
	[global::Cpp2ILInjected.Token(Token = "0x6000233")]
	[global::Cpp2ILInjected.Address(RVA = "0x70D388", Offset = "0x70D388", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public CachedFile(string filename)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000074")]
	public byte[] Data
	{
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x70D3B8", Offset = "0x70D3B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x70D3C0", Offset = "0x70D3C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000205")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public CachedFile.Modifications ModificationFlag;

	[global::Cpp2ILInjected.Token(Token = "0x4000206")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public readonly string Filename;

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x4000207")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private byte[] <Data>k__BackingField;

	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	public enum Modifications
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		Delete,
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		Write,
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		None
	}
}
