using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public class GUILayoutUtility
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002107 File Offset: 0x00000307
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9970C", Offset = "0x1F9970C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutSingleGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static Rect Internal_GetWindowRect(int windowID)
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000210A File Offset: 0x0000030A
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F997E0", Offset = "0x1F997E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutSingleGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void Internal_MoveWindow(int windowID, Rect r)
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000210D File Offset: 0x0000030D
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97D74", Offset = "0x1F97D74", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility.LayoutCache), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99970", Offset = "0x1F99970", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "BeginGUI", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(GUILayoutUtility.LayoutCache))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static void Begin(int instanceID)
		{
			throw null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002113 File Offset: 0x00000313
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97FD0", Offset = "0x1F97FD0", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(GUILayoutUtility.LayoutCache))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002116 File Offset: 0x00000316
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F981FC", Offset = "0x1F981FC", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "LayoutSingleGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void Layout()
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002119 File Offset: 0x00000319
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99FB0", Offset = "0x1F99FB0", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIUtility), Member = "EndGUI", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static void LayoutFromEditorWindow()
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000211C File Offset: 0x0000031C
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99C38", Offset = "0x1F99C38", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "LayoutSingleGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000211F File Offset: 0x0000031F
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99DE8", Offset = "0x1F99DE8", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFreeGroup", MemberParameters = new object[] { typeof(GUILayoutGroup) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "Internal_GetWindowRect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "Internal_MoveWindow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Rect)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void LayoutSingleGroup(GUILayoutGroup i)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002122 File Offset: 0x00000322
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A17C", Offset = "0x1F9A17C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(Type)
		}, ReturnType = typeof(GUILayoutGroup))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002125 File Offset: 0x00000325
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A2C0", Offset = "0x1F9A2C0", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "CreateGUILayoutGroupInstanceOfType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(GUILayoutGroup))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "Add", MemberParameters = new object[] { typeof(GUILayoutEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "GetNext", ReturnType = typeof(GUILayoutEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExitGUIException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002128 File Offset: 0x00000328
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A914", Offset = "0x1F9A914", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayout), Member = "DoLabel", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000212B File Offset: 0x0000032B
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A980", Offset = "0x1F9A980", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_isHeightDependantOnWidth", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWordWrapSizer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(GUIContent),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "GetNext", ReturnType = typeof(GUILayoutEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "Internal_CalcSizeWithConstraints", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = "Add", MemberParameters = new object[] { typeof(GUILayoutEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000212E File Offset: 0x0000032E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9AD18", Offset = "0x1F9AD18", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility.LayoutCache), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static GUILayoutUtility()
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9979C", Offset = "0x1F9979C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_GetWindowRect_Injected(int windowID, out Rect ret);

		// Token: 0x06000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9986C", Offset = "0x1F9986C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_MoveWindow_Injected(int windowID, ref Rect r);

		// Token: 0x04000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts;

		// Token: 0x04000058 RID: 88
		[global::Cpp2ILInjected.Token(Token = "0x4000058")]
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows;

		// Token: 0x04000059 RID: 89
		[global::Cpp2ILInjected.Token(Token = "0x4000059")]
		internal static GUILayoutUtility.LayoutCache current;

		// Token: 0x0400005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		internal static readonly Rect kDummyRect;

		// Token: 0x02000029 RID: 41
		[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
		[global::Cpp2ILInjected.Token(Token = "0x200000E")]
		internal sealed class LayoutCache
		{
			// Token: 0x17000055 RID: 85
			// (set) Token: 0x06000132 RID: 306 RVA: 0x00002332 File Offset: 0x00000532
			[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
			private int id
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6000065")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F9AE30", Offset = "0x1F9AE30", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00002335 File Offset: 0x00000535
			[global::Cpp2ILInjected.Token(Token = "0x6000066")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F998B0", Offset = "0x1F998B0", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(GUILayoutUtility.LayoutCache))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GenericStack), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal LayoutCache(int instanceID = -1)
			{
				throw null;
			}

			// Token: 0x040000EC RID: 236
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[global::Cpp2ILInjected.Token(Token = "0x400005B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <id>k__BackingField;

			// Token: 0x040000ED RID: 237
			[global::Cpp2ILInjected.Token(Token = "0x400005C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal GUILayoutGroup topLevel;

			// Token: 0x040000EE RID: 238
			[global::Cpp2ILInjected.Token(Token = "0x400005D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal GenericStack layoutGroups;

			// Token: 0x040000EF RID: 239
			[global::Cpp2ILInjected.Token(Token = "0x400005E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal GUILayoutGroup windows;
		}
	}
}
