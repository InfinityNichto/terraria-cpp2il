using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000634")]
	public struct ItemSyncPersistentStats
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40076EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color color;

		[global::Cpp2ILInjected.Token(Token = "0x40076EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int type;
	}
}
