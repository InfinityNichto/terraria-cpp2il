using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Audio;

[Cpp2IlInjected.Token(Token = "0x20002F9")]
public sealed class SoundEffect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002174")]
	private string _name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002175")]
	public readonly SoundDefinition Definition;

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public TimeSpan Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6001920")]
		[Cpp2IlInjected.Address(RVA = "0x12E3540", Offset = "0x12E3540", VA = "0x12E3540")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6001921")]
		[Cpp2IlInjected.Address(RVA = "0x12E35E4", Offset = "0x12E35E4", VA = "0x12E35E4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6001922")]
		[Cpp2IlInjected.Address(RVA = "0x12E35EC", Offset = "0x12E35EC", VA = "0x12E35EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600191C")]
	[Cpp2IlInjected.Address(RVA = "0x12E33B8", Offset = "0x12E33B8", VA = "0x12E33B8")]
	public SoundEffect(string id, AudioClip clip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600191D")]
	[Cpp2IlInjected.Address(RVA = "0x12E2EAC", Offset = "0x12E2EAC", VA = "0x12E2EAC")]
	public SoundEffectInstance CreateInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600191E")]
	[Cpp2IlInjected.Address(RVA = "0x12E34A4", Offset = "0x12E34A4", VA = "0x12E34A4")]
	public bool Play()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600191F")]
	[Cpp2IlInjected.Address(RVA = "0x12E34EC", Offset = "0x12E34EC", VA = "0x12E34EC")]
	public bool Play(float volume, float pitch, float pan)
	{
		return default(bool);
	}
}
