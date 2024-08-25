using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x200015B")]
	[global::System.Serializable]
	internal class ReflectionOnlyType : global::System.RuntimeType
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C750C4", Offset = "0x1C750C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ReflectionOnlyType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		public override global::System.RuntimeTypeHandle TypeHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7511C", Offset = "0x1C7511C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}
	}
}
