using System;
using System.Collections;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000036 RID: 54
	[global::Cpp2ILInjected.Token(Token = "0x2000080")]
	[Serializable]
	internal class InvariantComparer : IComparer
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00003215 File Offset: 0x00001415
		[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2310", Offset = "0x1EA2310", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InvariantComparer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal InvariantComparer()
		{
			throw null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00003218 File Offset: 0x00001418
		[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2384", Offset = "0x1EA2384", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Compare(object a, object b)
		{
			throw null;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000321B File Offset: 0x0000141B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA2464", Offset = "0x1EA2464", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvariantComparer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static InvariantComparer()
		{
			throw null;
		}

		// Token: 0x0400009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private CompareInfo m_compareInfo;

		// Token: 0x0400009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		internal static readonly InvariantComparer Default;
	}
}
