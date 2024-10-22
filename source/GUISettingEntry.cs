﻿using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000293")]
public class GUISettingEntry
{
	[global::Cpp2ILInjected.Token(Token = "0x6000F66")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2748C", Offset = "0xA2748C", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntryBase), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public GUISettingEntry(GUISettingID id)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000F67")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E620", Offset = "0xA2E620", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Draw()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000F68")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E624", Offset = "0xA2E624", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual float GetElementHeight()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000F69")]
	[global::Cpp2ILInjected.Address(RVA = "0xA2E62C", Offset = "0xA2E62C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void DrawOverlay()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001B7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GUISettingID _id;

	[global::Cpp2ILInjected.Token(Token = "0x4001B7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int _sortId;

	[global::Cpp2ILInjected.Token(Token = "0x4001B7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SettingsOverlayOptionCategories_Layout.Category _category;
}
