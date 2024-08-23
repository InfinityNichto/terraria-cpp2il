using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x2000015")]
	public class GUILayout
	{
		// Token: 0x06000094 RID: 148 RVA: 0x000021A6 File Offset: 0x000003A6
		[global::Cpp2ILInjected.Token(Token = "0x6000098")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BC34", Offset = "0x1F9BC34", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIContent), Member = "Temp", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GUIContent))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Label(string text, params GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021A9 File Offset: 0x000003A9
		[global::Cpp2ILInjected.Token(Token = "0x6000099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BCD4", Offset = "0x1F9BCD4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "GetRect", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "Label", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000021AC File Offset: 0x000003AC
		[global::Cpp2ILInjected.Token(Token = "0x600009A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BDA0", Offset = "0x1F9BDA0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void BeginArea(Rect screenRect, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000021AF File Offset: 0x000003AF
		[global::Cpp2ILInjected.Token(Token = "0x600009B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9BE30", Offset = "0x1F9BE30", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(Type)
		}, ReturnType = typeof(GUILayoutGroup))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMin", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_xMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_yMax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "MinMaxRect", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new object[]
		{
			typeof(Rect),
			typeof(GUIContent),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
			throw null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000021B2 File Offset: 0x000003B2
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9C058", Offset = "0x1F9C058", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SimpleProfiler", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIUtility), Member = "CheckOnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "EndGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void EndArea()
		{
			throw null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000021B5 File Offset: 0x000003B5
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97EA4", Offset = "0x1F97EA4", Length = "0x94")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static GUILayoutOption Width(float width)
		{
			throw null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000021B8 File Offset: 0x000003B8
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F97F38", Offset = "0x1F97F38", Length = "0x98")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static GUILayoutOption Height(float height)
		{
			throw null;
		}
	}
}
