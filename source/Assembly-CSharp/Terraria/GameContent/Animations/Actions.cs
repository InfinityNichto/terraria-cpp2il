using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Skies.CreditsRoll;

namespace Terraria.GameContent.Animations
{
	// Token: 0x02000649 RID: 1609
	[global::Cpp2ILInjected.Token(Token = "0x2000972")]
	public class Actions
	{
		// Token: 0x06003F24 RID: 16164 RVA: 0x0002D44F File Offset: 0x0002B64F
		[global::Cpp2ILInjected.Token(Token = "0x6004847")]
		[global::Cpp2ILInjected.Address(RVA = "0x822164", Offset = "0x822164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Actions()
		{
			throw null;
		}

		// Token: 0x02000A29 RID: 2601
		[global::Cpp2ILInjected.Token(Token = "0x2000973")]
		public class Players
		{
			// Token: 0x06004FE0 RID: 20448 RVA: 0x000301A6 File Offset: 0x0002E3A6
			[global::Cpp2ILInjected.Token(Token = "0x6004848")]
			[global::Cpp2ILInjected.Address(RVA = "0x82216C", Offset = "0x82216C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Players()
			{
				throw null;
			}

			// Token: 0x02000BB0 RID: 2992
			[global::Cpp2ILInjected.Token(Token = "0x2000974")]
			public interface IPlayerAction : IAnimationSegmentAction<Player>
			{
			}

			// Token: 0x02000BB1 RID: 2993
			[global::Cpp2ILInjected.Token(Token = "0x2000975")]
			public class Fade : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x0600542F RID: 21551 RVA: 0x00030D73 File Offset: 0x0002EF73
				[global::Cpp2ILInjected.Token(Token = "0x6004849")]
				[global::Cpp2ILInjected.Address(RVA = "0x822174", Offset = "0x822174", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Fade(float opacityTarget)
				{
					throw null;
				}

				// Token: 0x06005430 RID: 21552 RVA: 0x00030D76 File Offset: 0x0002EF76
				[global::Cpp2ILInjected.Token(Token = "0x600484A")]
				[global::Cpp2ILInjected.Address(RVA = "0x8221A0", Offset = "0x8221A0", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Fade(float opacityTarget, int duration)
				{
					throw null;
				}

				// Token: 0x06005431 RID: 21553 RVA: 0x00030D79 File Offset: 0x0002EF79
				[global::Cpp2ILInjected.Token(Token = "0x600484B")]
				[global::Cpp2ILInjected.Address(RVA = "0x8221D8", Offset = "0x8221D8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

				// Token: 0x17000927 RID: 2343
				// (get) Token: 0x06005432 RID: 21554 RVA: 0x00030D7C File Offset: 0x0002EF7C
				[global::Cpp2ILInjected.Token(Token = "0x1700082F")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600484C")]
					[global::Cpp2ILInjected.Address(RVA = "0x8221DC", Offset = "0x8221DC", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005433 RID: 21555 RVA: 0x00030D7F File Offset: 0x0002EF7F
				[global::Cpp2ILInjected.Token(Token = "0x600484D")]
				[global::Cpp2ILInjected.Address(RVA = "0x8221E4", Offset = "0x8221E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005434 RID: 21556 RVA: 0x00030D82 File Offset: 0x0002EF82
				[global::Cpp2ILInjected.Token(Token = "0x600484E")]
				[global::Cpp2ILInjected.Address(RVA = "0x8221EC", Offset = "0x8221EC", Length = "0xD0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float),
					typeof(bool)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0400910F RID: 37135
				[global::Cpp2ILInjected.Token(Token = "0x40083BC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009110 RID: 37136
				[global::Cpp2ILInjected.Token(Token = "0x40083BD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _opacityTarget;

				// Token: 0x04009111 RID: 37137
				[global::Cpp2ILInjected.Token(Token = "0x40083BE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			// Token: 0x02000BB2 RID: 2994
			[global::Cpp2ILInjected.Token(Token = "0x2000976")]
			public class Wait : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x06005435 RID: 21557 RVA: 0x00030D85 File Offset: 0x0002EF85
				[global::Cpp2ILInjected.Token(Token = "0x600484F")]
				[global::Cpp2ILInjected.Address(RVA = "0x8222BC", Offset = "0x8222BC", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Wait(int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005436 RID: 21558 RVA: 0x00030D88 File Offset: 0x0002EF88
				[global::Cpp2ILInjected.Token(Token = "0x6004850")]
				[global::Cpp2ILInjected.Address(RVA = "0x8222E4", Offset = "0x8222E4", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

				// Token: 0x17000928 RID: 2344
				// (get) Token: 0x06005437 RID: 21559 RVA: 0x00030D8B File Offset: 0x0002EF8B
				[global::Cpp2ILInjected.Token(Token = "0x17000830")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004851")]
					[global::Cpp2ILInjected.Address(RVA = "0x8222E8", Offset = "0x8222E8", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005438 RID: 21560 RVA: 0x00030D8E File Offset: 0x0002EF8E
				[global::Cpp2ILInjected.Token(Token = "0x6004852")]
				[global::Cpp2ILInjected.Address(RVA = "0x8222F0", Offset = "0x8222F0", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x06005439 RID: 21561 RVA: 0x00030D91 File Offset: 0x0002EF91
				[global::Cpp2ILInjected.Token(Token = "0x6004853")]
				[global::Cpp2ILInjected.Address(RVA = "0x82239C", Offset = "0x82239C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009112 RID: 37138
				[global::Cpp2ILInjected.Token(Token = "0x40083BF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009113 RID: 37139
				[global::Cpp2ILInjected.Token(Token = "0x40083C0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BB3 RID: 2995
			[global::Cpp2ILInjected.Token(Token = "0x2000977")]
			public class LookAt : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x0600543A RID: 21562 RVA: 0x00030D94 File Offset: 0x0002EF94
				[global::Cpp2ILInjected.Token(Token = "0x6004854")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223A4", Offset = "0x8223A4", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public LookAt(int direction)
				{
					throw null;
				}

				// Token: 0x0600543B RID: 21563 RVA: 0x00030D97 File Offset: 0x0002EF97
				[global::Cpp2ILInjected.Token(Token = "0x6004855")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223CC", Offset = "0x8223CC", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

				// Token: 0x17000929 RID: 2345
				// (get) Token: 0x0600543C RID: 21564 RVA: 0x00030D9A File Offset: 0x0002EF9A
				[global::Cpp2ILInjected.Token(Token = "0x17000831")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004856")]
					[global::Cpp2ILInjected.Address(RVA = "0x8223D0", Offset = "0x8223D0", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600543D RID: 21565 RVA: 0x00030D9D File Offset: 0x0002EF9D
				[global::Cpp2ILInjected.Token(Token = "0x6004857")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223D8", Offset = "0x8223D8", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0600543E RID: 21566 RVA: 0x00030DA0 File Offset: 0x0002EFA0
				[global::Cpp2ILInjected.Token(Token = "0x6004858")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223F0", Offset = "0x8223F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009114 RID: 37140
				[global::Cpp2ILInjected.Token(Token = "0x40083C1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _direction;

				// Token: 0x04009115 RID: 37141
				[global::Cpp2ILInjected.Token(Token = "0x40083C2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BB4 RID: 2996
			[global::Cpp2ILInjected.Token(Token = "0x2000978")]
			public class MoveWithAcceleration : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
				// Token: 0x0600543F RID: 21567 RVA: 0x00030DA3 File Offset: 0x0002EFA3
				[global::Cpp2ILInjected.Token(Token = "0x6004859")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223F8", Offset = "0x8223F8", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005440 RID: 21568 RVA: 0x00030DA6 File Offset: 0x0002EFA6
				[global::Cpp2ILInjected.Token(Token = "0x600485A")]
				[global::Cpp2ILInjected.Address(RVA = "0x822448", Offset = "0x822448", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

				// Token: 0x1700092A RID: 2346
				// (get) Token: 0x06005441 RID: 21569 RVA: 0x00030DA9 File Offset: 0x0002EFA9
				[global::Cpp2ILInjected.Token(Token = "0x17000832")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600485B")]
					[global::Cpp2ILInjected.Address(RVA = "0x82244C", Offset = "0x82244C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005442 RID: 21570 RVA: 0x00030DAC File Offset: 0x0002EFAC
				[global::Cpp2ILInjected.Token(Token = "0x600485C")]
				[global::Cpp2ILInjected.Address(RVA = "0x822454", Offset = "0x822454", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005443 RID: 21571 RVA: 0x00030DAF File Offset: 0x0002EFAF
				[global::Cpp2ILInjected.Token(Token = "0x600485D")]
				[global::Cpp2ILInjected.Address(RVA = "0x82245C", Offset = "0x82245C", Length = "0x140")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009116 RID: 37142
				[global::Cpp2ILInjected.Token(Token = "0x40083C3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009117 RID: 37143
				[global::Cpp2ILInjected.Token(Token = "0x40083C4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _accelerationPerFrame;

				// Token: 0x04009118 RID: 37144
				[global::Cpp2ILInjected.Token(Token = "0x40083C5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _duration;

				// Token: 0x04009119 RID: 37145
				[global::Cpp2ILInjected.Token(Token = "0x40083C6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private float _delay;
			}
		}

		// Token: 0x02000A2A RID: 2602
		[global::Cpp2ILInjected.Token(Token = "0x2000979")]
		public class NPCs
		{
			// Token: 0x06004FE1 RID: 20449 RVA: 0x000301A9 File Offset: 0x0002E3A9
			[global::Cpp2ILInjected.Token(Token = "0x600485E")]
			[global::Cpp2ILInjected.Address(RVA = "0x82259C", Offset = "0x82259C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NPCs()
			{
				throw null;
			}

			// Token: 0x02000BB5 RID: 2997
			[global::Cpp2ILInjected.Token(Token = "0x200097A")]
			public interface INPCAction : IAnimationSegmentAction<NPC>
			{
			}

			// Token: 0x02000BB6 RID: 2998
			[global::Cpp2ILInjected.Token(Token = "0x200097B")]
			public class Fade : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005444 RID: 21572 RVA: 0x00030DB2 File Offset: 0x0002EFB2
				[global::Cpp2ILInjected.Token(Token = "0x600485F")]
				[global::Cpp2ILInjected.Address(RVA = "0x8225A4", Offset = "0x8225A4", Length = "0x28")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Fade(int alphaPerFrame)
				{
					throw null;
				}

				// Token: 0x06005445 RID: 21573 RVA: 0x00030DB5 File Offset: 0x0002EFB5
				[global::Cpp2ILInjected.Token(Token = "0x6004860")]
				[global::Cpp2ILInjected.Address(RVA = "0x8225CC", Offset = "0x8225CC", Length = "0x2C")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 75)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Fade(int alphaPerFrame, int duration)
				{
					throw null;
				}

				// Token: 0x06005446 RID: 21574 RVA: 0x00030DB8 File Offset: 0x0002EFB8
				[global::Cpp2ILInjected.Token(Token = "0x6004861")]
				[global::Cpp2ILInjected.Address(RVA = "0x8225F8", Offset = "0x8225F8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x1700092B RID: 2347
				// (get) Token: 0x06005447 RID: 21575 RVA: 0x00030DBB File Offset: 0x0002EFBB
				[global::Cpp2ILInjected.Token(Token = "0x17000833")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004862")]
					[global::Cpp2ILInjected.Address(RVA = "0x8225FC", Offset = "0x8225FC", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005448 RID: 21576 RVA: 0x00030DBE File Offset: 0x0002EFBE
				[global::Cpp2ILInjected.Token(Token = "0x6004863")]
				[global::Cpp2ILInjected.Address(RVA = "0x822604", Offset = "0x822604", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005449 RID: 21577 RVA: 0x00030DC1 File Offset: 0x0002EFC1
				[global::Cpp2ILInjected.Token(Token = "0x6004864")]
				[global::Cpp2ILInjected.Address(RVA = "0x82260C", Offset = "0x82260C", Length = "0x100")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
				{
					typeof(int),
					typeof(int),
					typeof(int)
				}, ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0400911A RID: 37146
				[global::Cpp2ILInjected.Token(Token = "0x40083C7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x0400911B RID: 37147
				[global::Cpp2ILInjected.Token(Token = "0x40083C8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private int _alphaPerFrame;

				// Token: 0x0400911C RID: 37148
				[global::Cpp2ILInjected.Token(Token = "0x40083C9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			// Token: 0x02000BB7 RID: 2999
			[global::Cpp2ILInjected.Token(Token = "0x200097C")]
			public class ShowItem : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600544A RID: 21578 RVA: 0x00030DC4 File Offset: 0x0002EFC4
				[global::Cpp2ILInjected.Token(Token = "0x6004865")]
				[global::Cpp2ILInjected.Address(RVA = "0x82270C", Offset = "0x82270C", Length = "0x2C")]
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
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_AnglerAndPirateTalkAboutFish", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public ShowItem(int durationInFrames, int itemIdToShow)
				{
					throw null;
				}

				// Token: 0x0600544B RID: 21579 RVA: 0x00030DC7 File Offset: 0x0002EFC7
				[global::Cpp2ILInjected.Token(Token = "0x6004866")]
				[global::Cpp2ILInjected.Address(RVA = "0x822738", Offset = "0x822738", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x1700092C RID: 2348
				// (get) Token: 0x0600544C RID: 21580 RVA: 0x00030DCA File Offset: 0x0002EFCA
				[global::Cpp2ILInjected.Token(Token = "0x17000834")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004867")]
					[global::Cpp2ILInjected.Address(RVA = "0x82273C", Offset = "0x82273C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600544D RID: 21581 RVA: 0x00030DCD File Offset: 0x0002EFCD
				[global::Cpp2ILInjected.Token(Token = "0x6004868")]
				[global::Cpp2ILInjected.Address(RVA = "0x822744", Offset = "0x822744", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x0600544E RID: 21582 RVA: 0x00030DD0 File Offset: 0x0002EFD0
				[global::Cpp2ILInjected.Token(Token = "0x6004869")]
				[global::Cpp2ILInjected.Address(RVA = "0x82274C", Offset = "0x82274C", Length = "0x11C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0600544F RID: 21583 RVA: 0x00030DD3 File Offset: 0x0002EFD3
				[global::Cpp2ILInjected.Token(Token = "0x600486A")]
				[global::Cpp2ILInjected.Address(RVA = "0x822868", Offset = "0x822868", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private void FixNPCIfWasHoldingItem(NPC obj)
				{
					throw null;
				}

				// Token: 0x0400911D RID: 37149
				[global::Cpp2ILInjected.Token(Token = "0x40083CA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _itemIdToShow;

				// Token: 0x0400911E RID: 37150
				[global::Cpp2ILInjected.Token(Token = "0x40083CB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private int _duration;

				// Token: 0x0400911F RID: 37151
				[global::Cpp2ILInjected.Token(Token = "0x40083CC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			// Token: 0x02000BB8 RID: 3000
			[global::Cpp2ILInjected.Token(Token = "0x200097D")]
			public class Move : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005450 RID: 21584 RVA: 0x00030DD6 File Offset: 0x0002EFD6
				[global::Cpp2ILInjected.Token(Token = "0x600486B")]
				[global::Cpp2ILInjected.Address(RVA = "0x82288C", Offset = "0x82288C", Length = "0x3C")]
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
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 92)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Move(Vector2 offsetPerFrame, int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005451 RID: 21585 RVA: 0x00030DD9 File Offset: 0x0002EFD9
				[global::Cpp2ILInjected.Token(Token = "0x600486C")]
				[global::Cpp2ILInjected.Address(RVA = "0x8228C8", Offset = "0x8228C8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x1700092D RID: 2349
				// (get) Token: 0x06005452 RID: 21586 RVA: 0x00030DDC File Offset: 0x0002EFDC
				[global::Cpp2ILInjected.Token(Token = "0x17000835")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600486D")]
					[global::Cpp2ILInjected.Address(RVA = "0x8228CC", Offset = "0x8228CC", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005453 RID: 21587 RVA: 0x00030DDF File Offset: 0x0002EFDF
				[global::Cpp2ILInjected.Token(Token = "0x600486E")]
				[global::Cpp2ILInjected.Address(RVA = "0x8228D4", Offset = "0x8228D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005454 RID: 21588 RVA: 0x00030DE2 File Offset: 0x0002EFE2
				[global::Cpp2ILInjected.Token(Token = "0x600486F")]
				[global::Cpp2ILInjected.Address(RVA = "0x8228DC", Offset = "0x8228DC", Length = "0xEC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009120 RID: 37152
				[global::Cpp2ILInjected.Token(Token = "0x40083CD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009121 RID: 37153
				[global::Cpp2ILInjected.Token(Token = "0x40083CE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int _duration;

				// Token: 0x04009122 RID: 37154
				[global::Cpp2ILInjected.Token(Token = "0x40083CF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private float _delay;
			}

			// Token: 0x02000BB9 RID: 3001
			[global::Cpp2ILInjected.Token(Token = "0x200097E")]
			public class MoveWithAcceleration : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005455 RID: 21589 RVA: 0x00030DE5 File Offset: 0x0002EFE5
				[global::Cpp2ILInjected.Token(Token = "0x6004870")]
				[global::Cpp2ILInjected.Address(RVA = "0x8229C8", Offset = "0x8229C8", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2),
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public MoveWithAcceleration(Vector2 offsetPerFrame, Vector2 accelerationPerFrame, int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005456 RID: 21590 RVA: 0x00030DE8 File Offset: 0x0002EFE8
				[global::Cpp2ILInjected.Token(Token = "0x6004871")]
				[global::Cpp2ILInjected.Address(RVA = "0x822A18", Offset = "0x822A18", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x1700092E RID: 2350
				// (get) Token: 0x06005457 RID: 21591 RVA: 0x00030DEB File Offset: 0x0002EFEB
				[global::Cpp2ILInjected.Token(Token = "0x17000836")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004872")]
					[global::Cpp2ILInjected.Address(RVA = "0x822A1C", Offset = "0x822A1C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005458 RID: 21592 RVA: 0x00030DEE File Offset: 0x0002EFEE
				[global::Cpp2ILInjected.Token(Token = "0x6004873")]
				[global::Cpp2ILInjected.Address(RVA = "0x822A24", Offset = "0x822A24", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005459 RID: 21593 RVA: 0x00030DF1 File Offset: 0x0002EFF1
				[global::Cpp2ILInjected.Token(Token = "0x6004874")]
				[global::Cpp2ILInjected.Address(RVA = "0x822A2C", Offset = "0x822A2C", Length = "0x144")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009123 RID: 37155
				[global::Cpp2ILInjected.Token(Token = "0x40083D0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009124 RID: 37156
				[global::Cpp2ILInjected.Token(Token = "0x40083D1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _accelerationPerFrame;

				// Token: 0x04009125 RID: 37157
				[global::Cpp2ILInjected.Token(Token = "0x40083D2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _duration;

				// Token: 0x04009126 RID: 37158
				[global::Cpp2ILInjected.Token(Token = "0x40083D3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private float _delay;
			}

			// Token: 0x02000BBA RID: 3002
			[global::Cpp2ILInjected.Token(Token = "0x200097F")]
			public class MoveWithRotor : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600545A RID: 21594 RVA: 0x00030DF4 File Offset: 0x0002EFF4
				[global::Cpp2ILInjected.Token(Token = "0x6004875")]
				[global::Cpp2ILInjected.Address(RVA = "0x822B70", Offset = "0x822B70", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public MoveWithRotor(Vector2 radialOffset, float rotationPerFrame, Vector2 resultMultiplier, int durationInFrames)
				{
					throw null;
				}

				// Token: 0x0600545B RID: 21595 RVA: 0x00030DF7 File Offset: 0x0002EFF7
				[global::Cpp2ILInjected.Token(Token = "0x6004876")]
				[global::Cpp2ILInjected.Address(RVA = "0x822BD0", Offset = "0x822BD0", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x1700092F RID: 2351
				// (get) Token: 0x0600545C RID: 21596 RVA: 0x00030DFA File Offset: 0x0002EFFA
				[global::Cpp2ILInjected.Token(Token = "0x17000837")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004877")]
					[global::Cpp2ILInjected.Address(RVA = "0x822BD4", Offset = "0x822BD4", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600545D RID: 21597 RVA: 0x00030DFD File Offset: 0x0002EFFD
				[global::Cpp2ILInjected.Token(Token = "0x6004878")]
				[global::Cpp2ILInjected.Address(RVA = "0x822BDC", Offset = "0x822BDC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x0600545E RID: 21598 RVA: 0x00030E00 File Offset: 0x0002F000
				[global::Cpp2ILInjected.Token(Token = "0x6004879")]
				[global::Cpp2ILInjected.Address(RVA = "0x822BE4", Offset = "0x822BE4", Length = "0x114")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
				{
					typeof(Vector2),
					typeof(double),
					typeof(Vector2)
				}, ReturnType = typeof(Vector2))]
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
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009127 RID: 37159
				[global::Cpp2ILInjected.Token(Token = "0x40083D4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				// Token: 0x04009128 RID: 37160
				[global::Cpp2ILInjected.Token(Token = "0x40083D5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _resultMultiplier;

				// Token: 0x04009129 RID: 37161
				[global::Cpp2ILInjected.Token(Token = "0x40083D6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private float _radialOffset;

				// Token: 0x0400912A RID: 37162
				[global::Cpp2ILInjected.Token(Token = "0x40083D7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private int _duration;

				// Token: 0x0400912B RID: 37163
				[global::Cpp2ILInjected.Token(Token = "0x40083D8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				private float _delay;
			}

			// Token: 0x02000BBB RID: 3003
			[global::Cpp2ILInjected.Token(Token = "0x2000980")]
			public class DoBunnyRestAnimation : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600545F RID: 21599 RVA: 0x00030E03 File Offset: 0x0002F003
				[global::Cpp2ILInjected.Token(Token = "0x600487A")]
				[global::Cpp2ILInjected.Address(RVA = "0x822CF8", Offset = "0x822CF8", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public DoBunnyRestAnimation(int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005460 RID: 21600 RVA: 0x00030E06 File Offset: 0x0002F006
				[global::Cpp2ILInjected.Token(Token = "0x600487B")]
				[global::Cpp2ILInjected.Address(RVA = "0x822D20", Offset = "0x822D20", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000930 RID: 2352
				// (get) Token: 0x06005461 RID: 21601 RVA: 0x00030E09 File Offset: 0x0002F009
				[global::Cpp2ILInjected.Token(Token = "0x17000838")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600487C")]
					[global::Cpp2ILInjected.Address(RVA = "0x822D24", Offset = "0x822D24", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005462 RID: 21602 RVA: 0x00030E0C File Offset: 0x0002F00C
				[global::Cpp2ILInjected.Token(Token = "0x600487D")]
				[global::Cpp2ILInjected.Address(RVA = "0x822D2C", Offset = "0x822D2C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005463 RID: 21603 RVA: 0x00030E0F File Offset: 0x0002F00F
				[global::Cpp2ILInjected.Token(Token = "0x600487E")]
				[global::Cpp2ILInjected.Address(RVA = "0x822D34", Offset = "0x822D34", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0400912C RID: 37164
				[global::Cpp2ILInjected.Token(Token = "0x40083D9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x0400912D RID: 37165
				[global::Cpp2ILInjected.Token(Token = "0x40083DA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BBC RID: 3004
			[global::Cpp2ILInjected.Token(Token = "0x2000981")]
			public class Wait : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005464 RID: 21604 RVA: 0x00030E12 File Offset: 0x0002F012
				[global::Cpp2ILInjected.Token(Token = "0x600487F")]
				[global::Cpp2ILInjected.Address(RVA = "0x822DD4", Offset = "0x822DD4", Length = "0x28")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 139)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Wait(int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005465 RID: 21605 RVA: 0x00030E15 File Offset: 0x0002F015
				[global::Cpp2ILInjected.Token(Token = "0x6004880")]
				[global::Cpp2ILInjected.Address(RVA = "0x822DFC", Offset = "0x822DFC", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000931 RID: 2353
				// (get) Token: 0x06005466 RID: 21606 RVA: 0x00030E18 File Offset: 0x0002F018
				[global::Cpp2ILInjected.Token(Token = "0x17000839")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004881")]
					[global::Cpp2ILInjected.Address(RVA = "0x822E00", Offset = "0x822E00", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005467 RID: 21607 RVA: 0x00030E1B File Offset: 0x0002F01B
				[global::Cpp2ILInjected.Token(Token = "0x6004882")]
				[global::Cpp2ILInjected.Address(RVA = "0x822E08", Offset = "0x822E08", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x06005468 RID: 21608 RVA: 0x00030E1E File Offset: 0x0002F01E
				[global::Cpp2ILInjected.Token(Token = "0x6004883")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EB4", Offset = "0x822EB4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x0400912E RID: 37166
				[global::Cpp2ILInjected.Token(Token = "0x40083DB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x0400912F RID: 37167
				[global::Cpp2ILInjected.Token(Token = "0x40083DC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BBD RID: 3005
			[global::Cpp2ILInjected.Token(Token = "0x2000982")]
			public class Blink : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005469 RID: 21609 RVA: 0x00030E21 File Offset: 0x0002F021
				[global::Cpp2ILInjected.Token(Token = "0x6004884")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EBC", Offset = "0x822EBC", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2),
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Blink(int durationInFrames)
				{
					throw null;
				}

				// Token: 0x0600546A RID: 21610 RVA: 0x00030E24 File Offset: 0x0002F024
				[global::Cpp2ILInjected.Token(Token = "0x6004885")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EE4", Offset = "0x822EE4", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000932 RID: 2354
				// (get) Token: 0x0600546B RID: 21611 RVA: 0x00030E27 File Offset: 0x0002F027
				[global::Cpp2ILInjected.Token(Token = "0x1700083A")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004886")]
					[global::Cpp2ILInjected.Address(RVA = "0x822EE8", Offset = "0x822EE8", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600546C RID: 21612 RVA: 0x00030E2A File Offset: 0x0002F02A
				[global::Cpp2ILInjected.Token(Token = "0x6004887")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EF0", Offset = "0x822EF0", Length = "0xE0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0600546D RID: 21613 RVA: 0x00030E2D File Offset: 0x0002F02D
				[global::Cpp2ILInjected.Token(Token = "0x6004888")]
				[global::Cpp2ILInjected.Address(RVA = "0x822FD0", Offset = "0x822FD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009130 RID: 37168
				[global::Cpp2ILInjected.Token(Token = "0x40083DD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009131 RID: 37169
				[global::Cpp2ILInjected.Token(Token = "0x40083DE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BBE RID: 3006
			[global::Cpp2ILInjected.Token(Token = "0x2000983")]
			public class LookAt : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600546E RID: 21614 RVA: 0x00030E30 File Offset: 0x0002F030
				[global::Cpp2ILInjected.Token(Token = "0x6004889")]
				[global::Cpp2ILInjected.Address(RVA = "0x822FD8", Offset = "0x822FD8", Length = "0x28")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public LookAt(int direction)
				{
					throw null;
				}

				// Token: 0x0600546F RID: 21615 RVA: 0x00030E33 File Offset: 0x0002F033
				[global::Cpp2ILInjected.Token(Token = "0x600488A")]
				[global::Cpp2ILInjected.Address(RVA = "0x823000", Offset = "0x823000", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000933 RID: 2355
				// (get) Token: 0x06005470 RID: 21616 RVA: 0x00030E36 File Offset: 0x0002F036
				[global::Cpp2ILInjected.Token(Token = "0x1700083B")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600488B")]
					[global::Cpp2ILInjected.Address(RVA = "0x823004", Offset = "0x823004", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005471 RID: 21617 RVA: 0x00030E39 File Offset: 0x0002F039
				[global::Cpp2ILInjected.Token(Token = "0x600488C")]
				[global::Cpp2ILInjected.Address(RVA = "0x82300C", Offset = "0x82300C", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x06005472 RID: 21618 RVA: 0x00030E3C File Offset: 0x0002F03C
				[global::Cpp2ILInjected.Token(Token = "0x600488D")]
				[global::Cpp2ILInjected.Address(RVA = "0x823028", Offset = "0x823028", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009132 RID: 37170
				[global::Cpp2ILInjected.Token(Token = "0x40083DF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _direction;

				// Token: 0x04009133 RID: 37171
				[global::Cpp2ILInjected.Token(Token = "0x40083E0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BBF RID: 3007
			[global::Cpp2ILInjected.Token(Token = "0x2000984")]
			public class PartyHard : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005473 RID: 21619 RVA: 0x00030E3F File Offset: 0x0002F03F
				[global::Cpp2ILInjected.Token(Token = "0x600488E")]
				[global::Cpp2ILInjected.Address(RVA = "0x823030", Offset = "0x823030", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "AddWavingNPC", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2),
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public PartyHard()
				{
					throw null;
				}

				// Token: 0x06005474 RID: 21620 RVA: 0x00030E42 File Offset: 0x0002F042
				[global::Cpp2ILInjected.Token(Token = "0x600488F")]
				[global::Cpp2ILInjected.Address(RVA = "0x823038", Offset = "0x823038", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "UpdateAltTexture", ReturnType = typeof(void))]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000934 RID: 2356
				// (get) Token: 0x06005475 RID: 21621 RVA: 0x00030E45 File Offset: 0x0002F045
				[global::Cpp2ILInjected.Token(Token = "0x1700083C")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004890")]
					[global::Cpp2ILInjected.Address(RVA = "0x82304C", Offset = "0x82304C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005476 RID: 21622 RVA: 0x00030E48 File Offset: 0x0002F048
				[global::Cpp2ILInjected.Token(Token = "0x6004891")]
				[global::Cpp2ILInjected.Address(RVA = "0x823054", Offset = "0x823054", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x06005477 RID: 21623 RVA: 0x00030E4B File Offset: 0x0002F04B
				[global::Cpp2ILInjected.Token(Token = "0x6004892")]
				[global::Cpp2ILInjected.Address(RVA = "0x823058", Offset = "0x823058", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}
			}

			// Token: 0x02000BC0 RID: 3008
			[global::Cpp2ILInjected.Token(Token = "0x2000985")]
			public class ForceAltTexture : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005478 RID: 21624 RVA: 0x00030E4E File Offset: 0x0002F04E
				[global::Cpp2ILInjected.Token(Token = "0x6004893")]
				[global::Cpp2ILInjected.Address(RVA = "0x82305C", Offset = "0x82305C", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public ForceAltTexture(int altTexture)
				{
					throw null;
				}

				// Token: 0x06005479 RID: 21625 RVA: 0x00030E51 File Offset: 0x0002F051
				[global::Cpp2ILInjected.Token(Token = "0x6004894")]
				[global::Cpp2ILInjected.Address(RVA = "0x823084", Offset = "0x823084", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000935 RID: 2357
				// (get) Token: 0x0600547A RID: 21626 RVA: 0x00030E54 File Offset: 0x0002F054
				[global::Cpp2ILInjected.Token(Token = "0x1700083D")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x6004895")]
					[global::Cpp2ILInjected.Address(RVA = "0x823090", Offset = "0x823090", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600547B RID: 21627 RVA: 0x00030E57 File Offset: 0x0002F057
				[global::Cpp2ILInjected.Token(Token = "0x6004896")]
				[global::Cpp2ILInjected.Address(RVA = "0x823098", Offset = "0x823098", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0600547C RID: 21628 RVA: 0x00030E5A File Offset: 0x0002F05A
				[global::Cpp2ILInjected.Token(Token = "0x6004897")]
				[global::Cpp2ILInjected.Address(RVA = "0x82309C", Offset = "0x82309C", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009134 RID: 37172
				[global::Cpp2ILInjected.Token(Token = "0x40083E1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _altTexture;
			}

			// Token: 0x02000BC1 RID: 3009
			[global::Cpp2ILInjected.Token(Token = "0x2000986")]
			public class Variant : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x0600547D RID: 21629 RVA: 0x00030E5D File Offset: 0x0002F05D
				[global::Cpp2ILInjected.Token(Token = "0x6004898")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230A0", Offset = "0x8230A0", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_DryadTurningToTree", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WizardPartyGirlDyeTraderAndPainterPartyWithBunnies", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Variant(int variant)
				{
					throw null;
				}

				// Token: 0x0600547E RID: 21630 RVA: 0x00030E60 File Offset: 0x0002F060
				[global::Cpp2ILInjected.Token(Token = "0x6004899")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230C8", Offset = "0x8230C8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000936 RID: 2358
				// (get) Token: 0x0600547F RID: 21631 RVA: 0x00030E63 File Offset: 0x0002F063
				[global::Cpp2ILInjected.Token(Token = "0x1700083E")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600489A")]
					[global::Cpp2ILInjected.Address(RVA = "0x8230D4", Offset = "0x8230D4", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005480 RID: 21632 RVA: 0x00030E66 File Offset: 0x0002F066
				[global::Cpp2ILInjected.Token(Token = "0x600489B")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230DC", Offset = "0x8230DC", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x06005481 RID: 21633 RVA: 0x00030E69 File Offset: 0x0002F069
				[global::Cpp2ILInjected.Token(Token = "0x600489C")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230E0", Offset = "0x8230E0", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009135 RID: 37173
				[global::Cpp2ILInjected.Token(Token = "0x40083E2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _variant;
			}

			// Token: 0x02000BC2 RID: 3010
			[global::Cpp2ILInjected.Token(Token = "0x2000987")]
			public class ZombieKnockOnDoor : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
				// Token: 0x06005482 RID: 21634 RVA: 0x00030E6C File Offset: 0x0002F06C
				[global::Cpp2ILInjected.Token(Token = "0x600489D")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230E4", Offset = "0x8230E4", Length = "0x70")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_GuideRunningFromZombie", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public ZombieKnockOnDoor(int durationInFrames)
				{
					throw null;
				}

				// Token: 0x06005483 RID: 21635 RVA: 0x00030E6F File Offset: 0x0002F06F
				[global::Cpp2ILInjected.Token(Token = "0x600489E")]
				[global::Cpp2ILInjected.Address(RVA = "0x823154", Offset = "0x823154", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

				// Token: 0x17000937 RID: 2359
				// (get) Token: 0x06005484 RID: 21636 RVA: 0x00030E72 File Offset: 0x0002F072
				[global::Cpp2ILInjected.Token(Token = "0x1700083F")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x600489F")]
					[global::Cpp2ILInjected.Address(RVA = "0x823158", Offset = "0x823158", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005485 RID: 21637 RVA: 0x00030E75 File Offset: 0x0002F075
				[global::Cpp2ILInjected.Token(Token = "0x60048A0")]
				[global::Cpp2ILInjected.Address(RVA = "0x823160", Offset = "0x823160", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005486 RID: 21638 RVA: 0x00030E78 File Offset: 0x0002F078
				[global::Cpp2ILInjected.Token(Token = "0x60048A1")]
				[global::Cpp2ILInjected.Address(RVA = "0x823168", Offset = "0x823168", Length = "0x14C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
				{
					typeof(Vector2),
					typeof(Vector2)
				}, ReturnType = typeof(Vector2))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
				{
					typeof(Vector2),
					typeof(Vector2)
				}, ReturnType = typeof(Vector2))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009136 RID: 37174
				[global::Cpp2ILInjected.Token(Token = "0x40083E3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009137 RID: 37175
				[global::Cpp2ILInjected.Token(Token = "0x40083E4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;

				// Token: 0x04009138 RID: 37176
				[global::Cpp2ILInjected.Token(Token = "0x40083E5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 bumpOffset;

				// Token: 0x04009139 RID: 37177
				[global::Cpp2ILInjected.Token(Token = "0x40083E6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private Vector2 bumpVelocity;
			}
		}

		// Token: 0x02000A2B RID: 2603
		[global::Cpp2ILInjected.Token(Token = "0x2000988")]
		public class Sprites
		{
			// Token: 0x06004FE2 RID: 20450 RVA: 0x000301AC File Offset: 0x0002E3AC
			[global::Cpp2ILInjected.Token(Token = "0x60048A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8232B4", Offset = "0x8232B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sprites()
			{
				throw null;
			}

			// Token: 0x02000BC3 RID: 3011
			[global::Cpp2ILInjected.Token(Token = "0x2000989")]
			public interface ISpriteAction : IAnimationSegmentAction<Segments.LooseSprite>
			{
			}

			// Token: 0x02000BC4 RID: 3012
			[global::Cpp2ILInjected.Token(Token = "0x200098A")]
			public class Fade : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x06005487 RID: 21639 RVA: 0x00030E7B File Offset: 0x0002F07B
				[global::Cpp2ILInjected.Token(Token = "0x60048A3")]
				[global::Cpp2ILInjected.Address(RVA = "0x8232BC", Offset = "0x8232BC", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_PrincessAndEveryoneThanksPlayer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Fade(float opacityTarget)
				{
					throw null;
				}

				// Token: 0x06005488 RID: 21640 RVA: 0x00030E7E File Offset: 0x0002F07E
				[global::Cpp2ILInjected.Token(Token = "0x60048A4")]
				[global::Cpp2ILInjected.Address(RVA = "0x8232E8", Offset = "0x8232E8", Length = "0x38")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Fade(float opacityTarget, int duration)
				{
					throw null;
				}

				// Token: 0x06005489 RID: 21641 RVA: 0x00030E81 File Offset: 0x0002F081
				[global::Cpp2ILInjected.Token(Token = "0x60048A5")]
				[global::Cpp2ILInjected.Address(RVA = "0x823320", Offset = "0x823320", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

				// Token: 0x17000938 RID: 2360
				// (get) Token: 0x0600548A RID: 21642 RVA: 0x00030E84 File Offset: 0x0002F084
				[global::Cpp2ILInjected.Token(Token = "0x17000840")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x60048A6")]
					[global::Cpp2ILInjected.Address(RVA = "0x823324", Offset = "0x823324", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600548B RID: 21643 RVA: 0x00030E87 File Offset: 0x0002F087
				[global::Cpp2ILInjected.Token(Token = "0x60048A7")]
				[global::Cpp2ILInjected.Address(RVA = "0x82332C", Offset = "0x82332C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x0600548C RID: 21644 RVA: 0x00030E8A File Offset: 0x0002F08A
				[global::Cpp2ILInjected.Token(Token = "0x60048A8")]
				[global::Cpp2ILInjected.Address(RVA = "0x823334", Offset = "0x823334", Length = "0xD0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float),
					typeof(bool)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0400913A RID: 37178
				[global::Cpp2ILInjected.Token(Token = "0x40083E7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x0400913B RID: 37179
				[global::Cpp2ILInjected.Token(Token = "0x40083E8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _opacityTarget;

				// Token: 0x0400913C RID: 37180
				[global::Cpp2ILInjected.Token(Token = "0x40083E9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			// Token: 0x02000BC5 RID: 3013
			[global::Cpp2ILInjected.Token(Token = "0x200098B")]
			public abstract class AScale : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x0600548D RID: 21645 RVA: 0x00030E8D File Offset: 0x0002F08D
				[global::Cpp2ILInjected.Token(Token = "0x60048A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x823404", Offset = "0x823404", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public AScale(Vector2 scaleTarget)
				{
					throw null;
				}

				// Token: 0x0600548E RID: 21646 RVA: 0x00030E90 File Offset: 0x0002F090
				[global::Cpp2ILInjected.Token(Token = "0x60048AA")]
				[global::Cpp2ILInjected.Address(RVA = "0x823434", Offset = "0x823434", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public AScale(Vector2 scaleTarget, int duration)
				{
					throw null;
				}

				// Token: 0x0600548F RID: 21647 RVA: 0x00030E93 File Offset: 0x0002F093
				[global::Cpp2ILInjected.Token(Token = "0x60048AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x823470", Offset = "0x823470", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

				// Token: 0x17000939 RID: 2361
				// (get) Token: 0x06005490 RID: 21648 RVA: 0x00030E96 File Offset: 0x0002F096
				[global::Cpp2ILInjected.Token(Token = "0x17000841")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x60048AC")]
					[global::Cpp2ILInjected.Address(RVA = "0x823474", Offset = "0x823474", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06005491 RID: 21649 RVA: 0x00030E99 File Offset: 0x0002F099
				[global::Cpp2ILInjected.Token(Token = "0x60048AD")]
				[global::Cpp2ILInjected.Address(RVA = "0x82347C", Offset = "0x82347C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x06005492 RID: 21650 RVA: 0x00030E9C File Offset: 0x0002F09C
				[global::Cpp2ILInjected.Token(Token = "0x60048AE")]
				[global::Cpp2ILInjected.Address(RVA = "0x823484", Offset = "0x823484", Length = "0xDC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
				{
					typeof(Vector2),
					typeof(Vector2),
					typeof(float)
				}, ReturnType = typeof(Vector2))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x06005493 RID: 21651
				[global::Cpp2ILInjected.Token(Token = "0x60048AF")]
				protected abstract float GetProgress(float durationInFramesToApply);

				// Token: 0x0400913D RID: 37181
				[global::Cpp2ILInjected.Token(Token = "0x40083EA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				protected int Duration;

				// Token: 0x0400913E RID: 37182
				[global::Cpp2ILInjected.Token(Token = "0x40083EB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private Vector2 _scaleTarget;

				// Token: 0x0400913F RID: 37183
				[global::Cpp2ILInjected.Token(Token = "0x40083EC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private float _delay;
			}

			// Token: 0x02000BC6 RID: 3014
			[global::Cpp2ILInjected.Token(Token = "0x200098C")]
			public class LinearScale : Actions.Sprites.AScale
			{
				// Token: 0x06005494 RID: 21652 RVA: 0x00030E9F File Offset: 0x0002F09F
				[global::Cpp2ILInjected.Token(Token = "0x60048B0")]
				[global::Cpp2ILInjected.Address(RVA = "0x823560", Offset = "0x823560", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public LinearScale(Vector2 scaleTarget)
				{
					throw null;
				}

				// Token: 0x06005495 RID: 21653 RVA: 0x00030EA2 File Offset: 0x0002F0A2
				[global::Cpp2ILInjected.Token(Token = "0x60048B1")]
				[global::Cpp2ILInjected.Address(RVA = "0x823590", Offset = "0x823590", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public LinearScale(Vector2 scaleTarget, int duration)
				{
					throw null;
				}

				// Token: 0x06005496 RID: 21654 RVA: 0x00030EA5 File Offset: 0x0002F0A5
				[global::Cpp2ILInjected.Token(Token = "0x60048B2")]
				[global::Cpp2ILInjected.Address(RVA = "0x8235CC", Offset = "0x8235CC", Length = "0x74")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float),
					typeof(bool)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				protected override float GetProgress(float durationInFramesToApply)
				{
					throw null;
				}
			}

			// Token: 0x02000BC7 RID: 3015
			[global::Cpp2ILInjected.Token(Token = "0x200098D")]
			public class OutCircleScale : Actions.Sprites.AScale
			{
				// Token: 0x06005497 RID: 21655 RVA: 0x00030EA8 File Offset: 0x0002F0A8
				[global::Cpp2ILInjected.Token(Token = "0x60048B3")]
				[global::Cpp2ILInjected.Address(RVA = "0x823640", Offset = "0x823640", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public OutCircleScale(Vector2 scaleTarget)
				{
					throw null;
				}

				// Token: 0x06005498 RID: 21656 RVA: 0x00030EAB File Offset: 0x0002F0AB
				[global::Cpp2ILInjected.Token(Token = "0x60048B4")]
				[global::Cpp2ILInjected.Address(RVA = "0x823670", Offset = "0x823670", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public OutCircleScale(Vector2 scaleTarget, int duration)
				{
					throw null;
				}

				// Token: 0x06005499 RID: 21657 RVA: 0x00030EAE File Offset: 0x0002F0AE
				[global::Cpp2ILInjected.Token(Token = "0x60048B5")]
				[global::Cpp2ILInjected.Address(RVA = "0x8236AC", Offset = "0x8236AC", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
				{
					typeof(float),
					typeof(float),
					typeof(float),
					typeof(bool)
				}, ReturnType = typeof(float))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				protected override float GetProgress(float durationInFramesToApply)
				{
					throw null;
				}
			}

			// Token: 0x02000BC8 RID: 3016
			[global::Cpp2ILInjected.Token(Token = "0x200098E")]
			public class Wait : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x0600549A RID: 21658 RVA: 0x00030EB1 File Offset: 0x0002F0B1
				[global::Cpp2ILInjected.Token(Token = "0x60048B6")]
				[global::Cpp2ILInjected.Address(RVA = "0x823760", Offset = "0x823760", Length = "0x28")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 101)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public Wait(int durationInFrames)
				{
					throw null;
				}

				// Token: 0x0600549B RID: 21659 RVA: 0x00030EB4 File Offset: 0x0002F0B4
				[global::Cpp2ILInjected.Token(Token = "0x60048B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x823788", Offset = "0x823788", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

				// Token: 0x1700093A RID: 2362
				// (get) Token: 0x0600549C RID: 21660 RVA: 0x00030EB7 File Offset: 0x0002F0B7
				[global::Cpp2ILInjected.Token(Token = "0x17000842")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x60048B8")]
					[global::Cpp2ILInjected.Address(RVA = "0x82378C", Offset = "0x82378C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x0600549D RID: 21661 RVA: 0x00030EBA File Offset: 0x0002F0BA
				[global::Cpp2ILInjected.Token(Token = "0x60048B9")]
				[global::Cpp2ILInjected.Address(RVA = "0x823794", Offset = "0x823794", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0600549E RID: 21662 RVA: 0x00030EBD File Offset: 0x0002F0BD
				[global::Cpp2ILInjected.Token(Token = "0x60048BA")]
				[global::Cpp2ILInjected.Address(RVA = "0x823798", Offset = "0x823798", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x04009140 RID: 37184
				[global::Cpp2ILInjected.Token(Token = "0x40083ED")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009141 RID: 37185
				[global::Cpp2ILInjected.Token(Token = "0x40083EE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			// Token: 0x02000BC9 RID: 3017
			[global::Cpp2ILInjected.Token(Token = "0x200098F")]
			public class SimulateGravity : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x0600549F RID: 21663 RVA: 0x00030EC0 File Offset: 0x0002F0C0
				[global::Cpp2ILInjected.Token(Token = "0x60048BB")]
				[global::Cpp2ILInjected.Address(RVA = "0x8237A0", Offset = "0x8237A0", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_DryadSayingByeToTavernKeep", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public SimulateGravity(Vector2 initialVelocity, Vector2 gravityPerFrame, float rotationPerFrame, int duration)
				{
					throw null;
				}

				// Token: 0x060054A0 RID: 21664 RVA: 0x00030EC3 File Offset: 0x0002F0C3
				[global::Cpp2ILInjected.Token(Token = "0x60048BC")]
				[global::Cpp2ILInjected.Address(RVA = "0x823800", Offset = "0x823800", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

				// Token: 0x1700093B RID: 2363
				// (get) Token: 0x060054A1 RID: 21665 RVA: 0x00030EC6 File Offset: 0x0002F0C6
				[global::Cpp2ILInjected.Token(Token = "0x17000843")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x60048BD")]
					[global::Cpp2ILInjected.Address(RVA = "0x823804", Offset = "0x823804", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x060054A2 RID: 21666 RVA: 0x00030EC9 File Offset: 0x0002F0C9
				[global::Cpp2ILInjected.Token(Token = "0x60048BE")]
				[global::Cpp2ILInjected.Address(RVA = "0x82380C", Offset = "0x82380C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x060054A3 RID: 21667 RVA: 0x00030ECC File Offset: 0x0002F0CC
				[global::Cpp2ILInjected.Token(Token = "0x60048BF")]
				[global::Cpp2ILInjected.Address(RVA = "0x823814", Offset = "0x823814", Length = "0x104")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009142 RID: 37186
				[global::Cpp2ILInjected.Token(Token = "0x40083EF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				// Token: 0x04009143 RID: 37187
				[global::Cpp2ILInjected.Token(Token = "0x40083F0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;

				// Token: 0x04009144 RID: 37188
				[global::Cpp2ILInjected.Token(Token = "0x40083F1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _initialVelocity;

				// Token: 0x04009145 RID: 37189
				[global::Cpp2ILInjected.Token(Token = "0x40083F2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private Vector2 _gravityPerFrame;

				// Token: 0x04009146 RID: 37190
				[global::Cpp2ILInjected.Token(Token = "0x40083F3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				private float _rotationPerFrame;
			}

			// Token: 0x02000BCA RID: 3018
			[global::Cpp2ILInjected.Token(Token = "0x2000990")]
			public class SetFrame : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060054A4 RID: 21668 RVA: 0x00030ECF File Offset: 0x0002F0CF
				[global::Cpp2ILInjected.Token(Token = "0x60048C0")]
				[global::Cpp2ILInjected.Address(RVA = "0x823918", Offset = "0x823918", Length = "0x40")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_WitchDoctorGoingToHisPeople", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
				{
					typeof(int),
					typeof(Vector2)
				}, ReturnType = typeof(SegmentInforReport))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public SetFrame(int frameX, int frameY, int paddingX = 2, int paddingY = 2)
				{
					throw null;
				}

				// Token: 0x060054A5 RID: 21669 RVA: 0x00030ED2 File Offset: 0x0002F0D2
				[global::Cpp2ILInjected.Token(Token = "0x60048C1")]
				[global::Cpp2ILInjected.Address(RVA = "0x823958", Offset = "0x823958", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

				// Token: 0x1700093C RID: 2364
				// (get) Token: 0x060054A6 RID: 21670 RVA: 0x00030ED5 File Offset: 0x0002F0D5
				[global::Cpp2ILInjected.Token(Token = "0x17000844")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x60048C2")]
					[global::Cpp2ILInjected.Address(RVA = "0x82395C", Offset = "0x82395C", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x060054A7 RID: 21671 RVA: 0x00030ED8 File Offset: 0x0002F0D8
				[global::Cpp2ILInjected.Token(Token = "0x60048C3")]
				[global::Cpp2ILInjected.Address(RVA = "0x823964", Offset = "0x823964", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x060054A8 RID: 21672 RVA: 0x00030EDB File Offset: 0x0002F0DB
				[global::Cpp2ILInjected.Token(Token = "0x60048C4")]
				[global::Cpp2ILInjected.Address(RVA = "0x82396C", Offset = "0x82396C", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x04009147 RID: 37191
				[global::Cpp2ILInjected.Token(Token = "0x40083F4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _targetFrameX;

				// Token: 0x04009148 RID: 37192
				[global::Cpp2ILInjected.Token(Token = "0x40083F5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private int _targetFrameY;

				// Token: 0x04009149 RID: 37193
				[global::Cpp2ILInjected.Token(Token = "0x40083F6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int _paddingX;

				// Token: 0x0400914A RID: 37194
				[global::Cpp2ILInjected.Token(Token = "0x40083F7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private int _paddingY;

				// Token: 0x0400914B RID: 37195
				[global::Cpp2ILInjected.Token(Token = "0x40083F8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private float _delay;
			}

			// Token: 0x02000BCB RID: 3019
			[global::Cpp2ILInjected.Token(Token = "0x2000991")]
			public class SetFrameSequence : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				// Token: 0x060054A9 RID: 21673 RVA: 0x00030EDE File Offset: 0x0002F0DE
				[global::Cpp2ILInjected.Token(Token = "0x60048C5")]
				[global::Cpp2ILInjected.Address(RVA = "0x823990", Offset = "0x823990", Length = "0x5C")]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public SetFrameSequence(int duration, Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
				{
					throw null;
				}

				// Token: 0x060054AA RID: 21674 RVA: 0x00030EE1 File Offset: 0x0002F0E1
				[global::Cpp2ILInjected.Token(Token = "0x60048C6")]
				[global::Cpp2ILInjected.Address(RVA = "0x8239EC", Offset = "0x8239EC", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SteampunkerRepairingCyborg", MemberParameters = new object[]
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
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public SetFrameSequence(Point[] frameIndices, int timePerFrame, int paddingX = 2, int paddingY = 2)
				{
					throw null;
				}

				// Token: 0x060054AB RID: 21675 RVA: 0x00030EE4 File Offset: 0x0002F0E4
				[global::Cpp2ILInjected.Token(Token = "0x60048C7")]
				[global::Cpp2ILInjected.Address(RVA = "0x823A3C", Offset = "0x823A3C", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

				// Token: 0x1700093D RID: 2365
				// (get) Token: 0x060054AC RID: 21676 RVA: 0x00030EE7 File Offset: 0x0002F0E7
				[global::Cpp2ILInjected.Token(Token = "0x17000845")]
				public int ExpectedLengthOfActionInFrames
				{
					[global::Cpp2ILInjected.Token(Token = "0x60048C8")]
					[global::Cpp2ILInjected.Address(RVA = "0x823A40", Offset = "0x823A40", Length = "0x8")]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x060054AD RID: 21677 RVA: 0x00030EEA File Offset: 0x0002F0EA
				[global::Cpp2ILInjected.Token(Token = "0x60048C9")]
				[global::Cpp2ILInjected.Address(RVA = "0x823A48", Offset = "0x823A48", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				// Token: 0x060054AE RID: 21678 RVA: 0x00030EED File Offset: 0x0002F0ED
				[global::Cpp2ILInjected.Token(Token = "0x60048CA")]
				[global::Cpp2ILInjected.Address(RVA = "0x823A50", Offset = "0x823A50", Length = "0xF0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				// Token: 0x0400914C RID: 37196
				[global::Cpp2ILInjected.Token(Token = "0x40083F9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Point[] _frameIndices;

				// Token: 0x0400914D RID: 37197
				[global::Cpp2ILInjected.Token(Token = "0x40083FA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int _timePerFrame;

				// Token: 0x0400914E RID: 37198
				[global::Cpp2ILInjected.Token(Token = "0x40083FB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private int _paddingX;

				// Token: 0x0400914F RID: 37199
				[global::Cpp2ILInjected.Token(Token = "0x40083FC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _paddingY;

				// Token: 0x04009150 RID: 37200
				[global::Cpp2ILInjected.Token(Token = "0x40083FD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private float _delay;

				// Token: 0x04009151 RID: 37201
				[global::Cpp2ILInjected.Token(Token = "0x40083FE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				private int _duration;

				// Token: 0x04009152 RID: 37202
				[global::Cpp2ILInjected.Token(Token = "0x40083FF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
				private bool _loop;
			}
		}
	}
}
