using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000050")]
	public static class LayoutUtility
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000317")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC8098", Offset = "0x1FC8098", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetMinHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetMinWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		public static float GetMinSize(RectTransform rect, int axis)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC80A4", Offset = "0x1FC80A4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetPreferredHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetPreferredWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		public static float GetPreferredSize(RectTransform rect, int axis)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000319")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCA864", Offset = "0x1FCA864", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetFlexibleWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		public static float GetFlexibleSize(RectTransform rect, int axis)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600031A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCCADC", Offset = "0x1FCCADC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float GetMinWidth(RectTransform rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600031B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCCD54", Offset = "0x1FCCD54", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static float GetPreferredWidth(RectTransform rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600031C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCCFCC", Offset = "0x1FCCFCC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float GetFlexibleWidth(RectTransform rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600031D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCC9EC", Offset = "0x1FCC9EC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetMinSize", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float GetMinHeight(RectTransform rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCCBCC", Offset = "0x1FCCBCC", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSizeFitter), Member = "HandleSelfFittingAlongAxis", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredSize", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static float GetPreferredHeight(RectTransform rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600031F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCCEDC", Offset = "0x1FCCEDC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "GetChildSizes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleSize", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float GetFlexibleHeight(RectTransform rect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD0BC", Offset = "0x1FCD0BC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float),
			typeof(ref ILayoutElement)
		}, ReturnType = typeof(float))]
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD0D4", Offset = "0x1FCD0D4", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetMinWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleWidth", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetMinHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetPreferredHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetFlexibleHeight", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutUtility), Member = "GetLayoutProperty", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Func<ILayoutElement, float>),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(List<Component>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, object>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000051")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000322")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD3D4", Offset = "0x1FCD3D4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000323")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD430", Offset = "0x1FCD430", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000324")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD438", Offset = "0x1FCD438", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetMinWidth>b__3_0(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000325")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD4D0", Offset = "0x1FCD4D0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetPreferredWidth>b__4_0(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000326")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD568", Offset = "0x1FCD568", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetPreferredWidth>b__4_1(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000327")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD600", Offset = "0x1FCD600", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetFlexibleWidth>b__5_0(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000328")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD698", Offset = "0x1FCD698", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetMinHeight>b__6_0(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000329")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD730", Offset = "0x1FCD730", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetPreferredHeight>b__7_0(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600032A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD7C8", Offset = "0x1FCD7C8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetPreferredHeight>b__7_1(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600032B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FCD860", Offset = "0x1FCD860", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal float <GetFlexibleHeight>b__8_0(ILayoutElement e)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000189")]
			public static readonly LayoutUtility.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400018A")]
			public static Func<ILayoutElement, float> <>9__3_0;

			[global::Cpp2ILInjected.Token(Token = "0x400018B")]
			public static Func<ILayoutElement, float> <>9__4_0;

			[global::Cpp2ILInjected.Token(Token = "0x400018C")]
			public static Func<ILayoutElement, float> <>9__4_1;

			[global::Cpp2ILInjected.Token(Token = "0x400018D")]
			public static Func<ILayoutElement, float> <>9__5_0;

			[global::Cpp2ILInjected.Token(Token = "0x400018E")]
			public static Func<ILayoutElement, float> <>9__6_0;

			[global::Cpp2ILInjected.Token(Token = "0x400018F")]
			public static Func<ILayoutElement, float> <>9__7_0;

			[global::Cpp2ILInjected.Token(Token = "0x4000190")]
			public static Func<ILayoutElement, float> <>9__7_1;

			[global::Cpp2ILInjected.Token(Token = "0x4000191")]
			public static Func<ILayoutElement, float> <>9__8_0;
		}
	}
}
