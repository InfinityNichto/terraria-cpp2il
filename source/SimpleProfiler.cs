using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200005D")]
public static class SimpleProfiler
{
	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A304", Offset = "0x70A304", Length = "0x138")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetNames", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleProfilerFrameData), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public static void Initialise(Type enumType)
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A4C8", Offset = "0x70A4C8", Length = "0x94")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	private static void AllocateSampleFrames(int numberFrames)
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A564", Offset = "0x70A564", Length = "0x130")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SimpleProfilerFrameData), Member = "Reset", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static void BeginFrame()
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A6C8", Offset = "0x70A6C8", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void EndFrame()
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A73C", Offset = "0x70A73C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void Draw()
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A740", Offset = "0x70A740", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void BeginSample(int sampleId)
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A7E4", Offset = "0x70A7E4", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
	{
		typeof(DateTime),
		typeof(DateTime)
	}, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void EndSample(int sampleId)
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A8C0", Offset = "0x70A8C0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void Dump()
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A8C4", Offset = "0x70A8C4", Length = "0x310")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	private static void DumpFrameData(int frame)
	{
		throw null;
	}

	[Conditional("UNITYPROFILING")]
	[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ABD4", Offset = "0x70ABD4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void UnityProfileBegin(string begin)
	{
		throw null;
	}

	[Conditional("UNITYPROFILING")]
	[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ABD8", Offset = "0x70ABD8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void UnityProfileEnd(string end)
	{
		throw null;
	}

	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ABDC", Offset = "0x70ABDC", Length = "0x45C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUI), Member = "get_skin", ReturnType = typeof(GUISkin))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISkin), Member = "get_box", ReturnType = typeof(GUIStyle))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new object[]
	{
		typeof(Rect),
		typeof(GUIStyle)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new object[]
	{
		typeof(string),
		typeof(GUILayoutOption[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
	public static void OnGUI()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
	public static bool DisplayStats;

	[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
	private static int NextFrame;

	[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
	private static string[] FrameSampleTypes;

	[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
	private static SimpleProfilerFrameData[] FrameData;

	[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
	private static SimpleProfilerFrameData CurrentFrameData;

	[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
	private static SimpleProfilerFrameData LastFrameData;

	[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
	private static DateTime FrameTimeStart;

	[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
	private static DateTime FrameTimeEnd;

	[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
	private static SimpleProfilerSampleFrame AvailableFrames;

	[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
	private static SimpleProfilerSampleFrame CurrentFrames;
}
