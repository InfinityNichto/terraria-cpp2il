using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005B1")]
public class PotionOfReturnSmartInteractCandidateProvider : ISmartInteractCandidateProvider
{
	[Cpp2IlInjected.Token(Token = "0x20009A4")]
	private class ReusableCandidate : ISmartInteractCandidate
	{
		[Cpp2IlInjected.Token(Token = "0x170008C5")]
		public float DistanceFromCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E3E")]
			[Cpp2IlInjected.Address(RVA = "0x1194294", Offset = "0x1194294", VA = "0x1194294", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6004E3F")]
			[Cpp2IlInjected.Address(RVA = "0x119429C", Offset = "0x119429C", VA = "0x119429C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E40")]
		[Cpp2IlInjected.Address(RVA = "0x11942A4", Offset = "0x11942A4", VA = "0x11942A4", Slot = "5")]
		public void WinCandidacy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E41")]
		[Cpp2IlInjected.Address(RVA = "0x1194210", Offset = "0x1194210", VA = "0x1194210")]
		public void Reuse(float distanceFromCursor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E42")]
		[Cpp2IlInjected.Address(RVA = "0x119428C", Offset = "0x119428C", VA = "0x119428C")]
		public ReusableCandidate()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B52")]
	private ReusableCandidate _candidate;

	[Cpp2IlInjected.Token(Token = "0x6003C44")]
	[Cpp2IlInjected.Address(RVA = "0x1194028", Offset = "0x1194028", VA = "0x1194028", Slot = "4")]
	public void ClearSelfAndPrepareForCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C45")]
	[Cpp2IlInjected.Address(RVA = "0x11940A0", Offset = "0x11940A0", VA = "0x11940A0", Slot = "5")]
	public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C46")]
	[Cpp2IlInjected.Address(RVA = "0x1194218", Offset = "0x1194218", VA = "0x1194218")]
	public PotionOfReturnSmartInteractCandidateProvider()
	{
	}
}
