using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C3")]
	public sealed class AssemblyInformationalVersionAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002365")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8074C", Offset = "0x1B8074C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyInformationalVersionAttribute(string informationalVersion)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <InformationalVersion>k__BackingField;
	}
}
