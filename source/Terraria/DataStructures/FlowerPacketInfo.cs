using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.ID;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200062A")]
	public class FlowerPacketInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003604")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC5E8", Offset = "0x13DC5E8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public FlowerPacketInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<int> stylesOnPurity;

		[global::Cpp2ILInjected.Token(Token = "0x40076D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public List<int> stylesOnCorruption;

		[global::Cpp2ILInjected.Token(Token = "0x40076D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public List<int> stylesOnCrimson;

		[global::Cpp2ILInjected.Token(Token = "0x40076D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public List<int> stylesOnHallow;
	}
}
