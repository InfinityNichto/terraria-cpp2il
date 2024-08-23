using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003CB RID: 971
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200047B")]
	[global::System.Serializable]
	public sealed class RuntimeCompatibilityAttribute : global::System.Attribute
	{
		// Token: 0x06001FC9 RID: 8137 RVA: 0x00019DFC File Offset: 0x00017FFC
		[global::Cpp2ILInjected.Token(Token = "0x6002220")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B735E0", Offset = "0x1B735E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeCompatibilityAttribute()
		{
			throw null;
		}

		// Token: 0x1700040B RID: 1035
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x00019DFF File Offset: 0x00017FFF
		[global::Cpp2ILInjected.Token(Token = "0x1700046D")]
		public bool WrapNonExceptionThrows
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002221")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B735E8", Offset = "0x1B735E8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000FB9 RID: 4025
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <WrapNonExceptionThrows>k__BackingField;
	}
}
