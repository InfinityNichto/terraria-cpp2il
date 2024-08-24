using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000039 RID: 57
[global::Cpp2ILInjected.Token(Token = "0x200005D")]
public static class SimpleProfiler
{
	// Token: 0x06000162 RID: 354 RVA: 0x00021F9E File Offset: 0x0002019E
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

	// Token: 0x06000163 RID: 355 RVA: 0x00021FA1 File Offset: 0x000201A1
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

	// Token: 0x06000164 RID: 356 RVA: 0x00021FA4 File Offset: 0x000201A4
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

	// Token: 0x06000165 RID: 357 RVA: 0x00021FA7 File Offset: 0x000201A7
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

	// Token: 0x06000166 RID: 358 RVA: 0x00021FAA File Offset: 0x000201AA
	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A73C", Offset = "0x70A73C", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void Draw()
	{
		throw null;
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00021FAD File Offset: 0x000201AD
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

	// Token: 0x06000168 RID: 360 RVA: 0x00021FB0 File Offset: 0x000201B0
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

	// Token: 0x06000169 RID: 361 RVA: 0x00021FB3 File Offset: 0x000201B3
	[Conditional("SIMPLEPROFILER")]
	[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x70A8C0", Offset = "0x70A8C0", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void Dump()
	{
		throw null;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00021FB6 File Offset: 0x000201B6
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

	// Token: 0x0600016B RID: 363 RVA: 0x00021FB9 File Offset: 0x000201B9
	[Conditional("UNITYPROFILING")]
	[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ABD4", Offset = "0x70ABD4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void UnityProfileBegin(string begin)
	{
		throw null;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00021FBC File Offset: 0x000201BC
	[Conditional("UNITYPROFILING")]
	[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x70ABD8", Offset = "0x70ABD8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public static void UnityProfileEnd(string end)
	{
		throw null;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00021FBF File Offset: 0x000201BF
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

	// Token: 0x040000F1 RID: 241
	[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
	public static bool DisplayStats;

	// Token: 0x040000F2 RID: 242
	[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
	private static int NextFrame;

	// Token: 0x040000F3 RID: 243
	[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
	private static string[] FrameSampleTypes;

	// Token: 0x040000F4 RID: 244
	[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
	private static SimpleProfilerFrameData[] FrameData;

	// Token: 0x040000F5 RID: 245
	[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
	private static SimpleProfilerFrameData CurrentFrameData;

	// Token: 0x040000F6 RID: 246
	[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
	private static SimpleProfilerFrameData LastFrameData;

	// Token: 0x040000F7 RID: 247
	[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
	private static DateTime FrameTimeStart;

	// Token: 0x040000F8 RID: 248
	[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
	private static DateTime FrameTimeEnd;

	// Token: 0x040000F9 RID: 249
	[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
	private static SimpleProfilerSampleFrame AvailableFrames;

	// Token: 0x040000FA RID: 250
	[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
	private static SimpleProfilerSampleFrame CurrentFrames;
}
