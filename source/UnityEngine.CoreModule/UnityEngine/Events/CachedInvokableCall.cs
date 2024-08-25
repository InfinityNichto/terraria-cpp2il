using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Events
{
	[global::Cpp2ILInjected.Token(Token = "0x2000162")]
	internal class CachedInvokableCall<T> : InvokableCall<T>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600069F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB8A4", Offset = "0x18EB8A4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Invoke(object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB8BC", Offset = "0x18EB8BC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Invoke(T arg0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000653")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T m_Arg1;
	}
}
