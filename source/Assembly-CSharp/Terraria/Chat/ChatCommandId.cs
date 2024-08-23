using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Chat.Commands;

namespace Terraria.Chat
{
	// Token: 0x0200052B RID: 1323
	[global::Cpp2ILInjected.Token(Token = "0x2000797")]
	public struct ChatCommandId
	{
		// Token: 0x060038E9 RID: 14569 RVA: 0x0002C297 File Offset: 0x0002A497
		[global::Cpp2ILInjected.Token(Token = "0x6003F91")]
		[global::Cpp2ILInjected.Address(RVA = "0x748B9C", Offset = "0x748B9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private ChatCommandId(string name)
		{
			throw null;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x0002C29A File Offset: 0x0002A49A
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

		// Token: 0x060038EB RID: 14571 RVA: 0x0002C29D File Offset: 0x0002A49D
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

		// Token: 0x060038EC RID: 14572 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		[global::Cpp2ILInjected.Token(Token = "0x6003F94")]
		[global::Cpp2ILInjected.Address(RVA = "0x748C10", Offset = "0x748C10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static ChatCommandId Deserialize(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x0002C2A3 File Offset: 0x0002A4A3
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

		// Token: 0x04006891 RID: 26769
		[global::Cpp2ILInjected.Token(Token = "0x4007DC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;
	}
}
