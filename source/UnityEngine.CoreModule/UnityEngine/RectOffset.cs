using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000077 RID: 119
	[UsedByNativeCode]
	[NativeHeader("Modules/IMGUI/GUIStyle.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000084")]
	[Serializable]
	[StructLayout(0)]
	public class RectOffset : IFormattable
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000245B File Offset: 0x0000065B
		[global::Cpp2ILInjected.Token(Token = "0x600022D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76FDC", Offset = "0x1F76FDC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public RectOffset()
		{
			throw null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000245E File Offset: 0x0000065E
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		[global::Cpp2ILInjected.Token(Token = "0x600022E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7704C", Offset = "0x1F7704C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIStyle", Member = "get_margin", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIStyle", Member = "get_padding", ReturnType = typeof(RectOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal RectOffset(object sourceStyle, IntPtr source)
		{
			throw null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002461 File Offset: 0x00000661
		[global::Cpp2ILInjected.Token(Token = "0x600022F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77078", Offset = "0x1F77078", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectOffset), Member = "Destroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002464 File Offset: 0x00000664
		[global::Cpp2ILInjected.Token(Token = "0x6000230")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F771B8", Offset = "0x1F771B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002467 File Offset: 0x00000667
		[global::Cpp2ILInjected.Token(Token = "0x6000231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F771C4", Offset = "0x1F771C4", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000246A File Offset: 0x0000066A
		[global::Cpp2ILInjected.Token(Token = "0x6000232")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77118", Offset = "0x1F77118", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RectOffset), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Destroy()
		{
			throw null;
		}

		// Token: 0x06000225 RID: 549
		[ThreadAndSerializationSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000233")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77024", Offset = "0x1F77024", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr InternalCreate();

		// Token: 0x06000226 RID: 550
		[ThreadAndSerializationSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77514", Offset = "0x1F77514", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void InternalDestroy(IntPtr ptr);

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000227 RID: 551
		[NativeProperty("left", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public extern int left
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000235")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77424", Offset = "0x1F77424", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginLeft", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new object[] { "UnityEngine.GUIStyle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000228 RID: 552
		[NativeProperty("right", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public extern int right
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000236")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77460", Offset = "0x1F77460", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginRight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new object[] { "UnityEngine.GUIStyle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetHorizontal", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000229 RID: 553
		[NativeProperty("top", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public extern int top
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000237")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7749C", Offset = "0x1F7749C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginTop", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new object[] { "UnityEngine.GUIStyle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUIScrollGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600022A RID: 554
		[NativeProperty("bottom", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public extern int bottom
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000238")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F774D8", Offset = "0x1F774D8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutEntry", Member = "get_marginBottom", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "ApplyStyleSettings", MemberParameters = new object[] { "UnityEngine.GUIStyle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "SetVertical", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600022B RID: 555
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public extern int horizontal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000239")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F77550", Offset = "0x1F77550", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "SetCellsAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcWidth", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600022C RID: 556
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public extern int vertical
		{
			[global::Cpp2ILInjected.Token(Token = "0x600023A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7758C", Offset = "0x1F7758C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "CalculateLayoutInputVertical", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GridLayoutGroup", Member = "SetCellsAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "GetStartOffset", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUILayoutGroup", Member = "CalcHeight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x040002EA RID: 746
		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040002EB RID: 747
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object m_SourceStyle;
	}
}
