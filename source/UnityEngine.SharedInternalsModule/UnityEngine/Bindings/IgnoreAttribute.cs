using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Field)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	internal class IgnoreAttribute : Attribute
	{
		// Token: 0x17000017 RID: 23
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public bool DoesNotContributeToSize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600003A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA423C", Offset = "0x1FA423C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000020FE File Offset: 0x000002FE
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4248", Offset = "0x1FA4248", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public IgnoreAttribute()
		{
			throw null;
		}

		// Token: 0x04000025 RID: 37
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <DoesNotContributeToSize>k__BackingField;
	}
}
