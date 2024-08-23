using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	internal class RectangularVertexClipper
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002125 File Offset: 0x00000325
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA842C", Offset = "0x1FA842C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = "get_canvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "InverseTransformPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Rect GetCanvasRect(RectTransform t, Canvas c)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002128 File Offset: 0x00000328
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA854C", Offset = "0x1FA854C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectMask2D), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public RectangularVertexClipper()
		{
			throw null;
		}

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Vector3[] m_WorldCorners;

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Vector3[] m_CanvasCorners;
	}
}
