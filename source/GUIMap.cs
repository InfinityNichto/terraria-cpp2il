﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.Graphics;
using Terraria.Initializers;
using Terraria.Localization;
using Terraria.Map;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

// Token: 0x020000EF RID: 239
[global::Cpp2ILInjected.Token(Token = "0x2000156")]
public class GUIMap
{
	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000861 RID: 2145 RVA: 0x00023468 File Offset: 0x00021668
	// (set) Token: 0x06000862 RID: 2146 RVA: 0x0002346B File Offset: 0x0002166B
	[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
	public GUIMap.MinimapFrameStyle ActiveFrameStyle
	{
		[global::Cpp2ILInjected.Token(Token = "0x600095B")]
		[global::Cpp2ILInjected.Address(RVA = "0x950634", Offset = "0x950634", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600095C")]
		[global::Cpp2ILInjected.Address(RVA = "0x95063C", Offset = "0x95063C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0002346E File Offset: 0x0002166E
	[global::Cpp2ILInjected.Token(Token = "0x600095D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9508C8", Offset = "0x9508C8", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D[]), Member = "GetRawTextureData", MemberTypeParameters = new object[] { typeof(ushort) }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "GetUnsafePtr", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "Unity.Collections.NativeArray`1<T>" }, ReturnType = typeof(void*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_clearMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	private unsafe void ClearMap()
	{
		throw null;
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00023471 File Offset: 0x00021671
	[global::Cpp2ILInjected.Token(Token = "0x600095E")]
	[global::Cpp2ILInjected.Address(RVA = "0x950A30", Offset = "0x950A30", Length = "0xA8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap.<DrawToMap_Section_Sliced>d__41), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = "Apply", ReturnType = typeof(void))]
	private void ApplyMap()
	{
		throw null;
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00023474 File Offset: 0x00021674
	[global::Cpp2ILInjected.Token(Token = "0x600095F")]
	[global::Cpp2ILInjected.Address(RVA = "0x950AD8", Offset = "0x950AD8", Length = "0x314")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap.<DrawToMap_Section_Sliced>d__41), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "SupportsTextureFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(ref object[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(bool) }, MemberParameters = new object[]
	{
		typeof(ref bool[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
	{
		"T[]&",
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(TextureFormat),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture), Member = "set_wrapMode", MemberParameters = new object[] { typeof(TextureWrapMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture), Member = "set_filterMode", MemberParameters = new object[] { typeof(FilterMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(global::UnityEngine.Texture2D) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
	private void InitialiseTargets()
	{
		throw null;
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00023477 File Offset: 0x00021677
	[global::Cpp2ILInjected.Token(Token = "0x6000960")]
	[global::Cpp2ILInjected.Address(RVA = "0x950780", Offset = "0x950780", Length = "0x148")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "set_ActiveFrameStyle", MemberParameters = new object[] { typeof(GUIMap.MinimapFrameStyle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3", Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public void LoadContent(ContentManager content)
	{
		throw null;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0002347A File Offset: 0x0002167A
	[global::Cpp2ILInjected.Token(Token = "0x6000961")]
	[global::Cpp2ILInjected.Address(RVA = "0x950DEC", Offset = "0x950DEC", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAWorldCameraSettings), Member = "ApplyCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_DefaultMinimapScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinimapScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void LoadDefaultZoom()
	{
		throw null;
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0002347D File Offset: 0x0002167D
	[global::Cpp2ILInjected.Token(Token = "0x6000962")]
	[global::Cpp2ILInjected.Address(RVA = "0x950E74", Offset = "0x950E74", Length = "0x22C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdatePinchZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "IsCursorOver", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMap", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public bool IsCursorOverFullScreenMapControls(global::Cursor cursor)
	{
		throw null;
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00023480 File Offset: 0x00021680
	[global::Cpp2ILInjected.Token(Token = "0x6000963")]
	[global::Cpp2ILInjected.Address(RVA = "0x9510A0", Offset = "0x9510A0", Length = "0x13C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "LocalUserQuit", MemberParameters = new object[] { typeof(LocalUser) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public void CleanupMapTargets()
	{
		throw null;
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00023483 File Offset: 0x00021683
	[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
	[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
	[global::Cpp2ILInjected.Token(Token = "0x6000964")]
	[global::Cpp2ILInjected.Address(RVA = "0x9511DC", Offset = "0x9511DC", Length = "0x910")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "UpdateChunks", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "InitialiseTargets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_clearMap", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ClearMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMaxX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMaxY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(ref WorldMapChunk)
	}, ReturnType = typeof(MapTile*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_loadMap", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_loadMapLastX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapTile), Member = "get_Color", ReturnType = typeof(byte))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "MapColor", MemberParameters = new object[]
	{
		typeof(ushort),
		typeof(ref Microsoft.Xna.Framework.Graphics.Color),
		typeof(byte)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "RGB565", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ARGB4444", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D[]), Member = "GetRawTextureData", MemberTypeParameters = new object[] { typeof(ushort) }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "GetUnsafePtr", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "Unity.Collections.NativeArray`1<T>" }, ReturnType = typeof(void*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "GetMapTileXnaColor", MemberParameters = new object[] { typeof(ref MapTile) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ApplyMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapReady", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_loadMapSections", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_loadMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public unsafe void DrawToMap()
	{
		throw null;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00023486 File Offset: 0x00021686
	[global::Cpp2ILInjected.Token(Token = "0x6000965")]
	[global::Cpp2ILInjected.Address(RVA = "0x951AEC", Offset = "0x951AEC", Length = "0x540")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap.<DrawToMap_Section_Sliced>d__41), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D[]), Member = "GetRawTextureData", MemberTypeParameters = new object[] { typeof(ushort) }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "GetUnsafePtr", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "Unity.Collections.NativeArray`1<T>" }, ReturnType = typeof(void*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool),
		typeof(ref WorldMapChunk)
	}, ReturnType = typeof(MapTile*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapTile), Member = "get_Color", ReturnType = typeof(byte))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "MapColor", MemberParameters = new object[]
	{
		typeof(ushort),
		typeof(ref Microsoft.Xna.Framework.Graphics.Color),
		typeof(byte)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "RGB565", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ARGB4444", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private unsafe void ApplySection(int xStart, int xEnd, int yStart, int yEnd)
	{
		throw null;
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00023489 File Offset: 0x00021689
	[global::Cpp2ILInjected.Token(Token = "0x6000966")]
	[global::Cpp2ILInjected.Address(RVA = "0x95202C", Offset = "0x95202C", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public IEnumerator DrawToMap_Section_Sliced(int secX, int secY)
	{
		throw null;
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0002348C File Offset: 0x0002168C
	[global::Cpp2ILInjected.Token(Token = "0x6000967")]
	[global::Cpp2ILInjected.Address(RVA = "0x9520C8", Offset = "0x9520C8", Length = "0x650")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "InitialiseTargets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture2D[]), Member = "GetRawTextureData", MemberTypeParameters = new object[] { typeof(ushort) }, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeArrayUnsafeUtility), Member = "GetUnsafePtr", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "Unity.Collections.NativeArray`1<T>" }, ReturnType = typeof(void*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(bool),
		typeof(ref WorldMapChunk)
	}, ReturnType = typeof(MapTile*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapTile), Member = "get_Color", ReturnType = typeof(byte))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapHelper), Member = "MapColor", MemberParameters = new object[]
	{
		typeof(ushort),
		typeof(ref Microsoft.Xna.Framework.Graphics.Color),
		typeof(byte)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "RGB565", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "ARGB4444", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ApplyMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public unsafe void DrawToMap_Section(int secX, int secY)
	{
		throw null;
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0002348F File Offset: 0x0002168F
	[global::Cpp2ILInjected.Token(Token = "0x6000968")]
	[global::Cpp2ILInjected.Address(RVA = "0x952718", Offset = "0x952718", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIZoom), Member = "UpdatePinchZoom", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void ResetMapPing()
	{
		throw null;
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00023492 File Offset: 0x00021692
	[global::Cpp2ILInjected.Token(Token = "0x6000969")]
	[global::Cpp2ILInjected.Address(RVA = "0x952778", Offset = "0x952778", Length = "0x905C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InterfaceProfile_Layout), Member = "DrawEdit", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_16_MapOrMinimap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapEnabled", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapReady", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "AnyPageSelected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreen", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "DrawRightPageHUD", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_DisplayMinimap", ReturnType = typeof(Panel_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Region", MemberParameters = new object[] { typeof(Panel_Layout) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPanel), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Panel_Layout),
		typeof(bool),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?),
		typeof(Microsoft.Xna.Framework.Graphics.Color?)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_DisplayMinimapFrame", ReturnType = typeof(Panel_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_PrimaryInputMode", ReturnType = typeof(XNAUnityRunner.ForcedInputMode))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMap", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(GUIQuickActionButton.InteractionState),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_HUDMiniMapToggle", ReturnType = typeof(QuickActionButton_Layout))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_flushLighting", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(TransactionButton_Layout),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerNavigationController), Member = "set_CurrentNavigationItem", MemberParameters = new object[] { typeof(GUIControllerItem) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "IsRightPageSelected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_ActiveController", ReturnType = typeof(ControllerDevice))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControlsBanner), Member = "AddAction", MemberParameters = new object[]
	{
		typeof(GUIControlsBanner.ActionSource),
		typeof(ControllerActionButton),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerChat), Member = "CloseChat", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "RegisterPickingRegion", MemberParameters = new object[] { typeof(QuickActionButton_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = "get_Texture", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIButton), Member = "RegisterPickingRegion", MemberParameters = new object[]
	{
		typeof(Button_Layout),
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_TouchInputKeyboardLocked", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUINPCDialogue), Member = "Close", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardInput), Member = "GetKeyUp", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIKeyboardMappings), Member = "DisableEscapeKeyUsage", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreenScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapStyle", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinimapScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapOverlayScale", ReturnType = typeof(float))]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInputRegionManager), Member = "RegisterInputRegion", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_grabMapX", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_grabMapY", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_grabMapInProgress", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ResetMapPing", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_grabMapInProgress", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_grabMapX", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_grabMapY", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreenPos", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreenPos", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_miniMapWidth", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_miniMapHeight", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_miniMapX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_miniMapY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_miniMapHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_MinMinimapScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinimapScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_MaxMinimapScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapMinimapAlpha", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinimapAlpha", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_miniMapX", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_miniMapY", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenYOffset", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_miniMapWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(global::UnityEngine.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "get_WorldScreenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapFullscreenScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_resetMapFull", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_resetMapFull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_resetMapFullCharacter", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_resetMapFullCharacter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapOverlayScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapOverlayAlpha", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapOverlayAlpha", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "get_WorldScreenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "DrawMapFullscreenBackground", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "Distance", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Division", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "TriggerPing", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float),
		typeof(SpriteEffects),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapIconOverlay), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(float),
		typeof(float),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem), Member = "DrawMapIcons", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(float),
		typeof(float),
		typeof(ref string)
	}, ReturnType = typeof(CoinLossRevengeSystem.RevengeMarker))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawMiscMapIcons", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Rectangle?),
		typeof(float),
		typeof(float),
		typeof(ref string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "UseMouseOver", MemberParameters = new object[]
	{
		typeof(SpriteBatch),
		typeof(ref string),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(ref ITownNPCProfile)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TypeToDefaultHeadIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawNPCHeadFriendly", MemberParameters = new object[]
	{
		typeof(Entity),
		typeof(byte),
		typeof(float),
		typeof(SpriteEffects),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadTextureIndex", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadRotation", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetBossHeadSpriteEffects", ReturnType = typeof(SpriteEffects))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Addition", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(Microsoft.Xna.Framework.Vector2)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawNPCHeadBoss", MemberParameters = new object[]
	{
		typeof(Entity),
		typeof(byte),
		typeof(float),
		typeof(float),
		typeof(SpriteEffects),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetPlayerHeadBordersColor", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(global::Terraria.Graphics.Camera))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
	{
		typeof(Rectangle),
		typeof(Rectangle),
		typeof(SpriteBatch),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "DisabledClipping", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_FullName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_GivenOrTypeName", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Map_Layout), Member = "get_DefaultMinimapScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "LocalizedDuration", MemberParameters = new object[]
	{
		typeof(TimeSpan),
		typeof(bool),
		typeof(bool)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Map", ReturnType = typeof(WorldMap))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = "GetChunkTile", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(ref WorldMapChunk)
	}, ReturnType = typeof(MapTile*))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameY", ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawMap_FindChestName", MemberParameters = new object[]
	{
		typeof(LocalizedText[]),
		typeof(Tile),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "ResetTimeWithoutCursor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawPlayerDeathMarker", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClient", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "HasUnityPotion", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(SoundEffectInstance))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "UnityTeleport", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "TakeUnityPotion", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_cursorColor", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(byte)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ControllerBorderColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Vector2),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Graphics.Texture2D) }, ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorColor", ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int),
		typeof(byte),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "DetailedDrawTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIHearts), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMana), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_playerInventory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatCornerItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerMappings), Member = "UpdateUIInteractionOverloads", MemberParameters = new object[] { typeof(GUIControllerMappings.InteractionOverloadState) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
	{
		typeof(QuickActionButton_Layout.QuickActionControl),
		typeof(QuickActionButton_Layout),
		typeof(bool),
		typeof(ref float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Chest), Member = "FindChest", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_grabMapInitialX", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_grabMapInitialY", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lang), Member = "GetMapObjectName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 442)]
	public unsafe void DrawMap()
	{
		throw null;
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00023495 File Offset: 0x00021695
	[global::Cpp2ILInjected.Token(Token = "0x600096A")]
	[global::Cpp2ILInjected.Address(RVA = "0x95BA3C", Offset = "0x95BA3C", Length = "0x9CC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Microsoft.Xna.Framework.Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(Tile))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDungeon", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Texture2D),
		typeof(Rectangle),
		typeof(Microsoft.Xna.Framework.Graphics.Color)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGlowshroom", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSkyHeight", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCorrupt", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneDesert", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneCrimson", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneHallow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneSnow", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneJungle", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Color), Member = "op_Multiply", MemberParameters = new object[]
	{
		typeof(Microsoft.Xna.Framework.Graphics.Color),
		typeof(float)
	}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneGraveyard", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneRockLayerHeight", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
	private void DrawMapFullscreenBackground(Microsoft.Xna.Framework.Vector2 screenPosition, int screenWidth, int screenHeight)
	{
		throw null;
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000871 RID: 2161 RVA: 0x00023498 File Offset: 0x00021698
	[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
	private int WorldScreenWidth
	{
		[global::Cpp2ILInjected.Token(Token = "0x600096B")]
		[global::Cpp2ILInjected.Address(RVA = "0x95B874", Offset = "0x95B874", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000872 RID: 2162 RVA: 0x0002349B File Offset: 0x0002169B
	[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
	private int WorldScreenHeight
	{
		[global::Cpp2ILInjected.Token(Token = "0x600096C")]
		[global::Cpp2ILInjected.Address(RVA = "0x95B958", Offset = "0x95B958", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxPixelScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0002349E File Offset: 0x0002169E
	[global::Cpp2ILInjected.Token(Token = "0x600096D")]
	[global::Cpp2ILInjected.Address(RVA = "0x95C408", Offset = "0x95C408", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInstance), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerFullScreenMap), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public GUIMap()
	{
		throw null;
	}

	// Token: 0x0400069D RID: 1693
	[global::Cpp2ILInjected.Token(Token = "0x400090A")]
	private const int MapTextureDimensions = 256;

	// Token: 0x0400069E RID: 1694
	[global::Cpp2ILInjected.Token(Token = "0x400090B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private bool grabbedMap;

	// Token: 0x0400069F RID: 1695
	[global::Cpp2ILInjected.Token(Token = "0x400090C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private int activeX;

	// Token: 0x040006A0 RID: 1696
	[global::Cpp2ILInjected.Token(Token = "0x400090D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private int activeY;

	// Token: 0x040006A1 RID: 1697
	[global::Cpp2ILInjected.Token(Token = "0x400090E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private Microsoft.Xna.Framework.Graphics.Texture2D[] mapTarget;

	// Token: 0x040006A2 RID: 1698
	[global::Cpp2ILInjected.Token(Token = "0x400090F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool[] mapDirty;

	// Token: 0x040006A3 RID: 1699
	[global::Cpp2ILInjected.Token(Token = "0x4000910")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private NativeArray<ushort>[] mapTextureData;

	// Token: 0x040006A4 RID: 1700
	[global::Cpp2ILInjected.Token(Token = "0x4000911")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private unsafe ushort*[] mapTextureDataPtr;

	// Token: 0x040006A5 RID: 1701
	[global::Cpp2ILInjected.Token(Token = "0x4000912")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool miniMapEnabled;

	// Token: 0x040006A6 RID: 1702
	[global::Cpp2ILInjected.Token(Token = "0x4000913")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
	private bool minimapPressed;

	// Token: 0x040006A7 RID: 1703
	[global::Cpp2ILInjected.Token(Token = "0x4000914")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
	private bool mapPressed;

	// Token: 0x040006A8 RID: 1704
	[global::Cpp2ILInjected.Token(Token = "0x4000915")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
	private bool mapPressedLast;

	// Token: 0x040006A9 RID: 1705
	[global::Cpp2ILInjected.Token(Token = "0x4000916")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	private bool mapZoomInPressed;

	// Token: 0x040006AA RID: 1706
	[global::Cpp2ILInjected.Token(Token = "0x4000917")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45")]
	private bool mapZoomOutPressed;

	// Token: 0x040006AB RID: 1707
	[global::Cpp2ILInjected.Token(Token = "0x4000918")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x46")]
	private bool mapZoomResetPressed;

	// Token: 0x040006AC RID: 1708
	[global::Cpp2ILInjected.Token(Token = "0x4000919")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Microsoft.Xna.Framework.Graphics.Texture2D miniMapOpen;

	// Token: 0x040006AD RID: 1709
	[global::Cpp2ILInjected.Token(Token = "0x400091A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Microsoft.Xna.Framework.Graphics.Texture2D miniMapClosed;

	// Token: 0x040006AE RID: 1710
	[global::Cpp2ILInjected.Token(Token = "0x400091B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float ZoomInButtonScale;

	// Token: 0x040006AF RID: 1711
	[global::Cpp2ILInjected.Token(Token = "0x400091C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private float ZoomOutButtonScale;

	// Token: 0x040006B0 RID: 1712
	[global::Cpp2ILInjected.Token(Token = "0x400091D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private float ZoomDefaultButtonScale;

	// Token: 0x040006B1 RID: 1713
	[global::Cpp2ILInjected.Token(Token = "0x400091E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	private float ToggleButtonScale;

	// Token: 0x040006B2 RID: 1714
	[global::Cpp2ILInjected.Token(Token = "0x400091F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float MapButtonScale;

	// Token: 0x040006B3 RID: 1715
	[global::Cpp2ILInjected.Token(Token = "0x4000920")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	private bool use565Map;

	// Token: 0x040006B4 RID: 1716
	[global::Cpp2ILInjected.Token(Token = "0x4000921")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private GUIMap.MinimapFrameStyle _activeFrameStyle;

	// Token: 0x040006B5 RID: 1717
	[global::Cpp2ILInjected.Token(Token = "0x4000922")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public string BackingMiniTextureId;

	// Token: 0x040006B6 RID: 1718
	[global::Cpp2ILInjected.Token(Token = "0x4000923")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public string BackingLargeTextureId;

	// Token: 0x040006B7 RID: 1719
	[global::Cpp2ILInjected.Token(Token = "0x4000924")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	private bool draggingSlider;

	// Token: 0x040006B8 RID: 1720
	[global::Cpp2ILInjected.Token(Token = "0x4000925")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	private float ZoomValue;

	// Token: 0x040006B9 RID: 1721
	[global::Cpp2ILInjected.Token(Token = "0x4000926")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private float TinyScrollScale;

	// Token: 0x040006BA RID: 1722
	[global::Cpp2ILInjected.Token(Token = "0x4000927")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	private float TinyXOffset;

	// Token: 0x040006BB RID: 1723
	[global::Cpp2ILInjected.Token(Token = "0x4000928")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	private float TinyYOffset;

	// Token: 0x040006BC RID: 1724
	[global::Cpp2ILInjected.Token(Token = "0x4000929")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	private float TinyW;

	// Token: 0x040006BD RID: 1725
	[global::Cpp2ILInjected.Token(Token = "0x400092A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private float TinyH;

	// Token: 0x040006BE RID: 1726
	[global::Cpp2ILInjected.Token(Token = "0x400092B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private GUIControllerFullScreenMap _controller;

	// Token: 0x040006BF RID: 1727
	[global::Cpp2ILInjected.Token(Token = "0x400092C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private DateTime _lastPingMouseDownTime;

	// Token: 0x040006C0 RID: 1728
	[global::Cpp2ILInjected.Token(Token = "0x400092D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private Microsoft.Xna.Framework.Vector2 _lastPingMousePosition;

	// Token: 0x040006C1 RID: 1729
	[global::Cpp2ILInjected.Token(Token = "0x400092E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private int LastFrame;

	// Token: 0x020007C8 RID: 1992
	[global::Cpp2ILInjected.Token(Token = "0x2000157")]
	public enum MinimapFrameStyle
	{
		// Token: 0x04007A38 RID: 31288
		[global::Cpp2ILInjected.Token(Token = "0x4000930")]
		Default,
		// Token: 0x04007A39 RID: 31289
		[global::Cpp2ILInjected.Token(Token = "0x4000931")]
		Golden,
		// Token: 0x04007A3A RID: 31290
		[global::Cpp2ILInjected.Token(Token = "0x4000932")]
		Remix,
		// Token: 0x04007A3B RID: 31291
		[global::Cpp2ILInjected.Token(Token = "0x4000933")]
		Sticks,
		// Token: 0x04007A3C RID: 31292
		[global::Cpp2ILInjected.Token(Token = "0x4000934")]
		StoneGold,
		// Token: 0x04007A3D RID: 31293
		[global::Cpp2ILInjected.Token(Token = "0x4000935")]
		TwigLeaf,
		// Token: 0x04007A3E RID: 31294
		[global::Cpp2ILInjected.Token(Token = "0x4000936")]
		Leaf,
		// Token: 0x04007A3F RID: 31295
		[global::Cpp2ILInjected.Token(Token = "0x4000937")]
		Retro,
		// Token: 0x04007A40 RID: 31296
		[global::Cpp2ILInjected.Token(Token = "0x4000938")]
		Valkyrie
	}

	// Token: 0x020007C9 RID: 1993
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000158")]
	private sealed class <DrawToMap_Section_Sliced>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048CD RID: 18637 RVA: 0x0002EEC8 File Offset: 0x0002D0C8
		[DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600096E")]
		[global::Cpp2ILInjected.Address(RVA = "0x9520A0", Offset = "0x9520A0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <DrawToMap_Section_Sliced>d__41(int <>1__state)
		{
			throw null;
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x0002EECB File Offset: 0x0002D0CB
		[DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600096F")]
		[global::Cpp2ILInjected.Address(RVA = "0x95C4A0", Offset = "0x95C4A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x0002EECE File Offset: 0x0002D0CE
		[global::Cpp2ILInjected.Token(Token = "0x6000970")]
		[global::Cpp2ILInjected.Address(RVA = "0x95C4A4", Offset = "0x95C4A4", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "InitialiseTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ApplyMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "ApplySection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool MoveNext()
		{
			throw null;
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x0002EED1 File Offset: 0x0002D0D1
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000971")]
			[global::Cpp2ILInjected.Address(RVA = "0x95C6F4", Offset = "0x95C6F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x0002EED4 File Offset: 0x0002D0D4
		[DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000972")]
		[global::Cpp2ILInjected.Address(RVA = "0x95C6FC", Offset = "0x95C6FC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Collections.IEnumerator.Reset()
		{
			throw null;
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x0002EED7 File Offset: 0x0002D0D7
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		private object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000973")]
			[global::Cpp2ILInjected.Address(RVA = "0x95C734", Offset = "0x95C734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04007A41 RID: 31297
		[global::Cpp2ILInjected.Token(Token = "0x4000939")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007A42 RID: 31298
		[global::Cpp2ILInjected.Token(Token = "0x400093A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007A43 RID: 31299
		[global::Cpp2ILInjected.Token(Token = "0x400093B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GUIMap <>4__this;

		// Token: 0x04007A44 RID: 31300
		[global::Cpp2ILInjected.Token(Token = "0x400093C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int secX;

		// Token: 0x04007A45 RID: 31301
		[global::Cpp2ILInjected.Token(Token = "0x400093D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int secY;

		// Token: 0x04007A46 RID: 31302
		[global::Cpp2ILInjected.Token(Token = "0x400093E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int <xStart>5__2;

		// Token: 0x04007A47 RID: 31303
		[global::Cpp2ILInjected.Token(Token = "0x400093F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int <xEnd>5__3;

		// Token: 0x04007A48 RID: 31304
		[global::Cpp2ILInjected.Token(Token = "0x4000940")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <yEnd>5__4;

		// Token: 0x04007A49 RID: 31305
		[global::Cpp2ILInjected.Token(Token = "0x4000941")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int <ty>5__5;

		// Token: 0x04007A4A RID: 31306
		[global::Cpp2ILInjected.Token(Token = "0x4000942")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int <tx>5__6;

		// Token: 0x04007A4B RID: 31307
		[global::Cpp2ILInjected.Token(Token = "0x4000943")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int <chunkEndY>5__7;
	}
}