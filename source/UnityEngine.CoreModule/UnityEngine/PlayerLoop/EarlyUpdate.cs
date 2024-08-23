using System;
using Cpp2ILInjected;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.PlayerLoop
{
	// Token: 0x0200014E RID: 334
	[MovedFrom("UnityEngine.Experimental.PlayerLoop")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200017F")]
	public struct EarlyUpdate
	{
		// Token: 0x02000191 RID: 401
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000180")]
		public struct PollPlayerConnection
		{
		}

		// Token: 0x02000192 RID: 402
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000181")]
		public struct PollHtcsPlayerConnection
		{
		}

		// Token: 0x02000193 RID: 403
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000182")]
		public struct GpuTimestamp
		{
		}

		// Token: 0x02000194 RID: 404
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000183")]
		public struct AnalyticsCoreStatsUpdate
		{
		}

		// Token: 0x02000195 RID: 405
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000184")]
		public struct UnityWebRequestUpdate
		{
		}

		// Token: 0x02000196 RID: 406
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000185")]
		public struct UpdateStreamingManager
		{
		}

		// Token: 0x02000197 RID: 407
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000186")]
		public struct ExecuteMainThreadJobs
		{
		}

		// Token: 0x02000198 RID: 408
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000187")]
		public struct ProcessMouseInWindow
		{
		}

		// Token: 0x02000199 RID: 409
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000188")]
		public struct ClearIntermediateRenderers
		{
		}

		// Token: 0x0200019A RID: 410
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000189")]
		public struct ClearLines
		{
		}

		// Token: 0x0200019B RID: 411
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018A")]
		public struct PresentBeforeUpdate
		{
		}

		// Token: 0x0200019C RID: 412
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018B")]
		public struct ResetFrameStatsAfterPresent
		{
		}

		// Token: 0x0200019D RID: 413
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018C")]
		public struct UpdateAsyncReadbackManager
		{
		}

		// Token: 0x0200019E RID: 414
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018D")]
		public struct UpdateTextureStreamingManager
		{
		}

		// Token: 0x0200019F RID: 415
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018E")]
		public struct UpdatePreloading
		{
		}

		// Token: 0x020001A0 RID: 416
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200018F")]
		public struct RendererNotifyInvisible
		{
		}

		// Token: 0x020001A1 RID: 417
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000190")]
		public struct PlayerCleanupCachedData
		{
		}

		// Token: 0x020001A2 RID: 418
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000191")]
		public struct UpdateMainGameViewRect
		{
		}

		// Token: 0x020001A3 RID: 419
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000192")]
		public struct UpdateCanvasRectTransform
		{
		}

		// Token: 0x020001A4 RID: 420
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000193")]
		public struct UpdateInputManager
		{
		}

		// Token: 0x020001A5 RID: 421
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000194")]
		public struct ProcessRemoteInput
		{
		}

		// Token: 0x020001A6 RID: 422
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000195")]
		public struct XRUpdate
		{
		}

		// Token: 0x020001A7 RID: 423
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000196")]
		public struct ScriptRunDelayedStartupFrame
		{
		}

		// Token: 0x020001A8 RID: 424
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000197")]
		public struct UpdateKinect
		{
		}

		// Token: 0x020001A9 RID: 425
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000198")]
		public struct DeliverIosPlatformEvents
		{
		}

		// Token: 0x020001AA RID: 426
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x2000199")]
		public struct DispatchEventQueueEvents
		{
		}

		// Token: 0x020001AB RID: 427
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019A")]
		public struct PhysicsResetInterpolatedTransformPosition
		{
		}

		// Token: 0x020001AC RID: 428
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019B")]
		public struct SpriteAtlasManagerUpdate
		{
		}

		// Token: 0x020001AD RID: 429
		[RequiredByNativeCode]
		[Obsolete("TangoUpdate has been deprecated. Use ARCoreUpdate instead (UnityUpgradable) -> UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate", false)]
		[global::Cpp2ILInjected.Token(Token = "0x200019C")]
		public struct TangoUpdate
		{
		}

		// Token: 0x020001AE RID: 430
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019D")]
		public struct ARCoreUpdate
		{
		}

		// Token: 0x020001AF RID: 431
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x200019E")]
		public struct PerformanceAnalyticsUpdate
		{
		}
	}
}
