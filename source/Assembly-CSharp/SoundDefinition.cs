using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using UnityEngine;

// Token: 0x02000030 RID: 48
[global::Cpp2ILInjected.Token(Token = "0x2000050")]
public class SoundDefinition
{
	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600011E RID: 286 RVA: 0x00021ED2 File Offset: 0x000200D2
	[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
	public float MaxLength
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x706774", Offset = "0x706774", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00021ED5 File Offset: 0x000200D5
	[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x70677C", Offset = "0x70677C", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffect), Member = "Play", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffect), Member = "Play", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "Play", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundManager), Member = "GetChannel", MemberParameters = new object[] { typeof(SoundDefinition) }, ReturnType = typeof(SoundChannel))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(SoundChannel),
		typeof(SoundDefinition),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public SoundInstance Play(float volume = 1f, float pan = 0f, float pitch = 1f, bool loop = false)
	{
		throw null;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00021ED8 File Offset: 0x000200D8
	[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
	[global::Cpp2ILInjected.Address(RVA = "0x706DFC", Offset = "0x706DFC", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundInstance), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(SoundChannel),
		typeof(SoundDefinition),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Random), Member = "Range", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public AudioClip GetRandomClip()
	{
		throw null;
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00021EDB File Offset: 0x000200DB
	[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
	[global::Cpp2ILInjected.Address(RVA = "0x706E68", Offset = "0x706E68", Length = "0x100")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(AudioClip)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioClip), Member = "get_length", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void AddVariation(AudioClip clip)
	{
		throw null;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00021EDE File Offset: 0x000200DE
	[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
	[global::Cpp2ILInjected.Address(RVA = "0x706F68", Offset = "0x706F68", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(AudioClip)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public SoundDefinition()
	{
		throw null;
	}

	// Token: 0x040000C5 RID: 197
	[global::Cpp2ILInjected.Token(Token = "0x400011E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	// Token: 0x040000C6 RID: 198
	[global::Cpp2ILInjected.Token(Token = "0x400011F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SoundGroup Group;

	// Token: 0x040000C7 RID: 199
	[global::Cpp2ILInjected.Token(Token = "0x4000120")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int Priority;

	// Token: 0x040000C8 RID: 200
	[global::Cpp2ILInjected.Token(Token = "0x4000121")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float VolumeScale;

	// Token: 0x040000C9 RID: 201
	[global::Cpp2ILInjected.Token(Token = "0x4000122")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float _maxLength;

	// Token: 0x040000CA RID: 202
	[global::Cpp2ILInjected.Token(Token = "0x4000123")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private List<AudioClip> _variations;
}
