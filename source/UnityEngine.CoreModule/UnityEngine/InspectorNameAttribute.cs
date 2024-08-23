using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200008A")]
	public class InspectorNameAttribute : PropertyAttribute
	{
		// Token: 0x06000270 RID: 624 RVA: 0x00002536 File Offset: 0x00000736
		[global::Cpp2ILInjected.Token(Token = "0x600027E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A18", Offset = "0x1F78A18", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InspectorNameAttribute(string displayName)
		{
			throw null;
		}

		// Token: 0x040002F6 RID: 758
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string displayName;
	}
}
