using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000018 RID: 24
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("IMGUIScriptingClasses.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyle
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F6 RID: 246
		// (set) Token: 0x060000F7 RID: 247
		[NativeProperty("Name", false, TargetType.Function)]
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		internal extern string rawName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA04AC", Offset = "0x1FA04AC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA04E8", Offset = "0x1FA04E8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F8 RID: 248
		[NativeProperty("m_ImagePosition", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		public extern ImagePosition imagePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA052C", Offset = "0x1FA052C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F9 RID: 249
		[NativeProperty("m_WordWrap", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public extern bool wordWrap
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA0568", Offset = "0x1FA0568", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FA RID: 250
		[NativeProperty("m_FixedWidth", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		public extern float fixedWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000100")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F94F7C", Offset = "0x1F94F7C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000FB RID: 251
		[NativeProperty("m_FixedHeight", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		public extern float fixedHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000101")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F94FF4", Offset = "0x1F94FF4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000FC RID: 252
		[NativeProperty("m_StretchWidth", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public extern bool stretchWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000102")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F94FB8", Offset = "0x1F94FB8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000FD RID: 253
		// (set) Token: 0x060000FE RID: 254
		[NativeProperty("m_StretchHeight", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public extern bool stretchHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000103")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F95030", Offset = "0x1F95030", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000104")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9D668", Offset = "0x1F9D668", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x060000FF RID: 255
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA05A4", Offset = "0x1FA05A4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create(GUIStyle self);

		// Token: 0x06000100 RID: 256
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA05E0", Offset = "0x1FA05E0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr self);

		// Token: 0x06000101 RID: 257
		[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA061C", Offset = "0x1FA061C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern IntPtr GetStyleStatePtr(int idx);

		// Token: 0x06000102 RID: 258
		[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0660", Offset = "0x1FA0660", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern IntPtr GetRectOffsetPtr(int idx);

		// Token: 0x06000103 RID: 259 RVA: 0x000022C3 File Offset: 0x000004C3
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA06A4", Offset = "0x1FA06A4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			throw null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000022C6 File Offset: 0x000004C6
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA07B4", Offset = "0x1FA07B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
			throw null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000022C9 File Offset: 0x000004C9
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0894", Offset = "0x1FA0894", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "CalcSizeWithConstraints", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			throw null;
		}

		// Token: 0x06000106 RID: 262
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0954", Offset = "0x1FA0954", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern float Internal_CalcHeight(GUIContent content, float width);

		// Token: 0x06000107 RID: 263 RVA: 0x000022CC File Offset: 0x000004CC
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA09A8", Offset = "0x1FA09A8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWordWrapSizer), Member = "CalcWidth", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "CalcMinMaxWidth", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			throw null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000022CF File Offset: 0x000004CF
		[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97578", Offset = "0x1F97578", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265
		[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9753C", Offset = "0x1F9753C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool IsTooltipActive(string tooltip);

		// Token: 0x0600010A RID: 266
		[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C5D8", Offset = "0x1F9C5D8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void SetDefaultFont(Font font);

		// Token: 0x0600010B RID: 267 RVA: 0x000022D2 File Offset: 0x000004D2
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C870", Offset = "0x1F9C870", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "get_error", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public GUIStyle()
		{
			throw null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000022D5 File Offset: 0x000004D5
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0A9C", Offset = "0x1FA0A9C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000022D8 File Offset: 0x000004D8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000022DB File Offset: 0x000004DB
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public string name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000113")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F95838", Offset = "0x1F95838", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000114")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9C8F8", Offset = "0x1F9C8F8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000022DE File Offset: 0x000004DE
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public GUIStyleState normal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000115")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9D6AC", Offset = "0x1F9D6AC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "SetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "DrawUnityInputDebugger", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyleState), Member = "GetGUIStyleState", MemberParameters = new object[]
			{
				typeof(GUIStyle),
				typeof(IntPtr)
			}, ReturnType = typeof(GUIStyleState))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000022E1 File Offset: 0x000004E1
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public RectOffset margin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000116")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F94A2C", Offset = "0x1F94A2C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginLeft", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginRight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginTop", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutEntry), Member = "get_marginBottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "ApplyStyleSettings", MemberParameters = new object[] { typeof(GUIStyle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000022E4 File Offset: 0x000004E4
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public RectOffset padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000117")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9E3A8", Offset = "0x1F9E3A8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000022E7 File Offset: 0x000004E7
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F974D8", Offset = "0x1F974D8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			throw null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000022EA File Offset: 0x000004EA
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9798C", Offset = "0x1F9798C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void Draw(Rect position, GUIContent content, int controlID)
		{
			throw null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000022ED File Offset: 0x000004ED
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96F6C", Offset = "0x1F96F6C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "HasKeyFocus", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
			throw null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000022F0 File Offset: 0x000004F0
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0BE0", Offset = "0x1FA0BE0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_Draw2", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			throw null;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000022F3 File Offset: 0x000004F3
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public static GUIStyle none
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F94C90", Offset = "0x1F94C90", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(GUIStyle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(GUIStyle),
				typeof(GUILayoutOption[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new object[]
			{
				typeof(Rect),
				typeof(GUIContent),
				typeof(GUIStyle),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "CallWindowDelegate", MemberParameters = new object[]
			{
				typeof(GUI.WindowFunction),
				typeof(int),
				typeof(int),
				typeof(GUISkin),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(GUIStyle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextEditor), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcWidth", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutGroup), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000022F6 File Offset: 0x000004F6
		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AD14", Offset = "0x1F9AD14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_CalcSizeWithConstraints", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			throw null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000022F9 File Offset: 0x000004F9
		[global::Cpp2ILInjected.Token(Token = "0x600011E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95B70", Offset = "0x1F95B70", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float CalcHeight(GUIContent content, float width)
		{
			throw null;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000022FC File Offset: 0x000004FC
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public bool isHeightDependantOnWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9AC68", Offset = "0x1F9AC68", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new object[]
			{
				typeof(GUIContent),
				typeof(GUIStyle),
				typeof(GUILayoutOption[])
			}, ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000022FF File Offset: 0x000004FF
		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95AAC", Offset = "0x1F95AAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_CalcMinMaxWidth", MemberParameters = new object[] { typeof(GUIContent) }, ReturnType = typeof(Vector2))]
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002302 File Offset: 0x00000502
		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0C04", Offset = "0x1FA0C04", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002305 File Offset: 0x00000505
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0CD4", Offset = "0x1FA0CD4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static GUIStyle()
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0730", Offset = "0x1FA0730", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);

		// Token: 0x0600011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0828", Offset = "0x1FA0828", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on);

		// Token: 0x0600011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA08F8", Offset = "0x1FA08F8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret);

		// Token: 0x06000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0A04", Offset = "0x1FA0A04", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret);

		// Token: 0x06000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0A58", Offset = "0x1FA0A58", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect);

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private GUIStyleState m_Normal;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private GUIStyleState m_Hover;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private GUIStyleState m_Active;

		// Token: 0x040000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private GUIStyleState m_Focused;

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private GUIStyleState m_OnNormal;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private GUIStyleState m_OnHover;

		// Token: 0x040000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private GUIStyleState m_OnActive;

		// Token: 0x040000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private GUIStyleState m_OnFocused;

		// Token: 0x040000CC RID: 204
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private RectOffset m_Border;

		// Token: 0x040000CD RID: 205
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private RectOffset m_Padding;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private RectOffset m_Margin;

		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private RectOffset m_Overflow;

		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private string m_Name;

		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		internal static bool showKeyboardFocus;

		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		private static GUIStyle s_None;
	}
}
