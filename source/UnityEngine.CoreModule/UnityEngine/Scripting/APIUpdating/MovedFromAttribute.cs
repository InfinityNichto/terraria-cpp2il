using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020000E1 RID: 225
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
	[global::Cpp2ILInjected.Token(Token = "0x2000101")]
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x06000521 RID: 1313 RVA: 0x00002B4E File Offset: 0x00000D4E
		[global::Cpp2ILInjected.Token(Token = "0x6000550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89F28", Offset = "0x1F89F28", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MovedFromAttribute(string sourceNamespace)
		{
			throw null;
		}

		// Token: 0x040003E6 RID: 998
		[global::Cpp2ILInjected.Token(Token = "0x400042C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal MovedFromAttributeData data;
	}
}
