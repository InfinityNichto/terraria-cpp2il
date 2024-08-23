using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Playables
{
	// Token: 0x02000129 RID: 297
	[global::Cpp2ILInjected.Token(Token = "0x200014F")]
	public struct PlayableBinding
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x00002DF1 File Offset: 0x00000FF1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600064C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90024", Offset = "0x1F90024", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PlayableBinding()
		{
			throw null;
		}

		// Token: 0x040005D3 RID: 1491
		[global::Cpp2ILInjected.Token(Token = "0x4000629")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_StreamName;

		// Token: 0x040005D4 RID: 1492
		[global::Cpp2ILInjected.Token(Token = "0x400062A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Object m_SourceObject;

		// Token: 0x040005D5 RID: 1493
		[global::Cpp2ILInjected.Token(Token = "0x400062B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type m_SourceBindingType;

		// Token: 0x040005D6 RID: 1494
		[global::Cpp2ILInjected.Token(Token = "0x400062C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

		// Token: 0x040005D7 RID: 1495
		[global::Cpp2ILInjected.Token(Token = "0x400062D")]
		public static readonly PlayableBinding[] None;

		// Token: 0x040005D8 RID: 1496
		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		public static readonly double DefaultDuration;

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060006EB RID: 1771
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x2000150")]
		internal delegate PlayableOutput CreateOutputMethod(PlayableGraph graph, string name);
	}
}
