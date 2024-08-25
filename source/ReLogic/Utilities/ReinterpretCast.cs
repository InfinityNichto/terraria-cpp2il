using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B05")]
	public static class ReinterpretCast
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005283")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ECFC", Offset = "0x93ECFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float UIntAsFloat(uint value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005284")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED0C", Offset = "0x93ED0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float IntAsFloat(int value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005285")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED1C", Offset = "0x93ED1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint FloatAsUInt(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005286")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED2C", Offset = "0x93ED2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int FloatAsInt(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000B06")]
		[StructLayout(2)]
		private struct IntFloat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005287")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED14", Offset = "0x93ED14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public IntFloat(int value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005288")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED34", Offset = "0x93ED34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public IntFloat(float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008ACB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly int IntValue;

			[global::Cpp2ILInjected.Token(Token = "0x4008ACC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly float FloatValue;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000B07")]
		[StructLayout(2)]
		private struct UIntFloat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005289")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED04", Offset = "0x93ED04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public UIntFloat(uint value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600528A")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED24", Offset = "0x93ED24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public UIntFloat(float value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008ACD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly uint UIntValue;

			[global::Cpp2ILInjected.Token(Token = "0x4008ACE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly float FloatValue;
		}
	}
}
