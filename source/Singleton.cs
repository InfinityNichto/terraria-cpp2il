using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using UnityEngine;

// Token: 0x0200003E RID: 62
[global::Cpp2ILInjected.Token(Token = "0x2000063")]
public abstract class Singleton<T> : ScriptableObject where T : Singleton<T>, new()
{
	// Token: 0x06000176 RID: 374 RVA: 0x00021FDA File Offset: 0x000201DA
	[global::Cpp2ILInjected.Token(Token = "0x6000209")]
	[global::Cpp2ILInjected.Address(RVA = "0x1866CBC", Offset = "0x1866CBC", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlatformControllerDisplay), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	public Singleton()
	{
		throw null;
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000177 RID: 375 RVA: 0x00021FDD File Offset: 0x000201DD
	[global::Cpp2ILInjected.Token(Token = "0x17000073")]
	public static T Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1866CC4", Offset = "0x1866CC4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00021FE0 File Offset: 0x000201E0
	[global::Cpp2ILInjected.Token(Token = "0x600020B")]
	[global::Cpp2ILInjected.Address(RVA = "0x1866CFC", Offset = "0x1866CFC", Length = "0x17C")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "Awake", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AudioEngine), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public static void Create()
	{
		throw null;
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00021FE3 File Offset: 0x000201E3
	[global::Cpp2ILInjected.Token(Token = "0x600020C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1866E78", Offset = "0x1866E78", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private static void CreateOnMainThread(object resourceId)
	{
		throw null;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00021FE6 File Offset: 0x000201E6
	[global::Cpp2ILInjected.Token(Token = "0x600020D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1866F20", Offset = "0x1866F20", Length = "0x60C")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_IsMainThread", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution.ExecutionSnippet), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
	{
		typeof(MainThreadExecution.ExecutionSnippet),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberParameters = new object[]
	{
		typeof(string),
		typeof(Type)
	}, ReturnType = typeof(global::UnityEngine.Object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Instantiate", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(global::UnityEngine.Object))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonCleanup.CleanupSingletonCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonCleanup), Member = "add_CleanUpEvent", MemberParameters = new object[] { typeof(SingletonCleanup.CleanupSingletonCallback) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
	public static void Create(string resourceId)
	{
		throw null;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00021FE9 File Offset: 0x000201E9
	[global::Cpp2ILInjected.Token(Token = "0x600020E")]
	[global::Cpp2ILInjected.Address(RVA = "0x186752C", Offset = "0x186752C", Length = "0x1B0")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonCleanup.CleanupSingletonCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonCleanup), Member = "remove_CleanUpEvent", MemberParameters = new object[] { typeof(SingletonCleanup.CleanupSingletonCallback) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
	public static void Destroy()
	{
		throw null;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00021FEC File Offset: 0x000201EC
	[global::Cpp2ILInjected.Token(Token = "0x600020F")]
	[global::Cpp2ILInjected.Address(RVA = "0x18676DC", Offset = "0x18676DC", Length = "0xEC")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00021FEF File Offset: 0x000201EF
	[global::Cpp2ILInjected.Token(Token = "0x6000210")]
	[global::Cpp2ILInjected.Address(RVA = "0x18677C8", Offset = "0x18677C8", Length = "0xE8")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00021FF2 File Offset: 0x000201F2
	[global::Cpp2ILInjected.Token(Token = "0x6000211")]
	[global::Cpp2ILInjected.Address(RVA = "0x18678B0", Offset = "0x18678B0", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	private static void Cleanup()
	{
		throw null;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00021FF5 File Offset: 0x000201F5
	[global::Cpp2ILInjected.Token(Token = "0x6000212")]
	[global::Cpp2ILInjected.Address(RVA = "0x18679C8", Offset = "0x18679C8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Init()
	{
		throw null;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00021FF8 File Offset: 0x000201F8
	[global::Cpp2ILInjected.Token(Token = "0x6000213")]
	[global::Cpp2ILInjected.Address(RVA = "0x18679CC", Offset = "0x18679CC", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Shutdown()
	{
		throw null;
	}

	// Token: 0x04000104 RID: 260
	[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
	private static T _instance;

	// Token: 0x04000105 RID: 261
	[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
	private static bool _initialised;
}
