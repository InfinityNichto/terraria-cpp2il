using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007E6")]
	public struct PlayerEyeHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007BF")]
		public int EyeFrameToShow
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004114")]
			[global::Cpp2ILInjected.Address(RVA = "0x777DB0", Offset = "0x777DB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004115")]
			[global::Cpp2ILInjected.Address(RVA = "0x777DB8", Offset = "0x777DB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004116")]
		[global::Cpp2ILInjected.Address(RVA = "0x777DC0", Offset = "0x777DC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEyeHelper), Member = "SetStateByPlayerInfo", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEyeHelper), Member = "UpdateEyeFrameToShow", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		public void Update(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004117")]
		[global::Cpp2ILInjected.Address(RVA = "0x777F8C", Offset = "0x777F8C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerEyeHelper), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void UpdateEyeFrameToShow(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004118")]
		[global::Cpp2ILInjected.Address(RVA = "0x777DF8", Offset = "0x777DF8", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerEyeHelper), Member = "Update", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSandstorm", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsItRaining", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetStateByPlayerInfo(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004119")]
		[global::Cpp2ILInjected.Address(RVA = "0x7780E4", Offset = "0x7780E4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SwitchToState(PlayerEyeHelper.EyeState newState, bool resetStateTimerEvenIfAlreadyInState = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600411A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7780C0", Offset = "0x7780C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool DoesPlayerCountAsModeratelyDamaged(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600411B")]
		[global::Cpp2ILInjected.Address(RVA = "0x778100", Offset = "0x778100", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void BlinkBecausePlayerGotHurt()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007EC7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayerEyeHelper.EyeState _state;

		[global::Cpp2ILInjected.Token(Token = "0x4007EC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _timeInState;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007EC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int <EyeFrameToShow>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4007ECA")]
		private const int TimeToActDamaged = 20;

		[global::Cpp2ILInjected.Token(Token = "0x20007E7")]
		private enum EyeFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007ECC")]
			EyeOpen,
			[global::Cpp2ILInjected.Token(Token = "0x4007ECD")]
			EyeHalfClosed,
			[global::Cpp2ILInjected.Token(Token = "0x4007ECE")]
			EyeClosed
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007E8")]
		private enum EyeState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007ED0")]
			NormalBlinking,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED1")]
			InStorm,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED2")]
			InBed,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED3")]
			JustTookDamage,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED4")]
			IsModeratelyDamaged,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED5")]
			IsBlind,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED6")]
			IsTipsy,
			[global::Cpp2ILInjected.Token(Token = "0x4007ED7")]
			IsPoisoned
		}
	}
}
