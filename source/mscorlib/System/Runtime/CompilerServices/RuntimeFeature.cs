using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x200047C")]
	public static class RuntimeFeature
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700046E")]
		public static bool IsDynamicCodeSupported
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002222")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B735F4", Offset = "0x1B735F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeGenericType", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}
	}
}
