using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004BF")]
	public sealed class AssemblyDefaultAliasAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80660", Offset = "0x1B80660", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyDefaultAliasAttribute(string defaultAlias)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <DefaultAlias>k__BackingField;
	}
}
