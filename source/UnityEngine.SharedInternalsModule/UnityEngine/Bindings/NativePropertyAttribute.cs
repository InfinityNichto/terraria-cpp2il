using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Property)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	internal class NativePropertyAttribute : NativeMethodAttribute
	{
		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000020B3 File Offset: 0x000002B3
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public TargetType TargetType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000022")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA3F14", Offset = "0x1FA3F14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B6 File Offset: 0x000002B6
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3F1C", Offset = "0x1FA3F1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NativePropertyAttribute()
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3F24", Offset = "0x1FA3F24", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public NativePropertyAttribute(string name)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020BC File Offset: 0x000002BC
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA3F28", Offset = "0x1FA3F28", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethodAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public NativePropertyAttribute(string name, bool isFree, TargetType targetType)
		{
			throw null;
		}

		// Token: 0x04000014 RID: 20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private TargetType <TargetType>k__BackingField;
	}
}
