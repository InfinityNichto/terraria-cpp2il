using System;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000033")]
public class SoundInstance
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly AudioClip Clip;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public readonly SoundDefinition Definition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public DateTime FinishTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool _fading;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private DateTime _fadeStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DateTime _fadeEnd;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float _fadeStartVol;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private float _fadeEndVol;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private SoundChannel _channel;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public float CurrentPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x106274C", Offset = "0x106274C", VA = "0x106274C")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x10627FC", Offset = "0x10627FC", VA = "0x10627FC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public SoundChannel Channel
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x10630BC", Offset = "0x10630BC", VA = "0x10630BC")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x10630C4", Offset = "0x10630C4", VA = "0x10630C4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1061F60", Offset = "0x1061F60", VA = "0x1061F60")]
	public SoundInstance(SoundChannel channel, SoundDefinition definition, float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x10625D8", Offset = "0x10625D8", VA = "0x10625D8")]
	public void Restart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1062974", Offset = "0x1062974", VA = "0x1062974")]
	public void SetVolume(float volume)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x1062A28", Offset = "0x1062A28", VA = "0x1062A28")]
	public void SetPan(float pan)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x1062ADC", Offset = "0x1062ADC", VA = "0x1062ADC")]
	public void SetPitch(float pitch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1062B90", Offset = "0x1062B90", VA = "0x1062B90")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1062C8C", Offset = "0x1062C8C", VA = "0x1062C8C")]
	public void StartFade(float fadeTarget, DateTime fadeStart, DateTime targetTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1062E00", Offset = "0x1062E00", VA = "0x1062E00")]
	public bool UpdateFade()
	{
		return default(bool);
	}
}
