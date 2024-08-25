using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000619")]
	public struct BinaryWriterHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DADD8", Offset = "0x13DADD8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ReservePointToFillLengthLaterByFilling6Bytes(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DAE40", Offset = "0x13DAE40", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void FillReservedPoint(BinaryWriter writer, ushort dataId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DAF04", Offset = "0x13DAF04", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void FillOnlyIfThereIsLengthOrRevertToSavedPosition(BinaryWriter writer, ushort dataId, out bool wroteSomething)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007692")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private long _placeInWriter;
	}
}
