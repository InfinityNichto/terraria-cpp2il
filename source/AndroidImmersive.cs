using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000039")]
public static class AndroidImmersive
{
	[global::Cpp2ILInjected.Token(Token = "0x6000141")]
	[global::Cpp2ILInjected.Address(RVA = "0x6FEFC4", Offset = "0x6FEFC4", Length = "0x410")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "AlertButtonClicked", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Alert), Member = "AlertCancelled", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "GetSDKLevel", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = "ReturnType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive.RunPtr), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaRunnable), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
	public static void Activate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000142")]
	[global::Cpp2ILInjected.Address(RVA = "0x703F30", Offset = "0x703F30", Length = "0x288")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive.RunPtr), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaRunnable), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
	public static void Deactivate(bool blockReactivation)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000143")]
	[global::Cpp2ILInjected.Address(RVA = "0x7041B8", Offset = "0x7041B8", Length = "0x234")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidImmersive.Listener), Member = "onSystemUiVisibilityChange", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive.Listener), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
	private static void RunActivate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000144")]
	[global::Cpp2ILInjected.Address(RVA = "0x70445C", Offset = "0x70445C", Length = "0x154")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject), Member = "Call", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private static void RunDeactivate()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000145")]
	[global::Cpp2ILInjected.Address(RVA = "0x703CC0", Offset = "0x703CC0", Length = "0x1B4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidImmersive), Member = "Activate", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "FindClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "GetStaticFieldID", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(IntPtr))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNI), Member = "GetStaticIntField", MemberParameters = new object[]
	{
		typeof(IntPtr),
		typeof(IntPtr)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
	private static int GetSDKLevel()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
	private static AndroidJavaObject _viewInstance;

	[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
	private static AndroidJavaObject _viewInstanceBackup;

	[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
	private static bool _blockReactivation;

	[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
	private const int SYSTEM_UI_FLAG_HIDE_NAVIGATION = 2;

	[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
	private const int SYSTEM_UI_FLAG_FULLSCREEN = 4;

	[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
	private const int SYSTEM_UI_FLAG_LAYOUT_STABLE = 256;

	[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
	private const int SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION = 512;

	[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
	private const int SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN = 1024;

	[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE = 2048;

	[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
	private const int SYSTEM_UI_FLAG_IMMERSIVE_STICKY = 4096;

	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	private delegate void RunPtr();

	[global::Cpp2ILInjected.Token(Token = "0x200003B")]
	private class Listener : AndroidJavaProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x600014A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7043EC", Offset = "0x7043EC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidImmersive), Member = "RunActivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaProxy), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Listener()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600014B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7045F0", Offset = "0x7045F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidImmersive), Member = "RunActivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void onSystemUiVisibilityChange(int visibility)
		{
			throw null;
		}
	}
}
