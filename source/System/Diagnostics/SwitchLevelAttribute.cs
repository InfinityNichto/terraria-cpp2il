using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000072 RID: 114
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
	public sealed class SwitchLevelAttribute : Attribute
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x00003995 File Offset: 0x00001B95
		[global::Cpp2ILInjected.Token(Token = "0x600049B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC51C4", Offset = "0x1EC51C4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SwitchLevelAttribute(Type switchLevelType)
		{
			throw null;
		}

		// Token: 0x170000C1 RID: 193
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003998 File Offset: 0x00001B98
		[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
		public Type SwitchLevelType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EC51F0", Offset = "0x1EC51F0", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000252 RID: 594
		[global::Cpp2ILInjected.Token(Token = "0x4000393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type type;
	}
}
