using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200013D")]
	internal class MonoLimitationAttribute : global::System.MonoTODOAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C2E4", Offset = "0x1C5C2E4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoLimitationAttribute(string comment)
		{
			throw null;
		}
	}
}
