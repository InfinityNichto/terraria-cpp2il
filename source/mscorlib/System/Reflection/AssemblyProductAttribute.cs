using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C6")]
	public sealed class AssemblyProductAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002367")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8079C", Offset = "0x1B8079C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyProductAttribute(string product)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001366")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Product>k__BackingField;
	}
}
