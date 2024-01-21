using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class SimpleProfiler
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static bool DisplayStats;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int NextFrame;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static string[] FrameSampleTypes;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static SimpleProfilerFrameData[] FrameData;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static SimpleProfilerFrameData CurrentFrameData;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static SimpleProfilerFrameData LastFrameData;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static DateTime FrameTimeStart;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static DateTime FrameTimeEnd;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static SimpleProfilerSampleFrame AvailableFrames;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static SimpleProfilerSampleFrame CurrentFrames;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x105FDC0", Offset = "0x105FDC0", VA = "0x105FDC0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D080", Offset = "0x38D080")]
	public static void Initialise(Type enumType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x105FFF0", Offset = "0x105FFF0", VA = "0x105FFF0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D0B4", Offset = "0x38D0B4")]
	private static void AllocateSampleFrames(int numberFrames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x10600B0", Offset = "0x10600B0", VA = "0x10600B0")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D0E8", Offset = "0x38D0E8")]
	public static void BeginFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x1060360", Offset = "0x1060360", VA = "0x1060360")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D11C", Offset = "0x38D11C")]
	public static void EndFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x106041C", Offset = "0x106041C", VA = "0x106041C")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D150", Offset = "0x38D150")]
	public static void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1060420", Offset = "0x1060420", VA = "0x1060420")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D184", Offset = "0x38D184")]
	public static void BeginSample(int sampleId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1060508", Offset = "0x1060508", VA = "0x1060508")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D1B8", Offset = "0x38D1B8")]
	public static void EndSample(int sampleId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1060650", Offset = "0x1060650", VA = "0x1060650")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D1EC", Offset = "0x38D1EC")]
	public static void Dump()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x1060654", Offset = "0x1060654", VA = "0x1060654")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D220", Offset = "0x38D220")]
	private static void DumpFrameData(int frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x1060AC4", Offset = "0x1060AC4", VA = "0x1060AC4")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D254", Offset = "0x38D254")]
	public static void UnityProfileBegin(string begin)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1060AC8", Offset = "0x1060AC8", VA = "0x1060AC8")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D288", Offset = "0x38D288")]
	public static void UnityProfileEnd(string end)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x1060ACC", Offset = "0x1060ACC", VA = "0x1060ACC")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x38D2BC", Offset = "0x38D2BC")]
	public static void OnGUI()
	{
	}
}
