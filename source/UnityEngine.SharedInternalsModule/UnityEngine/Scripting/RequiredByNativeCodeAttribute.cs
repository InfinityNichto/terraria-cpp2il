using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Scripting
{
	// Token: 0x02000009 RID: 9
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, Inherited = false)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	internal class RequiredByNativeCodeAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3AD4", Offset = "0x1FA3AD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RequiredByNativeCodeAttribute()
		{
			throw null;
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public bool Optional
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3ADC", Offset = "0x1FA3ADC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public bool GenerateProxy
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3AE8", Offset = "0x1FA3AE8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000005 RID: 5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <Optional>k__BackingField;

		// Token: 0x04000006 RID: 6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool <GenerateProxy>k__BackingField;
	}
}
