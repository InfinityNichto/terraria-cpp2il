using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public sealed class AudioSettings
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68E78", Offset = "0x1F68E78", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68EE4", Offset = "0x1F68EE4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68F48", Offset = "0x1F68F48", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnAudioSystemStartedUp()
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68FAC", Offset = "0x1F68FAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool StartAudioOutput();

		// Token: 0x06000005 RID: 5
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F68FD4", Offset = "0x1F68FD4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern bool StopAudioOutput();

		// Token: 0x04000001 RID: 1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		// Token: 0x04000002 RID: 2
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		private static Action OnAudioSystemShuttingDown;

		// Token: 0x04000003 RID: 3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		private static Action OnAudioSystemStartedUp;

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600002D RID: 45
		[global::Cpp2ILInjected.Token(Token = "0x2000003")]
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

		// Token: 0x0200001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x2000004")]
		public static class Mobile
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600002E RID: 46 RVA: 0x000020A1 File Offset: 0x000002A1
			// (set) Token: 0x0600002F RID: 47 RVA: 0x000020A4 File Offset: 0x000002A4
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

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000030 RID: 48 RVA: 0x000020A7 File Offset: 0x000002A7
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

			// Token: 0x06000031 RID: 49 RVA: 0x000020AA File Offset: 0x000002AA
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

			// Token: 0x06000032 RID: 50 RVA: 0x000020AD File Offset: 0x000002AD
			[RequiredByNativeCode]
			[global::Cpp2ILInjected.Token(Token = "0x600000C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69380", Offset = "0x1F69380", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal static bool InvokeIsStopAudioOutputOnMuteEnabled()
			{
				throw null;
			}

			// Token: 0x06000033 RID: 51 RVA: 0x000020B0 File Offset: 0x000002B0
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69358", Offset = "0x1F69358", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void StartAudioOutput()
			{
				throw null;
			}

			// Token: 0x06000034 RID: 52 RVA: 0x000020B3 File Offset: 0x000002B3
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F69330", Offset = "0x1F69330", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void StopAudioOutput()
			{
				throw null;
			}

			// Token: 0x0400001D RID: 29
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000004")]
			private static bool <muteState>k__BackingField;

			// Token: 0x0400001E RID: 30
			[global::Cpp2ILInjected.Token(Token = "0x4000005")]
			private static bool _stopAudioOutputOnMute;

			// Token: 0x0400001F RID: 31
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4000006")]
			private static Action<bool> OnMuteStateChanged;
		}
	}
}
