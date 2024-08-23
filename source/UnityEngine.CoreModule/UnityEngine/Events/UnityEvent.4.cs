using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000147 RID: 327
	[global::Cpp2ILInjected.Token(Token = "0x200016F")]
	[Serializable]
	public class UnityEvent<T0, T1, T2, T3> : UnityEventBase
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x00002F3E File Offset: 0x0000113E
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60006D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897F84", Offset = "0x1897F84", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		public UnityEvent()
		{
			throw null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002F41 File Offset: 0x00001141
		[global::Cpp2ILInjected.Token(Token = "0x60006D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897F90", Offset = "0x1897F90", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			throw null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00002F44 File Offset: 0x00001144
		[global::Cpp2ILInjected.Token(Token = "0x60006DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1898110", Offset = "0x1898110", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x04000612 RID: 1554
		[global::Cpp2ILInjected.Token(Token = "0x4000669")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
