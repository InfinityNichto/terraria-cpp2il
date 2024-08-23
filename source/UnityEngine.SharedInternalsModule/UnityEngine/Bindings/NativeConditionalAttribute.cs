using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000B RID: 11
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	internal class NativeConditionalAttribute : Attribute
	{
		// Token: 0x17000005 RID: 5
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public string Condition
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000010")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3B04", Offset = "0x1FA3B04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public bool Enabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000011")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3B0C", Offset = "0x1FA3B0C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3B18", Offset = "0x1FA3B18", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativeConditionalAttribute(string condition)
		{
			throw null;
		}

		// Token: 0x04000007 RID: 7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Condition>k__BackingField;

		// Token: 0x04000008 RID: 8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <Enabled>k__BackingField;
	}
}
