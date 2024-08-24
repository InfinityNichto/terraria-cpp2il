using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000032 RID: 50
[global::Cpp2ILInjected.Token(Token = "0x2000052")]
public class SoundInstance
{
	// Token: 0x06000125 RID: 293 RVA: 0x00021EE7 File Offset: 0x000200E7
	[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x706C00", Offset = "0x706C00", Length = "0x1FC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundDefinition), Member = "Play", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(SoundInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundDefinition), Member = "GetRandomClip", ReturnType = typeof(AudioClip))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_clip", MemberParameters = new object[] { typeof(AudioClip) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundGroup), Member = "get_MixerGroup", ReturnType = typeof(AudioMixerGroup))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_outputAudioMixerGroup", MemberParameters = new object[] { typeof(AudioMixerGroup) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_time", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "Play", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_panStereo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_loop", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_priority", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(TimeSpan)
	}, ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public SoundInstance(SoundChannel channel, SoundDefinition definition, float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
		throw null;
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00021EEA File Offset: 0x000200EA
	[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
	[global::Cpp2ILInjected.Address(RVA = "0x707184", Offset = "0x707184", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "Restart", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_time", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(TimeSpan)
	}, ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void Restart()
	{
		throw null;
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000127 RID: 295 RVA: 0x00021EED File Offset: 0x000200ED
	// (set) Token: 0x06000128 RID: 296 RVA: 0x00021EF0 File Offset: 0x000200F0
	[global::Cpp2ILInjected.Token(Token = "0x17000070")]
	public float CurrentPosition
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x707298", Offset = "0x707298", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cue), Member = "Pause", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "get_CurrentPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "get_time", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x707324", Offset = "0x707324", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cue), Member = "Resume", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "set_CurrentPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_time", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000129 RID: 297 RVA: 0x00021EF3 File Offset: 0x000200F3
	[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
	[global::Cpp2ILInjected.Address(RVA = "0x707440", Offset = "0x707440", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundInstance), Member = "UpdateFade", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "set_Volume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_volume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SetVolume(float volume)
	{
		throw null;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00021EF6 File Offset: 0x000200F6
	[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
	[global::Cpp2ILInjected.Address(RVA = "0x7074DC", Offset = "0x7074DC", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "set_Pan", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_panStereo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SetPan(float pan)
	{
		throw null;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00021EF9 File Offset: 0x000200F9
	[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
	[global::Cpp2ILInjected.Address(RVA = "0x707578", Offset = "0x707578", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "set_Pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "set_pitch", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SetPitch(float pitch)
	{
		throw null;
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00021EFC File Offset: 0x000200FC
	[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
	[global::Cpp2ILInjected.Address(RVA = "0x707614", Offset = "0x707614", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundManager), Member = "StopAllSoundsOnChannels", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "Stop", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "Stop", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x0600012D RID: 301 RVA: 0x00021EFF File Offset: 0x000200FF
	[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
	[global::Cpp2ILInjected.Address(RVA = "0x7076D0", Offset = "0x7076D0", Length = "0xE0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioSource), Member = "get_volume", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void StartFade(float fadeTarget, DateTime fadeStart, DateTime targetTime)
	{
		throw null;
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00021F02 File Offset: 0x00020102
	[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
	[global::Cpp2ILInjected.Address(RVA = "0x7077B0", Offset = "0x7077B0", Length = "0x198")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThan", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "SetVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public bool UpdateFade()
	{
		throw null;
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600012F RID: 303 RVA: 0x00021F05 File Offset: 0x00020105
	// (set) Token: 0x06000130 RID: 304 RVA: 0x00021F08 File Offset: 0x00020108
	[global::Cpp2ILInjected.Token(Token = "0x17000071")]
	public SoundChannel Channel
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x707948", Offset = "0x707948", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x707950", Offset = "0x707950", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x040000CE RID: 206
	[global::Cpp2ILInjected.Token(Token = "0x4000127")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public readonly AudioClip Clip;

	// Token: 0x040000CF RID: 207
	[global::Cpp2ILInjected.Token(Token = "0x4000128")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public readonly SoundDefinition Definition;

	// Token: 0x040000D0 RID: 208
	[global::Cpp2ILInjected.Token(Token = "0x4000129")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public DateTime FinishTime;

	// Token: 0x040000D1 RID: 209
	[global::Cpp2ILInjected.Token(Token = "0x400012A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool _fading;

	// Token: 0x040000D2 RID: 210
	[global::Cpp2ILInjected.Token(Token = "0x400012B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private DateTime _fadeStart;

	// Token: 0x040000D3 RID: 211
	[global::Cpp2ILInjected.Token(Token = "0x400012C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private DateTime _fadeEnd;

	// Token: 0x040000D4 RID: 212
	[global::Cpp2ILInjected.Token(Token = "0x400012D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private float _fadeStartVol;

	// Token: 0x040000D5 RID: 213
	[global::Cpp2ILInjected.Token(Token = "0x400012E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private float _fadeEndVol;

	// Token: 0x040000D6 RID: 214
	[global::Cpp2ILInjected.Token(Token = "0x400012F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private SoundChannel _channel;
}
