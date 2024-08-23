using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000127 RID: 295
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200014D")]
	[Serializable]
	public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x00002DC4 File Offset: 0x00000FC4
		[global::Cpp2ILInjected.Token(Token = "0x600063D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEA4", Offset = "0x1F8FEA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayableBehaviour()
		{
			throw null;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002DC7 File Offset: 0x00000FC7
		[global::Cpp2ILInjected.Token(Token = "0x600063E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEAC", Offset = "0x1F8FEAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnGraphStart(Playable playable)
		{
			throw null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002DCA File Offset: 0x00000FCA
		[global::Cpp2ILInjected.Token(Token = "0x600063F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEB0", Offset = "0x1F8FEB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnGraphStop(Playable playable)
		{
			throw null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002DCD File Offset: 0x00000FCD
		[global::Cpp2ILInjected.Token(Token = "0x6000640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEB4", Offset = "0x1F8FEB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnPlayableCreate(Playable playable)
		{
			throw null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002DD0 File Offset: 0x00000FD0
		[global::Cpp2ILInjected.Token(Token = "0x6000641")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEB8", Offset = "0x1F8FEB8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnPlayableDestroy(Playable playable)
		{
			throw null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002DD3 File Offset: 0x00000FD3
		[global::Cpp2ILInjected.Token(Token = "0x6000642")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEBC", Offset = "0x1F8FEBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
			throw null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002DD6 File Offset: 0x00000FD6
		[global::Cpp2ILInjected.Token(Token = "0x6000643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEC0", Offset = "0x1F8FEC0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
			throw null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002DD9 File Offset: 0x00000FD9
		[global::Cpp2ILInjected.Token(Token = "0x6000644")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEC4", Offset = "0x1F8FEC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void PrepareFrame(Playable playable, FrameData info)
		{
			throw null;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002DDC File Offset: 0x00000FDC
		[global::Cpp2ILInjected.Token(Token = "0x6000645")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEC8", Offset = "0x1F8FEC8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
			throw null;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002DDF File Offset: 0x00000FDF
		[global::Cpp2ILInjected.Token(Token = "0x6000646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FECC", Offset = "0x1F8FECC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		public virtual object Clone()
		{
			throw null;
		}
	}
}
