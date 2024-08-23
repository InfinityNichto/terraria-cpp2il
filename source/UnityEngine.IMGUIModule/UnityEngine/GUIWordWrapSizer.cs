using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	internal sealed class GUIWordWrapSizer : GUILayoutEntry
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95904", Offset = "0x1F95904", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new object[] { typeof(GUIContent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GUIWordWrapSizer(GUIStyle style, GUIContent content, GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95A54", Offset = "0x1F95A54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_CalcMinMaxWidth", MemberParameters = new object[] { typeof(GUIContent) }, ReturnType = typeof(Vector2))]
		public override void CalcWidth()
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95AD4", Offset = "0x1F95AD4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void CalcHeight()
		{
			throw null;
		}

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly GUIContent m_Content;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly float m_ForcedMinHeight;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private readonly float m_ForcedMaxHeight;
	}
}
