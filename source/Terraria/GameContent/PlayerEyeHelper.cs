using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x02000560 RID: 1376
	[global::Cpp2ILInjected.Token(Token = "0x20007E6")]
	public struct PlayerEyeHelper
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x0002C612 File Offset: 0x0002A812
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x0002C615 File Offset: 0x0002A815
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

		// Token: 0x06003A27 RID: 14887 RVA: 0x0002C618 File Offset: 0x0002A818
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

		// Token: 0x06003A28 RID: 14888 RVA: 0x0002C61B File Offset: 0x0002A81B
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

		// Token: 0x06003A29 RID: 14889 RVA: 0x0002C61E File Offset: 0x0002A81E
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

		// Token: 0x06003A2A RID: 14890 RVA: 0x0002C621 File Offset: 0x0002A821
		[global::Cpp2ILInjected.Token(Token = "0x6004119")]
		[global::Cpp2ILInjected.Address(RVA = "0x7780E4", Offset = "0x7780E4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SwitchToState(PlayerEyeHelper.EyeState newState, bool resetStateTimerEvenIfAlreadyInState = false)
		{
			throw null;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x0002C624 File Offset: 0x0002A824
		[global::Cpp2ILInjected.Token(Token = "0x600411A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7780C0", Offset = "0x7780C0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool DoesPlayerCountAsModeratelyDamaged(Player player)
		{
			throw null;
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x0002C627 File Offset: 0x0002A827
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

		// Token: 0x04006933 RID: 26931
		[global::Cpp2ILInjected.Token(Token = "0x4007EC7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayerEyeHelper.EyeState _state;

		// Token: 0x04006934 RID: 26932
		[global::Cpp2ILInjected.Token(Token = "0x4007EC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int _timeInState;

		// Token: 0x04006935 RID: 26933
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007EC9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int <EyeFrameToShow>k__BackingField;

		// Token: 0x04006936 RID: 26934
		[global::Cpp2ILInjected.Token(Token = "0x4007ECA")]
		private const int TimeToActDamaged = 20;

		// Token: 0x02000991 RID: 2449
		[global::Cpp2ILInjected.Token(Token = "0x20007E7")]
		private enum EyeFrame
		{
			// Token: 0x04008C4A RID: 35914
			[global::Cpp2ILInjected.Token(Token = "0x4007ECC")]
			EyeOpen,
			// Token: 0x04008C4B RID: 35915
			[global::Cpp2ILInjected.Token(Token = "0x4007ECD")]
			EyeHalfClosed,
			// Token: 0x04008C4C RID: 35916
			[global::Cpp2ILInjected.Token(Token = "0x4007ECE")]
			EyeClosed
		}

		// Token: 0x02000992 RID: 2450
		[global::Cpp2ILInjected.Token(Token = "0x20007E8")]
		private enum EyeState
		{
			// Token: 0x04008C4E RID: 35918
			[global::Cpp2ILInjected.Token(Token = "0x4007ED0")]
			NormalBlinking,
			// Token: 0x04008C4F RID: 35919
			[global::Cpp2ILInjected.Token(Token = "0x4007ED1")]
			InStorm,
			// Token: 0x04008C50 RID: 35920
			[global::Cpp2ILInjected.Token(Token = "0x4007ED2")]
			InBed,
			// Token: 0x04008C51 RID: 35921
			[global::Cpp2ILInjected.Token(Token = "0x4007ED3")]
			JustTookDamage,
			// Token: 0x04008C52 RID: 35922
			[global::Cpp2ILInjected.Token(Token = "0x4007ED4")]
			IsModeratelyDamaged,
			// Token: 0x04008C53 RID: 35923
			[global::Cpp2ILInjected.Token(Token = "0x4007ED5")]
			IsBlind,
			// Token: 0x04008C54 RID: 35924
			[global::Cpp2ILInjected.Token(Token = "0x4007ED6")]
			IsTipsy,
			// Token: 0x04008C55 RID: 35925
			[global::Cpp2ILInjected.Token(Token = "0x4007ED7")]
			IsPoisoned
		}
	}
}
