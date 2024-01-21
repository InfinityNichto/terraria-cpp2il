using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Audio;

[Cpp2IlInjected.Token(Token = "0x2000034")]
[Cpp2IlInjected.Attribute(Name = "ResourceLocationAttribute", RVA = "0x384A5C", Offset = "0x384A5C")]
public class SoundManager : Singleton<SoundManager>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public AnimationCurve VolumeFalloff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private GameObject _soundRoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<SoundChannel> _channels;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static AudioMixer _mixer;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static AudioMixer MasterMixer
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1062454", Offset = "0x1062454", VA = "0x1062454")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x10630CC", Offset = "0x10630CC", VA = "0x10630CC", Slot = "4")]
	public override void Init()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x10632B0", Offset = "0x10632B0", VA = "0x10632B0", Slot = "5")]
	public override void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1063154", Offset = "0x1063154", VA = "0x1063154")]
	public void SetupChannels(int numChannels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1061AC8", Offset = "0x1061AC8", VA = "0x1061AC8")]
	public SoundChannel GetChannel(SoundDefinition soundDefinition)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x10632B8", Offset = "0x10632B8", VA = "0x10632B8")]
	public void StopAllSoundsOnChannels(string channelId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x1063498", Offset = "0x1063498", VA = "0x1063498")]
	public bool IsPlaying(SoundDefinition soundDefinition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x1063668", Offset = "0x1063668", VA = "0x1063668")]
	public SoundManager()
	{
	}
}
