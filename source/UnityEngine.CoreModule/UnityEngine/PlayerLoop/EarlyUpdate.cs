using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.PlayerLoop
{
	[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200017F")]
	public struct EarlyUpdate
	{
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000180")]
		public struct PollPlayerConnection
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000181")]
		public struct PollHtcsPlayerConnection
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000182")]
		public struct GpuTimestamp
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000183")]
		public struct AnalyticsCoreStatsUpdate
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000184")]
		public struct UnityWebRequestUpdate
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000185")]
		public struct UpdateStreamingManager
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000186")]
		public struct ExecuteMainThreadJobs
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000187")]
		public struct ProcessMouseInWindow
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000188")]
		public struct ClearIntermediateRenderers
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000189")]
		public struct ClearLines
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018A")]
		public struct PresentBeforeUpdate
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018B")]
		public struct ResetFrameStatsAfterPresent
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018C")]
		public struct UpdateAsyncReadbackManager
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018D")]
		public struct UpdateTextureStreamingManager
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018E")]
		public struct UpdatePreloading
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018F")]
		public struct RendererNotifyInvisible
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000190")]
		public struct PlayerCleanupCachedData
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000191")]
		public struct UpdateMainGameViewRect
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000192")]
		public struct UpdateCanvasRectTransform
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000193")]
		public struct UpdateInputManager
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000194")]
		public struct ProcessRemoteInput
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000195")]
		public struct XRUpdate
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000196")]
		public struct ScriptRunDelayedStartupFrame
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000197")]
		public struct UpdateKinect
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000198")]
		public struct DeliverIosPlatformEvents
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000199")]
		public struct DispatchEventQueueEvents
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019A")]
		public struct PhysicsResetInterpolatedTransformPosition
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019B")]
		public struct SpriteAtlasManagerUpdate
		{
		}

		[RequiredByNativeCode]
		[Obsolete("TangoUpdate has been deprecated. Use ARCoreUpdate instead (UnityUpgradable) -> UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate", false)]
		[global::Cpp2ILInjected.Token(Token = "0x200019C")]
		public struct TangoUpdate
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019D")]
		public struct ARCoreUpdate
		{
		}

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019E")]
		public struct PerformanceAnalyticsUpdate
		{
		}
	}
}
