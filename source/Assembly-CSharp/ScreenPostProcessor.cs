using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Effects;
using UnityEngine;

// Token: 0x0200024B RID: 587
[global::Cpp2ILInjected.Token(Token = "0x2000305")]
public class ScreenPostProcessor : MonoBehaviour
{
	// Token: 0x1700017C RID: 380
	// (get) Token: 0x0600109A RID: 4250 RVA: 0x00024CB0 File Offset: 0x00022EB0
	// (set) Token: 0x0600109B RID: 4251 RVA: 0x00024CB3 File Offset: 0x00022EB3
	[global::Cpp2ILInjected.Token(Token = "0x170001A4")]
	public static bool Enabled
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71430", Offset = "0xA71430", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUILowMemorySetttings), Member = "CheckMemorySettings", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "GetSelected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "UpdateFilters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60011EC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7147C", Offset = "0xA7147C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x0600109C RID: 4252 RVA: 0x00024CB6 File Offset: 0x00022EB6
	[global::Cpp2ILInjected.Token(Token = "0x170001A5")]
	public static List<ScreenPostProcessor> Instances
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xA714CC", Offset = "0xA714CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "AddFilter", MemberParameters = new object[] { typeof(Filter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "EndUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x0600109D RID: 4253 RVA: 0x00024CB9 File Offset: 0x00022EB9
	[global::Cpp2ILInjected.Token(Token = "0x170001A6")]
	public static List<ScreenPostProcessor> UIInstances
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71518", Offset = "0xA71518", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "AddFilter", MemberParameters = new object[] { typeof(Filter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "EndUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x0600109E RID: 4254 RVA: 0x00024CBC File Offset: 0x00022EBC
	// (set) Token: 0x0600109F RID: 4255 RVA: 0x00024CBF File Offset: 0x00022EBF
	[global::Cpp2ILInjected.Token(Token = "0x170001A7")]
	public static List<Filter> Filters
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71564", Offset = "0xA71564", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "BeginUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "AddFilter", MemberParameters = new object[] { typeof(Filter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60011F0")]
		[global::Cpp2ILInjected.Address(RVA = "0xA715B0", Offset = "0xA715B0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00024CC2 File Offset: 0x00022EC2
	[global::Cpp2ILInjected.Token(Token = "0x60011F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xA71600", Offset = "0xA71600", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Filters", ReturnType = typeof(List<Filter>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void BeginUpdate()
	{
		throw null;
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x00024CC5 File Offset: 0x00022EC5
	[global::Cpp2ILInjected.Token(Token = "0x60011F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xA716D4", Offset = "0xA716D4", Length = "0x1AC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "UpdateFilters", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_UIInstances", ReturnType = typeof(List<ScreenPostProcessor>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Instances", ReturnType = typeof(List<ScreenPostProcessor>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_countUpdate", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Filters", ReturnType = typeof(List<Filter>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "set_countUpdate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static void AddFilter(Filter filter)
	{
		throw null;
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00024CC8 File Offset: 0x00022EC8
	[global::Cpp2ILInjected.Token(Token = "0x60011F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA718CC", Offset = "0xA718CC", Length = "0x24C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "set_renderCheck", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_UIInstances", ReturnType = typeof(List<ScreenPostProcessor>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Instances", ReturnType = typeof(List<ScreenPostProcessor>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_countUpdate", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public static void EndUpdate()
	{
		throw null;
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00024CCB File Offset: 0x00022ECB
	// (set) Token: 0x060010A4 RID: 4260 RVA: 0x00024CCE File Offset: 0x00022ECE
	[global::Cpp2ILInjected.Token(Token = "0x170001A8")]
	private static int countUpdate
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71880", Offset = "0xA71880", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "AddFilter", MemberParameters = new object[] { typeof(Filter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "EndUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60011F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71684", Offset = "0xA71684", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "AddFilter", MemberParameters = new object[] { typeof(Filter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00024CD1 File Offset: 0x00022ED1
	// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00024CD4 File Offset: 0x00022ED4
	[global::Cpp2ILInjected.Token(Token = "0x170001A9")]
	private static int renderCheck
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71B68", Offset = "0xA71B68", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60011F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xA71B18", Offset = "0xA71B18", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "EndUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00024CD7 File Offset: 0x00022ED7
	[global::Cpp2ILInjected.Token(Token = "0x60011F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA71BB4", Offset = "0xA71BB4", Length = "0x3C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUser), Member = "LoadThreadstate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_Filters", ReturnType = typeof(List<Filter>))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenPostProcessor), Member = "get_renderCheck", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filter), Member = "Apply", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = "ApplyValuesToMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new object[]
	{
		typeof(int),
		typeof(global::UnityEngine.Texture)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityBindTexture", ReturnType = typeof(global::UnityEngine.Texture))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new object[]
	{
		typeof(int),
		typeof(global::UnityEngine.Vector4)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphics), Member = "Blit", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Texture),
		typeof(RenderTexture),
		typeof(Material)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
	private void OnRenderImage(RenderTexture source, RenderTexture dest)
	{
		throw null;
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00024CDA File Offset: 0x00022EDA
	[global::Cpp2ILInjected.Token(Token = "0x60011F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA71F74", Offset = "0xA71F74", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public ScreenPostProcessor()
	{
		throw null;
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00024CDD File Offset: 0x00022EDD
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60011FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA71F7C", Offset = "0xA71F7C", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	static ScreenPostProcessor()
	{
		throw null;
	}

	// Token: 0x04001BB6 RID: 7094
	[global::Cpp2ILInjected.Token(Token = "0x4002170")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int order;

	// Token: 0x04001BB7 RID: 7095
	[global::Cpp2ILInjected.Token(Token = "0x4002171")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private Filter filter;

	// Token: 0x04001BB8 RID: 7096
	[global::Cpp2ILInjected.Token(Token = "0x4002172")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool setActive;

	// Token: 0x04001BB9 RID: 7097
	[global::Cpp2ILInjected.Token(Token = "0x4002173")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public LocalUser User;

	// Token: 0x04001BBA RID: 7098
	[global::Cpp2ILInjected.Token(Token = "0x4002174")]
	private static int MainTexId;

	// Token: 0x04001BBB RID: 7099
	[global::Cpp2ILInjected.Token(Token = "0x4002175")]
	private static int SecTexId;

	// Token: 0x04001BBC RID: 7100
	[global::Cpp2ILInjected.Token(Token = "0x4002176")]
	private static int ThirdTexId;

	// Token: 0x04001BBD RID: 7101
	[global::Cpp2ILInjected.Token(Token = "0x4002177")]
	private static int ForthTexId;

	// Token: 0x04001BBE RID: 7102
	[global::Cpp2ILInjected.Token(Token = "0x4002178")]
	private static int _imageSize1Id;
}
