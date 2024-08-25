using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x2000213")]
	public static class Volatile
	{
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA34F8", Offset = "0x1CA34F8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool Read(ref bool location)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3510", Offset = "0x1CA3510", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int Read(ref int location)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3528", Offset = "0x1CA3528", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Write(ref int location, int value)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A44FC", Offset = "0x15A44FC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static T Read<T>(ref T location) where T : class
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x60012CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4514", Offset = "0x15A4514", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Write<T>(ref T location, T value) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000214")]
		private struct VolatileBoolean
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000A18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool Value;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000215")]
		private struct VolatileInt32
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000A19")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Value;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000216")]
		private struct VolatileObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000A1A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public object Value;
		}
	}
}
