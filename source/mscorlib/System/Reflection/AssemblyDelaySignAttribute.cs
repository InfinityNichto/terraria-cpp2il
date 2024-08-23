using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000402 RID: 1026
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004C0")]
	public sealed class AssemblyDelaySignAttribute : global::System.Attribute
	{
		// Token: 0x060020CA RID: 8394 RVA: 0x0001A0EA File Offset: 0x000182EA
		[global::Cpp2ILInjected.Token(Token = "0x6002362")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80688", Offset = "0x1B80688", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public AssemblyDelaySignAttribute(bool delaySign)
		{
			throw null;
		}

		// Token: 0x04001041 RID: 4161
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400135B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <DelaySign>k__BackingField;
	}
}
