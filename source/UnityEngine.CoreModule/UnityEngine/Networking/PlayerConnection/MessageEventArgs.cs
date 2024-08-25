using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Networking.PlayerConnection
{
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	[Serializable]
	public class MessageEventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F886D8", Offset = "0x1F886D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MessageEventArgs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000423")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int playerId;

		[global::Cpp2ILInjected.Token(Token = "0x4000424")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte[] data;
	}
}
