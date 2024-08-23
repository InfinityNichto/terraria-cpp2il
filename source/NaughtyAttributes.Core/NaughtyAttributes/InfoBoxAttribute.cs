using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200001B RID: 27
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	public class InfoBoxAttribute : MetaAttribute
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002131 File Offset: 0x00000331
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002134 File Offset: 0x00000334
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public string Text
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600004C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB589C", Offset = "0x1CB589C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600004D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB58A4", Offset = "0x1CB58A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002137 File Offset: 0x00000337
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000213A File Offset: 0x0000033A
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public InfoBoxType Type
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600004E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB58AC", Offset = "0x1CB58AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600004F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB58B4", Offset = "0x1CB58B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000213D File Offset: 0x0000033D
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002140 File Offset: 0x00000340
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public string VisibleIf
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000050")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB58BC", Offset = "0x1CB58BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000051")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB58C4", Offset = "0x1CB58C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002143 File Offset: 0x00000343
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB58CC", Offset = "0x1CB58CC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InfoBoxAttribute(string text, InfoBoxType type = InfoBoxType.Normal, string visibleIf = null)
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002146 File Offset: 0x00000346
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB5914", Offset = "0x1CB5914", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InfoBoxAttribute(string text, string visibleIf)
		{
			throw null;
		}

		// Token: 0x04000025 RID: 37
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Text>k__BackingField;

		// Token: 0x04000026 RID: 38
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private InfoBoxType <Type>k__BackingField;

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string <VisibleIf>k__BackingField;
	}
}
