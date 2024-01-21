using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005AE")]
public class TileSmartInteractCandidateProvider : ISmartInteractCandidateProvider
{
	[Cpp2IlInjected.Token(Token = "0x20009A1")]
	private class ReusableCandidate : ISmartInteractCandidate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008CA3")]
		private bool _strictSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CA4")]
		private int _aimedX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008CA5")]
		private int _aimedY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008CA6")]
		private int _hx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008CA7")]
		private int _hy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008CA8")]
		private int _lx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008CA9")]
		private int _ly;

		[Cpp2IlInjected.Token(Token = "0x170008C2")]
		public float DistanceFromCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E30")]
			[Cpp2IlInjected.Address(RVA = "0x1196698", Offset = "0x1196698", VA = "0x1196698", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6004E31")]
			[Cpp2IlInjected.Address(RVA = "0x11966A0", Offset = "0x11966A0", VA = "0x11966A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E2F")]
		[Cpp2IlInjected.Address(RVA = "0x119665C", Offset = "0x119665C", VA = "0x119665C")]
		public void Reuse(bool strictSettings, float distanceFromCursor, int AimedX, int AimedY, int LX, int LY, int HX, int HY)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E32")]
		[Cpp2IlInjected.Address(RVA = "0x11966A8", Offset = "0x11966A8", VA = "0x11966A8", Slot = "5")]
		public void WinCandidacy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E33")]
		[Cpp2IlInjected.Address(RVA = "0x1196690", Offset = "0x1196690", VA = "0x1196690")]
		public ReusableCandidate()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B4E")]
	private List<int> targets;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B4F")]
	private ReusableCandidate _candidate;

	[Cpp2IlInjected.Token(Token = "0x6003C38")]
	[Cpp2IlInjected.Address(RVA = "0x1195300", Offset = "0x1195300", VA = "0x1195300", Slot = "4")]
	public void ClearSelfAndPrepareForCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C39")]
	[Cpp2IlInjected.Address(RVA = "0x11953FC", Offset = "0x11953FC", VA = "0x11953FC")]
	private int JoinValue(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C3A")]
	[Cpp2IlInjected.Address(RVA = "0x1195404", Offset = "0x1195404", VA = "0x1195404")]
	private void SplitValue(int value, out int x, out int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C3B")]
	[Cpp2IlInjected.Address(RVA = "0x1195418", Offset = "0x1195418", VA = "0x1195418", Slot = "5")]
	public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C3C")]
	[Cpp2IlInjected.Address(RVA = "0x1196098", Offset = "0x1196098", VA = "0x1196098")]
	private void FillPotentialTargetTiles(SmartInteractScanSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C3D")]
	[Cpp2IlInjected.Address(RVA = "0x11949B0", Offset = "0x11949B0", VA = "0x11949B0")]
	public TileSmartInteractCandidateProvider()
	{
	}
}
