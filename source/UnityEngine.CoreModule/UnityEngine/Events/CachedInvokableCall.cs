using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	// Token: 0x0200013A RID: 314
	[global::Cpp2ILInjected.Token(Token = "0x2000162")]
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x06000662 RID: 1634 RVA: 0x00002EAE File Offset: 0x000010AE
		[global::Cpp2ILInjected.Token(Token = "0x600069E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB86C", Offset = "0x18EB86C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new object[] { typeof(UnityEventBase) }, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public CachedInvokableCall(Object target, MethodInfo theFunction, T argument)
		{
			throw null;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002EB1 File Offset: 0x000010B1
		[global::Cpp2ILInjected.Token(Token = "0x600069F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB8A4", Offset = "0x18EB8A4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002EB4 File Offset: 0x000010B4
		[global::Cpp2ILInjected.Token(Token = "0x60006A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB8BC", Offset = "0x18EB8BC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Invoke(T arg0)
		{
			throw null;
		}

		// Token: 0x040005FC RID: 1532
		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T m_Arg1;
	}
}
