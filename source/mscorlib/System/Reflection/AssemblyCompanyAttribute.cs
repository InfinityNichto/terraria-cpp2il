using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004BB")]
	public sealed class AssemblyCompanyAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600235E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B805E8", Offset = "0x1B805E8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyCompanyAttribute(string company)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001354")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Company>k__BackingField;
	}
}
