using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000475")]
public interface IConfigKeyHolder
{
	[Cpp2IlInjected.Token(Token = "0x17000627")]
	string NameKey
	{
		[Cpp2IlInjected.Token(Token = "0x600323B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000628")]
	string ConfigKey
	{
		[Cpp2IlInjected.Token(Token = "0x600323C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
