using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000024")]
	[Serializable]
	public struct InputRange
	{
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986CCC", Offset = "0x1986CCC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private InputRange(float value0, float value1, InputRangeType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986CD8", Offset = "0x1986CD8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InputRange(InputRangeType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986D58", Offset = "0x1986D58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Includes(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986D90", Offset = "0x1986D90", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Excludes(float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x19865FC", Offset = "0x19865FC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlMapping), Member = "ApplyToValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool Excludes(InputRangeType rangeType, float value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986DC8", Offset = "0x1986DC8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputRange), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(InputRangeType),
			typeof(InputRangeType)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static float Remap(float value, InputRange sourceRange, InputRange targetRange)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984C1C", Offset = "0x1984C1C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceControl), Member = "GetValue", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputControlMapping), Member = "ApplyToValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputRange), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(InputRange),
			typeof(InputRange)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Remap(float value, InputRangeType sourceRangeType, InputRangeType targetRangeType)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986E50", Offset = "0x1986E50", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static InputRange()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		public static readonly InputRange None;

		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		public static readonly InputRange MinusOneToOne;

		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		public static readonly InputRange OneToMinusOne;

		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		public static readonly InputRange ZeroToOne;

		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		public static readonly InputRange ZeroToMinusOne;

		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		public static readonly InputRange OneToZero;

		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		public static readonly InputRange MinusOneToZero;

		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		private static readonly InputRange[] typeToRange;

		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float Value0;

		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float Value1;

		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly InputRangeType Type;
	}
}
