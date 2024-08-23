using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Utilities
{
	// Token: 0x02000710 RID: 1808
	[global::Cpp2ILInjected.Token(Token = "0x2000B05")]
	public static class ReinterpretCast
	{
		// Token: 0x060045E7 RID: 17895 RVA: 0x0002E829 File Offset: 0x0002CA29
		[global::Cpp2ILInjected.Token(Token = "0x6005283")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ECFC", Offset = "0x93ECFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float UIntAsFloat(uint value)
		{
			throw null;
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x0002E82C File Offset: 0x0002CA2C
		[global::Cpp2ILInjected.Token(Token = "0x6005284")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED0C", Offset = "0x93ED0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float IntAsFloat(int value)
		{
			throw null;
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x0002E82F File Offset: 0x0002CA2F
		[global::Cpp2ILInjected.Token(Token = "0x6005285")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED1C", Offset = "0x93ED1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint FloatAsUInt(float value)
		{
			throw null;
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0002E832 File Offset: 0x0002CA32
		[global::Cpp2ILInjected.Token(Token = "0x6005286")]
		[global::Cpp2ILInjected.Address(RVA = "0x93ED2C", Offset = "0x93ED2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int FloatAsInt(float value)
		{
			throw null;
		}

		// Token: 0x02000AD1 RID: 2769
		[global::Cpp2ILInjected.Token(Token = "0x2000B06")]
		[StructLayout(2)]
		private struct IntFloat
		{
			// Token: 0x060052C8 RID: 21192 RVA: 0x0003099E File Offset: 0x0002EB9E
			[global::Cpp2ILInjected.Token(Token = "0x6005287")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED14", Offset = "0x93ED14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public IntFloat(int value)
			{
				throw null;
			}

			// Token: 0x060052C9 RID: 21193 RVA: 0x000309A1 File Offset: 0x0002EBA1
			[global::Cpp2ILInjected.Token(Token = "0x6005288")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED34", Offset = "0x93ED34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public IntFloat(float value)
			{
				throw null;
			}

			// Token: 0x04008F8A RID: 36746
			[global::Cpp2ILInjected.Token(Token = "0x4008ACB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly int IntValue;

			// Token: 0x04008F8B RID: 36747
			[global::Cpp2ILInjected.Token(Token = "0x4008ACC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly float FloatValue;
		}

		// Token: 0x02000AD2 RID: 2770
		[global::Cpp2ILInjected.Token(Token = "0x2000B07")]
		[StructLayout(2)]
		private struct UIntFloat
		{
			// Token: 0x060052CA RID: 21194 RVA: 0x000309A4 File Offset: 0x0002EBA4
			[global::Cpp2ILInjected.Token(Token = "0x6005289")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED04", Offset = "0x93ED04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public UIntFloat(uint value)
			{
				throw null;
			}

			// Token: 0x060052CB RID: 21195 RVA: 0x000309A7 File Offset: 0x0002EBA7
			[global::Cpp2ILInjected.Token(Token = "0x600528A")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ED24", Offset = "0x93ED24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public UIntFloat(float value)
			{
				throw null;
			}

			// Token: 0x04008F8C RID: 36748
			[global::Cpp2ILInjected.Token(Token = "0x4008ACD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly uint UIntValue;

			// Token: 0x04008F8D RID: 36749
			[global::Cpp2ILInjected.Token(Token = "0x4008ACE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			[global::System.Runtime.InteropServices.FieldOffset(0)]
			public readonly float FloatValue;
		}
	}
}
