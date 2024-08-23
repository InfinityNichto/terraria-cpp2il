using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public class TextEditor
	{
		// Token: 0x06000092 RID: 146 RVA: 0x000021A0 File Offset: 0x000003A0
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BB24", Offset = "0x1F9BB24", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TextEditor()
		{
			throw null;
		}

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TouchScreenKeyboard keyboardOnScreen;

		// Token: 0x0400006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int controlID;

		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GUIStyle style;

		// Token: 0x0400006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool multiline;

		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		public bool hasHorizontalCursorPos;

		// Token: 0x04000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		public bool isPasswordField;

		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector2 scrollOffset;

		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private GUIContent m_Content;

		// Token: 0x04000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int m_CursorIndex;

		// Token: 0x04000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int m_SelectIndex;

		// Token: 0x04000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool m_RevealCursor;

		// Token: 0x04000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool m_MouseDragSelectsWholeWords;

		// Token: 0x04000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int m_DblClickInitPos;

		// Token: 0x04000079 RID: 121
		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private TextEditor.DblClickSnapping m_DblClickSnap;

		// Token: 0x0400007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		private bool m_bJustSelected;

		// Token: 0x0400007B RID: 123
		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int m_iAltCursorPos;

		// Token: 0x0200002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		public enum DblClickSnapping : byte
		{
			// Token: 0x040000F1 RID: 241
			[global::Cpp2ILInjected.Token(Token = "0x4000081")]
			WORDS,
			// Token: 0x040000F2 RID: 242
			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			PARAGRAPHS
		}
	}
}
