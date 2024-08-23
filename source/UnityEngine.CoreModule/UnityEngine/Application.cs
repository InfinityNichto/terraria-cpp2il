using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C8 RID: 200
	[NativeHeader("Runtime/Misc/Player.h")]
	[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
	[NativeHeader("Runtime/Network/NetworkUtility.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
	[NativeHeader("Runtime/Application/AdsIdHandler.h")]
	[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
	[NativeHeader("Runtime/Application/ApplicationInfo.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
	[NativeHeader("Runtime/Logging/LogSystem.h")]
	[NativeHeader("Runtime/Misc/BuildSettings.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Utilities/URLUtility.h")]
	[NativeHeader("Runtime/Utilities/Argv.h")]
	[NativeHeader("Runtime/Input/TargetFrameRate.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000DA")]
	public class Application
	{
		// Token: 0x06000466 RID: 1126
		[FreeFunction("GetInputManager().QuitApplication")]
		[global::Cpp2ILInjected.Token(Token = "0x600047A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84368", Offset = "0x1F84368", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void Quit(int exitCode);

		// Token: 0x06000467 RID: 1127 RVA: 0x000029E0 File Offset: 0x00000BE0
		[global::Cpp2ILInjected.Token(Token = "0x600047B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F843A4", Offset = "0x1F843A4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIQuitConfirm", Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Quit()
		{
			throw null;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000468 RID: 1128
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public static extern bool isPlaying
		{
			[FreeFunction("IsWorldPlaying")]
			[global::Cpp2ILInjected.Token(Token = "0x600047C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F843D4", Offset = "0x1F843D4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Singleton`1", Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchControl", Member = "OnDrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "get_EnforceSingleton", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "Awake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Set", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Misc", Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000469 RID: 1129
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		public static extern bool isBatchMode
		{
			[FreeFunction("::IsBatchmode")]
			[global::Cpp2ILInjected.Token(Token = "0x600047D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F843FC", Offset = "0x1F843FC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "LogWarningWhenNotInBatchmode", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600046A RID: 1130
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public static extern string persistentDataPath
		{
			[FreeFunction("GetPersistentDataPathApplicationSpecific")]
			[global::Cpp2ILInjected.Token(Token = "0x600047E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84424", Offset = "0x1F84424", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "GetUserSavePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.OldSaveSynchronise", Member = "CopyOldSaves", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager", Member = "get_SavePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600046B RID: 1131
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public static extern string unityVersion
		{
			[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = true)]
			[global::Cpp2ILInjected.Token(Token = "0x600047F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8444C", Offset = "0x1F8444C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.VersionInfo", Member = "UnityVersion", ReturnType = "InControl.VersionInfo")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600046C RID: 1132
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public static extern string identifier
		{
			[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
			[global::Cpp2ILInjected.Token(Token = "0x6000480")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84474", Offset = "0x1F84474", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600046D RID: 1133
		[FreeFunction("OpenURL")]
		[global::Cpp2ILInjected.Token(Token = "0x6000481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8449C", Offset = "0x1F8449C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform.IOS", Member = "OpenGameCentreSettings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform", Member = "OpenStoreURL", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUILinkButtonSetting", Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void OpenURL(string url);

		// Token: 0x170000E6 RID: 230
		// (set) Token: 0x0600046E RID: 1134
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public static extern int targetFrameRate
		{
			[FreeFunction("SetTargetFrameRate")]
			[global::Cpp2ILInjected.Token(Token = "0x6000482")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F844D8", Offset = "0x1F844D8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUnityRunner", Member = "Awake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "set_Setting_Target60FPS", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600046F RID: 1135
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public static extern RuntimePlatform platform
		{
			[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000483")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84514", Offset = "0x1F84514", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "AndroidImmersive", Member = "Activate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMainMenu", Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.OldSaveSynchronise", Member = "get_OldSaveRoot", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.OldSaveSynchronise", Member = "CopyOldSaves", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.KeyInfo", Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager", Member = "CheckPlatformSupport", MemberParameters = new object[] { "System.Collections.Generic.ICollection`1<String>" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager", Member = "DetectJoystickDevice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchScreenKeyboard), Member = "get_isSupported", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_shouldHideMobileInput", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_shouldActivateOnSelect", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000470 RID: 1136
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public static extern SystemLanguage systemLanguage
		{
			[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
			[global::Cpp2ILInjected.Token(Token = "0x6000484")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8453C", Offset = "0x1F8453C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Localisation", Member = "GetLanguage", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000471 RID: 1137 RVA: 0x000029E3 File Offset: 0x00000BE3
		// (remove) Token: 0x06000472 RID: 1138 RVA: 0x000029E6 File Offset: 0x00000BE6
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public static event Application.LowMemoryCallback lowMemory
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000485")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84564", Offset = "0x1F84564", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUnityRunner", Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000486")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8461C", Offset = "0x1F8461C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000029E9 File Offset: 0x00000BE9
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000487")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F846D4", Offset = "0x1F846D4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void CallLowMemory()
		{
			throw null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000029EC File Offset: 0x00000BEC
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000488")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84738", Offset = "0x1F84738", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
			throw null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000029EF File Offset: 0x00000BEF
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000489")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F847F4", Offset = "0x1F847F4", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static bool Internal_ApplicationWantsToQuit()
		{
			throw null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000029F2 File Offset: 0x00000BF2
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600048A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84990", Offset = "0x1F84990", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Internal_ApplicationQuit()
		{
			throw null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000029F5 File Offset: 0x00000BF5
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600048B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F849F4", Offset = "0x1F849F4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void Internal_ApplicationUnload()
		{
			throw null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000029F8 File Offset: 0x00000BF8
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600048C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84A58", Offset = "0x1F84A58", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BeforeRenderHelper), Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeOnBeforeRender()
		{
			throw null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000029FB File Offset: 0x00000BFB
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600048D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84AA8", Offset = "0x1F84AA8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeFocusChanged(bool focus)
		{
			throw null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000029FE File Offset: 0x00000BFE
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600048E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84B14", Offset = "0x1F84B14", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void InvokeDeepLinkActivated(string url)
		{
			throw null;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00002A01 File Offset: 0x00000C01
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		public static bool isEditor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600048F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84B80", Offset = "0x1F84B80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000398 RID: 920
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40003D0")]
		private static Application.LowMemoryCallback lowMemory;

		// Token: 0x04000399 RID: 921
		[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
		private static Application.LogCallback s_LogCallbackHandler;

		// Token: 0x0400039A RID: 922
		[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
		private static Application.LogCallback s_LogCallbackHandlerThreaded;

		// Token: 0x0400039B RID: 923
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
		private static Action<bool> focusChanged;

		// Token: 0x0400039C RID: 924
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
		private static Action<string> deepLinkActivated;

		// Token: 0x0400039D RID: 925
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
		private static Func<bool> wantsToQuit;

		// Token: 0x0400039E RID: 926
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
		private static Action quitting;

		// Token: 0x0400039F RID: 927
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003D7")]
		private static Action unloading;

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x060006C9 RID: 1737
		[global::Cpp2ILInjected.Token(Token = "0x20000DB")]
		public delegate void LowMemoryCallback();

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x060006CB RID: 1739
		[global::Cpp2ILInjected.Token(Token = "0x20000DC")]
		public delegate void LogCallback(string condition, string stackTrace, LogType type);
	}
}
