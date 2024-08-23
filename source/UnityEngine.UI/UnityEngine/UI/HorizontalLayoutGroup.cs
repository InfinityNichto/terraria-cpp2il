using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x0200001D RID: 29
	[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x06000251 RID: 593 RVA: 0x0000271C File Offset: 0x0000091C
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC9510", Offset = "0x1FC9510", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
		protected HorizontalLayoutGroup()
		{
			throw null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000271F File Offset: 0x0000091F
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC9528", Offset = "0x1FC9528", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		public override void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002722 File Offset: 0x00000922
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC97D0", Offset = "0x1FC97D0", Length = "0xC")]
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

		// Token: 0x06000254 RID: 596 RVA: 0x00002725 File Offset: 0x00000925
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC97DC", Offset = "0x1FC97DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002728 File Offset: 0x00000928
		[global::Cpp2ILInjected.Token(Token = "0x6000295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC9DE8", Offset = "0x1FC9DE8", Length = "0xC")]
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
