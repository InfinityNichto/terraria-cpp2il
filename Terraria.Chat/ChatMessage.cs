using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Terraria.Chat.Commands;

namespace Terraria.Chat;

[Cpp2IlInjected.Token(Token = "0x2000530")]
public sealed class ChatMessage
{
	[Cpp2IlInjected.Token(Token = "0x1700071A")]
	public ChatCommandId CommandId
	{
		[Cpp2IlInjected.Token(Token = "0x6003933")]
		[Cpp2IlInjected.Address(RVA = "0x11CCFBC", Offset = "0x11CCFBC", VA = "0x11CCFBC")]
		[CompilerGenerated]
		get
		{
			return default(ChatCommandId);
		}
		[Cpp2IlInjected.Token(Token = "0x6003934")]
		[Cpp2IlInjected.Address(RVA = "0x11CCFC4", Offset = "0x11CCFC4", VA = "0x11CCFC4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700071B")]
	public string Text
	{
		[Cpp2IlInjected.Token(Token = "0x6003935")]
		[Cpp2IlInjected.Address(RVA = "0x11CCFCC", Offset = "0x11CCFCC", VA = "0x11CCFCC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6003936")]
		[Cpp2IlInjected.Address(RVA = "0x11CCFD4", Offset = "0x11CCFD4", VA = "0x11CCFD4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700071C")]
	public bool IsConsumed
	{
		[Cpp2IlInjected.Token(Token = "0x6003937")]
		[Cpp2IlInjected.Address(RVA = "0x11CCFDC", Offset = "0x11CCFDC", VA = "0x11CCFDC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6003938")]
		[Cpp2IlInjected.Address(RVA = "0x11CCFE4", Offset = "0x11CCFE4", VA = "0x11CCFE4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003939")]
	[Cpp2IlInjected.Address(RVA = "0x11CB684", Offset = "0x11CB684", VA = "0x11CB684")]
	public ChatMessage(string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600393A")]
	[Cpp2IlInjected.Address(RVA = "0x11CCFEC", Offset = "0x11CCFEC", VA = "0x11CCFEC")]
	private ChatMessage(string message, ChatCommandId commandId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600393B")]
	[Cpp2IlInjected.Address(RVA = "0x11CD014", Offset = "0x11CD014", VA = "0x11CD014")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600393C")]
	[Cpp2IlInjected.Address(RVA = "0x11CD0F4", Offset = "0x11CD0F4", VA = "0x11CD0F4")]
	public int GetMaxSerializedSize()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600393D")]
	[Cpp2IlInjected.Address(RVA = "0x11CD1DC", Offset = "0x11CD1DC", VA = "0x11CD1DC")]
	public static ChatMessage Deserialize(BinaryReader reader)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600393E")]
	[Cpp2IlInjected.Address(RVA = "0x11CB6FC", Offset = "0x11CB6FC", VA = "0x11CB6FC")]
	public void SetCommand(ChatCommandId commandId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600393F")]
	[Cpp2IlInjected.Address(RVA = "0x15A573C", Offset = "0x15A573C", VA = "0x15A573C")]
	public void SetCommand<T>() where T : IChatCommand
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003940")]
	[Cpp2IlInjected.Address(RVA = "0x11CB910", Offset = "0x11CB910", VA = "0x11CB910")]
	public void Consume()
	{
	}
}
