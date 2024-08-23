using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x2000058")]
	internal static class Misc
	{
		// Token: 0x06000302 RID: 770 RVA: 0x000028FF File Offset: 0x00000AFF
		[global::Cpp2ILInjected.Token(Token = "0x600035C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCFB98", Offset = "0x1FCFB98", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Destroy(Object obj)
		{
			throw null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002902 File Offset: 0x00000B02
		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCFC90", Offset = "0x1FCFC90", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StencilMaterial), Member = "ClearAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DestroyImmediate(Object obj)
		{
			throw null;
		}
	}
}
