using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200000D")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x3848F0", Offset = "0x3848F0")]
public struct DictionaryIntArray
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static List<int> keysToDecrement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private Dictionary<int, int> data;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int Item
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x441EDC", Offset = "0x441EDC", VA = "0x441EDC")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x441EE4", Offset = "0x441EE4", VA = "0x441EE4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x441EEC", Offset = "0x441EEC", VA = "0x441EEC")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x441EF8", Offset = "0x441EF8", VA = "0x441EF8")]
	public int EntryCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x441F00", Offset = "0x441F00", VA = "0x441F00")]
	public void DecrementEntries()
	{
	}
}
