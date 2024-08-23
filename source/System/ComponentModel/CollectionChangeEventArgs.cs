using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000264 RID: 612
	[global::Cpp2ILInjected.Token(Token = "0x2000358")]
	public class CollectionChangeEventArgs : EventArgs
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x00006791 File Offset: 0x00004991
		[global::Cpp2ILInjected.Token(Token = "0x600165E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4069C", Offset = "0x1E4069C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CollectionChangeEventArgs(CollectionChangeAction action, object element)
		{
			throw null;
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00006794 File Offset: 0x00004994
		[global::Cpp2ILInjected.Token(Token = "0x1700051B")]
		public virtual CollectionChangeAction Action
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600165F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E40710", Offset = "0x1E40710", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x00006797 File Offset: 0x00004997
		[global::Cpp2ILInjected.Token(Token = "0x1700051C")]
		public virtual object Element
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001660")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E40718", Offset = "0x1E40718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000DD9 RID: 3545
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly CollectionChangeAction <Action>k__BackingField;

		// Token: 0x04000DDA RID: 3546
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object <Element>k__BackingField;
	}
}
