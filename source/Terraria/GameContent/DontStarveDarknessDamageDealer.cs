using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Golf;
using Terraria.Localization;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007B7")]
	public class DontStarveDarknessDamageDealer
	{
		[global::Cpp2ILInjected.Token(Token = "0x600405A")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D87C", Offset = "0x76D87C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DontStarveDarknessDamageDealer), Member = "ResetTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600405B")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D8DC", Offset = "0x76D8DC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "UpdateDarknessState", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void ResetTimer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600405C")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D938", Offset = "0x76D938", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetDarknessDamagePerHit()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600405D")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D940", Offset = "0x76D940", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetDarknessTimeBeforeStartingHits()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600405E")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D948", Offset = "0x76D948", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetDarknessTimeForMessage()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600405F")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D950", Offset = "0x76D950", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_DeadOrGhost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DontStarveDarknessDamageDealer), Member = "ResetTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DontStarveDarknessDamageDealer), Member = "UpdateDarknessState", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(LegacySoundStyle),
			typeof(Vector2)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDeathReason), Member = "ByOther", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PlayerDeathReason))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void Update(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004060")]
		[global::Cpp2ILInjected.Address(RVA = "0x76DB00", Offset = "0x76DB00", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DontStarveDarknessDamageDealer), Member = "IsPlayerSafe", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "NewText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DontStarveDarknessDamageDealer), Member = "ResetTimer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void UpdateDarknessState(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004061")]
		[global::Cpp2ILInjected.Address(RVA = "0x76DD34", Offset = "0x76DD34", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveDarknessDamageDealer), Member = "UpdateDarknessState", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalGolfState", ReturnType = typeof(GolfState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "get_ShouldCameraTrackBallLastKnownLocation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = "get_IsTrackingBall", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_DroneCameraTracker", ReturnType = typeof(DroneCameraTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool IsPlayerSafe(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004062")]
		[global::Cpp2ILInjected.Address(RVA = "0x76DF30", Offset = "0x76DF30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DontStarveDarknessDamageDealer()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004063")]
		[global::Cpp2ILInjected.Address(RVA = "0x76DF38", Offset = "0x76DF38", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static DontStarveDarknessDamageDealer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E1E")]
		public const int DARKNESS_HIT_TIMER_MAX_BEFORE_HIT = 60;

		[global::Cpp2ILInjected.Token(Token = "0x4007E1F")]
		public static int darknessTimer;

		[global::Cpp2ILInjected.Token(Token = "0x4007E20")]
		public static int darknessHitTimer;

		[global::Cpp2ILInjected.Token(Token = "0x4007E21")]
		public static bool saidMessage;

		[global::Cpp2ILInjected.Token(Token = "0x4007E22")]
		public static bool lastFrameWasTooBright;
	}
}
