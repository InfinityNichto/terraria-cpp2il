using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Animations;

namespace Terraria.GameContent.Skies.CreditsRoll;

[Cpp2IlInjected.Token(Token = "0x2000668")]
public class CreditsRollComposer
{
	[Cpp2IlInjected.Token(Token = "0x2000A53")]
	private struct SimplifiedNPCInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008E0D")]
		private Vector2 _simplifiedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008E0E")]
		private int _npcType;

		[Cpp2IlInjected.Token(Token = "0x60050D9")]
		[Cpp2IlInjected.Address(RVA = "0x39EAC4", Offset = "0x39EAC4", VA = "0x39EAC4")]
		public SimplifiedNPCInfo(int npcType, Vector2 simplifiedPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050DA")]
		[Cpp2IlInjected.Address(RVA = "0x39EAD4", Offset = "0x39EAD4", VA = "0x39EAD4")]
		public void SpawnNPC(AddNPCMethod methodToUse, Vector2 baseAnchor, int startTime, int totalSceneTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60050DB")]
		[Cpp2IlInjected.Address(RVA = "0x39EAFC", Offset = "0x39EAFC", VA = "0x39EAFC")]
		private Vector2 GetProperPosition(Vector2 baseAnchor)
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A54")]
	private delegate void AddNPCMethod(int npcType, Vector2 sceneAnchoePosition, int lookDirection, int fromTime, int duration, int timeToJumpAt);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006D16")]
	private Vector2 _originAtBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006D17")]
	private Vector2 _emoteBubbleOffsetWhenOnLeft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006D18")]
	private Vector2 _emoteBubbleOffsetWhenOnRight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006D19")]
	private Vector2 _backgroundOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006D1A")]
	private int _endTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006D1B")]
	private List<IAnimationSegment> _segments;

	[Cpp2IlInjected.Token(Token = "0x6004042")]
	[Cpp2IlInjected.Address(RVA = "0x111D94C", Offset = "0x111D94C", VA = "0x111D94C")]
	public void FillSegments_Test(List<IAnimationSegment> segmentsList, out int endTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004043")]
	[Cpp2IlInjected.Address(RVA = "0x1120394", Offset = "0x1120394", VA = "0x1120394")]
	public void FillSegments(List<IAnimationSegment> segmentsList, out int endTime, bool inGame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004044")]
	[Cpp2IlInjected.Address(RVA = "0x1135884", Offset = "0x1135884", VA = "0x1135884")]
	private SegmentInforReport PlaySegment_PrincessAndEveryoneThanksPlayer(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004045")]
	[Cpp2IlInjected.Address(RVA = "0x113678C", Offset = "0x113678C", VA = "0x113678C")]
	private void AddWavingNPC(int npcType, Vector2 sceneAnchoePosition, int lookDirection, int fromTime, int duration, int timeToJumpAt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004046")]
	[Cpp2IlInjected.Address(RVA = "0x1136E70", Offset = "0x1136E70", VA = "0x1136E70")]
	private void AddEmote(Vector2 sceneAnchoePosition, int fromTime, int duration, int blinkTime, int emoteId, int direction)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004047")]
	[Cpp2IlInjected.Address(RVA = "0x1120AB0", Offset = "0x1120AB0", VA = "0x1120AB0")]
	private SegmentInforReport PlaySegment_TextRoll(int startTime, string sourceCategory, [Optional] Vector2 anchorOffset)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004048")]
	[Cpp2IlInjected.Address(RVA = "0x1136F98", Offset = "0x1136F98", VA = "0x1136F98")]
	private SegmentInforReport PlaySegment_GuideEmotingAtRainbowPanel(int startTime)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004049")]
	[Cpp2IlInjected.Address(RVA = "0x112632C", Offset = "0x112632C", VA = "0x112632C")]
	private SegmentInforReport PlaySegment_Grox_DryadSayingByeToTavernKeep(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x600404A")]
	[Cpp2IlInjected.Address(RVA = "0x11303B4", Offset = "0x11303B4", VA = "0x11303B4")]
	private SegmentInforReport PlaySegment_Grox_SteampunkerRepairingCyborg(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x600404B")]
	[Cpp2IlInjected.Address(RVA = "0x1131E34", Offset = "0x1131E34", VA = "0x1131E34")]
	private SegmentInforReport PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x600404C")]
	[Cpp2IlInjected.Address(RVA = "0x11333F8", Offset = "0x11333F8", VA = "0x11333F8")]
	private SegmentInforReport PlaySegment_Grox_WitchDoctorGoingToHisPeople(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x600404D")]
	[Cpp2IlInjected.Address(RVA = "0x11373F0", Offset = "0x11373F0", VA = "0x11373F0")]
	private Vector2 GetSceneFixVector()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600404E")]
	[Cpp2IlInjected.Address(RVA = "0x112EA78", Offset = "0x112EA78", VA = "0x112EA78")]
	private SegmentInforReport PlaySegment_DryadTurningToTree(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x600404F")]
	[Cpp2IlInjected.Address(RVA = "0x113741C", Offset = "0x113741C", VA = "0x113741C")]
	private SegmentInforReport PlaySegment_SantaItemExample(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004050")]
	[Cpp2IlInjected.Address(RVA = "0x112C788", Offset = "0x112C788", VA = "0x112C788")]
	private SegmentInforReport PlaySegment_Grox_SkeletonMerchantSearchesThroughBones(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004051")]
	[Cpp2IlInjected.Address(RVA = "0x1122028", Offset = "0x1122028", VA = "0x1122028")]
	private SegmentInforReport PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004052")]
	[Cpp2IlInjected.Address(RVA = "0x1120BE0", Offset = "0x1120BE0", VA = "0x1120BE0")]
	private SegmentInforReport PlaySegment_Grox_GuideRunningFromZombie(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004053")]
	[Cpp2IlInjected.Address(RVA = "0x112A82C", Offset = "0x112A82C", VA = "0x112A82C")]
	private SegmentInforReport PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004054")]
	[Cpp2IlInjected.Address(RVA = "0x1129210", Offset = "0x1129210", VA = "0x1129210")]
	private SegmentInforReport PlaySegment_Grox_AnglerAndPirateTalkAboutFish(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004055")]
	[Cpp2IlInjected.Address(RVA = "0x111DA88", Offset = "0x111DA88", VA = "0x111DA88")]
	private SegmentInforReport PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004056")]
	[Cpp2IlInjected.Address(RVA = "0x1123B24", Offset = "0x1123B24", VA = "0x1123B24")]
	private SegmentInforReport PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004057")]
	[Cpp2IlInjected.Address(RVA = "0x1125570", Offset = "0x1125570", VA = "0x1125570")]
	private SegmentInforReport PlaySegment_TinkererAndMechanic(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004058")]
	[Cpp2IlInjected.Address(RVA = "0x1128228", Offset = "0x1128228", VA = "0x1128228")]
	private SegmentInforReport PlaySegment_ClothierChasingTruffle(int startTime, Vector2 sceneAnchorPosition)
	{
		return default(SegmentInforReport);
	}

	[Cpp2IlInjected.Token(Token = "0x6004059")]
	[Cpp2IlInjected.Address(RVA = "0x1137670", Offset = "0x1137670", VA = "0x1137670")]
	public CreditsRollComposer()
	{
	}
}
