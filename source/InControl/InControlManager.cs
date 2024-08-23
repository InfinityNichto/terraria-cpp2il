using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace InControl
{
	// Token: 0x02000019 RID: 25
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	public class InControlManager : SingletonMonoBehavior<InControlManager>
	{
		// Token: 0x0600011A RID: 282 RVA: 0x000023B7 File Offset: 0x000005B7
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1984F70", Offset = "0x1984F70", Length = "0x57C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_EnforceSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "SetupInternal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<LogMessage>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "remove_OnLogMessage", MemberParameters = new object[] { typeof(Action<LogMessage>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "add_OnLogMessage", MemberParameters = new object[] { typeof(Action<LogMessage>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<Scene, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManager), Member = "remove_sceneLoaded", MemberParameters = new object[] { typeof(UnityAction<Scene, LoadSceneMode>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManager), Member = "add_sceneLoaded", MemberParameters = new object[] { typeof(UnityAction<Scene, LoadSceneMode>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "DontDestroyOnLoad", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000023BA File Offset: 0x000005BA
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985684", Offset = "0x1985684", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<Scene, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SceneManager), Member = "remove_sceneLoaded", MemberParameters = new object[] { typeof(UnityAction<Scene, LoadSceneMode>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "ResetInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000023BD File Offset: 0x000005BD
		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985788", Offset = "0x1985788", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_timeScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000023C0 File Offset: 0x000005C0
		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985870", Offset = "0x1985870", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000023C3 File Offset: 0x000005C3
		[global::Cpp2ILInjected.Token(Token = "0x600011E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985908", Offset = "0x1985908", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnApplicationFocus(bool focusState)
		{
			throw null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000023C6 File Offset: 0x000005C6
		[global::Cpp2ILInjected.Token(Token = "0x600011F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19859A0", Offset = "0x19859A0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnApplicationPause(bool pauseState)
		{
			throw null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000023C9 File Offset: 0x000005C9
		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985A38", Offset = "0x1985A38", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000023CC File Offset: 0x000005CC
		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985ABC", Offset = "0x1985ABC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "OnLevelWasLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnSceneWasLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000023CF File Offset: 0x000005CF
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985B54", Offset = "0x1985B54", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void LogMessage(LogMessage logMessage)
		{
			throw null;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000023D2 File Offset: 0x000005D2
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1985C18", Offset = "0x1985C18", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public InControlManager()
		{
			throw null;
		}

		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool logDebugInfo;

		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x4000114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool invertYAxis;

		// Token: 0x04000111 RID: 273
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		private bool useFixedUpdate;

		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
		public bool dontDestroyOnLoad;

		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x4000117")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public bool suspendInBackground;

		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x4000118")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public InControlUpdateMode updateMode;

		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x4000119")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool enableICade;

		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x400011A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		public bool enableXInput;

		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		public bool xInputOverrideUpdateRate;

		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int xInputUpdateRate;

		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public bool xInputOverrideBufferSize;

		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x400011E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int xInputBufferSize;

		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public bool editorDisableAllProfiles;

		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		public bool enableNativeInput;

		// Token: 0x0400011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x36")]
		public bool nativeInputEnableXInput;

		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x37")]
		public bool nativeInputEnableMFi;

		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public bool nativeInputPreventSleep;

		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		public bool nativeInputOverrideUpdateRate;

		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int nativeInputUpdateRate;

		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool applicationHasQuit;
	}
}
