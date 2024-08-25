using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public class TextEditor
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TouchScreenKeyboard keyboardOnScreen;

		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int controlID;

		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GUIStyle style;

		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool multiline;

		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		public bool hasHorizontalCursorPos;

		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		public bool isPasswordField;

		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public Vector2 scrollOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private GUIContent m_Content;

		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int m_CursorIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int m_SelectIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool m_RevealCursor;

		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool m_MouseDragSelectsWholeWords;

		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int m_DblClickInitPos;

		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private TextEditor.DblClickSnapping m_DblClickSnap;

		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		private bool m_bJustSelected;

		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int m_iAltCursorPos;

		[global::Cpp2ILInjected.Token(Token = "0x2000013")]
		public enum DblClickSnapping : byte
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000081")]
			WORDS,
			[global::Cpp2ILInjected.Token(Token = "0x4000082")]
			PARAGRAPHS
		}
	}
}
