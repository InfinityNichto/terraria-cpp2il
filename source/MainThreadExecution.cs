﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;
using Terraria.WorldBuilding;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200005B")]
public class MainThreadExecution
{
	[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
	[global::Cpp2ILInjected.Address(RVA = "0x709E74", Offset = "0x709E74", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void ExcludeThread(ManagedThread thread)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
	[global::Cpp2ILInjected.Address(RVA = "0x7038B0", Offset = "0x7038B0", Length = "0x190")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform.Switch), Member = "set_CPUBoostMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Singleton<>), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(GraphicsDevice),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "Play", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundEffectInstance), Member = "Stop", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DedServ", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SaveAndQuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "playWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "joinLocalWorldCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenConfiguration), Member = "FromEmbeddedPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldGenConfiguration))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(MainThreadExecution.ExecutionSnippet),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "Enqueue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "WaitOnMainThreadComplete", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
	public static void ExecuteOnMainThread(MainThreadExecution.ExecutionSnippet snippet, object data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A08C", Offset = "0x70A08C", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MainThreadExecution), Member = "ExecuteSnippets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ExecuteThreadTime", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = "TryDequeue", MemberParameters = new object[] { typeof(ref object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "Execute", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void ExecuteSnippetsOnly()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
	[global::Cpp2ILInjected.Address(RVA = "0x7012F4", Offset = "0x7012F4", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrPlatform), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteSnippetsOnly", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "ExecuteThreadTime", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void ExecuteSnippets()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
	[global::Cpp2ILInjected.Address(RVA = "0x709F38", Offset = "0x709F38", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
	{
		typeof(MainThreadExecution.ExecutionSnippet),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MainThreadExecution(MainThreadExecution.ExecutionSnippet snippet, object data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A118", Offset = "0x70A118", Length = "0xD0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MainThreadExecution), Member = "ExecuteSnippetsOnly", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void Execute()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
	[global::Cpp2ILInjected.Address(RVA = "0x709FB0", Offset = "0x709FB0", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
	{
		typeof(MainThreadExecution.ExecutionSnippet),
		typeof(object)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
	{
		typeof(object),
		typeof(ref bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	public void WaitOnMainThreadComplete()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A1E8", Offset = "0x70A1E8", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	static MainThreadExecution()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
	private static List<ManagedThread> ExcludedThreads;

	[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
	private static ConcurrentQueue<MainThreadExecution> _pendingRequests;

	[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private object _lockObject;

	[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private MainThreadExecution.ExecutionSnippet _snippet;

	[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private object _data;

	[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private bool _completed;

	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public delegate void ExecutionSnippet(object data);
}
