using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InterfaceMovement
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public class Button : MonoBehaviour
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000020F8 File Offset: 0x000002F8
		[global::Cpp2ILInjected.Token(Token = "0x6000039")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F2F0", Offset = "0x198F2F0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F340", Offset = "0x198F340", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "get_material", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000020FE File Offset: 0x000002FE
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x198F488", Offset = "0x198F488", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		public Button()
		{
			throw null;
		}

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Renderer cachedRenderer;

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Button up;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x4000024")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Button down;

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x4000025")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Button left;

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x4000026")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Button right;
	}
}
