using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Chat.Commands
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200079C")]
	public sealed class ChatCommandAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003FB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x749750", Offset = "0x749750", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ChatCommandAttribute(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007DCB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Name;
	}
}
