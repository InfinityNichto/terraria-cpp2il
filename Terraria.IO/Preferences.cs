using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003CB")]
public class Preferences
{
	[Cpp2IlInjected.Token(Token = "0x20008F3")]
	public delegate void TextProcessAction(ref string text);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003298")]
	private Dictionary<string, object> _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003299")]
	private readonly string _path;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400329A")]
	private readonly JsonSerializerSettings _serializerSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400329B")]
	public readonly bool UseBson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400329C")]
	private readonly object _lock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400329D")]
	public bool AutoSave;

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event Action<Preferences> OnSave
	{
		[Cpp2IlInjected.Token(Token = "0x6002F9C")]
		[Cpp2IlInjected.Address(RVA = "0xE45AD0", Offset = "0xE45AD0", VA = "0xE45AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002F9D")]
		[Cpp2IlInjected.Address(RVA = "0xE45B80", Offset = "0xE45B80", VA = "0xE45B80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event Action<Preferences> OnLoad
	{
		[Cpp2IlInjected.Token(Token = "0x6002F9E")]
		[Cpp2IlInjected.Address(RVA = "0xE45C30", Offset = "0xE45C30", VA = "0xE45C30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002F9F")]
		[Cpp2IlInjected.Address(RVA = "0xE45CE0", Offset = "0xE45CE0", VA = "0xE45CE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event TextProcessAction OnProcessText
	{
		[Cpp2IlInjected.Token(Token = "0x6002FA0")]
		[Cpp2IlInjected.Address(RVA = "0xE45D90", Offset = "0xE45D90", VA = "0xE45D90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6002FA1")]
		[Cpp2IlInjected.Address(RVA = "0xE45E40", Offset = "0xE45E40", VA = "0xE45E40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA2")]
	[Cpp2IlInjected.Address(RVA = "0xE45EF0", Offset = "0xE45EF0", VA = "0xE45EF0")]
	public Preferences(string path, bool parseAllTypes = false, bool useBson = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA3")]
	[Cpp2IlInjected.Address(RVA = "0xE46008", Offset = "0xE46008", VA = "0xE46008")]
	public bool Load()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA4")]
	[Cpp2IlInjected.Address(RVA = "0xE4669C", Offset = "0xE4669C", VA = "0xE4669C")]
	public bool Save(bool canCreateFile = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA5")]
	[Cpp2IlInjected.Address(RVA = "0xE46E00", Offset = "0xE46E00", VA = "0xE46E00")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA6")]
	[Cpp2IlInjected.Address(RVA = "0xE46E5C", Offset = "0xE46E5C", VA = "0xE46E5C")]
	public void Put(string name, object value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA7")]
	[Cpp2IlInjected.Address(RVA = "0xE46F58", Offset = "0xE46F58", VA = "0xE46F58")]
	public bool Contains(string name)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA8")]
	[Cpp2IlInjected.Address(RVA = "0x15F0428", Offset = "0x15F0428", VA = "0x15F0428")]
	public T Get<T>(string name, T defaultValue)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002FA9")]
	[Cpp2IlInjected.Address(RVA = "0x15A618C", Offset = "0x15A618C", VA = "0x15A618C")]
	public void Get<T>(string name, ref T currentValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FAA")]
	[Cpp2IlInjected.Address(RVA = "0xE47038", Offset = "0xE47038", VA = "0xE47038")]
	public List<string> GetAllKeys()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002FAB")]
	[Cpp2IlInjected.Address(RVA = "0xE470A8", Offset = "0xE470A8", VA = "0xE470A8")]
	public void Clear(string name)
	{
	}
}
