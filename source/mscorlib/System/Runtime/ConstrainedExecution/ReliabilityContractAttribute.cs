using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.ConstrainedExecution
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Interface, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200045F")]
	public sealed class ReliabilityContractAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60021ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72E70", Offset = "0x1B72E70", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		{
			throw null;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Consistency <ConsistencyGuarantee>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly Cer <Cer>k__BackingField;
	}
}
