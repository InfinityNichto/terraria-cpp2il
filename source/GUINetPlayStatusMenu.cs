using System;
using System.Threading;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Telepathy;
using Terraria;
using Terraria.Audio;
using Terraria.Localization;
using UnityEngine;

// Token: 0x020001D8 RID: 472
[global::Cpp2ILInjected.Token(Token = "0x2000273")]
public class GUINetPlayStatusMenu
{
	// Token: 0x06000CEC RID: 3308 RVA: 0x00024209 File Offset: 0x00022409
	[global::Cpp2ILInjected.Token(Token = "0x6000E0B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F129C", Offset = "0x9F129C", Length = "0x434")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMenu", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ClearVisualPostProcessEffects", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
	{
		typeof(SpriteSortMode),
		typeof(BlendState),
		typeof(SamplerState),
		typeof(DepthStencilState),
		typeof(RasterizerState),
		typeof(Effect),
		typeof(Matrix?),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPulldownSetting), Member = "DisablePulldown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputControllerEdit), Member = "DisablePulldown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINetPlayStatusMenu), Member = "Quit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIStringButton), Member = "DrawButton", MemberParameters = new object[]
	{
		typeof(StringButton_Layout),
		typeof(string),
		typeof(ref float),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_menuMode", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUITransactionButton), Member = "DrawWithBanner", MemberParameters = new object[]
	{
		typeof(TransactionButton_Layout),
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(Item),
		typeof(string),
		typeof(bool),
		typeof(ref float),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(GUITransactionButton.InputState))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x06000CED RID: 3309 RVA: 0x0002420C File Offset: 0x0002240C
	[global::Cpp2ILInjected.Token(Token = "0x6000E0C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F16D0", Offset = "0x9F16D0", Length = "0x320")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MPSessionManager), Member = "UpdateUI", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform.Switch), Member = "set_CPUBoostMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterizedThreadStart), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadManager), Member = "RunForUserCritical", MemberParameters = new object[]
	{
		typeof(ParameterizedThreadStart),
		typeof(object),
		typeof(LocalUser)
	}, ReturnType = typeof(ManagedThread))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	public void Quit()
	{
		throw null;
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x0002420F File Offset: 0x0002240F
	[global::Cpp2ILInjected.Token(Token = "0x6000E0D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F19F0", Offset = "0x9F19F0", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "QuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private void UpdateServerStatus()
	{
		throw null;
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00024212 File Offset: 0x00022412
	[global::Cpp2ILInjected.Token(Token = "0x6000E0E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F1A90", Offset = "0x9F1A90", Length = "0x2B8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadThreadstate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINetPlayStatusMenu), Member = "UpdateServerStatus", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "RefreshPlayers", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	private void QuitCallBack(object threadContext)
	{
		throw null;
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00024215 File Offset: 0x00022415
	[global::Cpp2ILInjected.Token(Token = "0x6000E0F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9F1D48", Offset = "0x9F1D48", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUINetPlayStatusMenu()
	{
		throw null;
	}

	// Token: 0x040014AF RID: 5295
	[global::Cpp2ILInjected.Token(Token = "0x40019B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float scale0;

	// Token: 0x040014B0 RID: 5296
	[global::Cpp2ILInjected.Token(Token = "0x40019BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float scale1;

	// Token: 0x040014B1 RID: 5297
	[global::Cpp2ILInjected.Token(Token = "0x40019BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float scale2;
}
