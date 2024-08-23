using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngineInternal
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public class GenericStack : Stack
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69E04", Offset = "0x1F69E04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUI", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutUtility.LayoutCache", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
		public GenericStack()
		{
			throw null;
		}
	}
}
