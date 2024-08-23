using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[NativeHeader("Runtime/Utilities/CopyPaste.h")]
	[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Modules/IMGUI/GUIUtility.h")]
	[NativeHeader("Modules/IMGUI/GUIManager.h")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000010")]
	public class GUIUtility
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000064 RID: 100
		[NativeProperty("GetGUIState().m_PixelsPerPoint", true, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		internal static extern float pixelsPerPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000068")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F99C10", Offset = "0x1F99C10", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000065 RID: 101
		[NativeProperty("GetGUIState().m_OnGUIDepth", true, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		internal static extern int guiDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000069")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9AE40", Offset = "0x1F9AE40", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000020 RID: 32
		// (set) Token: 0x06000066 RID: 102
		[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		internal static extern bool mouseUsed
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F979A0", Offset = "0x1F979A0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000067 RID: 103
		// (set) Token: 0x06000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public static extern string systemCopyBuffer
		{
			[FreeFunction("GetCopyBuffer")]
			[global::Cpp2ILInjected.Token(Token = "0x600006B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9AE68", Offset = "0x1F9AE68", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_clipboard", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = "UnityEngine.UI.InputField.EditState")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[FreeFunction("SetCopyBuffer")]
			[global::Cpp2ILInjected.Token(Token = "0x600006C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9AE90", Offset = "0x1F9AE90", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_clipboard", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new object[] { typeof(Event) }, ReturnType = "UnityEngine.UI.InputField.EditState")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002134 File Offset: 0x00000334
		[FreeFunction("GetGUIState().GetControlID")]
		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AECC", Offset = "0x1F9AECC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FocusType),
			typeof(Rect)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
		{
			throw null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002137 File Offset: 0x00000337
		[global::Cpp2ILInjected.Token(Token = "0x600006E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96888", Offset = "0x1F96888", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FocusType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "Internal_GetControlID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FocusType),
			typeof(Rect)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int GetControlID(int hint, FocusType focusType, Rect rect)
		{
			throw null;
		}

		// Token: 0x0600006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x600006F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AF7C", Offset = "0x1F9AF7C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int Internal_GetHotControl();

		// Token: 0x0600006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x6000070")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AFA4", Offset = "0x1F9AFA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int Internal_GetKeyboardControl();

		// Token: 0x0600006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x6000071")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AFCC", Offset = "0x1F9AFCC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern object Internal_GetDefaultSkin(int skinMode);

		// Token: 0x0600006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B008", Offset = "0x1F9B008", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_ExitGUI();

		// Token: 0x0600006F RID: 111 RVA: 0x0000213A File Offset: 0x0000033A
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B030", Offset = "0x1F9B030", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void MarkGUIChanged()
		{
			throw null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000213D File Offset: 0x0000033D
		[global::Cpp2ILInjected.Token(Token = "0x6000074")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97960", Offset = "0x1F97960", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_zero", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FocusType),
			typeof(Rect)
		}, ReturnType = typeof(int))]
		public static int GetControlID(int hint, FocusType focus)
		{
			throw null;
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002140 File Offset: 0x00000340
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		internal static bool guiIsExiting
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000075")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9B094", Offset = "0x1F9B094", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002143 File Offset: 0x00000343
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public static int hotControl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000076")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9B0E0", Offset = "0x1F9B0E0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002146 File Offset: 0x00000346
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000077")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B108", Offset = "0x1F9B108", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void TakeCapture()
		{
			throw null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002149 File Offset: 0x00000349
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000078")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B16C", Offset = "0x1F9B16C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void RemoveCapture()
		{
			throw null;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000214C File Offset: 0x0000034C
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public static int keyboardControl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F973C4", Offset = "0x1F973C4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000214F File Offset: 0x0000034F
		[global::Cpp2ILInjected.Token(Token = "0x600007A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B1D0", Offset = "0x1F9B1D0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool HasKeyFocus(int controlID)
		{
			throw null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002152 File Offset: 0x00000352
		[global::Cpp2ILInjected.Token(Token = "0x600007B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9607C", Offset = "0x1F9607C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static GUISkin GetDefaultSkin()
		{
			throw null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002155 File Offset: 0x00000355
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600007C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B270", Offset = "0x1F9B270", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
		{
			throw null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002158 File Offset: 0x00000358
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600007D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B2F4", Offset = "0x1F9B2F4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "ResetGlobalState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
			throw null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000215B File Offset: 0x0000035B
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600007E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B488", Offset = "0x1F9B488", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(GUILayoutUtility.LayoutCache))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = "ClearStaticCache", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static void EndGUI(int layoutType)
		{
			throw null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000215E File Offset: 0x0000035E
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B700", Offset = "0x1F9B700", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "IsExitGUIException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool EndGUIFromException(Exception exception)
		{
			throw null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002161 File Offset: 0x00000361
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B744", Offset = "0x1F9B744", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool EndContainerGUIFromException(Exception exception)
		{
			throw null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002164 File Offset: 0x00000364
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B390", Offset = "0x1F9B390", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "BeginGUI", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "set_skin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static void ResetGlobalState()
		{
			throw null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002167 File Offset: 0x00000367
		[global::Cpp2ILInjected.Token(Token = "0x6000082")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B7B4", Offset = "0x1F9B7B4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "EndGUIFromException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "ShouldRethrowException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool IsExitGUIException(Exception exception)
		{
			throw null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000216A File Offset: 0x0000036A
		[global::Cpp2ILInjected.Token(Token = "0x6000083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B740", Offset = "0x1F9B740", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "IsExitGUIException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
		internal static bool ShouldRethrowException(Exception exception)
		{
			throw null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000216D File Offset: 0x0000036D
		[global::Cpp2ILInjected.Token(Token = "0x6000084")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95F04", Offset = "0x1F95F04", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "set_skin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "EndGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void CheckOnGUI()
		{
			throw null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002170 File Offset: 0x00000370
		[global::Cpp2ILInjected.Token(Token = "0x6000085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B838", Offset = "0x1F9B838", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Event)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
		internal static bool HitTest(Rect rect, Vector2 point, int offset)
		{
			throw null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002173 File Offset: 0x00000373
		[global::Cpp2ILInjected.Token(Token = "0x6000086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9B8DC", Offset = "0x1F9B8DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(bool))]
		internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
		{
			throw null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002176 File Offset: 0x00000376
		[global::Cpp2ILInjected.Token(Token = "0x6000087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97024", Offset = "0x1F97024", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_isDirectManipulationDevice", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(bool))]
		internal static bool HitTest(Rect rect, Event evt)
		{
			throw null;
		}

		// Token: 0x06000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x6000088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AF28", Offset = "0x1F9AF28", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect);

		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		internal static int s_ControlCount;

		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		internal static int s_SkinMode;

		// Token: 0x0400005D RID: 93
		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		internal static int s_OriginalID;

		// Token: 0x0400005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		internal static Action takeCapture;

		// Token: 0x0400005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x4000063")]
		internal static Action releaseCapture;

		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x4000064")]
		internal static Func<int, IntPtr, bool> processEvent;

		// Token: 0x04000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x4000065")]
		internal static Func<Exception, bool> endContainerGUIFromException;

		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x4000066")]
		internal static Action guiChanged;

		// Token: 0x04000063 RID: 99
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000067")]
		private static bool <guiIsExiting>k__BackingField;

		// Token: 0x04000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x4000068")]
		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc;
	}
}
