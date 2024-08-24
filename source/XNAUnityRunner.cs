using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Telepathy;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.IO;
using Terraria.UI;
using UnityEngine;

// Token: 0x02000250 RID: 592
[global::Cpp2ILInjected.Token(Token = "0x200030B")]
public class XNAUnityRunner : MonoBehaviour
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00024D31 File Offset: 0x00022F31
	[global::Cpp2ILInjected.Token(Token = "0x170001B4")]
	public static XNAUnityRunner.ForcedInputMode CurrentInputMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001216")]
		[global::Cpp2ILInjected.Address(RVA = "0xA73634", Offset = "0xA73634", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00024D34 File Offset: 0x00022F34
	[global::Cpp2ILInjected.Token(Token = "0x170001B5")]
	public static XNAUnityRunner.ForcedInputMode PrimaryInputMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001217")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6E160", Offset = "0xA6E160", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00024D37 File Offset: 0x00022F37
	[global::Cpp2ILInjected.Token(Token = "0x6001218")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73764", Offset = "0xA73764", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "Setup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = "LoadReleaseLayout", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "SetupPrimary", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "set_sleepTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Singleton<>), Member = "Create", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "UnityAwake", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00024D3A File Offset: 0x00022F3A
	[global::Cpp2ILInjected.Token(Token = "0x6001219")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73D30", Offset = "0xA73D30", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application.LowMemoryCallback), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "add_lowMemory", MemberParameters = new object[] { typeof(Application.LowMemoryCallback) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "UnityStart", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00024D3D File Offset: 0x00022F3D
	[global::Cpp2ILInjected.Token(Token = "0x600121A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73DC8", Offset = "0xA73DC8", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "UnloadAssets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextureAtlasDB), Member = "ActionPendingUnloadAssets", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Application_lowMemory()
	{
		throw null;
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x00024D40 File Offset: 0x00022F40
	[global::Cpp2ILInjected.Token(Token = "0x600121B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73E24", Offset = "0xA73E24", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00024D43 File Offset: 0x00022F43
	[global::Cpp2ILInjected.Token(Token = "0x600121C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73E88", Offset = "0xA73E88", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private void OnGUI()
	{
		throw null;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00024D46 File Offset: 0x00022F46
	[global::Cpp2ILInjected.Token(Token = "0x600121D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA73E8C", Offset = "0xA73E8C", Length = "0x1A0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "ServerLoopUpdateFrame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "TerminateAll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerAutoFinder), Member = "StopSearching", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Netplay), Member = "StopBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public void OnApplicationQuit()
	{
		throw null;
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00024D49 File Offset: 0x00022F49
	[global::Cpp2ILInjected.Token(Token = "0x600121E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA74120", Offset = "0xA74120", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrKeyboard_Touch), Member = "AppFocusGained", ReturnType = typeof(void))]
	private void OnApplicationFocus(bool focus)
	{
		throw null;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00024D4C File Offset: 0x00022F4C
	[global::Cpp2ILInjected.Token(Token = "0x600121F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA74130", Offset = "0xA74130", Length = "0x270")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isEditor", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XBOChatPermissions), Member = "Reset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XBOOnlinePresencePermissions), Member = "Reset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "UpdateAudio", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerFileData", ReturnType = typeof(PlayerFileData))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "OnLostFocus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "UnloadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	private void OnApplicationPause(bool pause)
	{
		throw null;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x00024D4F File Offset: 0x00022F4F
	[global::Cpp2ILInjected.Token(Token = "0x6001220")]
	[global::Cpp2ILInjected.Address(RVA = "0xA743A0", Offset = "0xA743A0", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private string GetNextScreenshotFilename()
	{
		throw null;
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00024D52 File Offset: 0x00022F52
	[global::Cpp2ILInjected.Token(Token = "0x170001B6")]
	public static int ScreenWidth
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001221")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6FC6C", Offset = "0xA6FC6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "ShouldIgnoreForWorld", MemberParameters = new object[] { typeof(global::UnityEngine.Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "DrawBacking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawBacking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UpdateViewPorts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "PlatformGetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "set_VirtualScreenSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "PlatformInitializeAdapters", MemberParameters = new object[] { typeof(ref ReadOnlyCollection<GraphicsAdapter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00024D55 File Offset: 0x00022F55
	[global::Cpp2ILInjected.Token(Token = "0x170001B7")]
	public static int ScreenHeight
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001222")]
		[global::Cpp2ILInjected.Address(RVA = "0xA6F410", Offset = "0xA6F410", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "ShouldIgnoreForWorld", MemberParameters = new object[] { typeof(global::UnityEngine.Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursor", MemberParameters = new object[] { typeof(global::Cursor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "DrawBacking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISafeRegionEdit), Member = "UpdateCursorDragging", MemberParameters = new object[] { typeof(ref Rect) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "DrawBacking", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "UpdateViewPorts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "SetWorldScreenOffset", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "PlatformGetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "set_VirtualScreenSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "PlatformInitializeAdapters", MemberParameters = new object[] { typeof(ref ReadOnlyCollection<GraphicsAdapter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00024D58 File Offset: 0x00022F58
	[global::Cpp2ILInjected.Token(Token = "0x6001223")]
	[global::Cpp2ILInjected.Address(RVA = "0xA74508", Offset = "0xA74508", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00024D5B File Offset: 0x00022F5B
	[global::Cpp2ILInjected.Token(Token = "0x170001B8")]
	public static global::UnityEngine.Vector3 MousePosition
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001224")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75420", Offset = "0xA75420", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "get_MousePositionReal", ReturnType = typeof(global::UnityEngine.Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "get_EmuMouseModeActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.IOS), Member = "get_Mouse", ReturnType = typeof(iOS_Mouse))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(global::UnityEngine.Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x060010D4 RID: 4308 RVA: 0x00024D5E File Offset: 0x00022F5E
	[global::Cpp2ILInjected.Token(Token = "0x170001B9")]
	public static global::UnityEngine.Vector3 MousePositionReal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001225")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75500", Offset = "0xA75500", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::UnityEngine.Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_MousePosition", ReturnType = typeof(global::UnityEngine.Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00024D61 File Offset: 0x00022F61
	[global::Cpp2ILInjected.Token(Token = "0x6001226")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7554C", Offset = "0xA7554C", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "Draw", MemberParameters = new object[]
	{
		typeof(DraggableItemGrid_Layout),
		typeof(GUIItemGrid.GetItemScaleHandler),
		typeof(GUIItemGrid.CursorOver),
		typeof(GUIItemGrid.DrawItemHandler),
		typeof(int),
		typeof(ref float),
		typeof(ref float),
		typeof(ref int),
		typeof(ref Microsoft.Xna.Framework.Vector2),
		typeof(GUIItemGrid.GetItemSizeHandler),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarScroll", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "PlatformGetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "get_EmuMouseModeActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.IOS), Member = "get_Mouse", ReturnType = typeof(iOS_Mouse))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static float GetMouseScrollDelta(bool ignoreEditor = false)
	{
		throw null;
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00024D64 File Offset: 0x00022F64
	[global::Cpp2ILInjected.Token(Token = "0x6001227")]
	[global::Cpp2ILInjected.Address(RVA = "0xA75600", Offset = "0xA75600", Length = "0xD8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsMouseActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsTouchScrollOnly", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "PlatformGetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "get_EmuMouseModeActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetEMUMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.IOS), Member = "get_Mouse", ReturnType = typeof(iOS_Mouse))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static bool GetMouseButton(int index, bool ignoreEditor = false)
	{
		throw null;
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00024D67 File Offset: 0x00022F67
	[global::Cpp2ILInjected.Token(Token = "0x6001228")]
	[global::Cpp2ILInjected.Address(RVA = "0xA756D8", Offset = "0xA756D8", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsMouseActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsTouchScrollOnly", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateCursorList", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "get_EmuMouseModeActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetEMUMouseButtonUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.IOS), Member = "get_Mouse", ReturnType = typeof(iOS_Mouse))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static bool GetMouseButtonUp(int index, bool ignoreEditor = false)
	{
		throw null;
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00024D6A File Offset: 0x00022F6A
	[global::Cpp2ILInjected.Token(Token = "0x6001229")]
	[global::Cpp2ILInjected.Address(RVA = "0xA757E8", Offset = "0xA757E8", Length = "0x110")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsMouseActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "IsTouchScrollOnly", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "GetTouchPhase", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TouchPhase))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "get_EmuMouseModeActive", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetEMUMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.IOS), Member = "get_Mouse", ReturnType = typeof(iOS_Mouse))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static bool GetMouseButtonDown(int index, bool ignoreEditor = false)
	{
		throw null;
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00024D6D File Offset: 0x00022F6D
	// (set) Token: 0x060010DA RID: 4314 RVA: 0x00024D70 File Offset: 0x00022F70
	[global::Cpp2ILInjected.Token(Token = "0x170001BA")]
	public static bool MobileKeyboardLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x600122A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA758F8", Offset = "0xA758F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600122B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75950", Offset = "0xA75950", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "set_MobileControllerLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "set_MobileTouchLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x060010DB RID: 4315 RVA: 0x00024D73 File Offset: 0x00022F73
	[global::Cpp2ILInjected.Token(Token = "0x170001BB")]
	public static bool KeyboardModeLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x600122C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75A68", Offset = "0xA75A68", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "UpdateMouseEMUTouches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "get_Visible", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "DrawHUD", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x060010DC RID: 4316 RVA: 0x00024D76 File Offset: 0x00022F76
	// (set) Token: 0x060010DD RID: 4317 RVA: 0x00024D79 File Offset: 0x00022F79
	[global::Cpp2ILInjected.Token(Token = "0x170001BC")]
	public static bool MobileControllerLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x600122D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75B10", Offset = "0xA75B10", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600122E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA759DC", Offset = "0xA759DC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIReturnToTouch), Member = "Draw", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "set_MobileTouchLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "set_MobileKeyboardLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060010DE RID: 4318 RVA: 0x00024D7C File Offset: 0x00022F7C
	[global::Cpp2ILInjected.Token(Token = "0x170001BD")]
	public static bool ControllerModeLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x600122F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA736A4", Offset = "0xA736A4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x060010DF RID: 4319 RVA: 0x00024D7F File Offset: 0x00022F7F
	// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00024D82 File Offset: 0x00022F82
	[global::Cpp2ILInjected.Token(Token = "0x170001BE")]
	public static bool MobileTouchLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001230")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75B68", Offset = "0xA75B68", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6001231")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75BC0", Offset = "0xA75BC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "set_MobileKeyboardLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "set_MobileControllerLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00024D85 File Offset: 0x00022F85
	[global::Cpp2ILInjected.Token(Token = "0x170001BF")]
	public static bool TouchInputKeyboardLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001232")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75C54", Offset = "0xA75C54", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageIcons), Member = "DrawLeftMenuButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettings), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchModeLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00024D88 File Offset: 0x00022F88
	[global::Cpp2ILInjected.Token(Token = "0x170001C0")]
	public static bool TouchModeLocked
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001233")]
		[global::Cpp2ILInjected.Address(RVA = "0xA75CD0", Offset = "0xA75CD0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00024D8B File Offset: 0x00022F8B
	[global::Cpp2ILInjected.Token(Token = "0x6001234")]
	[global::Cpp2ILInjected.Address(RVA = "0xA75D78", Offset = "0xA75D78", Length = "0x330")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	private void SetMobileMouseMode(int mode)
	{
		throw null;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00024D8E File Offset: 0x00022F8E
	[global::Cpp2ILInjected.Token(Token = "0x6001235")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7456C", Offset = "0xA7456C", Length = "0xEB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadContentRequest), Member = "UpdatingLoading", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDeviceManager), Member = "UpdateConnectedControllers", MemberParameters = new object[]
	{
		typeof(float),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "LookForNewUsers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUICameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "UpdateCursors", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "OnUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.PS4), Member = "UpdateMouse", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.IOS), Member = "UpdateMouse", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_HasController", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "set_MobileControllerLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "set_MobileKeyboardLocked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_HasKeyboard", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_MousePosition", ReturnType = typeof(global::UnityEngine.Vector3))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_KeyboardModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "set_KeyboardEnabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetRealTouchCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ControllerModeLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "SetMobileMouseMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentSamples), Member = "ResetItemTooltips", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTooltip), Member = "InvalidateTooltips", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "UnloadState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "UnityUpdate", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Switch), Member = "get_Docked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "get_Active", ReturnType = typeof(InterfaceProfile_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceProfile_Layout), Member = "InvalidateMinResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "LoadUIResolution", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InterfaceStyles_Layout), Member = "SetActiveLayout", MemberParameters = new object[] { typeof(InterfaceProfile_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 75)]
	private void ExecuteFrame(float timeDelta)
	{
		throw null;
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00024D91 File Offset: 0x00022F91
	[global::Cpp2ILInjected.Token(Token = "0x170001C1")]
	public static bool RenderingUI
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001236")]
		[global::Cpp2ILInjected.Address(RVA = "0xA760A8", Offset = "0xA760A8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00024D94 File Offset: 0x00022F94
	[global::Cpp2ILInjected.Token(Token = "0x170001C2")]
	private static XNAUnityRunner.MouseStateBackup _uiMouseState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001237")]
		[global::Cpp2ILInjected.Address(RVA = "0xA76100", Offset = "0xA76100", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00024D97 File Offset: 0x00022F97
	[global::Cpp2ILInjected.Token(Token = "0x170001C3")]
	private static XNAUnityRunner.MouseStateBackup _worldMouseState
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001238")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7614C", Offset = "0xA7614C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00024D9A File Offset: 0x00022F9A
	// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00024D9D File Offset: 0x00022F9D
	[global::Cpp2ILInjected.Token(Token = "0x170001C4")]
	private static int _lastUIFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001239")]
		[global::Cpp2ILInjected.Address(RVA = "0xA76198", Offset = "0xA76198", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600123A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA761E4", Offset = "0xA761E4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00024DA0 File Offset: 0x00022FA0
	[global::Cpp2ILInjected.Token(Token = "0x600123B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA76234", Offset = "0xA76234", Length = "0xE4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Vector2 AdjustRealScreenForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00024DA3 File Offset: 0x00022FA3
	[global::Cpp2ILInjected.Token(Token = "0x600123C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA76318", Offset = "0xA76318", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00024DA6 File Offset: 0x00022FA6
	[global::Cpp2ILInjected.Token(Token = "0x600123D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7641C", Offset = "0xA7641C", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateUINavigation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "UpdateCursorPosition", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Vector2 AdjustUIForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00024DA9 File Offset: 0x00022FA9
	[global::Cpp2ILInjected.Token(Token = "0x600123E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA76528", Offset = "0xA76528", Length = "0x134")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Microsoft.Xna.Framework.Vector2 AdjustWorldPositionForUI(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00024DAC File Offset: 0x00022FAC
	[global::Cpp2ILInjected.Token(Token = "0x600123F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7665C", Offset = "0xA7665C", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CursorManager), Member = "ShouldIgnoreForWorld", MemberParameters = new object[] { typeof(global::UnityEngine.Vector2) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Vector2 ScaleUIDirectionForRealScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00024DAF File Offset: 0x00022FAF
	[global::Cpp2ILInjected.Token(Token = "0x6001240")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7674C", Offset = "0xA7674C", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Vector2 ScaleScreenDirectionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00024DB2 File Offset: 0x00022FB2
	[global::Cpp2ILInjected.Token(Token = "0x6001241")]
	[global::Cpp2ILInjected.Address(RVA = "0xA767FC", Offset = "0xA767FC", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static Microsoft.Xna.Framework.Vector2 ScaleWorldDirectionForScreen(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00024DB5 File Offset: 0x00022FB5
	[global::Cpp2ILInjected.Token(Token = "0x6001242")]
	[global::Cpp2ILInjected.Address(RVA = "0xA768AC", Offset = "0xA768AC", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "GetMouseNPC", ReturnType = typeof(NPC))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMagnify), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_MouseWorld2", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTileGridOption", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Microsoft.Xna.Framework.Vector2 AdjustScreenPositionForWorld(Microsoft.Xna.Framework.Vector2 inputPosition)
	{
		throw null;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00024DB8 File Offset: 0x00022FB8
	[global::Cpp2ILInjected.Token(Token = "0x6001243")]
	[global::Cpp2ILInjected.Address(RVA = "0xA76A00", Offset = "0xA76A00", Length = "0x5CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner.MouseStateBackup), Member = "Capture", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseRight", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseRightRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner.MouseStateBackup), Member = "UpdateState", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseLeft", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner.MouseStateBackup), Member = "Restore", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "SetMousePosition", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_screenWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_screenHeight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "set__overloadScreenWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "set__overloadScreenHeight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "set__overloadScreenOffsetX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "set__overloadScreenOffsetY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public static void SetupRenderingUI(bool renderingUI)
	{
		throw null;
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00024DBB File Offset: 0x00022FBB
	[global::Cpp2ILInjected.Token(Token = "0x6001244")]
	[global::Cpp2ILInjected.Address(RVA = "0xA77298", Offset = "0xA77298", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimationCurve), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public XNAUnityRunner()
	{
		throw null;
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00024DBE File Offset: 0x00022FBE
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001245")]
	[global::Cpp2ILInjected.Address(RVA = "0xA77388", Offset = "0xA77388", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	static XNAUnityRunner()
	{
		throw null;
	}

	// Token: 0x04001BE6 RID: 7142
	[global::Cpp2ILInjected.Token(Token = "0x40021A4")]
	public static XNAUnityRunner _instance;

	// Token: 0x04001BE7 RID: 7143
	[global::Cpp2ILInjected.Token(Token = "0x40021A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public XNAWorldCameraSettings WorldCameraSettings;

	// Token: 0x04001BE8 RID: 7144
	[global::Cpp2ILInjected.Token(Token = "0x40021A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public XNAUICameraSettings UICameraSettings;

	// Token: 0x04001BE9 RID: 7145
	[global::Cpp2ILInjected.Token(Token = "0x40021A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool IncrementalBatching;

	// Token: 0x04001BEA RID: 7146
	[global::Cpp2ILInjected.Token(Token = "0x40021A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
	public bool LogMaterialCreation;

	// Token: 0x04001BEB RID: 7147
	[global::Cpp2ILInjected.Token(Token = "0x40021A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
	public bool DisableVariableUpdate;

	// Token: 0x04001BEC RID: 7148
	[global::Cpp2ILInjected.Token(Token = "0x40021AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Microsoft.Xna.Framework.Vector2 IncrementalBatchingOffset;

	// Token: 0x04001BED RID: 7149
	[global::Cpp2ILInjected.Token(Token = "0x40021AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public bool EnableBatching;

	// Token: 0x04001BEE RID: 7150
	[global::Cpp2ILInjected.Token(Token = "0x40021AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
	public bool DumpMemory;

	// Token: 0x04001BEF RID: 7151
	[global::Cpp2ILInjected.Token(Token = "0x40021AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string ReleaseVersion;

	// Token: 0x04001BF0 RID: 7152
	[global::Cpp2ILInjected.Token(Token = "0x40021AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int BuildNumber;

	// Token: 0x04001BF1 RID: 7153
	[global::Cpp2ILInjected.Token(Token = "0x40021AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public bool DumpGeometryStats;

	// Token: 0x04001BF2 RID: 7154
	[global::Cpp2ILInjected.Token(Token = "0x40021B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float DefaultUITabletMode;

	// Token: 0x04001BF3 RID: 7155
	[global::Cpp2ILInjected.Token(Token = "0x40021B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::UnityEngine.Texture2D WaterMask;

	// Token: 0x04001BF4 RID: 7156
	[global::Cpp2ILInjected.Token(Token = "0x40021B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public int WorldInputEdgeRange;

	// Token: 0x04001BF5 RID: 7157
	[global::Cpp2ILInjected.Token(Token = "0x40021B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public long SimulatedDiskSpace;

	// Token: 0x04001BF6 RID: 7158
	[global::Cpp2ILInjected.Token(Token = "0x40021B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public long SimulatedDeviceMemory;

	// Token: 0x04001BF7 RID: 7159
	[global::Cpp2ILInjected.Token(Token = "0x40021B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public bool SimulatedCloudRequired;

	// Token: 0x04001BF8 RID: 7160
	[global::Cpp2ILInjected.Token(Token = "0x40021B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
	public bool SimulatedCloudAvailable;

	// Token: 0x04001BF9 RID: 7161
	[global::Cpp2ILInjected.Token(Token = "0x40021B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
	public bool SimulatedCloudConnected;

	// Token: 0x04001BFA RID: 7162
	[global::Cpp2ILInjected.Token(Token = "0x40021B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float SimulatedCloudSyncTime;

	// Token: 0x04001BFB RID: 7163
	[global::Cpp2ILInjected.Token(Token = "0x40021B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public XNAUnityRunner.ForcedInputMode ForcedInput;

	// Token: 0x04001BFC RID: 7164
	[global::Cpp2ILInjected.Token(Token = "0x40021BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private Game _game;

	// Token: 0x04001BFD RID: 7165
	[global::Cpp2ILInjected.Token(Token = "0x40021BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public bool isStarted;

	// Token: 0x04001BFE RID: 7166
	[global::Cpp2ILInjected.Token(Token = "0x40021BC")]
	private static bool broadcastTest;

	// Token: 0x04001BFF RID: 7167
	[global::Cpp2ILInjected.Token(Token = "0x40021BD")]
	private static bool firstUpdate;

	// Token: 0x04001C00 RID: 7168
	[global::Cpp2ILInjected.Token(Token = "0x40021BE")]
	private static global::UnityEngine.Vector3 LastMousePosition;

	// Token: 0x04001C01 RID: 7169
	[global::Cpp2ILInjected.Token(Token = "0x40021BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private global::UnityEngine.Vector3 lastMousePosition;

	// Token: 0x04001C02 RID: 7170
	[global::Cpp2ILInjected.Token(Token = "0x40021C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private bool KeyboardOpen;

	// Token: 0x04001C03 RID: 7171
	[global::Cpp2ILInjected.Token(Token = "0x40021C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x99")]
	private bool lastFrameSplitHorizontal;

	// Token: 0x04001C04 RID: 7172
	[global::Cpp2ILInjected.Token(Token = "0x40021C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	private int lastSplitPlayerCount;

	// Token: 0x04001C05 RID: 7173
	[global::Cpp2ILInjected.Token(Token = "0x40021C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public bool SplitscreenOrientationChanged;

	// Token: 0x04001C06 RID: 7174
	[global::Cpp2ILInjected.Token(Token = "0x40021C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
	private bool switchNextFrame;

	// Token: 0x04001C07 RID: 7175
	[global::Cpp2ILInjected.Token(Token = "0x40021C5")]
	public static bool _mobileKeyboardLocked;

	// Token: 0x04001C08 RID: 7176
	[global::Cpp2ILInjected.Token(Token = "0x40021C6")]
	public static int DelayInputSwitch;

	// Token: 0x04001C09 RID: 7177
	[global::Cpp2ILInjected.Token(Token = "0x40021C7")]
	public static bool _mobileControllerLocked;

	// Token: 0x04001C0A RID: 7178
	[global::Cpp2ILInjected.Token(Token = "0x40021C8")]
	public static bool _mobileTouchLocked;

	// Token: 0x04001C0B RID: 7179
	[global::Cpp2ILInjected.Token(Token = "0x40021C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	private int mobileMouseMode;

	// Token: 0x04001C0C RID: 7180
	[global::Cpp2ILInjected.Token(Token = "0x40021CA")]
	private static bool _renderingUI;

	// Token: 0x04001C0D RID: 7181
	[global::Cpp2ILInjected.Token(Token = "0x40021CB")]
	public static int _frame;

	// Token: 0x04001C0E RID: 7182
	[global::Cpp2ILInjected.Token(Token = "0x40021CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public AnimationCurve FireAxisRemap;

	// Token: 0x0200081A RID: 2074
	[global::Cpp2ILInjected.Token(Token = "0x200030C")]
	public enum ForcedInputMode
	{
		// Token: 0x04007D7D RID: 32125
		[global::Cpp2ILInjected.Token(Token = "0x40021CE")]
		None,
		// Token: 0x04007D7E RID: 32126
		[global::Cpp2ILInjected.Token(Token = "0x40021CF")]
		Touch,
		// Token: 0x04007D7F RID: 32127
		[global::Cpp2ILInjected.Token(Token = "0x40021D0")]
		Controller,
		// Token: 0x04007D80 RID: 32128
		[global::Cpp2ILInjected.Token(Token = "0x40021D1")]
		KeyboardMouse
	}

	// Token: 0x0200081B RID: 2075
	[global::Cpp2ILInjected.Token(Token = "0x200030D")]
	public class MouseStateBackup
	{
		// Token: 0x06004924 RID: 18724 RVA: 0x0002EF85 File Offset: 0x0002D185
		[global::Cpp2ILInjected.Token(Token = "0x6001246")]
		[global::Cpp2ILInjected.Address(RVA = "0xA76FCC", Offset = "0xA76FCC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_lastMouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_lastMouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRightRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_worldMouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Capture()
		{
			throw null;
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x0002EF88 File Offset: 0x0002D188
		[global::Cpp2ILInjected.Token(Token = "0x6001247")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7718C", Offset = "0xA7718C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lastMouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lastMouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeft", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRightRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Restore()
		{
			throw null;
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x0002EF8B File Offset: 0x0002D18B
		[global::Cpp2ILInjected.Token(Token = "0x6001248")]
		[global::Cpp2ILInjected.Address(RVA = "0xA770A4", Offset = "0xA770A4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "GetState", ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void UpdateState()
		{
			throw null;
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x0002EF8E File Offset: 0x0002D18E
		[global::Cpp2ILInjected.Token(Token = "0x6001249")]
		[global::Cpp2ILInjected.Address(RVA = "0xA773EC", Offset = "0xA773EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserXNAState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MouseStateBackup()
		{
			throw null;
		}

		// Token: 0x04007D81 RID: 32129
		[global::Cpp2ILInjected.Token(Token = "0x40021D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _mouseX;

		// Token: 0x04007D82 RID: 32130
		[global::Cpp2ILInjected.Token(Token = "0x40021D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _mouseY;

		// Token: 0x04007D83 RID: 32131
		[global::Cpp2ILInjected.Token(Token = "0x40021D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _lastMouseX;

		// Token: 0x04007D84 RID: 32132
		[global::Cpp2ILInjected.Token(Token = "0x40021D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _lastMouseY;

		// Token: 0x04007D85 RID: 32133
		[global::Cpp2ILInjected.Token(Token = "0x40021D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _worldMouseX;

		// Token: 0x04007D86 RID: 32134
		[global::Cpp2ILInjected.Token(Token = "0x40021D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _worldMouseY;

		// Token: 0x04007D87 RID: 32135
		[global::Cpp2ILInjected.Token(Token = "0x40021D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _mouseLeft;

		// Token: 0x04007D88 RID: 32136
		[global::Cpp2ILInjected.Token(Token = "0x40021D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _mouseRight;

		// Token: 0x04007D89 RID: 32137
		[global::Cpp2ILInjected.Token(Token = "0x40021DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool _mouseLeftRelease;

		// Token: 0x04007D8A RID: 32138
		[global::Cpp2ILInjected.Token(Token = "0x40021DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		private bool _mouseRightRelease;
	}
}
