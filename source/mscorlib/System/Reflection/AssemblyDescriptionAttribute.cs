using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C1")]
	public sealed class AssemblyDescriptionAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002363")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B806B0", Offset = "0x1B806B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyDescriptionAttribute(string description)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Description>k__BackingField;
	}
}
