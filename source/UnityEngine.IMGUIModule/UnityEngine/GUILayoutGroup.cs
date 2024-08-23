using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	internal class GUILayoutGroup : GUILayoutEntry
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002275 File Offset: 0x00000475
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public override int marginLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9DBE8", Offset = "0x1F9DBE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002278 File Offset: 0x00000478
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public override int marginRight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9DBF0", Offset = "0x1F9DBF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000227B File Offset: 0x0000047B
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public override int marginTop
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9DBF8", Offset = "0x1F9DBF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000227E File Offset: 0x0000047E
		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		public override int marginBottom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9DC00", Offset = "0x1F9DC00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002281 File Offset: 0x00000481
		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F99B04", Offset = "0x1F99B04", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility.LayoutCache), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginWindow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public GUILayoutGroup()
		{
			throw null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002284 File Offset: 0x00000484
		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9DC08", Offset = "0x1F9DC08", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = "ApplyOptions", MemberParameters = new object[] { typeof(GUILayoutOption[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void ApplyOptions(GUILayoutOption[] options)
		{
			throw null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002287 File Offset: 0x00000487
		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9DD10", Offset = "0x1F9DD10", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = "ApplyStyleSettings", MemberParameters = new object[] { typeof(GUIStyle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_margin", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
		protected override void ApplyStyleSettings(GUIStyle style)
		{
			throw null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000228A File Offset: 0x0000048A
		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A174", Offset = "0x1F9A174", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ResetCursor()
		{
			throw null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000228D File Offset: 0x0000048D
		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A5AC", Offset = "0x1F9A5AC", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(Type)
		}, ReturnType = typeof(GUILayoutGroup))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Event), Member = "get_rawType", ReturnType = typeof(EventType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public GUILayoutEntry GetNext()
		{
			throw null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002290 File Offset: 0x00000490
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9A504", Offset = "0x1F9A504", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "BeginLayoutArea", MemberParameters = new object[]
		{
			typeof(GUIStyle),
			typeof(Type)
		}, ReturnType = typeof(GUILayoutGroup))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILayoutUtility), Member = "DoGetRect", MemberParameters = new object[]
		{
			typeof(GUIContent),
			typeof(GUIStyle),
			typeof(GUILayoutOption[])
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(GUILayoutEntry e)
		{
			throw null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002293 File Offset: 0x00000493
		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9DD78", Offset = "0x1F9DD78", Length = "0x630")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcWidth", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override void CalcWidth()
		{
			throw null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002296 File Offset: 0x00000496
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9E448", Offset = "0x1F9E448", Length = "0x780")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "SetHorizontal", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_x", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_width", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override void SetHorizontal(float x, float width)
		{
			throw null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002299 File Offset: 0x00000499
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9EBC8", Offset = "0x1F9EBC8", Length = "0x580")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "CalcHeight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override void CalcHeight()
		{
			throw null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000229C File Offset: 0x0000049C
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9F148", Offset = "0x1F9F148", Length = "0x788")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIScrollGroup), Member = "SetVertical", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_y", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_height", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_padding", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override void SetVertical(float y, float height)
		{
			throw null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000229F File Offset: 0x0000049F
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9F8D0", Offset = "0x1F9F8D0", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000022A2 File Offset: 0x000004A2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F9FC9C", Offset = "0x1F9FC9C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStyle), Member = "get_none", ReturnType = typeof(GUIStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayoutEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(GUIStyle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static GUILayoutGroup()
		{
			throw null;
		}

		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public List<GUILayoutEntry> entries;

		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public bool isVertical;

		// Token: 0x040000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		public bool resetCoords;

		// Token: 0x040000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float spacing;

		// Token: 0x040000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public bool sameSize;

		// Token: 0x040000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		public bool isWindow;

		// Token: 0x040000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public int windowID;

		// Token: 0x040000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int m_Cursor;

		// Token: 0x040000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		protected int m_StretchableCountX;

		// Token: 0x040000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected int m_StretchableCountY;

		// Token: 0x040000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		protected bool m_UserSpecifiedWidth;

		// Token: 0x040000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6D")]
		protected bool m_UserSpecifiedHeight;

		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		protected float m_ChildMinWidth;

		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		protected float m_ChildMaxWidth;

		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		protected float m_ChildMinHeight;

		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		protected float m_ChildMaxHeight;

		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		protected int m_MarginLeft;

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		protected int m_MarginRight;

		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		protected int m_MarginTop;

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		protected int m_MarginBottom;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		private static readonly GUILayoutEntry none;
	}
}
