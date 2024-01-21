using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000046")]
public class CachedFile
{
	[Cpp2IlInjected.Token(Token = "0x200077E")]
	public enum Modifications
	{
		[Cpp2IlInjected.Token(Token = "0x40078C6")]
		Delete,
		[Cpp2IlInjected.Token(Token = "0x40078C7")]
		Write,
		[Cpp2IlInjected.Token(Token = "0x40078C8")]
		None
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Modifications ModificationFlag;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public readonly string Filename;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public byte[] Data
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1204B28", Offset = "0x1204B28", VA = "0x1204B28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1204B30", Offset = "0x1204B30", VA = "0x1204B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1203E78", Offset = "0x1203E78", VA = "0x1203E78")]
	public CachedFile(string filename)
	{
	}
}
