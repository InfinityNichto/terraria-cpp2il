using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000563")]
public struct PlayerEyeHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000988")]
	private enum EyeFrame
	{
		[Cpp2IlInjected.Token(Token = "0x4008C37")]
		EyeOpen,
		[Cpp2IlInjected.Token(Token = "0x4008C38")]
		EyeHalfClosed,
		[Cpp2IlInjected.Token(Token = "0x4008C39")]
		EyeClosed
	}

	[Cpp2IlInjected.Token(Token = "0x2000989")]
	private enum EyeState
	{
		[Cpp2IlInjected.Token(Token = "0x4008C3B")]
		NormalBlinking,
		[Cpp2IlInjected.Token(Token = "0x4008C3C")]
		InStorm,
		[Cpp2IlInjected.Token(Token = "0x4008C3D")]
		InBed,
		[Cpp2IlInjected.Token(Token = "0x4008C3E")]
		JustTookDamage,
		[Cpp2IlInjected.Token(Token = "0x4008C3F")]
		IsModeratelyDamaged,
		[Cpp2IlInjected.Token(Token = "0x4008C40")]
		IsBlind,
		[Cpp2IlInjected.Token(Token = "0x4008C41")]
		IsTipsy,
		[Cpp2IlInjected.Token(Token = "0x4008C42")]
		IsPoisoned
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006934")]
	private EyeState _state;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006935")]
	private int _timeInState;

	[Cpp2IlInjected.Token(Token = "0x4006937")]
	private const int TimeToActDamaged = 20;

	[Cpp2IlInjected.Token(Token = "0x17000721")]
	public int EyeFrameToShow
	{
		[Cpp2IlInjected.Token(Token = "0x6003A61")]
		[Cpp2IlInjected.Address(RVA = "0x39CEBC", Offset = "0x39CEBC", VA = "0x39CEBC")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6003A62")]
		[Cpp2IlInjected.Address(RVA = "0x39CEC4", Offset = "0x39CEC4", VA = "0x39CEC4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003A63")]
	[Cpp2IlInjected.Address(RVA = "0x39CECC", Offset = "0x39CECC", VA = "0x39CECC")]
	public void Update(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A64")]
	[Cpp2IlInjected.Address(RVA = "0x39CF04", Offset = "0x39CF04", VA = "0x39CF04")]
	private void UpdateEyeFrameToShow(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A65")]
	[Cpp2IlInjected.Address(RVA = "0x39CF0C", Offset = "0x39CF0C", VA = "0x39CF0C")]
	private void SetStateByPlayerInfo(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A66")]
	[Cpp2IlInjected.Address(RVA = "0x39CF14", Offset = "0x39CF14", VA = "0x39CF14")]
	private void SwitchToState(EyeState newState, bool resetStateTimerEvenIfAlreadyInState = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A67")]
	[Cpp2IlInjected.Address(RVA = "0x39CF34", Offset = "0x39CF34", VA = "0x39CF34")]
	private bool DoesPlayerCountAsModeratelyDamaged(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A68")]
	[Cpp2IlInjected.Address(RVA = "0x39CF70", Offset = "0x39CF70", VA = "0x39CF70")]
	public void BlinkBecausePlayerGotHurt()
	{
	}
}
