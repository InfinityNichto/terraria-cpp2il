using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public class GUI
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95BC4", Offset = "0x1F95BC4", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenericStack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static GUI()
		{
			throw null;
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		internal static DateTime nextScrollStepTime
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000017")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F95E50", Offset = "0x1F95E50", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		public static GUISkin skin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000019")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F96020", Offset = "0x1F96020", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "Label", MemberParameters = new object[]
			{
				typeof(string),
				typeof(GUILayoutOption[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000018")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F95EAC", Offset = "0x1F95EAC", Length = "0x58")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "ResetGlobalState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F95F84", Offset = "0x1F95F84", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "set_skin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "GetDefaultSkin", ReturnType = typeof(GUISkin))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "MakeCurrent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void DoSetSkin(GUISkin newSkin)
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F961E4", Offset = "0x1F961E4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.PlayerManager", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIContent))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Label(Rect position, string text)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F963D0", Offset = "0x1F963D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "DrawUnityInputDebugger", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIContent))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Label(Rect position, string text, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96338", Offset = "0x1F96338", Length = "0x98")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96700", Offset = "0x1F96700", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIContent))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool Button(Rect position, string text)
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F967D0", Offset = "0x1F967D0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FocusType),
			typeof(Rect)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96920", Offset = "0x1F96920", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Button", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020B0 File Offset: 0x000002B0
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96AD0", Offset = "0x1F96AD0", Length = "0x418")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "DoButton", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Event)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "Use", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020B3 File Offset: 0x000002B3
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F96498", Offset = "0x1F96498", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_Draw", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClip), Member = "get_visibleRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "SetMouseTooltip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Rect)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void DoLabel(Rect position, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B6 File Offset: 0x000002B6
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F969C0", Offset = "0x1F969C0", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "DoControl", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97604", Offset = "0x1F97604", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020BC File Offset: 0x000002BC
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F976DC", Offset = "0x1F976DC", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FocusType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIClip), Member = "Internal_Push", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020BF File Offset: 0x000002BF
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F979E4", Offset = "0x1F979E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void EndGroup()
		{
			throw null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020C2 File Offset: 0x000002C2
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		internal static GenericStack scrollViewStates
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F97A38", Offset = "0x1F97A38", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020C5 File Offset: 0x000002C5
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97A90", Offset = "0x1F97A90", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(GUILayoutUtility.LayoutCache))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayout), Member = "Width", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(GUILayoutOption))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayout), Member = "Height", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(GUILayoutOption))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "set_skin", MemberParameters = new object[] { typeof(GUISkin) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000029 RID: 41
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public static extern bool changed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000029")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F973EC", Offset = "0x1F973EC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x0600002A RID: 42
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9708C", Offset = "0x1F9708C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void GrabMouseControl(int id);

		// Token: 0x0600002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97428", Offset = "0x1F97428", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool HasMouseControl(int id);

		// Token: 0x0600002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97464", Offset = "0x1F97464", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern void ReleaseMouseControl();

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		private static int s_HotTextField;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		private static readonly int s_BoxHash;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		private static readonly int s_ButonHash;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		private static readonly int s_RepeatButtonHash;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		private static readonly int s_ToggleHash;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		private static readonly int s_ButtonGridHash;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		private static readonly int s_SliderHash;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		private static readonly int s_BeginGroupHash;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		private static readonly int s_ScrollviewHash;

		// Token: 0x04000018 RID: 24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		private static DateTime <nextScrollStepTime>k__BackingField;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		private static GUISkin s_Skin;

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		internal static Rect s_ToolTipRect;

		// Token: 0x0400001B RID: 27
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		private static GenericStack <scrollViewStates>k__BackingField;

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x2000005")]
		public delegate void WindowFunction(int id);
	}
}
