using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Testing.ChatCommands;

[Cpp2IlInjected.Token(Token = "0x2000381")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x385040", Offset = "0x385040")]
public class ArgumentListResult : IEnumerable<string>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x40031A5")]
	public static readonly ArgumentListResult Empty;

	[Cpp2IlInjected.Token(Token = "0x40031A6")]
	public static readonly ArgumentListResult Invalid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031A7")]
	public readonly bool IsValid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031A8")]
	private readonly List<string> _results;

	[Cpp2IlInjected.Token(Token = "0x170005AC")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6002D3A")]
		[Cpp2IlInjected.Address(RVA = "0x14E9250", Offset = "0x14E9250", VA = "0x14E9250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005AD")]
	public string Item
	{
		[Cpp2IlInjected.Token(Token = "0x6002D3B")]
		[Cpp2IlInjected.Address(RVA = "0x14E929C", Offset = "0x14E929C", VA = "0x14E929C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002D3C")]
	[Cpp2IlInjected.Address(RVA = "0x14E9148", Offset = "0x14E9148", VA = "0x14E9148")]
	public ArgumentListResult(IEnumerable<string> results)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D3D")]
	[Cpp2IlInjected.Address(RVA = "0x14E9308", Offset = "0x14E9308", VA = "0x14E9308")]
	private ArgumentListResult(bool isValid)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D3E")]
	[Cpp2IlInjected.Address(RVA = "0x14E9394", Offset = "0x14E9394", VA = "0x14E9394", Slot = "4")]
	public IEnumerator<string> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D3F")]
	[Cpp2IlInjected.Address(RVA = "0x14E9420", Offset = "0x14E9420", VA = "0x14E9420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
