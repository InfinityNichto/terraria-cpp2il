using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace ReLogic.Reflection;

[Cpp2IlInjected.Token(Token = "0x2000723")]
public class IdDictionary
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007175")]
	private readonly Dictionary<string, int> _nameToId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007176")]
	private Dictionary<int, string> _idToName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007177")]
	public readonly int Count;

	[Cpp2IlInjected.Token(Token = "0x170007F5")]
	public IEnumerable<string> Names
	{
		[Cpp2IlInjected.Token(Token = "0x60046C2")]
		[Cpp2IlInjected.Address(RVA = "0xF92CF8", Offset = "0xF92CF8", VA = "0xF92CF8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60046C3")]
	[Cpp2IlInjected.Address(RVA = "0xF92D54", Offset = "0xF92D54", VA = "0xF92D54")]
	private IdDictionary(int count)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046C4")]
	[Cpp2IlInjected.Address(RVA = "0xF92DE0", Offset = "0xF92DE0", VA = "0xF92DE0")]
	public bool TryGetName(int id, out string name)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046C5")]
	[Cpp2IlInjected.Address(RVA = "0xF92E4C", Offset = "0xF92E4C", VA = "0xF92E4C")]
	public bool TryGetId(string name, out int id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046C6")]
	[Cpp2IlInjected.Address(RVA = "0xF92EB8", Offset = "0xF92EB8", VA = "0xF92EB8")]
	public bool ContainsName(string name)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046C7")]
	[Cpp2IlInjected.Address(RVA = "0xF92F1C", Offset = "0xF92F1C", VA = "0xF92F1C")]
	public bool ContainsId(int id)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60046C8")]
	[Cpp2IlInjected.Address(RVA = "0xF92F80", Offset = "0xF92F80", VA = "0xF92F80")]
	public string GetName(int id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046C9")]
	[Cpp2IlInjected.Address(RVA = "0xF92FE4", Offset = "0xF92FE4", VA = "0xF92FE4")]
	public int GetId(string name)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60046CA")]
	[Cpp2IlInjected.Address(RVA = "0xF93048", Offset = "0xF93048", VA = "0xF93048")]
	public void Add(string name, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046CB")]
	[Cpp2IlInjected.Address(RVA = "0xF930D4", Offset = "0xF930D4", VA = "0xF930D4")]
	public void Remove(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046CC")]
	[Cpp2IlInjected.Address(RVA = "0xF93174", Offset = "0xF93174", VA = "0xF93174")]
	public void Remove(int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046CD")]
	[Cpp2IlInjected.Address(RVA = "0xF93214", Offset = "0xF93214", VA = "0xF93214")]
	public static IdDictionary Create(Type idClass, Type idType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046CE")]
	[Cpp2IlInjected.Address(RVA = "0x166B754", Offset = "0x166B754", VA = "0x166B754")]
	public static IdDictionary Create<IdClass, IdType>()
	{
		return null;
	}
}
