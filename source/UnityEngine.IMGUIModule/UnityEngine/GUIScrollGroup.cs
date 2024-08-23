using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x000022A5 File Offset: 0x000004A5
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9FD64", Offset = "0x1F9FD64", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GUIScrollGroup()
		{
			throw null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000022A8 File Offset: 0x000004A8
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9FDC0", Offset = "0x1F9FDC0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		public override void CalcWidth()
		{
			throw null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000022AB File Offset: 0x000004AB
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9FE3C", Offset = "0x1F9FE3C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_width", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetHorizontal(float x, float width)
		{
			throw null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000022AE File Offset: 0x000004AE
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9FF50", Offset = "0x1F9FF50", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void CalcHeight()
		{
			throw null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000022B1 File Offset: 0x000004B1
		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA003C", Offset = "0x1FA003C", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_width", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_height", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void SetVertical(float y, float height)
		{
			throw null;
		}

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public float calcMinWidth;

		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public float calcMaxWidth;

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public float calcMinHeight;

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public float calcMaxHeight;

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public float clientWidth;

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		public float clientHeight;

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public bool allowHorizontalScroll;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		public bool allowVerticalScroll;

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAA")]
		public bool needsHorizontalScrollbar;

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAB")]
		public bool needsVerticalScrollbar;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public GUIStyle horizontalScrollbar;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public GUIStyle verticalScrollbar;
	}
}
