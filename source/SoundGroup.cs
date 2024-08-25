using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Audio;

[global::Cpp2ILInjected.Token(Token = "0x2000051")]
public class SoundGroup
{
	[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
	public AudioMixerGroup MixerGroup
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x706FEC", Offset = "0x706FEC", Length = "0x8C")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundManager), Member = "get_MasterMixer", ReturnType = typeof(AudioMixer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AudioMixer), Member = "FindMatchingGroups", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AudioMixerGroup[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x70717C", Offset = "0x70717C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SoundGroup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000124")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	[global::Cpp2ILInjected.Token(Token = "0x4000125")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string MixerGroupPath;

	[global::Cpp2ILInjected.Token(Token = "0x4000126")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private AudioMixerGroup _group;
}
