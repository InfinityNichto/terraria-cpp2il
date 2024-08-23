using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000014")]
	[Serializable]
	public sealed class GUISettings
	{
		// Token: 0x06000093 RID: 147 RVA: 0x000021A3 File Offset: 0x000003A3
		[global::Cpp2ILInjected.Token(Token = "0x6000097")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BC08", Offset = "0x1F9BC08", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GUISettings()
		{
			throw null;
		}

		// Token: 0x0400007C RID: 124
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_DoubleClickSelectsWord;

		// Token: 0x0400007D RID: 125
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool m_TripleClickSelectsLine;

		// Token: 0x0400007E RID: 126
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private Color m_CursorColor;

		// Token: 0x0400007F RID: 127
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float m_CursorFlashSpeed;

		// Token: 0x04000080 RID: 128
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Color m_SelectionColor;
	}
}
