using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x0200007F RID: 127
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200008C")]
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x06000272 RID: 626 RVA: 0x0000253C File Offset: 0x0000073C
		[global::Cpp2ILInjected.Token(Token = "0x6000280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A68", Offset = "0x1F78A68", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SpaceAttribute()
		{
			throw null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000253F File Offset: 0x0000073F
		[global::Cpp2ILInjected.Token(Token = "0x6000281")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A88", Offset = "0x1F78A88", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SpaceAttribute(float height)
		{
			throw null;
		}

		// Token: 0x040002F8 RID: 760
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly float height;
	}
}
