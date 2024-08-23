using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020000DE RID: 222
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	[Serializable]
	public class MessageEventArgs
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00002B45 File Offset: 0x00000D45
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F886D8", Offset = "0x1F886D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MessageEventArgs()
		{
			throw null;
		}

		// Token: 0x040003DD RID: 989
		[global::Cpp2ILInjected.Token(Token = "0x4000423")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int playerId;

		// Token: 0x040003DE RID: 990
		[global::Cpp2ILInjected.Token(Token = "0x4000424")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte[] data;
	}
}
