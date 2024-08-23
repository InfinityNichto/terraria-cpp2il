using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	internal struct RuntimeGenericParamInfoHandle
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0001463C File Offset: 0x0001283C
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAF80", Offset = "0x1AAAF80", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(global::System.Reflection.GenericParameterAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		internal unsafe RuntimeGenericParamInfoHandle(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0001463F File Offset: 0x0001283F
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		internal global::System.Type[] Constraints
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAAFA0", Offset = "0x1AAAFA0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(global::System.Type[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00014642 File Offset: 0x00012842
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		internal global::System.Reflection.GenericParameterAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x600004B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAB0DC", Offset = "0x1AAB0DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(global::System.Reflection.GenericParameterAttributes))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00014645 File Offset: 0x00012845
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAAFA4", Offset = "0x1AAAFA4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private global::System.Type[] GetConstraints()
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00014648 File Offset: 0x00012848
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB0E8", Offset = "0x1AAB0E8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int GetConstraintsCount()
		{
			throw null;
		}

		// Token: 0x0400000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x400008D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe RuntimeStructs.GenericParamInfo* value;
	}
}
