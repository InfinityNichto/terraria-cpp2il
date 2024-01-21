using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005AF")]
public class NPCSmartInteractCandidateProvider : ISmartInteractCandidateProvider
{
	[Cpp2IlInjected.Token(Token = "0x20009A2")]
	private class ReusableCandidate : ISmartInteractCandidate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008CAC")]
		private int _npcIndexToTarget;

		[Cpp2IlInjected.Token(Token = "0x170008C3")]
		public float DistanceFromCursor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E34")]
			[Cpp2IlInjected.Address(RVA = "0x1193C08", Offset = "0x1193C08", VA = "0x1193C08", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6004E35")]
			[Cpp2IlInjected.Address(RVA = "0x1193C10", Offset = "0x1193C10", VA = "0x1193C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E36")]
		[Cpp2IlInjected.Address(RVA = "0x1193C18", Offset = "0x1193C18", VA = "0x1193C18", Slot = "5")]
		public void WinCandidacy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E37")]
		[Cpp2IlInjected.Address(RVA = "0x1193CA4", Offset = "0x1193CA4", VA = "0x1193CA4")]
		public void Reuse(int npcIndex, float npcDistanceFromCursor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E38")]
		[Cpp2IlInjected.Address(RVA = "0x1193CB0", Offset = "0x1193CB0", VA = "0x1193CB0")]
		public ReusableCandidate()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B50")]
	private ReusableCandidate _candidate;

	[Cpp2IlInjected.Token(Token = "0x6003C3E")]
	[Cpp2IlInjected.Address(RVA = "0x105F008", Offset = "0x105F008", VA = "0x105F008", Slot = "4")]
	public void ClearSelfAndPrepareForCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C3F")]
	[Cpp2IlInjected.Address(RVA = "0x105F080", Offset = "0x105F080", VA = "0x105F080", Slot = "5")]
	public bool ProvideCandidate(SmartInteractScanSettings settings, out ISmartInteractCandidate candidate)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003C40")]
	[Cpp2IlInjected.Address(RVA = "0x105F4B0", Offset = "0x105F4B0", VA = "0x105F4B0")]
	public NPCSmartInteractCandidateProvider()
	{
	}
}
