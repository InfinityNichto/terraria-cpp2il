using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000031 RID: 49
[global::Cpp2ILInjected.Token(Token = "0x2000051")]
public class SoundGroup
{
	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000123 RID: 291 RVA: 0x00021EE1 File Offset: 0x000200E1
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

	// Token: 0x06000124 RID: 292 RVA: 0x00021EE4 File Offset: 0x000200E4
	[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x70717C", Offset = "0x70717C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SoundGroup()
	{
		throw null;
	}

	// Token: 0x040000CB RID: 203
	[global::Cpp2ILInjected.Token(Token = "0x4000124")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string Id;

	// Token: 0x040000CC RID: 204
	[global::Cpp2ILInjected.Token(Token = "0x4000125")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string MixerGroupPath;

	// Token: 0x040000CD RID: 205
	[global::Cpp2ILInjected.Token(Token = "0x4000126")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private AudioMixerGroup _group;
}
