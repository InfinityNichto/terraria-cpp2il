using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Modules/IMGUI/GUIContent.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	[Serializable]
	[StructLayout(0)]
	public class GUIContent
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002179 File Offset: 0x00000379
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000217C File Offset: 0x0000037C
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public string text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9B8E4", Offset = "0x1F9B8E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9B8EC", Offset = "0x1F9B8EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000217F File Offset: 0x0000037F
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public Texture image
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9B8F4", Offset = "0x1F9B8F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002182 File Offset: 0x00000382
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002185 File Offset: 0x00000385
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public string tooltip
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F974EC", Offset = "0x1F974EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9B8FC", Offset = "0x1F9B8FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002188 File Offset: 0x00000388
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B904", Offset = "0x1F9B904", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GUIContent()
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000218B File Offset: 0x0000038B
		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B960", Offset = "0x1F9B960", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIContent), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GUIContent(string text)
		{
			throw null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000218E File Offset: 0x0000038E
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B9C4", Offset = "0x1F9B9C4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GUIContent(string text, Texture image, string tooltip)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002191 File Offset: 0x00000391
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F959D8", Offset = "0x1F959D8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWordWrapSizer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(GUIContent),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GUIContent(GUIContent src)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002194 File Offset: 0x00000394
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F962AC", Offset = "0x1F962AC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "Label", MemberParameters = new object[]
		{
			typeof(string),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static GUIContent Temp(string t)
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002197 File Offset: 0x00000397
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B670", Offset = "0x1F9B670", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void ClearStaticCache()
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000219A File Offset: 0x0000039A
		[global::Cpp2ILInjected.Token(Token = "0x6000094")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BA48", Offset = "0x1F9BA48", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000219D File Offset: 0x0000039D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000095")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BA68", Offset = "0x1F9BA68", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static GUIContent()
		{
			throw null;
		}

		// Token: 0x04000065 RID: 101
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000069")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_Text;

		// Token: 0x04000066 RID: 102
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400006A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Texture m_Image;

		// Token: 0x04000067 RID: 103
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400006B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_Tooltip;

		// Token: 0x04000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		private static readonly GUIContent s_Text;

		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x400006D")]
		private static readonly GUIContent s_Image;

		// Token: 0x0400006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x400006E")]
		private static readonly GUIContent s_TextImage;

		// Token: 0x0400006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		public static GUIContent none;
	}
}
