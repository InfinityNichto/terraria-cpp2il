using System;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	internal static class AsyncHelper
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C4A0", Offset = "0x1D5C4A0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { "TResult" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static AsyncHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		public static readonly Task DoneTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		public static readonly Task<bool> DoneTaskTrue;

		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		public static readonly Task<bool> DoneTaskFalse;

		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		public static readonly Task<int> DoneTaskZero;
	}
}
