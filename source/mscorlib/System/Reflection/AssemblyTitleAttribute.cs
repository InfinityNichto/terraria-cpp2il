using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C7")]
	public sealed class AssemblyTitleAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B807C4", Offset = "0x1B807C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyTitleAttribute(string title)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001367")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Title>k__BackingField;
	}
}
