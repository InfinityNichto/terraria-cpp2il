using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Audio
{
	// Token: 0x02000009 RID: 9
	[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
	[ExcludeFromPreset]
	[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
	[ExcludeFromObjectFactory]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public class AudioMixer : Object
	{
		// Token: 0x06000019 RID: 25
		[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = true, HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F69A60", Offset = "0x1F69A60", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundGroup", Member = "get_MixerGroup", ReturnType = typeof(AudioMixerGroup))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern AudioMixerGroup[] FindMatchingGroups(string subPath);
	}
}
