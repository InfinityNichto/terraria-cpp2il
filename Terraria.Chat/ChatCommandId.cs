using System.IO;
using Cpp2IlInjected;
using Terraria.Chat.Commands;

namespace Terraria.Chat;

[Cpp2IlInjected.Token(Token = "0x200052E")]
public struct ChatCommandId
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006892")]
	private readonly string _name;

	[Cpp2IlInjected.Token(Token = "0x6003925")]
	[Cpp2IlInjected.Address(RVA = "0x39D4EC", Offset = "0x39D4EC", VA = "0x39D4EC")]
	private ChatCommandId(string name)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003926")]
	[Cpp2IlInjected.Address(RVA = "0x206E4F4", Offset = "0x206E4F4", VA = "0x206E4F4")]
	public static ChatCommandId FromType<T>() where T : IChatCommand
	{
		return default(ChatCommandId);
	}

	[Cpp2IlInjected.Token(Token = "0x6003927")]
	[Cpp2IlInjected.Address(RVA = "0x39D4F4", Offset = "0x39D4F4", VA = "0x39D4F4")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003928")]
	[Cpp2IlInjected.Address(RVA = "0x11CB104", Offset = "0x11CB104", VA = "0x11CB104")]
	public static ChatCommandId Deserialize(BinaryReader reader)
	{
		return default(ChatCommandId);
	}

	[Cpp2IlInjected.Token(Token = "0x6003929")]
	[Cpp2IlInjected.Address(RVA = "0x39D4FC", Offset = "0x39D4FC", VA = "0x39D4FC")]
	public int GetMaxSerializedSize()
	{
		return default(int);
	}
}
