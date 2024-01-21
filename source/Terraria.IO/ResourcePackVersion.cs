using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003CD")]
[Cpp2IlInjected.Attribute(Name = "DebuggerDisplayAttribute", RVA = "0x3850D4", Offset = "0x3850D4")]
public struct ResourcePackVersion : IComparable, IComparable<ResourcePackVersion>
{
	[Cpp2IlInjected.Token(Token = "0x170005FE")]
	[JsonProperty]
	public int Major
	{
		[Cpp2IlInjected.Token(Token = "0x6002FC0")]
		[Cpp2IlInjected.Address(RVA = "0x39A108", Offset = "0x39A108", VA = "0x39A108")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002FC1")]
		[Cpp2IlInjected.Address(RVA = "0x39A110", Offset = "0x39A110", VA = "0x39A110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005FF")]
	[JsonProperty]
	public int Minor
	{
		[Cpp2IlInjected.Token(Token = "0x6002FC2")]
		[Cpp2IlInjected.Address(RVA = "0x39A118", Offset = "0x39A118", VA = "0x39A118")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002FC3")]
		[Cpp2IlInjected.Address(RVA = "0x39A120", Offset = "0x39A120", VA = "0x39A120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002FC4")]
	[Cpp2IlInjected.Address(RVA = "0x39A128", Offset = "0x39A128", VA = "0x39A128", Slot = "4")]
	public int CompareTo(object obj)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FC5")]
	[Cpp2IlInjected.Address(RVA = "0x39A130", Offset = "0x39A130", VA = "0x39A130", Slot = "5")]
	public int CompareTo(ResourcePackVersion other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FC6")]
	[Cpp2IlInjected.Address(RVA = "0xE481D0", Offset = "0xE481D0", VA = "0xE481D0")]
	public static bool operator ==(ResourcePackVersion lhs, ResourcePackVersion rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FC7")]
	[Cpp2IlInjected.Address(RVA = "0xE481FC", Offset = "0xE481FC", VA = "0xE481FC")]
	public static bool operator !=(ResourcePackVersion lhs, ResourcePackVersion rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FC8")]
	[Cpp2IlInjected.Address(RVA = "0xE48228", Offset = "0xE48228", VA = "0xE48228")]
	public static bool operator <(ResourcePackVersion lhs, ResourcePackVersion rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FC9")]
	[Cpp2IlInjected.Address(RVA = "0xE48250", Offset = "0xE48250", VA = "0xE48250")]
	public static bool operator >(ResourcePackVersion lhs, ResourcePackVersion rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FCA")]
	[Cpp2IlInjected.Address(RVA = "0x39A138", Offset = "0x39A138", VA = "0x39A138", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FCB")]
	[Cpp2IlInjected.Address(RVA = "0x39A140", Offset = "0x39A140", VA = "0x39A140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FCC")]
	[Cpp2IlInjected.Address(RVA = "0x39A174", Offset = "0x39A174", VA = "0x39A174")]
	public string GetFormattedVersion()
	{
		return null;
	}
}
