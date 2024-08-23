using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x0200007E RID: 126
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200008B")]
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x06000271 RID: 625 RVA: 0x00002539 File Offset: 0x00000739
		[global::Cpp2ILInjected.Token(Token = "0x600027F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A40", Offset = "0x1F78A40", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TooltipAttribute(string tooltip)
		{
			throw null;
		}

		// Token: 0x040002F7 RID: 759
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string tooltip;
	}
}
