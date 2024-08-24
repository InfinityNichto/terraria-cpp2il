using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Animations;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies.CreditsRoll
{
	// Token: 0x02000665 RID: 1637
	[global::Cpp2ILInjected.Token(Token = "0x20009E2")]
	public class CreditsRollComposer
	{
		// Token: 0x06004006 RID: 16390 RVA: 0x0002D6EF File Offset: 0x0002B8EF
		[global::Cpp2ILInjected.Token(Token = "0x6004A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x83C064", Offset = "0x83C064", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void FillSegments_Test(List<IAnimationSegment> segmentsList, out int endTime)
		{
			throw null;
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x0002D6F2 File Offset: 0x0002B8F2
		[global::Cpp2ILInjected.Token(Token = "0x6004A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x83EA50", Offset = "0x83EA50", Length = "0x6DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollSky), Member = "EnsureSegmentsAreMade", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TextRoll", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public void FillSegments(List<IAnimationSegment> segmentsList, out int endTime, bool inGame)
		{
			throw null;
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x0002D6F5 File Offset: 0x0002B8F5
		[global::Cpp2ILInjected.Token(Token = "0x6004A7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8524E4", Offset = "0x8524E4", Length = "0x16EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CreditsRollComposer.SimplifiedNPCInfo>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer.SimplifiedNPCInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CreditsRollComposer.SimplifiedNPCInfo>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CreditsRollComposer.SimplifiedNPCInfo>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer.AddNPCMethod), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer.SimplifiedNPCInfo), Member = "SpawnNPC", MemberParameters = new object[]
		{
			typeof(CreditsRollComposer.AddNPCMethod),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<CreditsRollComposer.SimplifiedNPCInfo>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.PlayerSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.PlayerSegment.ImmediateSpritebatchForPlayerDyesEffect), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.PlayerSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.PlayerSegment.IShaderEffect) }, ReturnType = typeof(Segments.PlayerSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Players.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Players.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Players.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Players.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Players.MoveWithAcceleration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 71)]
		private SegmentInforReport PlaySegment_PrincessAndEveryoneThanksPlayer(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		[global::Cpp2ILInjected.Token(Token = "0x6004A7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x853BD0", Offset = "0x853BD0", Length = "0x6E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.PartyHard), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.MoveWithAcceleration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Blink), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer), Member = "AddEmote", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void AddWavingNPC(int npcType, Vector2 sceneAnchoePosition, int lookDirection, int fromTime, int duration, int timeToJumpAt)
		{
			throw null;
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x0002D6FB File Offset: 0x0002B8FB
		[global::Cpp2ILInjected.Token(Token = "0x6004A80")]
		[global::Cpp2ILInjected.Address(RVA = "0x8542B4", Offset = "0x8542B4", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void AddEmote(Vector2 sceneAnchoePosition, int fromTime, int duration, int blinkTime, int emoteId, int direction)
		{
			throw null;
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x0002D6FE File Offset: 0x0002B8FE
		[global::Cpp2ILInjected.Token(Token = "0x6004A81")]
		[global::Cpp2ILInjected.Address(RVA = "0x83F12C", Offset = "0x83F12C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "FindAll", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.LocalizedTextSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(LocalizedText),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private SegmentInforReport PlaySegment_TextRoll(int startTime, string sourceCategory, Vector2 anchorOffset = default(Vector2))
		{
			throw null;
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x0002D701 File Offset: 0x0002B901
		[global::Cpp2ILInjected.Token(Token = "0x6004A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x854444", Offset = "0x854444", Length = "0x3E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private SegmentInforReport PlaySegment_GuideEmotingAtRainbowPanel(int startTime)
		{
			throw null;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x0002D704 File Offset: 0x0002B904
		[global::Cpp2ILInjected.Token(Token = "0x6004A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x84455C", Offset = "0x84455C", Length = "0x1C34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ShowItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SimulateGravity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 98)]
		private SegmentInforReport PlaySegment_Grox_DryadSayingByeToTavernKeep(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x0002D707 File Offset: 0x0002B907
		[global::Cpp2ILInjected.Token(Token = "0x6004A84")]
		[global::Cpp2ILInjected.Address(RVA = "0x84D860", Offset = "0x84D860", Length = "0x15C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 72)]
		private SegmentInforReport PlaySegment_Grox_SteampunkerRepairingCyborg(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x0002D70A File Offset: 0x0002B90A
		[global::Cpp2ILInjected.Token(Token = "0x6004A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x84EE28", Offset = "0x84EE28", Length = "0x1478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ShowItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 80)]
		private SegmentInforReport PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x0002D70D File Offset: 0x0002B90D
		[global::Cpp2ILInjected.Token(Token = "0x6004A86")]
		[global::Cpp2ILInjected.Address(RVA = "0x8502A0", Offset = "0x8502A0", Length = "0x2244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SimulateGravity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 131)]
		private SegmentInforReport PlaySegment_Grox_WitchDoctorGoingToHisPeople(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x0002D710 File Offset: 0x0002B910
		[global::Cpp2ILInjected.Token(Token = "0x6004A87")]
		[global::Cpp2ILInjected.Address(RVA = "0x854824", Offset = "0x854824", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private Vector2 GetSceneFixVector()
		{
			throw null;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x0002D713 File Offset: 0x0002B913
		[global::Cpp2ILInjected.Token(Token = "0x6004A88")]
		[global::Cpp2ILInjected.Address(RVA = "0x84C070", Offset = "0x84C070", Length = "0x17F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.MoveWithRotor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Variant), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.DoBunnyRestAnimation), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 95)]
		private SegmentInforReport PlaySegment_DryadTurningToTree(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x0002D716 File Offset: 0x0002B916
		[global::Cpp2ILInjected.Token(Token = "0x6004A89")]
		[global::Cpp2ILInjected.Address(RVA = "0x854850", Offset = "0x854850", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ShowItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private SegmentInforReport PlaySegment_SantaItemExample(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x0002D719 File Offset: 0x0002B919
		[global::Cpp2ILInjected.Token(Token = "0x6004A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x84A320", Offset = "0x84A320", Length = "0x1D50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloatDirection", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SimulateGravity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ShowItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 123)]
		private SegmentInforReport PlaySegment_Grox_SkeletonMerchantSearchesThroughBones(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x0002D71C File Offset: 0x0002B91C
		[global::Cpp2ILInjected.Token(Token = "0x6004A8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x840504", Offset = "0x840504", Length = "0x191C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ShowItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 102)]
		private SegmentInforReport PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x0002D71F File Offset: 0x0002B91F
		[global::Cpp2ILInjected.Token(Token = "0x6004A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x83F288", Offset = "0x83F288", Length = "0x127C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ZombieKnockOnDoor), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 71)]
		private SegmentInforReport PlaySegment_Grox_GuideRunningFromZombie(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x0002D722 File Offset: 0x0002B922
		[global::Cpp2ILInjected.Token(Token = "0x6004A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x848694", Offset = "0x848694", Length = "0x1C8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ForceAltTexture), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Variant), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SimulateGravity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 112)]
		private SegmentInforReport PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x0002D725 File Offset: 0x0002B925
		[global::Cpp2ILInjected.Token(Token = "0x6004A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8470E8", Offset = "0x8470E8", Length = "0x15AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.ShowItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 79)]
		private SegmentInforReport PlaySegment_Grox_AnglerAndPirateTalkAboutFish(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x0002D728 File Offset: 0x0002B928
		[global::Cpp2ILInjected.Token(Token = "0x6004A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x83C138", Offset = "0x83C138", Length = "0x2918")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments_Test", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.PartyHard), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Variant), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.SetFrameSequence), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Point[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 152)]
		private SegmentInforReport PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x0002D72B File Offset: 0x0002B92B
		[global::Cpp2ILInjected.Token(Token = "0x6004A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x841E20", Offset = "0x841E20", Length = "0x1A10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 93)]
		private SegmentInforReport PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x0002D72E File Offset: 0x0002B92E
		[global::Cpp2ILInjected.Token(Token = "0x6004A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x843830", Offset = "0x843830", Length = "0xD2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		private SegmentInforReport PlaySegment_TinkererAndMechanic(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x0002D731 File Offset: 0x0002B931
		[global::Cpp2ILInjected.Token(Token = "0x6004A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x846190", Offset = "0x846190", Length = "0xF58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "FillSegments", MemberParameters = new object[]
		{
			typeof(List<IAnimationSegment>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(DrawData),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment), Member = "UseShaderEffect", MemberParameters = new object[] { typeof(Segments.SpriteSegment.IShaderEffect) }, ReturnType = typeof(Segments.SpriteSegment))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "Then", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "With", MemberParameters = new object[] { "Terraria.GameContent.Animations.IAnimationSegmentAction`1<T>" }, ReturnType = "AnimationSegmentWithActions`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Fade), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.LookAt), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.Sprites.Wait), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Actions.NPCs.Move), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
		private SegmentInforReport PlaySegment_ClothierChasingTruffle(int startTime, Vector2 sceneAnchorPosition)
		{
			throw null;
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x0002D734 File Offset: 0x0002B934
		[global::Cpp2ILInjected.Token(Token = "0x6004A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x854BC4", Offset = "0x854BC4", Length = "0x10BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public CreditsRollComposer()
		{
			throw null;
		}

		// Token: 0x04006D15 RID: 27925
		[global::Cpp2ILInjected.Token(Token = "0x400851C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Vector2 _originAtBottom;

		// Token: 0x04006D16 RID: 27926
		[global::Cpp2ILInjected.Token(Token = "0x400851D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Vector2 _emoteBubbleOffsetWhenOnLeft;

		// Token: 0x04006D17 RID: 27927
		[global::Cpp2ILInjected.Token(Token = "0x400851E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 _emoteBubbleOffsetWhenOnRight;

		// Token: 0x04006D18 RID: 27928
		[global::Cpp2ILInjected.Token(Token = "0x400851F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector2 _backgroundOffset;

		// Token: 0x04006D19 RID: 27929
		[global::Cpp2ILInjected.Token(Token = "0x4008520")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _endTime;

		// Token: 0x04006D1A RID: 27930
		[global::Cpp2ILInjected.Token(Token = "0x4008521")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private List<IAnimationSegment> _segments;

		// Token: 0x02000A5C RID: 2652
		[global::Cpp2ILInjected.Token(Token = "0x20009E3")]
		private struct SimplifiedNPCInfo
		{
			// Token: 0x060050A2 RID: 20642 RVA: 0x0003038F File Offset: 0x0002E58F
			[global::Cpp2ILInjected.Token(Token = "0x6004A94")]
			[global::Cpp2ILInjected.Address(RVA = "0x85D688", Offset = "0x85D688", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			public SimplifiedNPCInfo(int npcType, Vector2 simplifiedPosition)
			{
				throw null;
			}

			// Token: 0x060050A3 RID: 20643 RVA: 0x00030392 File Offset: 0x0002E592
			[global::Cpp2ILInjected.Token(Token = "0x6004A95")]
			[global::Cpp2ILInjected.Address(RVA = "0x85D694", Offset = "0x85D694", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreditsRollComposer.SimplifiedNPCInfo), Member = "GetProperPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void SpawnNPC(CreditsRollComposer.AddNPCMethod methodToUse, Vector2 baseAnchor, int startTime, int totalSceneTime)
			{
				throw null;
			}

			// Token: 0x060050A4 RID: 20644 RVA: 0x00030395 File Offset: 0x0002E595
			[global::Cpp2ILInjected.Token(Token = "0x6004A96")]
			[global::Cpp2ILInjected.Address(RVA = "0x85D724", Offset = "0x85D724", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer.SimplifiedNPCInfo), Member = "SpawnNPC", MemberParameters = new object[]
			{
				"Terraria.GameContent.Skies.CreditsRoll.CreditsRollComposer.AddNPCMethod",
				typeof(Vector2),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private Vector2 GetProperPosition(Vector2 baseAnchor)
			{
				throw null;
			}

			// Token: 0x04008E20 RID: 36384
			[global::Cpp2ILInjected.Token(Token = "0x4008522")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Vector2 _simplifiedPosition;

			// Token: 0x04008E21 RID: 36385
			[global::Cpp2ILInjected.Token(Token = "0x4008523")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private int _npcType;
		}

		// Token: 0x02000A5D RID: 2653
		// (Invoke) Token: 0x060050A6 RID: 20646
		[global::Cpp2ILInjected.Token(Token = "0x20009E4")]
		private delegate void AddNPCMethod(int npcType, Vector2 sceneAnchoePosition, int lookDirection, int fromTime, int duration, int timeToJumpAt);
	}
}
