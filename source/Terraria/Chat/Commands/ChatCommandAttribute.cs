using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Chat.Commands
{
	// Token: 0x0200052F RID: 1327
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200079C")]
	public sealed class ChatCommandAttribute : Attribute
	{
		// Token: 0x06003907 RID: 14599 RVA: 0x0002C2EB File Offset: 0x0002A4EB
		[global::Cpp2ILInjected.Token(Token = "0x6003FB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x749750", Offset = "0x749750", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ChatCommandAttribute(string name)
		{
			throw null;
		}

		// Token: 0x04006899 RID: 26777
		[global::Cpp2ILInjected.Token(Token = "0x4007DCB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Name;
	}
}
