using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.Localization;
using Terraria.UI.Chat;

namespace Terraria.GameContent.Animations
{
	// Token: 0x0200064D RID: 1613
	[global::Cpp2ILInjected.Token(Token = "0x2000995")]
	public class Segments
	{
		// Token: 0x06003F27 RID: 16167 RVA: 0x0002D452 File Offset: 0x0002B652
		[global::Cpp2ILInjected.Token(Token = "0x60048CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x823B40", Offset = "0x823B40", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Segments()
		{
			throw null;
		}

		// Token: 0x04006C9A RID: 27802
		[global::Cpp2ILInjected.Token(Token = "0x4008405")]
		private const float PixelsToRollUpPerFrame = 0.5f;

		// Token: 0x02000A2C RID: 2604
		[global::Cpp2ILInjected.Token(Token = "0x2000996")]
		public class LocalizedTextSegment : IAnimationSegment
		{
			// Token: 0x170008DA RID: 2266
			// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x000301AF File Offset: 0x0002E3AF
			[global::Cpp2ILInjected.Token(Token = "0x17000847")]
			public float DedicatedTimeNeeded
			{
				[global::Cpp2ILInjected.Token(Token = "0x60048CE")]
				[global::Cpp2ILInjected.Address(RVA = "0x823B48", Offset = "0x823B48", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FE4 RID: 20452 RVA: 0x000301B2 File Offset: 0x0002E3B2
			[global::Cpp2ILInjected.Token(Token = "0x60048CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x823B54", Offset = "0x823B54", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
			public LocalizedTextSegment(float timeInAnimation, string textKey)
			{
				throw null;
			}

			// Token: 0x06004FE5 RID: 20453 RVA: 0x000301B5 File Offset: 0x0002E3B5
			[global::Cpp2ILInjected.Token(Token = "0x60048D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x823B98", Offset = "0x823B98", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TextRoll", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public LocalizedTextSegment(float timeInAnimation, LocalizedText textObject, Vector2 anchorOffset)
			{
				throw null;
			}

			// Token: 0x06004FE6 RID: 20454 RVA: 0x000301B8 File Offset: 0x0002E3B8
			[global::Cpp2ILInjected.Token(Token = "0x60048D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x823BE4", Offset = "0x823BE4", Length = "0x400")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(byte)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringShadow", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(float),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			public void Draw(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x04008D8A RID: 36234
			[global::Cpp2ILInjected.Token(Token = "0x4008406")]
			private const int PixelsForALine = 120;

			// Token: 0x04008D8B RID: 36235
			[global::Cpp2ILInjected.Token(Token = "0x4008407")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private LocalizedText _text;

			// Token: 0x04008D8C RID: 36236
			[global::Cpp2ILInjected.Token(Token = "0x4008408")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private float _timeToShowPeak;

			// Token: 0x04008D8D RID: 36237
			[global::Cpp2ILInjected.Token(Token = "0x4008409")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private Vector2 _anchorOffset;
		}

		// Token: 0x02000A2D RID: 2605
		[global::Cpp2ILInjected.Token(Token = "0x2000997")]
		public abstract class AnimationSegmentWithActions<T> : IAnimationSegment
		{
			// Token: 0x170008DB RID: 2267
			// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x000301BB File Offset: 0x0002E3BB
			[global::Cpp2ILInjected.Token(Token = "0x17000848")]
			public float DedicatedTimeNeeded
			{
				[global::Cpp2ILInjected.Token(Token = "0x60048D2")]
				[global::Cpp2ILInjected.Address(RVA = "0x15C6108", Offset = "0x15C6108", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.PlayerSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.NPCSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_GuideEmotingAtRainbowPanel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004FE8 RID: 20456 RVA: 0x000301BE File Offset: 0x0002E3BE
			[global::Cpp2ILInjected.Token(Token = "0x60048D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6114", Offset = "0x15C6114", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.PlayerSegment), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.NPCSegment), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(DrawData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public AnimationSegmentWithActions(int targetTime)
			{
				throw null;
			}

			// Token: 0x06004FE9 RID: 20457 RVA: 0x000301C1 File Offset: 0x0002E3C1
			[global::Cpp2ILInjected.Token(Token = "0x60048D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C618C", Offset = "0x15C618C", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.PlayerSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.NPCSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			protected void ProcessActions(T obj, float localTimeForObject)
			{
				throw null;
			}

			// Token: 0x06004FEA RID: 20458 RVA: 0x000301C4 File Offset: 0x0002E3C4
			[global::Cpp2ILInjected.Token(Token = "0x60048D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C62AC", Offset = "0x15C62AC", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_GuideEmotingAtRainbowPanel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_SantaItemExample", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 528)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public Segments.AnimationSegmentWithActions<T> Then(IAnimationSegmentAction<T> act)
			{
				throw null;
			}

			// Token: 0x06004FEB RID: 20459 RVA: 0x000301C7 File Offset: 0x0002E3C7
			[global::Cpp2ILInjected.Token(Token = "0x60048D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15C6414", Offset = "0x15C6414", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 121)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public Segments.AnimationSegmentWithActions<T> With(IAnimationSegmentAction<T> act)
			{
				throw null;
			}

			// Token: 0x06004FEC RID: 20460
			[global::Cpp2ILInjected.Token(Token = "0x60048D7")]
			protected abstract void Bind(IAnimationSegmentAction<T> act);

			// Token: 0x06004FED RID: 20461
			[global::Cpp2ILInjected.Token(Token = "0x60048D8")]
			public abstract void Draw(ref GameAnimationSegment info);

			// Token: 0x04008D8E RID: 36238
			[global::Cpp2ILInjected.Token(Token = "0x400840A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _dedicatedTimeNeeded;

			// Token: 0x04008D8F RID: 36239
			[global::Cpp2ILInjected.Token(Token = "0x400840B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _lastDedicatedTimeNeeded;

			// Token: 0x04008D90 RID: 36240
			[global::Cpp2ILInjected.Token(Token = "0x400840C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			protected int _targetTime;

			// Token: 0x04008D91 RID: 36241
			[global::Cpp2ILInjected.Token(Token = "0x400840D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private List<IAnimationSegmentAction<T>> _actions;
		}

		// Token: 0x02000A2E RID: 2606
		[global::Cpp2ILInjected.Token(Token = "0x2000998")]
		public class PlayerSegment : Segments.AnimationSegmentWithActions<Player>
		{
			// Token: 0x06004FEE RID: 20462 RVA: 0x000301CA File Offset: 0x0002E3CA
			[global::Cpp2ILInjected.Token(Token = "0x60048D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x823FE4", Offset = "0x823FE4", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public PlayerSegment(int targetTime, Vector2 anchorOffset, Vector2 normalizedHitboxOrigin)
			{
				throw null;
			}

			// Token: 0x06004FEF RID: 20463 RVA: 0x000301CD File Offset: 0x0002E3CD
			[global::Cpp2ILInjected.Token(Token = "0x60048DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x824094", Offset = "0x824094", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public Segments.PlayerSegment UseShaderEffect(Segments.PlayerSegment.IShaderEffect shaderEffect)
			{
				throw null;
			}

			// Token: 0x06004FF0 RID: 20464 RVA: 0x000301D0 File Offset: 0x0002E3D0
			[global::Cpp2ILInjected.Token(Token = "0x60048DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x82409C", Offset = "0x82409C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			protected override void Bind(IAnimationSegmentAction<Player> act)
			{
				throw null;
			}

			// Token: 0x06004FF1 RID: 20465 RVA: 0x000301D3 File Offset: 0x0002E3D3
			[global::Cpp2ILInjected.Token(Token = "0x60048DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x824144", Offset = "0x824144", Length = "0x454")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.PlayerSegment), Member = "ResetPlayerAnimation", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "ProcessActions", MemberParameters = new object[]
			{
				"T",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ResetEffects", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "ResetVisibleAccessories", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UpdateMiscCounter", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UpdateDyes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			public override void Draw(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x06004FF2 RID: 20466 RVA: 0x000301D6 File Offset: 0x0002E3D6
			[global::Cpp2ILInjected.Token(Token = "0x60048DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x824598", Offset = "0x824598", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.PlayerSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "CopyVisuals", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void ResetPlayerAnimation(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x06004FF3 RID: 20467 RVA: 0x000301D9 File Offset: 0x0002E3D9
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60048DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x824678", Offset = "0x824678", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			static PlayerSegment()
			{
				throw null;
			}

			// Token: 0x04008D92 RID: 36242
			[global::Cpp2ILInjected.Token(Token = "0x400840E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Player _player;

			// Token: 0x04008D93 RID: 36243
			[global::Cpp2ILInjected.Token(Token = "0x400840F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Vector2 _anchorOffset;

			// Token: 0x04008D94 RID: 36244
			[global::Cpp2ILInjected.Token(Token = "0x4008410")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private Vector2 _normalizedOriginForHitbox;

			// Token: 0x04008D95 RID: 36245
			[global::Cpp2ILInjected.Token(Token = "0x4008411")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private Segments.PlayerSegment.IShaderEffect _shaderEffect;

			// Token: 0x04008D96 RID: 36246
			[global::Cpp2ILInjected.Token(Token = "0x4008412")]
			private static Item _blankItem;

			// Token: 0x02000BCC RID: 3020
			[global::Cpp2ILInjected.Token(Token = "0x2000999")]
			public interface IShaderEffect
			{
				// Token: 0x060054AF RID: 21679
				[global::Cpp2ILInjected.Token(Token = "0x60048DF")]
				void BeforeDrawing(ref GameAnimationSegment info);

				// Token: 0x060054B0 RID: 21680
				[global::Cpp2ILInjected.Token(Token = "0x60048E0")]
				void AfterDrawing(ref GameAnimationSegment info);
			}

			// Token: 0x02000BCD RID: 3021
			[global::Cpp2ILInjected.Token(Token = "0x200099A")]
			public class ImmediateSpritebatchForPlayerDyesEffect : Segments.PlayerSegment.IShaderEffect
			{
				// Token: 0x060054B1 RID: 21681 RVA: 0x00030EF0 File Offset: 0x0002F0F0
				[global::Cpp2ILInjected.Token(Token = "0x60048E1")]
				[global::Cpp2ILInjected.Address(RVA = "0x8246E8", Offset = "0x8246E8", Length = "0x1D8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
				{
					typeof(SpriteSortMode),
					typeof(BlendState),
					typeof(SamplerState),
					typeof(DepthStencilState),
					typeof(RasterizerState),
					typeof(Effect),
					typeof(Matrix?),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
				public void BeforeDrawing(ref GameAnimationSegment info)
				{
					throw null;
				}

				// Token: 0x060054B2 RID: 21682 RVA: 0x00030EF3 File Offset: 0x0002F0F3
				[global::Cpp2ILInjected.Token(Token = "0x60048E2")]
				[global::Cpp2ILInjected.Address(RVA = "0x8248C0", Offset = "0x8248C0", Length = "0x1D8")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
				{
					typeof(SpriteSortMode),
					typeof(BlendState),
					typeof(SamplerState),
					typeof(DepthStencilState),
					typeof(RasterizerState),
					typeof(Effect),
					typeof(Matrix?),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
				public void AfterDrawing(ref GameAnimationSegment info)
				{
					throw null;
				}

				// Token: 0x060054B3 RID: 21683 RVA: 0x00030EF6 File Offset: 0x0002F0F6
				[global::Cpp2ILInjected.Token(Token = "0x60048E3")]
				[global::Cpp2ILInjected.Address(RVA = "0x824A98", Offset = "0x824A98", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public ImmediateSpritebatchForPlayerDyesEffect()
				{
					throw null;
				}
			}
		}

		// Token: 0x02000A2F RID: 2607
		[global::Cpp2ILInjected.Token(Token = "0x200099B")]
		public class NPCSegment : Segments.AnimationSegmentWithActions<NPC>
		{
			// Token: 0x06004FF4 RID: 20468 RVA: 0x000301DC File Offset: 0x0002E3DC
			[global::Cpp2ILInjected.Token(Token = "0x60048E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x824AA0", Offset = "0x824AA0", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_SantaItemExample", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 40)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCSpawnParams)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public NPCSegment(int targetTime, int npcId, Vector2 anchorOffset, Vector2 normalizedNPCHitboxOrigin)
			{
				throw null;
			}

			// Token: 0x06004FF5 RID: 20469 RVA: 0x000301DF File Offset: 0x0002E3DF
			[global::Cpp2ILInjected.Token(Token = "0x60048E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x824C40", Offset = "0x824C40", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			protected override void Bind(IAnimationSegmentAction<NPC> act)
			{
				throw null;
			}

			// Token: 0x06004FF6 RID: 20470 RVA: 0x000301E2 File Offset: 0x0002E3E2
			[global::Cpp2ILInjected.Token(Token = "0x60048E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x824CE8", Offset = "0x824CE8", Length = "0x2FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.NPCSegment), Member = "ResetNPCAnimation", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "ProcessActions", MemberParameters = new object[]
			{
				"T",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "FindFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref ITownNPCProfile)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_Opacity", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "set_Opacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(NPC),
				typeof(bool),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			public override void Draw(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x06004FF7 RID: 20471 RVA: 0x000301E5 File Offset: 0x0002E3E5
			[global::Cpp2ILInjected.Token(Token = "0x60048E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x824FE4", Offset = "0x824FE4", Length = "0x1114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.NPCSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void ResetNPCAnimation(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x04008D97 RID: 36247
			[global::Cpp2ILInjected.Token(Token = "0x4008413")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private NPC _npc;

			// Token: 0x04008D98 RID: 36248
			[global::Cpp2ILInjected.Token(Token = "0x4008414")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Vector2 _anchorOffset;

			// Token: 0x04008D99 RID: 36249
			[global::Cpp2ILInjected.Token(Token = "0x4008415")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private Vector2 _normalizedOriginForHitbox;
		}

		// Token: 0x02000A30 RID: 2608
		[global::Cpp2ILInjected.Token(Token = "0x200099C")]
		public class LooseSprite
		{
			// Token: 0x06004FF8 RID: 20472 RVA: 0x000301E8 File Offset: 0x0002E3E8
			[global::Cpp2ILInjected.Token(Token = "0x60048E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x8260F8", Offset = "0x8260F8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Asset<Texture2D>),
				typeof(int),
				typeof(DrawData),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public LooseSprite(DrawData data, Asset<Texture2D> asset)
			{
				throw null;
			}

			// Token: 0x06004FF9 RID: 20473 RVA: 0x000301EB File Offset: 0x0002E3EB
			[global::Cpp2ILInjected.Token(Token = "0x60048E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x826184", Offset = "0x826184", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x04008D9A RID: 36250
			[global::Cpp2ILInjected.Token(Token = "0x4008416")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private DrawData _originalDrawData;

			// Token: 0x04008D9B RID: 36251
			[global::Cpp2ILInjected.Token(Token = "0x4008417")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private Asset<Texture2D> _asset;

			// Token: 0x04008D9C RID: 36252
			[global::Cpp2ILInjected.Token(Token = "0x4008418")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public DrawData CurrentDrawData;

			// Token: 0x04008D9D RID: 36253
			[global::Cpp2ILInjected.Token(Token = "0x4008419")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public float CurrentOpacity;
		}

		// Token: 0x02000A31 RID: 2609
		[global::Cpp2ILInjected.Token(Token = "0x200099D")]
		public class SpriteSegment : Segments.AnimationSegmentWithActions<Segments.LooseSprite>
		{
			// Token: 0x06004FFA RID: 20474 RVA: 0x000301EE File Offset: 0x0002E3EE
			[global::Cpp2ILInjected.Token(Token = "0x60048EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x8261E0", Offset = "0x8261E0", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_GuideEmotingAtRainbowPanel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.LooseSprite), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(DrawData),
				typeof(Asset<Texture2D>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public SpriteSegment(Asset<Texture2D> asset, int targetTime, DrawData data, Vector2 anchorOffset)
			{
				throw null;
			}

			// Token: 0x06004FFB RID: 20475 RVA: 0x000301F1 File Offset: 0x0002E3F1
			[global::Cpp2ILInjected.Token(Token = "0x60048EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x8262A8", Offset = "0x8262A8", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			protected override void Bind(IAnimationSegmentAction<Segments.LooseSprite> act)
			{
				throw null;
			}

			// Token: 0x06004FFC RID: 20476 RVA: 0x000301F4 File Offset: 0x0002E3F4
			[global::Cpp2ILInjected.Token(Token = "0x60048EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x826350", Offset = "0x826350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			public Segments.SpriteSegment UseShaderEffect(Segments.SpriteSegment.IShaderEffect shaderEffect)
			{
				throw null;
			}

			// Token: 0x06004FFD RID: 20477 RVA: 0x000301F7 File Offset: 0x0002E3F7
			[global::Cpp2ILInjected.Token(Token = "0x60048ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x826358", Offset = "0x826358", Length = "0x2F0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "get_DedicatedTimeNeeded", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.AnimationSegmentWithActions<>), Member = "ProcessActions", MemberParameters = new object[]
			{
				"T",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			public override void Draw(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x06004FFE RID: 20478 RVA: 0x000301FA File Offset: 0x0002E3FA
			[global::Cpp2ILInjected.Token(Token = "0x60048EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x826648", Offset = "0x826648", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void ResetSpriteAnimation(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x04008D9E RID: 36254
			[global::Cpp2ILInjected.Token(Token = "0x400841A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Segments.LooseSprite _sprite;

			// Token: 0x04008D9F RID: 36255
			[global::Cpp2ILInjected.Token(Token = "0x400841B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Vector2 _anchorOffset;

			// Token: 0x04008DA0 RID: 36256
			[global::Cpp2ILInjected.Token(Token = "0x400841C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private Segments.SpriteSegment.IShaderEffect _shaderEffect;

			// Token: 0x02000BCE RID: 3022
			[global::Cpp2ILInjected.Token(Token = "0x200099E")]
			public interface IShaderEffect
			{
				// Token: 0x060054B4 RID: 21684
				[global::Cpp2ILInjected.Token(Token = "0x60048EF")]
				void BeforeDrawing(ref GameAnimationSegment info, ref DrawData drawData);

				// Token: 0x060054B5 RID: 21685
				[global::Cpp2ILInjected.Token(Token = "0x60048F0")]
				void AfterDrawing(ref GameAnimationSegment info, ref DrawData drawData);
			}

			// Token: 0x02000BCF RID: 3023
			[global::Cpp2ILInjected.Token(Token = "0x200099F")]
			public class MaskedFadeEffect : Segments.SpriteSegment.IShaderEffect
			{
				// Token: 0x060054B6 RID: 21686 RVA: 0x00030EF9 File Offset: 0x0002F0F9
				[global::Cpp2ILInjected.Token(Token = "0x60048F1")]
				[global::Cpp2ILInjected.Address(RVA = "0x8266A4", Offset = "0x8266A4", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(IntPtr)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				public MaskedFadeEffect(Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction fetchMatrixMethod = null, string shaderKey = "MaskedFade", int verticalFrameCount = 1, int verticalFrameWait = 1)
				{
					throw null;
				}

				// Token: 0x060054B7 RID: 21687 RVA: 0x00030EFC File Offset: 0x0002F0FC
				[global::Cpp2ILInjected.Token(Token = "0x60048F2")]
				[global::Cpp2ILInjected.Address(RVA = "0x826814", Offset = "0x826814", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				private Matrix DefaultFetchMatrix()
				{
					throw null;
				}

				// Token: 0x060054B8 RID: 21688 RVA: 0x00030EFF File Offset: 0x0002F0FF
				[global::Cpp2ILInjected.Token(Token = "0x60048F3")]
				[global::Cpp2ILInjected.Address(RVA = "0x82686C", Offset = "0x82686C", Length = "0x384")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
				{
					typeof(SpriteSortMode),
					typeof(BlendState),
					typeof(SamplerState),
					typeof(DepthStencilState),
					typeof(RasterizerState),
					typeof(Effect),
					typeof(Matrix?),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseShaderSpecificData", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(MiscShaderData))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = ".ctor", MemberParameters = new object[] { typeof(DrawData) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
				public void BeforeDrawing(ref GameAnimationSegment info, ref DrawData drawData)
				{
					throw null;
				}

				// Token: 0x060054B9 RID: 21689 RVA: 0x00030F02 File Offset: 0x0002F102
				[global::Cpp2ILInjected.Token(Token = "0x60048F4")]
				[global::Cpp2ILInjected.Address(RVA = "0x826C28", Offset = "0x826C28", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public Segments.SpriteSegment.MaskedFadeEffect WithPanX(Segments.Panning panning)
				{
					throw null;
				}

				// Token: 0x060054BA RID: 21690 RVA: 0x00030F05 File Offset: 0x0002F105
				[global::Cpp2ILInjected.Token(Token = "0x60048F5")]
				[global::Cpp2ILInjected.Address(RVA = "0x826C34", Offset = "0x826C34", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public Segments.SpriteSegment.MaskedFadeEffect WithPanY(Segments.Panning panning)
				{
					throw null;
				}

				// Token: 0x060054BB RID: 21691 RVA: 0x00030F08 File Offset: 0x0002F108
				[global::Cpp2ILInjected.Token(Token = "0x60048F6")]
				[global::Cpp2ILInjected.Address(RVA = "0x826C40", Offset = "0x826C40", Length = "0x1FC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DefaultSamplerState", ReturnType = typeof(SamplerState))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
				{
					typeof(SpriteSortMode),
					typeof(BlendState),
					typeof(SamplerState),
					typeof(DepthStencilState),
					typeof(RasterizerState),
					typeof(Effect),
					typeof(Matrix?),
					typeof(bool)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
				public void AfterDrawing(ref GameAnimationSegment info, ref DrawData drawData)
				{
					throw null;
				}

				// Token: 0x04009153 RID: 37203
				[global::Cpp2ILInjected.Token(Token = "0x400841D")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private readonly string _shaderKey;

				// Token: 0x04009154 RID: 37204
				[global::Cpp2ILInjected.Token(Token = "0x400841E")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private readonly int _verticalFrameCount;

				// Token: 0x04009155 RID: 37205
				[global::Cpp2ILInjected.Token(Token = "0x400841F")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private readonly int _verticalFrameWait;

				// Token: 0x04009156 RID: 37206
				[global::Cpp2ILInjected.Token(Token = "0x4008420")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private Segments.Panning _panX;

				// Token: 0x04009157 RID: 37207
				[global::Cpp2ILInjected.Token(Token = "0x4008421")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
				private Segments.Panning _panY;

				// Token: 0x04009158 RID: 37208
				[global::Cpp2ILInjected.Token(Token = "0x4008422")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
				private Segments.SpriteSegment.MaskedFadeEffect.GetMatrixAction _fetchMatrix;

				// Token: 0x02000BDD RID: 3037
				// (Invoke) Token: 0x060054C3 RID: 21699
				[global::Cpp2ILInjected.Token(Token = "0x20009A0")]
				public delegate Matrix GetMatrixAction();
			}
		}

		// Token: 0x02000A32 RID: 2610
		[global::Cpp2ILInjected.Token(Token = "0x20009A1")]
		public struct Panning
		{
			// Token: 0x06004FFF RID: 20479 RVA: 0x000301FD File Offset: 0x0002E3FD
			[global::Cpp2ILInjected.Token(Token = "0x60048FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x826BF0", Offset = "0x826BF0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			public float GetPanAmount(float time)
			{
				throw null;
			}

			// Token: 0x04008DA1 RID: 36257
			[global::Cpp2ILInjected.Token(Token = "0x4008423")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float AmountOverTime;

			// Token: 0x04008DA2 RID: 36258
			[global::Cpp2ILInjected.Token(Token = "0x4008424")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float StartAmount;

			// Token: 0x04008DA3 RID: 36259
			[global::Cpp2ILInjected.Token(Token = "0x4008425")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Delay;

			// Token: 0x04008DA4 RID: 36260
			[global::Cpp2ILInjected.Token(Token = "0x4008426")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public float Duration;
		}

		// Token: 0x02000A33 RID: 2611
		[global::Cpp2ILInjected.Token(Token = "0x20009A2")]
		public class EmoteSegment : IAnimationSegment
		{
			// Token: 0x170008DC RID: 2268
			// (get) Token: 0x06005000 RID: 20480 RVA: 0x00030200 File Offset: 0x0002E400
			// (set) Token: 0x06005001 RID: 20481 RVA: 0x00030203 File Offset: 0x0002E403
			[global::Cpp2ILInjected.Token(Token = "0x17000849")]
			public float DedicatedTimeNeeded
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60048FC")]
				[global::Cpp2ILInjected.Address(RVA = "0x826EA0", Offset = "0x826EA0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60048FD")]
				[global::Cpp2ILInjected.Address(RVA = "0x826EA8", Offset = "0x826EA8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06005002 RID: 20482 RVA: 0x00030206 File Offset: 0x0002E406
			[global::Cpp2ILInjected.Token(Token = "0x60048FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x826EB0", Offset = "0x826EB0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddEmote", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SantaAndTaxCollectorThrowingPresents", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_MerchantAndTravelingMerchantTryingToSellJunk", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DemolitionistAndArmsDealerArguingThenNurseComes", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_TinkererAndMechanic", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_ClothierChasingTruffle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(SegmentInforReport))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 69)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EmoteSegment(int emoteId, int targetTime, int timeToPlay, Vector2 position, SpriteEffects drawEffect, Vector2 velocity = default(Vector2))
			{
				throw null;
			}

			// Token: 0x06005003 RID: 20483 RVA: 0x00030209 File Offset: 0x0002E409
			[global::Cpp2ILInjected.Token(Token = "0x60048FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x826F20", Offset = "0x826F20", Length = "0x3D4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Segments.EmoteSegment), Member = "GetFrame", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public void Draw(ref GameAnimationSegment info)
			{
				throw null;
			}

			// Token: 0x06005004 RID: 20484 RVA: 0x0003020C File Offset: 0x0002E40C
			[global::Cpp2ILInjected.Token(Token = "0x6004900")]
			[global::Cpp2ILInjected.Address(RVA = "0x8272F4", Offset = "0x8272F4", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.EmoteSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private Rectangle GetFrame(int wrappedTime)
			{
				throw null;
			}

			// Token: 0x04008DA5 RID: 36261
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4008427")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private float <DedicatedTimeNeeded>k__BackingField;

			// Token: 0x04008DA6 RID: 36262
			[global::Cpp2ILInjected.Token(Token = "0x4008428")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _targetTime;

			// Token: 0x04008DA7 RID: 36263
			[global::Cpp2ILInjected.Token(Token = "0x4008429")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Vector2 _offset;

			// Token: 0x04008DA8 RID: 36264
			[global::Cpp2ILInjected.Token(Token = "0x400842A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private SpriteEffects _effect;

			// Token: 0x04008DA9 RID: 36265
			[global::Cpp2ILInjected.Token(Token = "0x400842B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _emoteId;

			// Token: 0x04008DAA RID: 36266
			[global::Cpp2ILInjected.Token(Token = "0x400842C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private Vector2 _velocity;
		}
	}
}
