using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000350")]
public static class TimeLogger
{
	[Cpp2IlInjected.Token(Token = "0x2000866")]
	private struct TimeLogData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007F83")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007F84")]
		public float timeMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F85")]
		public int resetMaxTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F86")]
		public bool usedLastDraw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007F87")]
		public string logText;
	}

	[Cpp2IlInjected.Token(Token = "0x4002FAD")]
	private static StreamWriter logWriter;

	[Cpp2IlInjected.Token(Token = "0x4002FAE")]
	private static StringBuilder logBuilder;

	[Cpp2IlInjected.Token(Token = "0x4002FAF")]
	private static int framesToLog;

	[Cpp2IlInjected.Token(Token = "0x4002FB0")]
	private static int currentFrame;

	[Cpp2IlInjected.Token(Token = "0x4002FB1")]
	private static bool startLoggingNextFrame;

	[Cpp2IlInjected.Token(Token = "0x4002FB2")]
	private static bool endLoggingThisFrame;

	[Cpp2IlInjected.Token(Token = "0x4002FB3")]
	private static bool currentlyLogging;

	[Cpp2IlInjected.Token(Token = "0x4002FB4")]
	private static Stopwatch detailedDrawTimer;

	[Cpp2IlInjected.Token(Token = "0x4002FB5")]
	private static double lastDetailedDrawTime;

	[Cpp2IlInjected.Token(Token = "0x4002FB6")]
	private static TimeLogData[] renderTimes;

	[Cpp2IlInjected.Token(Token = "0x4002FB7")]
	private static TimeLogData[] drawTimes;

	[Cpp2IlInjected.Token(Token = "0x4002FB8")]
	private static TimeLogData[] lightingTimes;

	[Cpp2IlInjected.Token(Token = "0x4002FB9")]
	private static TimeLogData[] detailedDrawTimes;

	[Cpp2IlInjected.Token(Token = "0x4002FBA")]
	private const int maxTimeDelay = 100;

	[Cpp2IlInjected.Token(Token = "0x60028A7")]
	[Cpp2IlInjected.Address(RVA = "0x14B1BFC", Offset = "0x14B1BFC", VA = "0x14B1BFC")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A8")]
	[Cpp2IlInjected.Address(RVA = "0x14B2370", Offset = "0x14B2370", VA = "0x14B2370")]
	public static void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028A9")]
	[Cpp2IlInjected.Address(RVA = "0x14B2458", Offset = "0x14B2458", VA = "0x14B2458")]
	public static void NewDrawFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028AA")]
	[Cpp2IlInjected.Address(RVA = "0x14B28C8", Offset = "0x14B28C8", VA = "0x14B28C8")]
	public static void EndDrawFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028AB")]
	[Cpp2IlInjected.Address(RVA = "0x14B2B88", Offset = "0x14B2B88", VA = "0x14B2B88")]
	private static void UpdateTime(TimeLogData[] times, int type, double time)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028AC")]
	[Cpp2IlInjected.Address(RVA = "0x14B2CF8", Offset = "0x14B2CF8", VA = "0x14B2CF8")]
	public static void RenderTime(int renderType, double timeElapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028AD")]
	[Cpp2IlInjected.Address(RVA = "0x14B2D88", Offset = "0x14B2D88", VA = "0x14B2D88")]
	public static float GetRenderTime(int renderType)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028AE")]
	[Cpp2IlInjected.Address(RVA = "0x14B2DF0", Offset = "0x14B2DF0", VA = "0x14B2DF0")]
	public static float GetRenderMax(int renderType)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028AF")]
	[Cpp2IlInjected.Address(RVA = "0x14B2E58", Offset = "0x14B2E58", VA = "0x14B2E58")]
	public static void DrawTime(int drawType, double timeElapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028B0")]
	[Cpp2IlInjected.Address(RVA = "0x14B2EE8", Offset = "0x14B2EE8", VA = "0x14B2EE8")]
	public static float GetDrawTime(int drawType)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028B1")]
	[Cpp2IlInjected.Address(RVA = "0x14B2F50", Offset = "0x14B2F50", VA = "0x14B2F50")]
	public static float GetDrawTotal()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028B2")]
	[Cpp2IlInjected.Address(RVA = "0x14B2FE0", Offset = "0x14B2FE0", VA = "0x14B2FE0")]
	public static void LightingTime(int lightingType, double timeElapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028B3")]
	[Cpp2IlInjected.Address(RVA = "0x14B3070", Offset = "0x14B3070", VA = "0x14B3070")]
	public static float GetLightingTime(int lightingType)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028B4")]
	[Cpp2IlInjected.Address(RVA = "0x14B30D8", Offset = "0x14B30D8", VA = "0x14B30D8")]
	public static float GetLightingTotal()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028B5")]
	[Cpp2IlInjected.Address(RVA = "0x14B3168", Offset = "0x14B3168", VA = "0x14B3168")]
	public static void DetailedDrawReset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028B6")]
	[Cpp2IlInjected.Address(RVA = "0x14B31F8", Offset = "0x14B31F8", VA = "0x14B31F8")]
	public static void DetailedDrawTime(int detailedDrawType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028B7")]
	[Cpp2IlInjected.Address(RVA = "0x14B32D4", Offset = "0x14B32D4", VA = "0x14B32D4")]
	public static float GetDetailedDrawTime(int detailedDrawType)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028B8")]
	[Cpp2IlInjected.Address(RVA = "0x14B333C", Offset = "0x14B333C", VA = "0x14B333C")]
	public static float GetDetailedDrawTotal()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028B9")]
	[Cpp2IlInjected.Address(RVA = "0x14B33D4", Offset = "0x14B33D4", VA = "0x14B33D4")]
	public static void MenuDrawTime(double timeElapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028BA")]
	[Cpp2IlInjected.Address(RVA = "0x14B3494", Offset = "0x14B3494", VA = "0x14B3494")]
	public static void SplashDrawTime(double timeElapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028BB")]
	[Cpp2IlInjected.Address(RVA = "0x14B3554", Offset = "0x14B3554", VA = "0x14B3554")]
	public static void MapDrawTime(double timeElapsed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028BC")]
	[Cpp2IlInjected.Address(RVA = "0x14B3614", Offset = "0x14B3614", VA = "0x14B3614")]
	public static void DrawException(Exception e)
	{
	}
}
