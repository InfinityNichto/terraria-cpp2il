using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000083 RID: 131
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000090")]
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x06000277 RID: 631 RVA: 0x0000254B File Offset: 0x0000074B
		[global::Cpp2ILInjected.Token(Token = "0x6000285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78B24", Offset = "0x1F78B24", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TextAreaAttribute()
		{
			throw null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000254E File Offset: 0x0000074E
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78B44", Offset = "0x1F78B44", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TextAreaAttribute(int minLines, int maxLines)
		{
			throw null;
		}

		// Token: 0x040002FD RID: 765
		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int minLines;

		// Token: 0x040002FE RID: 766
		[global::Cpp2ILInjected.Token(Token = "0x4000329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly int maxLines;
	}
}
