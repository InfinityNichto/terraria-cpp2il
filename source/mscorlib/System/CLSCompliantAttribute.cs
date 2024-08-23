using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200006D RID: 109
	[global::System.AttributeUsage(global::System.AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000094")]
	[global::System.Serializable]
	public sealed class CLSCompliantAttribute : global::System.Attribute
	{
		// Token: 0x060003CB RID: 971 RVA: 0x00015080 File Offset: 0x00013280
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBA088", Offset = "0x1BBA088", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public CLSCompliantAttribute(bool isCompliant)
		{
			throw null;
		}

		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _compliant;
	}
}
