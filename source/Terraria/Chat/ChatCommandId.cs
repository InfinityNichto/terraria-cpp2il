using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Chat.Commands;

namespace Terraria.Chat
{
	[global::Cpp2ILInjected.Token(Token = "0x2000797")]
	public struct ChatCommandId
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003F91")]
		[global::Cpp2ILInjected.Address(RVA = "0x748B9C", Offset = "0x748B9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private ChatCommandId(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F92")]
		[global::Cpp2ILInjected.Address(RVA = "0x157675C", Offset = "0x157675C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatMessage), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static ChatCommandId FromType<T>() where T : IChatCommand
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F93")]
		[global::Cpp2ILInjected.Address(RVA = "0x748BA4", Offset = "0x748BA4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatMessage), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F94")]
		[global::Cpp2ILInjected.Address(RVA = "0x748C10", Offset = "0x748C10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static ChatCommandId Deserialize(BinaryReader reader)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F95")]
		[global::Cpp2ILInjected.Address(RVA = "0x748C20", Offset = "0x748C20", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatMessage), Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int GetMaxSerializedSize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007DC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;
	}
}
