using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Skies.CreditsRoll;

namespace Terraria.GameContent.Animations
{
	[global::Cpp2ILInjected.Token(Token = "0x2000972")]
	public class Actions
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004847")]
		[global::Cpp2ILInjected.Address(RVA = "0x822164", Offset = "0x822164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Actions()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000973")]
		public class Players
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004848")]
			[global::Cpp2ILInjected.Address(RVA = "0x82216C", Offset = "0x82216C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Players()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000974")]
			public interface IPlayerAction : IAnimationSegmentAction<Player>
			{
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000975")]
			public class Fade : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600484B")]
				[global::Cpp2ILInjected.Address(RVA = "0x8221D8", Offset = "0x8221D8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x600484D")]
				[global::Cpp2ILInjected.Address(RVA = "0x8221E4", Offset = "0x8221E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083BC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083BD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _opacityTarget;

				[global::Cpp2ILInjected.Token(Token = "0x40083BE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000976")]
			public class Wait : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004850")]
				[global::Cpp2ILInjected.Address(RVA = "0x8222E4", Offset = "0x8222E4", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004852")]
				[global::Cpp2ILInjected.Address(RVA = "0x8222F0", Offset = "0x8222F0", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004853")]
				[global::Cpp2ILInjected.Address(RVA = "0x82239C", Offset = "0x82239C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083BF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083C0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000977")]
			public class LookAt : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004855")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223CC", Offset = "0x8223CC", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004857")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223D8", Offset = "0x8223D8", Length = "0x18")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(Player obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004858")]
				[global::Cpp2ILInjected.Address(RVA = "0x8223F0", Offset = "0x8223F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083C1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _direction;

				[global::Cpp2ILInjected.Token(Token = "0x40083C2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000978")]
			public class MoveWithAcceleration : Actions.Players.IPlayerAction, IAnimationSegmentAction<Player>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600485A")]
				[global::Cpp2ILInjected.Address(RVA = "0x822448", Offset = "0x822448", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Player obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x600485C")]
				[global::Cpp2ILInjected.Address(RVA = "0x822454", Offset = "0x822454", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083C3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083C4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _accelerationPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083C5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083C6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private float _delay;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000979")]
		public class NPCs
		{
			[global::Cpp2ILInjected.Token(Token = "0x600485E")]
			[global::Cpp2ILInjected.Address(RVA = "0x82259C", Offset = "0x82259C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public NPCs()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200097A")]
			public interface INPCAction : IAnimationSegmentAction<NPC>
			{
			}

			[global::Cpp2ILInjected.Token(Token = "0x200097B")]
			public class Fade : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004861")]
				[global::Cpp2ILInjected.Address(RVA = "0x8225F8", Offset = "0x8225F8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004863")]
				[global::Cpp2ILInjected.Address(RVA = "0x822604", Offset = "0x822604", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083C7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083C8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private int _alphaPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083C9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200097C")]
			public class ShowItem : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004866")]
				[global::Cpp2ILInjected.Address(RVA = "0x822738", Offset = "0x822738", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004868")]
				[global::Cpp2ILInjected.Address(RVA = "0x822744", Offset = "0x822744", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004869")]
				[global::Cpp2ILInjected.Address(RVA = "0x82274C", Offset = "0x82274C", Length = "0x11C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600486A")]
				[global::Cpp2ILInjected.Address(RVA = "0x822868", Offset = "0x822868", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				private void FixNPCIfWasHoldingItem(NPC obj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083CA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _itemIdToShow;

				[global::Cpp2ILInjected.Token(Token = "0x40083CB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083CC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200097D")]
			public class Move : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600486C")]
				[global::Cpp2ILInjected.Address(RVA = "0x8228C8", Offset = "0x8228C8", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x600486E")]
				[global::Cpp2ILInjected.Address(RVA = "0x8228D4", Offset = "0x8228D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083CD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083CE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083CF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200097E")]
			public class MoveWithAcceleration : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004871")]
				[global::Cpp2ILInjected.Address(RVA = "0x822A18", Offset = "0x822A18", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004873")]
				[global::Cpp2ILInjected.Address(RVA = "0x822A24", Offset = "0x822A24", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083D0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083D1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _accelerationPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083D2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083D3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200097F")]
			public class MoveWithRotor : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004876")]
				[global::Cpp2ILInjected.Address(RVA = "0x822BD0", Offset = "0x822BD0", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004878")]
				[global::Cpp2ILInjected.Address(RVA = "0x822BDC", Offset = "0x822BDC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083D4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Vector2 _offsetPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083D5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _resultMultiplier;

				[global::Cpp2ILInjected.Token(Token = "0x40083D6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private float _radialOffset;

				[global::Cpp2ILInjected.Token(Token = "0x40083D7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083D8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000980")]
			public class DoBunnyRestAnimation : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600487B")]
				[global::Cpp2ILInjected.Address(RVA = "0x822D20", Offset = "0x822D20", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x600487D")]
				[global::Cpp2ILInjected.Address(RVA = "0x822D2C", Offset = "0x822D2C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600487E")]
				[global::Cpp2ILInjected.Address(RVA = "0x822D34", Offset = "0x822D34", Length = "0xA0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083D9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083DA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000981")]
			public class Wait : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004880")]
				[global::Cpp2ILInjected.Address(RVA = "0x822DFC", Offset = "0x822DFC", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004882")]
				[global::Cpp2ILInjected.Address(RVA = "0x822E08", Offset = "0x822E08", Length = "0xAC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004883")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EB4", Offset = "0x822EB4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083DB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083DC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000982")]
			public class Blink : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004885")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EE4", Offset = "0x822EE4", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004887")]
				[global::Cpp2ILInjected.Address(RVA = "0x822EF0", Offset = "0x822EF0", Length = "0xE0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004888")]
				[global::Cpp2ILInjected.Address(RVA = "0x822FD0", Offset = "0x822FD0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083DD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083DE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000983")]
			public class LookAt : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600488A")]
				[global::Cpp2ILInjected.Address(RVA = "0x823000", Offset = "0x823000", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x600488C")]
				[global::Cpp2ILInjected.Address(RVA = "0x82300C", Offset = "0x82300C", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600488D")]
				[global::Cpp2ILInjected.Address(RVA = "0x823028", Offset = "0x823028", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083DF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _direction;

				[global::Cpp2ILInjected.Token(Token = "0x40083E0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000984")]
			public class PartyHard : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600488F")]
				[global::Cpp2ILInjected.Address(RVA = "0x823038", Offset = "0x823038", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "UpdateAltTexture", ReturnType = typeof(void))]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004891")]
				[global::Cpp2ILInjected.Address(RVA = "0x823054", Offset = "0x823054", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004892")]
				[global::Cpp2ILInjected.Address(RVA = "0x823058", Offset = "0x823058", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000985")]
			public class ForceAltTexture : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004894")]
				[global::Cpp2ILInjected.Address(RVA = "0x823084", Offset = "0x823084", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x6004896")]
				[global::Cpp2ILInjected.Address(RVA = "0x823098", Offset = "0x823098", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x6004897")]
				[global::Cpp2ILInjected.Address(RVA = "0x82309C", Offset = "0x82309C", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083E1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _altTexture;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000986")]
			public class Variant : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x6004899")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230C8", Offset = "0x8230C8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x600489B")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230DC", Offset = "0x8230DC", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(NPC obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x600489C")]
				[global::Cpp2ILInjected.Address(RVA = "0x8230E0", Offset = "0x8230E0", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083E2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _variant;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000987")]
			public class ZombieKnockOnDoor : Actions.NPCs.INPCAction, IAnimationSegmentAction<NPC>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x600489E")]
				[global::Cpp2ILInjected.Address(RVA = "0x823154", Offset = "0x823154", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(NPC obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048A0")]
				[global::Cpp2ILInjected.Address(RVA = "0x823160", Offset = "0x823160", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083E3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083E4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;

				[global::Cpp2ILInjected.Token(Token = "0x40083E5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 bumpOffset;

				[global::Cpp2ILInjected.Token(Token = "0x40083E6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private Vector2 bumpVelocity;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000988")]
		public class Sprites
		{
			[global::Cpp2ILInjected.Token(Token = "0x60048A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8232B4", Offset = "0x8232B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sprites()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000989")]
			public interface ISpriteAction : IAnimationSegmentAction<Segments.LooseSprite>
			{
			}

			[global::Cpp2ILInjected.Token(Token = "0x200098A")]
			public class Fade : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x60048A5")]
				[global::Cpp2ILInjected.Address(RVA = "0x823320", Offset = "0x823320", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048A7")]
				[global::Cpp2ILInjected.Address(RVA = "0x82332C", Offset = "0x82332C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083E7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083E8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _opacityTarget;

				[global::Cpp2ILInjected.Token(Token = "0x40083E9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200098B")]
			public abstract class AScale : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
				[global::Cpp2ILInjected.Token(Token = "0x60048A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x823404", Offset = "0x823404", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public AScale(Vector2 scaleTarget)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048AA")]
				[global::Cpp2ILInjected.Address(RVA = "0x823434", Offset = "0x823434", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public AScale(Vector2 scaleTarget, int duration)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x823470", Offset = "0x823470", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048AD")]
				[global::Cpp2ILInjected.Address(RVA = "0x82347C", Offset = "0x82347C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048AF")]
				protected abstract float GetProgress(float durationInFramesToApply);

				[global::Cpp2ILInjected.Token(Token = "0x40083EA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				protected int Duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083EB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private Vector2 _scaleTarget;

				[global::Cpp2ILInjected.Token(Token = "0x40083EC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200098C")]
			public class LinearScale : Actions.Sprites.AScale
			{
				[global::Cpp2ILInjected.Token(Token = "0x60048B0")]
				[global::Cpp2ILInjected.Address(RVA = "0x823560", Offset = "0x823560", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public LinearScale(Vector2 scaleTarget)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048B1")]
				[global::Cpp2ILInjected.Address(RVA = "0x823590", Offset = "0x823590", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public LinearScale(Vector2 scaleTarget, int duration)
				{
					throw null;
				}

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

			[global::Cpp2ILInjected.Token(Token = "0x200098D")]
			public class OutCircleScale : Actions.Sprites.AScale
			{
				[global::Cpp2ILInjected.Token(Token = "0x60048B3")]
				[global::Cpp2ILInjected.Address(RVA = "0x823640", Offset = "0x823640", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public OutCircleScale(Vector2 scaleTarget)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048B4")]
				[global::Cpp2ILInjected.Address(RVA = "0x823670", Offset = "0x823670", Length = "0x3C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StardewValleyAnimation), Member = "ComposeAnimation", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public OutCircleScale(Vector2 scaleTarget, int duration)
				{
					throw null;
				}

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

			[global::Cpp2ILInjected.Token(Token = "0x200098E")]
			public class Wait : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x60048B7")]
				[global::Cpp2ILInjected.Address(RVA = "0x823788", Offset = "0x823788", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048B9")]
				[global::Cpp2ILInjected.Address(RVA = "0x823794", Offset = "0x823794", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048BA")]
				[global::Cpp2ILInjected.Address(RVA = "0x823798", Offset = "0x823798", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083ED")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083EE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x200098F")]
			public class SimulateGravity : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x60048BC")]
				[global::Cpp2ILInjected.Address(RVA = "0x823800", Offset = "0x823800", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048BE")]
				[global::Cpp2ILInjected.Address(RVA = "0x82380C", Offset = "0x82380C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x40083EF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083F0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private float _delay;

				[global::Cpp2ILInjected.Token(Token = "0x40083F1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private Vector2 _initialVelocity;

				[global::Cpp2ILInjected.Token(Token = "0x40083F2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private Vector2 _gravityPerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083F3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				private float _rotationPerFrame;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000990")]
			public class SetFrame : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x60048C1")]
				[global::Cpp2ILInjected.Address(RVA = "0x823958", Offset = "0x823958", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048C3")]
				[global::Cpp2ILInjected.Address(RVA = "0x823964", Offset = "0x823964", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048C4")]
				[global::Cpp2ILInjected.Address(RVA = "0x82396C", Offset = "0x82396C", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083F4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private int _targetFrameX;

				[global::Cpp2ILInjected.Token(Token = "0x40083F5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
				private int _targetFrameY;

				[global::Cpp2ILInjected.Token(Token = "0x40083F6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int _paddingX;

				[global::Cpp2ILInjected.Token(Token = "0x40083F7")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private int _paddingY;

				[global::Cpp2ILInjected.Token(Token = "0x40083F8")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private float _delay;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000991")]
			public class SetFrameSequence : Actions.Sprites.ISpriteAction, IAnimationSegmentAction<Segments.LooseSprite>
			{
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

				[global::Cpp2ILInjected.Token(Token = "0x60048C7")]
				[global::Cpp2ILInjected.Address(RVA = "0x823A3C", Offset = "0x823A3C", Length = "0x4")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void BindTo(Segments.LooseSprite obj)
				{
					throw null;
				}

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

				[global::Cpp2ILInjected.Token(Token = "0x60048C9")]
				[global::Cpp2ILInjected.Address(RVA = "0x823A48", Offset = "0x823A48", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				public void SetDelay(float delay)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60048CA")]
				[global::Cpp2ILInjected.Address(RVA = "0x823A50", Offset = "0x823A50", Length = "0xF0")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				public void ApplyTo(Segments.LooseSprite obj, float localTimeForObj)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40083F9")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				private Point[] _frameIndices;

				[global::Cpp2ILInjected.Token(Token = "0x40083FA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				private int _timePerFrame;

				[global::Cpp2ILInjected.Token(Token = "0x40083FB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				private int _paddingX;

				[global::Cpp2ILInjected.Token(Token = "0x40083FC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				private int _paddingY;

				[global::Cpp2ILInjected.Token(Token = "0x40083FD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
				private float _delay;

				[global::Cpp2ILInjected.Token(Token = "0x40083FE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				private int _duration;

				[global::Cpp2ILInjected.Token(Token = "0x40083FF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
				private bool _loop;
			}
		}
	}
}
