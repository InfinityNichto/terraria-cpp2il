using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000216")]
public class IntHashSet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40019F9")]
	private List<int> ValuesInSet;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public List<int> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000F16")]
		[Cpp2IlInjected.Address(RVA = "0x11707EC", Offset = "0x11707EC", VA = "0x11707EC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000F17")]
		[Cpp2IlInjected.Address(RVA = "0x11707F4", Offset = "0x11707F4", VA = "0x11707F4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000F1B")]
		[Cpp2IlInjected.Address(RVA = "0x117097C", Offset = "0x117097C", VA = "0x117097C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000F18")]
	[Cpp2IlInjected.Address(RVA = "0x11707FC", Offset = "0x11707FC", VA = "0x11707FC")]
	public void Add(int valueToAdd)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F19")]
	[Cpp2IlInjected.Address(RVA = "0x1170878", Offset = "0x1170878", VA = "0x1170878")]
	public bool Contains(int valueToCheck)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F1A")]
	[Cpp2IlInjected.Address(RVA = "0x1170920", Offset = "0x1170920", VA = "0x1170920")]
	public bool ContainsSet(int[] values)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000F1C")]
	[Cpp2IlInjected.Address(RVA = "0x11709C8", Offset = "0x11709C8", VA = "0x11709C8")]
	public IntHashSet()
	{
	}
}
