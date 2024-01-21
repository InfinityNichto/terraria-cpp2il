using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005B0")]
public class ProjectileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
{
	[Cpp2IlInjected.Token(Token = "0x20009A3")]
	private class ReusableCandidate : ISmartInteractCandidate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CAE")]
		private int _projectileIndexToTarget;

		[Cpp2IlInjected.Token(Token = "0x170008C4")]
		public float DistanceFromCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E39")]
			[Cpp2IlInjected.Address(RVA = "0x1194718", Offset = "0x1194718", VA = "0x1194718", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6004E3A")]
			[Cpp2IlInjected.Address(RVA = "0x1194720", Offset = "0x1194720", VA = "0x1194720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3B")]
		[Cpp2IlInjected.Address(RVA = "0x1194728", Offset = "0x1194728", VA = "0x1194728", Slot = "5")]
		public void WinCandidacy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3C")]
		[Cpp2IlInjected.Address(RVA = "0x1194690", Offset = "0x1194690", VA = "0x1194690")]
		public void Reuse(int projectileIndex, float projectileDistanceFromCursor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E3D")]
		[Cpp2IlInjected.Address(RVA = "0x1194710", Offset = "0x1194710", VA = "0x1194710")]
		public ReusableCandidate()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B51")]
	private ReusableCandidate _candidate;

	[Cpp2IlInjected.Token(Token = "0x6003C41")]
	[Cpp2IlInjected.Address(RVA = "0x1194328", Offset = "0x1194328", VA = "0x1194328", Slot = "4")]
	public void ClearSelfAndPrepareForCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C42")]
	[Cpp2IlInjected.Address(RVA = "0x11943A0", Offset = "0x11943A0", VA = "0x11943A0", Slot = "5")]
	public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C43")]
	[Cpp2IlInjected.Address(RVA = "0x119469C", Offset = "0x119469C", VA = "0x119469C")]
	public ProjectileSmartInteractCandidateProvider()
	{
	}
}
