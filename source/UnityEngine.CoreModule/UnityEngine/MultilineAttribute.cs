using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000082 RID: 130
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200008F")]
	public sealed class MultilineAttribute : PropertyAttribute
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00002548 File Offset: 0x00000748
		[global::Cpp2ILInjected.Token(Token = "0x6000284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78B04", Offset = "0x1F78B04", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MultilineAttribute()
		{
			throw null;
		}

		// Token: 0x040002FC RID: 764
		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int lines;
	}
}
