using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000033 RID: 51
[ResourceLocation("Managers/SoundManager")]
[global::Cpp2ILInjected.Token(Token = "0x2000053")]
public class SoundManager : Singleton<SoundManager>
{
	// Token: 0x06000131 RID: 305 RVA: 0x00021F0B File Offset: 0x0002010B
	[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
	[global::Cpp2ILInjected.Address(RVA = "0x707958", Offset = "0x707958", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override void Init()
	{
		throw null;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00021F0E File Offset: 0x0002010E
	[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
	[global::Cpp2ILInjected.Address(RVA = "0x707B94", Offset = "0x707B94", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundManager), Member = "SetupChannels", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	public override void Shutdown()
	{
		throw null;
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000133 RID: 307 RVA: 0x00021F11 File Offset: 0x00020111
	[global::Cpp2ILInjected.Token(Token = "0x17000072")]
	public static AudioMixer MasterMixer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x707078", Offset = "0x707078", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundGroup), Member = "get_MixerGroup", ReturnType = typeof(AudioMixerGroup))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::UnityEngine.Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00021F14 File Offset: 0x00020114
	[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
	[global::Cpp2ILInjected.Address(RVA = "0x7079D8", Offset = "0x7079D8", Length = "0x1BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Destroy", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void SetupChannels(int numChannels)
	{
		throw null;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00021F17 File Offset: 0x00020117
	[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
	[global::Cpp2ILInjected.Address(RVA = "0x70688C", Offset = "0x70688C", Length = "0x374")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundDefinition), Member = "Play", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(SoundInstance))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
	public SoundChannel GetChannel(SoundDefinition soundDefinition)
	{
		throw null;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00021F1A File Offset: 0x0002011A
	[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
	[global::Cpp2ILInjected.Address(RVA = "0x707B9C", Offset = "0x707B9C", Length = "0x1CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundInstance), Member = "Stop", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void StopAllSoundsOnChannels(string channelId)
	{
		throw null;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00021F1D File Offset: 0x0002011D
	[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
	[global::Cpp2ILInjected.Address(RVA = "0x707D68", Offset = "0x707D68", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public bool IsPlaying(SoundDefinition soundDefinition)
	{
		throw null;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00021F20 File Offset: 0x00020120
	[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
	[global::Cpp2ILInjected.Address(RVA = "0x707F28", Offset = "0x707F28", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public SoundManager()
	{
		throw null;
	}

	// Token: 0x040000D7 RID: 215
	[global::Cpp2ILInjected.Token(Token = "0x4000130")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public AnimationCurve VolumeFalloff;

	// Token: 0x040000D8 RID: 216
	[global::Cpp2ILInjected.Token(Token = "0x4000131")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private GameObject _soundRoot;

	// Token: 0x040000D9 RID: 217
	[global::Cpp2ILInjected.Token(Token = "0x4000132")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private List<SoundChannel> _channels;

	// Token: 0x040000DA RID: 218
	[global::Cpp2ILInjected.Token(Token = "0x4000133")]
	private static AudioMixer _mixer;
}
