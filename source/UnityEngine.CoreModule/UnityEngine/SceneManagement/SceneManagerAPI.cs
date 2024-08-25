using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SceneManagement
{
	[global::Cpp2ILInjected.Token(Token = "0x2000126")]
	public class SceneManagerAPI
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		internal static SceneManagerAPI ActiveAPI
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8CE20", Offset = "0x1F8CE20", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(LoadSceneParameters),
				typeof(bool)
			}, ReturnType = typeof(AsyncOperation))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneManager), Member = "LoadFirstScene_Internal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(AsyncOperation))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public static SceneManagerAPI overrideAPI
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8D0B8", Offset = "0x1F8D0B8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D110", Offset = "0x1F8D110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected internal SceneManagerAPI()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D118", Offset = "0x1F8D118", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D178", Offset = "0x1F8D178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D180", Offset = "0x1F8D180", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static SceneManagerAPI()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
		private static SceneManagerAPI s_DefaultAPI;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
		private static SceneManagerAPI <overrideAPI>k__BackingField;
	}
}
