using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000439 RID: 1081
	[global::Cpp2ILInjected.Token(Token = "0x2000634")]
	public struct ItemSyncPersistentStats
	{
		// Token: 0x0600310D RID: 12557 RVA: 0x0002AC59 File Offset: 0x00028E59
		[global::Cpp2ILInjected.Token(Token = "0x600362A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCBA4", Offset = "0x13DCBA4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void CopyFrom(Item item)
		{
			throw null;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x0002AC5C File Offset: 0x00028E5C
		[global::Cpp2ILInjected.Token(Token = "0x600362B")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCBB8", Offset = "0x13DCBB8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PasteInto(Item item)
		{
			throw null;
		}

		// Token: 0x04006300 RID: 25344
		[global::Cpp2ILInjected.Token(Token = "0x40076EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color color;

		// Token: 0x04006301 RID: 25345
		[global::Cpp2ILInjected.Token(Token = "0x40076EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int type;
	}
}
