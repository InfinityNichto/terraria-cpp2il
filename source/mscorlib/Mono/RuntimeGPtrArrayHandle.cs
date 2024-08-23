using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	internal struct RuntimeGPtrArrayHandle
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00014663 File Offset: 0x00012863
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB360", Offset = "0x1AAB360", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		internal unsafe RuntimeGPtrArrayHandle(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00014666 File Offset: 0x00012866
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		internal int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000057")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAB380", Offset = "0x1AAB380", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		internal global::System.IntPtr this[int i]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000058")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAB38C", Offset = "0x1AAB38C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0001466C File Offset: 0x0001286C
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB390", Offset = "0x1AAB390", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.IntPtr Lookup(int i)
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB3EC", Offset = "0x1AAB3EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void GPtrArrayFree(RuntimeStructs.GPtrArray* value);

		// Token: 0x06000035 RID: 53 RVA: 0x0001466F File Offset: 0x0001286F
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB3F0", Offset = "0x1AAB3F0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
		{
			throw null;
		}

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.GPtrArray* value;
	}
}
