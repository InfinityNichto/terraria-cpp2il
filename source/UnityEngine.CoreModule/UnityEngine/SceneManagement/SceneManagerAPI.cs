using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000103 RID: 259
	[global::Cpp2ILInjected.Token(Token = "0x2000126")]
	public class SceneManagerAPI
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00002CE3 File Offset: 0x00000EE3
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00002CE6 File Offset: 0x00000EE6
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

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002CE9 File Offset: 0x00000EE9
		[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D110", Offset = "0x1F8D110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected internal SceneManagerAPI()
		{
			throw null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002CEC File Offset: 0x00000EEC
		[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D118", Offset = "0x1F8D118", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw null;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002CEF File Offset: 0x00000EEF
		[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D178", Offset = "0x1F8D178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
		{
			throw null;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002CF2 File Offset: 0x00000EF2
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

		// Token: 0x04000499 RID: 1177
		[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
		private static SceneManagerAPI s_DefaultAPI;

		// Token: 0x0400049A RID: 1178
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
		private static SceneManagerAPI <overrideAPI>k__BackingField;
	}
}
