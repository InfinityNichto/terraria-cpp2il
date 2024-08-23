using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.ConstrainedExecution
{
	// Token: 0x020003B2 RID: 946
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Interface, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200045F")]
	public sealed class ReliabilityContractAttribute : global::System.Attribute
	{
		// Token: 0x06001FA4 RID: 8100 RVA: 0x00019D9C File Offset: 0x00017F9C
		[global::Cpp2ILInjected.Token(Token = "0x60021ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72E70", Offset = "0x1B72E70", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
		{
			throw null;
		}

		// Token: 0x04000FA9 RID: 4009
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Consistency <ConsistencyGuarantee>k__BackingField;

		// Token: 0x04000FAA RID: 4010
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly Cer <Cer>k__BackingField;
	}
}
