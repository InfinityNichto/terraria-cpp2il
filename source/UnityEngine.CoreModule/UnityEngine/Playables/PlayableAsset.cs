using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[AssetFileNameExtension("playable", new string[] { })]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200014B")]
	[Serializable]
	public abstract class PlayableAsset : ScriptableObject
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000637")]
		public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

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

		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600063B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FE78", Offset = "0x1F8FE78", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble)
		{
			throw null;
		}

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
