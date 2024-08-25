using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

namespace Terraria.GameContent.UI.BigProgressBar
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AE4")]
	public class BigProgressBarSystem
	{
		[global::Cpp2ILInjected.Token(Token = "0x60051ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x936440", Offset = "0x936440", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BottomCentreHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RightSideHUDAnchorUpdator), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsTracking()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x936450", Offset = "0x936450", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateUIStates", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigProgressBarSystem), Member = "TryFindingNPCToTrack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9366AC", Offset = "0x9366AC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_15_InvasionProgressBars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x936510", Offset = "0x936510", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Hitbox", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigProgressBarSystem), Member = "TryTracking", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void TryFindingNPCToTrack()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x936768", Offset = "0x936768", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OnHit", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(Entity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarSystem), Member = "TryFindingNPCToTrack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool TryTracking(int npcIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x9368BC", Offset = "0x9368BC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Configuration_Save(Preferences obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x93696C", Offset = "0x93696C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void Configuration_OnLoad(Preferences obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x936A48", Offset = "0x936A48", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ToggleShowText()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60051F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x936AA8", Offset = "0x936AA8", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonBossBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public BigProgressBarSystem()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60051F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x936E68", Offset = "0x936E68", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwinsBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EaterOfWorldsProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BrainOfCthuluBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolemHeadProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SolarFlarePillarBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VortexPillarBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NebulaPillarBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StardustPillarBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NeverValidProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PirateShipBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSaucerBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeerclopsBigProgressBar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		static BigProgressBarSystem()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A49")]
		private static TwinsBigProgressBar _twinsBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A4A")]
		private static EaterOfWorldsProgressBar _eaterOfWorldsBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A4B")]
		private static BrainOfCthuluBigProgressBar _brainOfCthuluBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A4C")]
		private static GolemHeadProgressBar _golemBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A4D")]
		private static MoonLordProgressBar _moonlordBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A4E")]
		private static SolarFlarePillarBigProgressBar _solarPillarBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A4F")]
		private static VortexPillarBigProgressBar _vortexPillarBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A50")]
		private static NebulaPillarBigProgressBar _nebulaPillarBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A51")]
		private static StardustPillarBigProgressBar _stardustPillarBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A52")]
		private static NeverValidProgressBar _neverValid;

		[global::Cpp2ILInjected.Token(Token = "0x4008A53")]
		private static PirateShipBigProgressBar _pirateShipBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A54")]
		private static MartianSaucerBigProgressBar _martianSaucerBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IBigProgressBar _currentBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CommonBossBigProgressBar _bossBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BigProgressBarInfo _info;

		[global::Cpp2ILInjected.Token(Token = "0x4008A58")]
		private static DeerclopsBigProgressBar _deerclopsBar;

		[global::Cpp2ILInjected.Token(Token = "0x4008A59")]
		public static bool ShowText;

		[global::Cpp2ILInjected.Token(Token = "0x4008A5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Dictionary<int, IBigProgressBar> _bossBarsByNpcNetId;

		[global::Cpp2ILInjected.Token(Token = "0x4008A5B")]
		private const string _preferencesKey = "ShowBossBarHealthText";
	}
}
