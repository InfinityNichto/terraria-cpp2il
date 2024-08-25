using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C0")]
	public sealed class AssemblyDelaySignAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002362")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80688", Offset = "0x1B80688", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyDelaySignAttribute(bool delaySign)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <DelaySign>k__BackingField;
	}
}
