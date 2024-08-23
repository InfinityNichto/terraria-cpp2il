using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000125 RID: 293
	[AssetFileNameExtension("playable", new string[] { })]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200014B")]
	[Serializable]
	public abstract class PlayableAsset : ScriptableObject
	{
		// Token: 0x06000601 RID: 1537
		[global::Cpp2ILInjected.Token(Token = "0x6000637")]
		public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00002DB5 File Offset: 0x00000FB5
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public virtual double duration
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000638")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8FCA0", Offset = "0x1F8FCA0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00002DB8 File Offset: 0x00000FB8
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public virtual IEnumerable<PlayableBinding> outputs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000639")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8FCF8", Offset = "0x1F8FCF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002DBB File Offset: 0x00000FBB
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600063A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FD50", Offset = "0x1F8FD50", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Playable), Member = "get_Null", ReturnType = typeof(Playable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002DBE File Offset: 0x00000FBE
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600063B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FE78", Offset = "0x1F8FE78", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
			throw null;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002DC1 File Offset: 0x00000FC1
		[global::Cpp2ILInjected.Token(Token = "0x600063C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FE9C", Offset = "0x1F8FE9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
		protected PlayableAsset()
		{
			throw null;
		}
	}
}
