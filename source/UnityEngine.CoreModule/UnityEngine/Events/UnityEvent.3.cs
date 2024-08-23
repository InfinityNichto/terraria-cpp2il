using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Events
{
	// Token: 0x02000145 RID: 325
	[global::Cpp2ILInjected.Token(Token = "0x200016D")]
	[Serializable]
	public class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x06000697 RID: 1687 RVA: 0x00002F35 File Offset: 0x00001135
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60006D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897DCC", Offset = "0x1897DCC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = ".ctor", ReturnType = typeof(void))]
		public UnityEvent()
		{
			throw null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002F38 File Offset: 0x00001138
		[global::Cpp2ILInjected.Token(Token = "0x60006D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897DD8", Offset = "0x1897DD8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			throw null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002F3B File Offset: 0x0000113B
		[global::Cpp2ILInjected.Token(Token = "0x60006D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1897F24", Offset = "0x1897F24", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
		{
			throw null;
		}

		// Token: 0x04000611 RID: 1553
		[global::Cpp2ILInjected.Token(Token = "0x4000668")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object[] m_InvokeArray;
	}
}
