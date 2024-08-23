using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x02000028 RID: 40
	[AddComponentMenu("Layout/Vertical Layout Group", 151)]
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x00002875 File Offset: 0x00000A75
		[global::Cpp2ILInjected.Token(Token = "0x600032C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD8F8", Offset = "0x1FCD8F8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		protected VerticalLayoutGroup()
		{
			throw null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002878 File Offset: 0x00000A78
		[global::Cpp2ILInjected.Token(Token = "0x600032D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD904", Offset = "0x1FCD904", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000287B File Offset: 0x00000A7B
		[global::Cpp2ILInjected.Token(Token = "0x600032E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD924", Offset = "0x1FCD924", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "CalcAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000287E File Offset: 0x00000A7E
		[global::Cpp2ILInjected.Token(Token = "0x600032F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD930", Offset = "0x1FCD930", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002881 File Offset: 0x00000A81
		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FCD93C", Offset = "0x1FCD93C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalOrVerticalLayoutGroup), Member = "SetChildrenAlongAxis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void SetLayoutVertical()
		{
			throw null;
		}
	}
}
