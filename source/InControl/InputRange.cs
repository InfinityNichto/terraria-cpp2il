using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000023 RID: 35
	[global::Cpp2ILInjected.Token(Token = "0x2000024")]
	[Serializable]
	public struct InputRange
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00002492 File Offset: 0x00000692
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986CCC", Offset = "0x1986CCC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private InputRange(float value0, float value1, InputRangeType type)
		{
			throw null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002495 File Offset: 0x00000695
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986CD8", Offset = "0x1986CD8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public InputRange(InputRangeType type)
		{
			throw null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002498 File Offset: 0x00000698
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986D58", Offset = "0x1986D58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Includes(float value)
		{
			throw null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000249B File Offset: 0x0000069B
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986D90", Offset = "0x1986D90", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Excludes(float value)
		{
			throw null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000249E File Offset: 0x0000069E
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

		// Token: 0x06000171 RID: 369 RVA: 0x000024A1 File Offset: 0x000006A1
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

		// Token: 0x06000172 RID: 370 RVA: 0x000024A4 File Offset: 0x000006A4
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

		// Token: 0x06000173 RID: 371 RVA: 0x000024A7 File Offset: 0x000006A7
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

		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		public static readonly InputRange None;

		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		public static readonly InputRange MinusOneToOne;

		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		public static readonly InputRange OneToMinusOne;

		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		public static readonly InputRange ZeroToOne;

		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		public static readonly InputRange ZeroToMinusOne;

		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		public static readonly InputRange OneToZero;

		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		public static readonly InputRange MinusOneToZero;

		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		private static readonly InputRange[] typeToRange;

		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float Value0;

		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float Value1;

		// Token: 0x040001C5 RID: 453
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly InputRangeType Type;
	}
}
