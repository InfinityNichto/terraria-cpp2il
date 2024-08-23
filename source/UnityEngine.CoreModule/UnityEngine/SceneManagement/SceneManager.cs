using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement
{
	// Token: 0x02000100 RID: 256
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000123")]
	public class SceneManager
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600059D RID: 1437 RVA: 0x00002CB6 File Offset: 0x00000EB6
		// (remove) Token: 0x0600059E RID: 1438 RVA: 0x00002CB9 File Offset: 0x00000EB9
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8C798", Offset = "0x1F8C798", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8C888", Offset = "0x1F8C888", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlManager", Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002CBC File Offset: 0x00000EBC
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60005D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C978", Offset = "0x1F8C978", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "LoadScene", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LoadScene(string sceneName)
		{
			throw null;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002CBF File Offset: 0x00000EBF
		[global::Cpp2ILInjected.Token(Token = "0x60005D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8C9D0", Offset = "0x1F8C9D0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManager), Member = "LoadSceneAsyncNameIndexInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(LoadSceneParameters),
			typeof(bool)
		}, ReturnType = typeof(AsyncOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManager), Member = "GetSceneAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Scene))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			throw null;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002CC2 File Offset: 0x00000EC2
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CBF8", Offset = "0x1F8CBF8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			throw null;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002CC5 File Offset: 0x00000EC5
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CCA0", Offset = "0x1F8CCA0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Internal_SceneUnloaded(Scene scene)
		{
			throw null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002CC8 File Offset: 0x00000EC8
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CD34", Offset = "0x1F8CD34", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			throw null;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005A4 RID: 1444
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public static extern int sceneCount
		{
			[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
			[NativeHeader("Runtime/SceneManager/SceneManager.h")]
			[NativeMethod("GetSceneCount")]
			[global::Cpp2ILInjected.Token(Token = "0x60005D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8CB44", Offset = "0x1F8CB44", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002CCB File Offset: 0x00000ECB
		[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x60005D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CB6C", Offset = "0x1F8CB6C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LoadSceneParameters)
		}, ReturnType = typeof(Scene))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Scene GetSceneAt(int index)
		{
			throw null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002CCE File Offset: 0x00000ECE
		[global::Cpp2ILInjected.Token(Token = "0x60005D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CA70", Offset = "0x1F8CA70", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SceneManager), Member = "LoadScene", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LoadSceneParameters)
		}, ReturnType = typeof(Scene))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManagerAPI), Member = "get_ActiveAPI", ReturnType = typeof(SceneManagerAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			throw null;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002CD1 File Offset: 0x00000ED1
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60005D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CEC8", Offset = "0x1F8CEC8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManagerAPI), Member = "get_ActiveAPI", ReturnType = typeof(SceneManagerAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			throw null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002CD4 File Offset: 0x00000ED4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60005D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CF28", Offset = "0x1F8CF28", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static SceneManager()
		{
			throw null;
		}

		// Token: 0x060005A9 RID: 1449
		[global::Cpp2ILInjected.Token(Token = "0x60005DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8CDDC", Offset = "0x1F8CDDC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void GetSceneAt_Injected(int index, out Scene ret);

		// Token: 0x04000494 RID: 1172
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
		private static UnityAction<Scene, LoadSceneMode> sceneLoaded;

		// Token: 0x04000495 RID: 1173
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
		private static UnityAction<Scene> sceneUnloaded;

		// Token: 0x04000496 RID: 1174
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
		private static UnityAction<Scene, Scene> activeSceneChanged;

		// Token: 0x04000497 RID: 1175
		[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
		internal static bool s_AllowLoadScene;
	}
}
