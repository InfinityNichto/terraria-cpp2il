using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly)]
	[global::Cpp2ILInjected.Token(Token = "0x2000498")]
	[global::System.Serializable]
	public sealed class DefaultDependencyAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75884", Offset = "0x1B75884", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultDependencyAttribute(LoadHint loadHintArgument)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private LoadHint loadHint;
	}
}
