using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public sealed class AudioSettings
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68E78", Offset = "0x1F68E78", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			throw null;
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68EE4", Offset = "0x1F68EE4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
			throw null;
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68F48", Offset = "0x1F68F48", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnAudioSystemStartedUp()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68FAC", Offset = "0x1F68FAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool StartAudioOutput();

		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68FD4", Offset = "0x1F68FD4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool StopAudioOutput();

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		private static Action OnAudioSystemShuttingDown;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		private static Action OnAudioSystemStartedUp;

		[global::Cpp2ILInjected.Token(Token = "0x2000003")]
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

		[global::Cpp2ILInjected.Token(Token = "0x2000004")]
		public static class Mobile
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000001")]
			public static bool muteState
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6000008")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F690D8", Offset = "0x1F690D8", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x6000009")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F69120", Offset = "0x1F69120", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				private set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000002")]
			public static bool stopAudioOutputOnMute
			{
				[global::Cpp2ILInjected.Token(Token = "0x600000A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F6916C", Offset = "0x1F6916C", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[RequiredByNativeCode]
			[global::Cpp2ILInjected.Token(Token = "0x600000B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F691B4", Offset = "0x1F691B4", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal static void InvokeOnMuteStateChanged(bool mute)
			{
				throw null;
			}

			[RequiredByNativeCode]
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69380", Offset = "0x1F69380", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal static bool InvokeIsStopAudioOutputOnMuteEnabled()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69358", Offset = "0x1F69358", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void StartAudioOutput()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69330", Offset = "0x1F69330", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void StopAudioOutput()
			{
				throw null;
			}

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000004")]
			private static bool <muteState>k__BackingField;

			[global::Cpp2ILInjected.Token(Token = "0x4000005")]
			private static bool _stopAudioOutputOnMute;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000006")]
			private static Action<bool> OnMuteStateChanged;
		}
	}
}
