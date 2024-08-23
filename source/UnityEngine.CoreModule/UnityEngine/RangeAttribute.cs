using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000081 RID: 129
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200008E")]
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x06000275 RID: 629 RVA: 0x00002545 File Offset: 0x00000745
		[global::Cpp2ILInjected.Token(Token = "0x6000283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78AD8", Offset = "0x1F78AD8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RangeAttribute(float min, float max)
		{
			throw null;
		}

		// Token: 0x040002FA RID: 762
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly float min;

		// Token: 0x040002FB RID: 763
		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly float max;
	}
}
