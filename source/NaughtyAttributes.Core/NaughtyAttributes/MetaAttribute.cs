using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x0200001D RID: 29
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public abstract class MetaAttribute : NaughtyAttribute
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002149 File Offset: 0x00000349
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000214C File Offset: 0x0000034C
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public int Order
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000054")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5948", Offset = "0x1CB5948", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000055")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB5950", Offset = "0x1CB5950", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000214F File Offset: 0x0000034F
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB590C", Offset = "0x1CB590C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected MetaAttribute()
		{
			throw null;
		}

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <Order>k__BackingField;
	}
}
