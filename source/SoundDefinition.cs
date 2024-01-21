using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000031")]
public class SoundDefinition
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public SoundGroup Group;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int Priority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float VolumeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float _maxLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private List<AudioClip> _variations;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public float MaxLength
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x10619A0", Offset = "0x10619A0", VA = "0x10619A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x10619A8", Offset = "0x10619A8", VA = "0x10619A8")]
	public SoundInstance Play(float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1062198", Offset = "0x1062198", VA = "0x1062198")]
	public AudioClip GetRandomClip()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1062214", Offset = "0x1062214", VA = "0x1062214")]
	public void AddVariation(AudioClip clip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x10622EC", Offset = "0x10622EC", VA = "0x10622EC")]
	public SoundDefinition()
	{
	}
}
