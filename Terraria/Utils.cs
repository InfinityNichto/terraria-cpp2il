using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000351")]
public static class Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000867")]
	public delegate bool TileActionAttempt(int x, int y);

	[Cpp2IlInjected.Token(Token = "0x2000868")]
	public delegate void LaserLineFraming(int stage, out float distanceCovered, out Rectangle frame, out Vector2 origin, out Color color);

	[Cpp2IlInjected.Token(Token = "0x2000869")]
	public delegate Color ColorLerpMethod(float percent);

	[Cpp2IlInjected.Token(Token = "0x200086A")]
	public struct ChaseResults
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007F88")]
		public bool InterceptionHappens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007F89")]
		public Vector2 InterceptionPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007F8A")]
		public float InterceptionTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007F8B")]
		public Vector2 ChaserVelocity;
	}

	[Cpp2IlInjected.Token(Token = "0x4002FBB")]
	public const long MaxCoins = 999999999L;

	[Cpp2IlInjected.Token(Token = "0x4002FBC")]
	public static Dictionary<SpriteFont, float[]> charLengths;

	[Cpp2IlInjected.Token(Token = "0x4002FBD")]
	private static Regex _substitutionRegex;

	[Cpp2IlInjected.Token(Token = "0x4002FBE")]
	private const ulong RANDOM_MULTIPLIER = 25214903917uL;

	[Cpp2IlInjected.Token(Token = "0x4002FBF")]
	private const ulong RANDOM_ADD = 11uL;

	[Cpp2IlInjected.Token(Token = "0x4002FC0")]
	private const ulong RANDOM_MASK = 281474976710655uL;

	[Cpp2IlInjected.Token(Token = "0x4002FC1")]
	private static TileActionAttempt plotInnerCall;

	[Cpp2IlInjected.Token(Token = "0x4002FC2")]
	private static Point plotInnerLineMinOffset;

	[Cpp2IlInjected.Token(Token = "0x4002FC3")]
	private static Point plotInnerLineMaxOffset;

	[Cpp2IlInjected.Token(Token = "0x4002FC4")]
	private static TileActionAttempt PlotTileLineInnerInstance;

	[Cpp2IlInjected.Token(Token = "0x60028BD")]
	[Cpp2IlInjected.Address(RVA = "0x10DE9E8", Offset = "0x10DE9E8", VA = "0x10DE9E8")]
	public static Color ColorLerp_BlackToWhite(float percent)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60028BE")]
	[Cpp2IlInjected.Address(RVA = "0x10DEA74", Offset = "0x10DEA74", VA = "0x10DEA74")]
	public static double Lerp(double value1, double value2, double amount)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60028BF")]
	[Cpp2IlInjected.Address(RVA = "0x10DEA90", Offset = "0x10DEA90", VA = "0x10DEA90")]
	public static Vector2 Round(Vector2 input)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C0")]
	[Cpp2IlInjected.Address(RVA = "0x10DEC60", Offset = "0x10DEC60", VA = "0x10DEC60")]
	public static bool IsPowerOfTwo(int x)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C1")]
	[Cpp2IlInjected.Address(RVA = "0x10DEC7C", Offset = "0x10DEC7C", VA = "0x10DEC7C")]
	public static float SmoothStep(float min, float max, float x)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C2")]
	[Cpp2IlInjected.Address(RVA = "0x10DECA8", Offset = "0x10DECA8", VA = "0x10DECA8")]
	public static double SmoothStep(double min, double max, double x)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C3")]
	[Cpp2IlInjected.Address(RVA = "0x10DED7C", Offset = "0x10DED7C", VA = "0x10DED7C")]
	public static float UnclampedSmoothStep(float min, float max, float x)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C4")]
	[Cpp2IlInjected.Address(RVA = "0x10DED9C", Offset = "0x10DED9C", VA = "0x10DED9C")]
	public static double UnclampedSmoothStep(double min, double max, double x)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C5")]
	[Cpp2IlInjected.Address(RVA = "0x10DEDBC", Offset = "0x10DEDBC", VA = "0x10DEDBC")]
	public static Dictionary<string, string> ParseArguements(string[] args)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028C6")]
	[Cpp2IlInjected.Address(RVA = "0x15A6EB0", Offset = "0x15A6EB0", VA = "0x15A6EB0")]
	public static void Swap<T>(ref T t1, ref T t2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028C7")]
	[Cpp2IlInjected.Address(RVA = "0x15F15A4", Offset = "0x15F15A4", VA = "0x15F15A4")]
	public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028C8")]
	[Cpp2IlInjected.Address(RVA = "0x10DEF70", Offset = "0x10DEF70", VA = "0x10DEF70")]
	public static float Turn01ToCyclic010(float value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028C9")]
	[Cpp2IlInjected.Address(RVA = "0x10DF020", Offset = "0x10DF020", VA = "0x10DF020")]
	public static float PingPongFrom01To010(float value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028CA")]
	[Cpp2IlInjected.Address(RVA = "0x10DF06C", Offset = "0x10DF06C", VA = "0x10DF06C")]
	public static float MultiLerp(float percent, params float[] floats)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028CB")]
	[Cpp2IlInjected.Address(RVA = "0x10DF0FC", Offset = "0x10DF0FC", VA = "0x10DF0FC")]
	public static float WrappedLerp(float value1, float value2, float percent)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028CC")]
	[Cpp2IlInjected.Address(RVA = "0x10DF128", Offset = "0x10DF128", VA = "0x10DF128")]
	public static float GetLerpValue(float from, float to, float t, bool clamped = false)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028CD")]
	[Cpp2IlInjected.Address(RVA = "0x10DF1A4", Offset = "0x10DF1A4", VA = "0x10DF1A4")]
	public static float Remap(float fromValue, float fromMin, float fromMax, float toMin, float toMax, bool clamped = true)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028CE")]
	[Cpp2IlInjected.Address(RVA = "0x10DF2B8", Offset = "0x10DF2B8", VA = "0x10DF2B8")]
	public static void ClampWithinWorld(ref int minX, ref int minY, ref int maxX, ref int maxY, bool lastValuesInclusiveToIteration = false, int fluffX = 0, int fluffY = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028CF")]
	[Cpp2IlInjected.Address(RVA = "0x10DF438", Offset = "0x10DF438", VA = "0x10DF438")]
	public static ChaseResults GetChaseResults(Vector2 chaserPosition, float chaserSpeed, Vector2 runnerPosition, Vector2 runnerVelocity)
	{
		return default(ChaseResults);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D0")]
	[Cpp2IlInjected.Address(RVA = "0x10DFA68", Offset = "0x10DFA68", VA = "0x10DFA68")]
	public static Vector2 FactorAcceleration(Vector2 currentVelocity, float timeToInterception, Vector2 descendOfProjectile, int framesOfLenience)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D1")]
	[Cpp2IlInjected.Address(RVA = "0x10DF8F8", Offset = "0x10DF8F8", VA = "0x10DF8F8")]
	public static bool SolveQuadratic(float a, float b, float c, out float result1, out float result2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D2")]
	[Cpp2IlInjected.Address(RVA = "0x10DFBC8", Offset = "0x10DFBC8", VA = "0x10DFBC8")]
	public static double GetLerpValue(double from, double to, double t, bool clamped = false)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D3")]
	[Cpp2IlInjected.Address(RVA = "0x10DFC48", Offset = "0x10DFC48", VA = "0x10DFC48")]
	public static float GetDayTimeAs24FloatStartingFromMidnight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D4")]
	[Cpp2IlInjected.Address(RVA = "0x10DFD48", Offset = "0x10DFD48", VA = "0x10DFD48")]
	public static Vector2 GetDayTimeAsDirectionIn24HClock()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D5")]
	[Cpp2IlInjected.Address(RVA = "0x10DFDC8", Offset = "0x10DFDC8", VA = "0x10DFDC8")]
	public static Vector2 GetDayTimeAsDirectionIn24HClock(float timeFrom0To24)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D6")]
	[Cpp2IlInjected.Address(RVA = "0x10DFFEC", Offset = "0x10DFFEC", VA = "0x10DFFEC")]
	public static string[] ConvertMonoArgsToDotNet(string[] brokenArgs)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028D7")]
	[Cpp2IlInjected.Address(RVA = "0x15F1858", Offset = "0x15F1858", VA = "0x15F1858")]
	public static T Max<T>(params T[] args) where T : IComparable
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028D8")]
	[Cpp2IlInjected.Address(RVA = "0x10E01C0", Offset = "0x10E01C0", VA = "0x10E01C0")]
	public static float LineRectangleDistance(Rectangle rect, Vector2 lineStart, Vector2 lineEnd)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028D9")]
	[Cpp2IlInjected.Address(RVA = "0x10E0900", Offset = "0x10E0900", VA = "0x10E0900")]
	public static List<List<TextSnippet>> WordwrapStringSmart(string text, Color c, SpriteFont font, int maxWidth, int maxLines)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028DA")]
	[Cpp2IlInjected.Address(RVA = "0x10E1028", Offset = "0x10E1028", VA = "0x10E1028")]
	public static string[] WordwrapString(string text, SpriteFont font, int maxWidth, int maxLines, out int lineAmount)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028DB")]
	[Cpp2IlInjected.Address(RVA = "0x10E15B0", Offset = "0x10E15B0", VA = "0x10E15B0")]
	public static Rectangle CenteredRectangle(Vector2 center, Vector2 size)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60028DC")]
	[Cpp2IlInjected.Address(RVA = "0x10E1614", Offset = "0x10E1614", VA = "0x10E1614")]
	public static Vector2 Vector2FromElipse(Vector2 angleVector, Vector2 elipseSizes)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028DD")]
	[Cpp2IlInjected.Address(RVA = "0x10E1978", Offset = "0x10E1978", VA = "0x10E1978")]
	public static bool FloatIntersect(float r1StartX, float r1StartY, float r1Width, float r1Height, float r2StartX, float r2StartY, float r2Width, float r2Height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60028DE")]
	[Cpp2IlInjected.Address(RVA = "0x10E19E4", Offset = "0x10E19E4", VA = "0x10E19E4")]
	public static long CoinsCount(out bool overFlowing, Item[] inv, params int[] ignoreSlots)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60028DF")]
	[Cpp2IlInjected.Address(RVA = "0x10E1B44", Offset = "0x10E1B44", VA = "0x10E1B44")]
	public static int[] CoinsSplit(long count)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028E0")]
	[Cpp2IlInjected.Address(RVA = "0x10E1C30", Offset = "0x10E1C30", VA = "0x10E1C30")]
	public static long CoinsCombineStacks(out bool overFlowing, params long[] coinCounts)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60028E1")]
	[Cpp2IlInjected.Address(RVA = "0x10E1CB8", Offset = "0x10E1CB8", VA = "0x10E1CB8")]
	public static void PoofOfSmoke(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028E2")]
	[Cpp2IlInjected.Address(RVA = "0x10E22B0", Offset = "0x10E22B0", VA = "0x10E22B0")]
	public static Vector2 ToScreenPosition(this Vector2 worldPosition)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028E3")]
	[Cpp2IlInjected.Address(RVA = "0x10E24BC", Offset = "0x10E24BC", VA = "0x10E24BC")]
	public static string PrettifyPercentDisplay(float percent, string originalFormat)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028E4")]
	[Cpp2IlInjected.Address(RVA = "0x10E2610", Offset = "0x10E2610", VA = "0x10E2610")]
	public static void TrimTextIfNeeded(ref string text, SpriteFont font, float scale, float maxWidth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028E5")]
	[Cpp2IlInjected.Address(RVA = "0x10E27BC", Offset = "0x10E27BC", VA = "0x10E27BC")]
	public static string FormatWith(string original, object obj)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028E6")]
	[Cpp2IlInjected.Address(RVA = "0x10E28F0", Offset = "0x10E28F0", VA = "0x10E28F0")]
	public static bool TryCreatingDirectory(string folderPath)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60028E7")]
	[Cpp2IlInjected.Address(RVA = "0x10E29DC", Offset = "0x10E29DC", VA = "0x10E29DC")]
	public static void OpenFolder(string folderPath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028E8")]
	[Cpp2IlInjected.Address(RVA = "0x10E2A98", Offset = "0x10E2A98", VA = "0x10E2A98")]
	public static byte[] ToByteArray(this string str)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028E9")]
	[Cpp2IlInjected.Address(RVA = "0x10E21B0", Offset = "0x10E21B0", VA = "0x10E21B0")]
	public static float NextFloat(this UnifiedRandom r)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028EA")]
	[Cpp2IlInjected.Address(RVA = "0x10E2B30", Offset = "0x10E2B30", VA = "0x10E2B30")]
	public static float NextFloatDirection(this UnifiedRandom r)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028EB")]
	[Cpp2IlInjected.Address(RVA = "0x10E2B70", Offset = "0x10E2B70", VA = "0x10E2B70")]
	public static float NextFloat(this UnifiedRandom random, FloatRange range)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60028EC")]
	[Cpp2IlInjected.Address(RVA = "0x15F1B08", Offset = "0x15F1B08", VA = "0x15F1B08")]
	public static T NextFromList<T>(this UnifiedRandom random, params T[] objs)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028ED")]
	[Cpp2IlInjected.Address(RVA = "0x15F1AB4", Offset = "0x15F1AB4", VA = "0x15F1AB4")]
	public static T NextFromCollection<T>(this UnifiedRandom random, List<T> objs)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60028EE")]
	[Cpp2IlInjected.Address(RVA = "0x10E2C24", Offset = "0x10E2C24", VA = "0x10E2C24")]
	public static int Next(this UnifiedRandom random, IntRange range)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60028EF")]
	[Cpp2IlInjected.Address(RVA = "0x10E2C30", Offset = "0x10E2C30", VA = "0x10E2C30")]
	public static Vector2 NextVector2Square(this UnifiedRandom r, float min, float max)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F0")]
	[Cpp2IlInjected.Address(RVA = "0x10E2CC8", Offset = "0x10E2CC8", VA = "0x10E2CC8")]
	public static Vector2 NextVector2FromRectangle(this UnifiedRandom r, Rectangle rect)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F1")]
	[Cpp2IlInjected.Address(RVA = "0x10E2DE8", Offset = "0x10E2DE8", VA = "0x10E2DE8")]
	public static Vector2 NextVector2Unit(this UnifiedRandom r, float startRotation = 0f, float rotationRange = (float)Math.PI * 2f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F2")]
	[Cpp2IlInjected.Address(RVA = "0x10E2EB0", Offset = "0x10E2EB0", VA = "0x10E2EB0")]
	public static Vector2 NextVector2Circular(this UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F3")]
	[Cpp2IlInjected.Address(RVA = "0x10E2FF0", Offset = "0x10E2FF0", VA = "0x10E2FF0")]
	public static Vector2 NextVector2CircularEdge(this UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F4")]
	[Cpp2IlInjected.Address(RVA = "0x10E30F0", Offset = "0x10E30F0", VA = "0x10E30F0")]
	public static int Width(this Asset<Texture2D> asset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F5")]
	[Cpp2IlInjected.Address(RVA = "0x10E3160", Offset = "0x10E3160", VA = "0x10E3160")]
	public static int Height(this Asset<Texture2D> asset)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F6")]
	[Cpp2IlInjected.Address(RVA = "0x10E31D0", Offset = "0x10E31D0", VA = "0x10E31D0")]
	public static Rectangle Frame(this Asset<Texture2D> tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F7")]
	[Cpp2IlInjected.Address(RVA = "0x10E33E8", Offset = "0x10E33E8", VA = "0x10E33E8")]
	public static Rectangle OffsetSize(this Rectangle rect, int xSize, int ySize)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F8")]
	[Cpp2IlInjected.Address(RVA = "0x10E340C", Offset = "0x10E340C", VA = "0x10E340C")]
	public static Vector2 Size(this Asset<Texture2D> tex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028F9")]
	[Cpp2IlInjected.Address(RVA = "0x10E336C", Offset = "0x10E336C", VA = "0x10E336C")]
	public static Rectangle Frame(this Texture2D tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60028FA")]
	[Cpp2IlInjected.Address(RVA = "0x10E35A8", Offset = "0x10E35A8", VA = "0x10E35A8")]
	public static Vector2 OriginFlip(this Rectangle rect, Vector2 origin, SpriteEffects effects)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028FB")]
	[Cpp2IlInjected.Address(RVA = "0x10E3570", Offset = "0x10E3570", VA = "0x10E3570")]
	public static Vector2 Size(this Texture2D tex)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60028FC")]
	[Cpp2IlInjected.Address(RVA = "0x10E36C4", Offset = "0x10E36C4", VA = "0x10E36C4")]
	public static void WriteRGB(this BinaryWriter bb, Color c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028FD")]
	[Cpp2IlInjected.Address(RVA = "0x10E3720", Offset = "0x10E3720", VA = "0x10E3720")]
	public static void WriteVector2(this BinaryWriter bb, Vector2 v)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028FE")]
	[Cpp2IlInjected.Address(RVA = "0x10E3760", Offset = "0x10E3760", VA = "0x10E3760")]
	public static void WritePackedVector2(this BinaryWriter bb, Vector2 v)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60028FF")]
	[Cpp2IlInjected.Address(RVA = "0x10E37A4", Offset = "0x10E37A4", VA = "0x10E37A4")]
	public static Color ReadRGB(this BinaryReader bb)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002900")]
	[Cpp2IlInjected.Address(RVA = "0x10E3824", Offset = "0x10E3824", VA = "0x10E3824")]
	public static Vector2 ReadVector2(this BinaryReader bb)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002901")]
	[Cpp2IlInjected.Address(RVA = "0x10E3884", Offset = "0x10E3884", VA = "0x10E3884")]
	public static Vector2 ReadPackedVector2(this BinaryReader bb)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002902")]
	[Cpp2IlInjected.Address(RVA = "0x10E38D0", Offset = "0x10E38D0", VA = "0x10E38D0")]
	public static Vector2 Left(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002903")]
	[Cpp2IlInjected.Address(RVA = "0x10E3914", Offset = "0x10E3914", VA = "0x10E3914")]
	public static Vector2 Right(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002904")]
	[Cpp2IlInjected.Address(RVA = "0x10E395C", Offset = "0x10E395C", VA = "0x10E395C")]
	public static Vector2 Top(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002905")]
	[Cpp2IlInjected.Address(RVA = "0x10E399C", Offset = "0x10E399C", VA = "0x10E399C")]
	public static Vector2 Bottom(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002906")]
	[Cpp2IlInjected.Address(RVA = "0x10E0564", Offset = "0x10E0564", VA = "0x10E0564")]
	public static Vector2 TopLeft(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002907")]
	[Cpp2IlInjected.Address(RVA = "0x10E059C", Offset = "0x10E059C", VA = "0x10E059C")]
	public static Vector2 TopRight(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002908")]
	[Cpp2IlInjected.Address(RVA = "0x10E05D8", Offset = "0x10E05D8", VA = "0x10E05D8")]
	public static Vector2 BottomLeft(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002909")]
	[Cpp2IlInjected.Address(RVA = "0x10E0618", Offset = "0x10E0618", VA = "0x10E0618")]
	public static Vector2 BottomRight(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600290A")]
	[Cpp2IlInjected.Address(RVA = "0x10E39E4", Offset = "0x10E39E4", VA = "0x10E39E4")]
	public static Vector2 Center(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600290B")]
	[Cpp2IlInjected.Address(RVA = "0x10E3A30", Offset = "0x10E3A30", VA = "0x10E3A30")]
	public static Vector2 Size(this Rectangle r)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600290C")]
	[Cpp2IlInjected.Address(RVA = "0x10E3A68", Offset = "0x10E3A68", VA = "0x10E3A68")]
	public static float Distance(this Rectangle r, Vector2 point)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600290D")]
	[Cpp2IlInjected.Address(RVA = "0x10E3DBC", Offset = "0x10E3DBC", VA = "0x10E3DBC")]
	public static Vector2 ClosestPointInRect(this Rectangle r, Vector2 point)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600290E")]
	[Cpp2IlInjected.Address(RVA = "0x10E3EA0", Offset = "0x10E3EA0", VA = "0x10E3EA0")]
	public static Rectangle Modified(this Rectangle r, int x, int y, int w, int h)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600290F")]
	[Cpp2IlInjected.Address(RVA = "0x10E3EEC", Offset = "0x10E3EEC", VA = "0x10E3EEC")]
	public static bool IntersectsConeFastInaccurate(this Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002910")]
	[Cpp2IlInjected.Address(RVA = "0x10E4170", Offset = "0x10E4170", VA = "0x10E4170")]
	public static bool IntersectsConeSlowMoreAccurate(this Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002911")]
	[Cpp2IlInjected.Address(RVA = "0x10E44EC", Offset = "0x10E44EC", VA = "0x10E44EC")]
	public static bool DoesFitInCone(Vector2 point, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002912")]
	[Cpp2IlInjected.Address(RVA = "0x10E40CC", Offset = "0x10E40CC", VA = "0x10E40CC")]
	public static float ToRotation(this Vector2 v)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002913")]
	[Cpp2IlInjected.Address(RVA = "0x10E21E0", Offset = "0x10E21E0", VA = "0x10E21E0")]
	public static Vector2 ToRotationVector2(this float f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002914")]
	[Cpp2IlInjected.Address(RVA = "0x10DFEA8", Offset = "0x10DFEA8", VA = "0x10DFEA8")]
	public static Vector2 RotatedBy(this Vector2 spinningpoint, double radians, [Optional] Vector2 center)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002915")]
	[Cpp2IlInjected.Address(RVA = "0x10E4660", Offset = "0x10E4660", VA = "0x10E4660")]
	public static Vector2D RotatedBy(this Vector2D spinningpoint, double radians, [Optional] Vector2D center)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6002916")]
	[Cpp2IlInjected.Address(RVA = "0x10E47D8", Offset = "0x10E47D8", VA = "0x10E47D8")]
	public static Vector2 RotatedByRandom(this Vector2 spinninpoint, double maxRadians)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002917")]
	[Cpp2IlInjected.Address(RVA = "0x10E4900", Offset = "0x10E4900", VA = "0x10E4900")]
	public static Vector2 Floor(this Vector2 vec)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002918")]
	[Cpp2IlInjected.Address(RVA = "0x10E4924", Offset = "0x10E4924", VA = "0x10E4924")]
	public static bool HasNaNs(this Vector2 vec)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002919")]
	[Cpp2IlInjected.Address(RVA = "0x10E065C", Offset = "0x10E065C", VA = "0x10E065C")]
	public static bool Between(this Vector2 vec, Vector2 minimum, Vector2 maximum)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600291A")]
	[Cpp2IlInjected.Address(RVA = "0x10E4958", Offset = "0x10E4958", VA = "0x10E4958")]
	public static Vector2 ToVector2(this Point p)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600291B")]
	[Cpp2IlInjected.Address(RVA = "0x10E4990", Offset = "0x10E4990", VA = "0x10E4990")]
	public static Vector2 ToVector2(this Point16 p)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600291C")]
	[Cpp2IlInjected.Address(RVA = "0x10E49D0", Offset = "0x10E49D0", VA = "0x10E49D0")]
	public static Vector2D ToVector2D(this Point p)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600291D")]
	[Cpp2IlInjected.Address(RVA = "0x10E4A14", Offset = "0x10E4A14", VA = "0x10E4A14")]
	public static Vector2D ToVector2D(this Point16 p)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600291E")]
	[Cpp2IlInjected.Address(RVA = "0x10E4A5C", Offset = "0x10E4A5C", VA = "0x10E4A5C")]
	public static Vector2 ToWorldCoordinates(this Point p, float autoAddX = 8f, float autoAddY = 8f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600291F")]
	[Cpp2IlInjected.Address(RVA = "0x10E4B98", Offset = "0x10E4B98", VA = "0x10E4B98")]
	public static Vector2 ToWorldCoordinates(this Point16 p, float autoAddX = 8f, float autoAddY = 8f)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002920")]
	[Cpp2IlInjected.Address(RVA = "0x10E4CD0", Offset = "0x10E4CD0", VA = "0x10E4CD0")]
	public static Vector2 MoveTowards(this Vector2 currentPosition, Vector2 targetPosition, float maxAmountAllowedToMove)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002921")]
	[Cpp2IlInjected.Address(RVA = "0x10E506C", Offset = "0x10E506C", VA = "0x10E506C")]
	public static Point16 ToTileCoordinates16(this Vector2 vec)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x6002922")]
	[Cpp2IlInjected.Address(RVA = "0x10E50B8", Offset = "0x10E50B8", VA = "0x10E50B8")]
	public static Point16 ToTileCoordinates16(this Vector2D vec)
	{
		return default(Point16);
	}

	[Cpp2IlInjected.Token(Token = "0x6002923")]
	[Cpp2IlInjected.Address(RVA = "0x10E5104", Offset = "0x10E5104", VA = "0x10E5104")]
	public static Point ToTileCoordinates(this Vector2 vec)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002924")]
	[Cpp2IlInjected.Address(RVA = "0x10E5144", Offset = "0x10E5144", VA = "0x10E5144")]
	public static Point ToTileCoordinates(this Vector2D vec)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002925")]
	[Cpp2IlInjected.Address(RVA = "0x10E518C", Offset = "0x10E518C", VA = "0x10E518C")]
	public static Point ToPoint(this Vector2 v)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002926")]
	[Cpp2IlInjected.Address(RVA = "0x10E51C4", Offset = "0x10E51C4", VA = "0x10E51C4")]
	public static Point ToPoint(this Vector2D v)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002927")]
	[Cpp2IlInjected.Address(RVA = "0x10E5204", Offset = "0x10E5204", VA = "0x10E5204")]
	public static Vector2D ToVector2D(this Vector2 v)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6002928")]
	[Cpp2IlInjected.Address(RVA = "0x10E4EE4", Offset = "0x10E4EE4", VA = "0x10E4EE4")]
	public static Vector2 SafeNormalize(this Vector2 v, Vector2 defaultValue)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002929")]
	[Cpp2IlInjected.Address(RVA = "0x10E06B8", Offset = "0x10E06B8", VA = "0x10E06B8")]
	public static Vector2 ClosestPointOnLine(this Vector2 P, Vector2 A, Vector2 B)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600292A")]
	[Cpp2IlInjected.Address(RVA = "0x10E5248", Offset = "0x10E5248", VA = "0x10E5248")]
	public static bool RectangleLineCollision(Vector2 rectTopLeft, Vector2 rectBottomRight, Vector2 lineStart, Vector2 lineEnd)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600292B")]
	[Cpp2IlInjected.Address(RVA = "0x10E5588", Offset = "0x10E5588", VA = "0x10E5588")]
	public static Vector2 RotateRandom(this Vector2 spinninpoint, double maxRadians)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600292C")]
	[Cpp2IlInjected.Address(RVA = "0x10E56B0", Offset = "0x10E56B0", VA = "0x10E56B0")]
	public static float AngleTo(this Vector2 Origin, Vector2 Target)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600292D")]
	[Cpp2IlInjected.Address(RVA = "0x10E576C", Offset = "0x10E576C", VA = "0x10E576C")]
	public static float AngleFrom(this Vector2 Origin, Vector2 Target)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600292E")]
	[Cpp2IlInjected.Address(RVA = "0x10E5828", Offset = "0x10E5828", VA = "0x10E5828")]
	public static Vector2 rotateTowards(Vector2 currentPosition, Vector2 currentVelocity, Vector2 targetPosition, float maxChange)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600292F")]
	[Cpp2IlInjected.Address(RVA = "0x10E0860", Offset = "0x10E0860", VA = "0x10E0860")]
	public static float Distance(this Vector2 Origin, Vector2 Target)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002930")]
	[Cpp2IlInjected.Address(RVA = "0x10E59F8", Offset = "0x10E59F8", VA = "0x10E59F8")]
	public static float DistanceSQ(this Vector2 Origin, Vector2 Target)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002931")]
	[Cpp2IlInjected.Address(RVA = "0x10E5A98", Offset = "0x10E5A98", VA = "0x10E5A98")]
	public static Vector2 DirectionTo(this Vector2 Origin, Vector2 Target)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002932")]
	[Cpp2IlInjected.Address(RVA = "0x10E5B54", Offset = "0x10E5B54", VA = "0x10E5B54")]
	public static Vector2 DirectionFrom(this Vector2 Origin, Vector2 Target)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002933")]
	[Cpp2IlInjected.Address(RVA = "0x10E5C10", Offset = "0x10E5C10", VA = "0x10E5C10")]
	public static bool WithinRange(this Vector2 Origin, Vector2 Target, float MaxRange)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002934")]
	[Cpp2IlInjected.Address(RVA = "0x10E5CD4", Offset = "0x10E5CD4", VA = "0x10E5CD4")]
	public static Vector2 XY(this Vector4 vec)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002935")]
	[Cpp2IlInjected.Address(RVA = "0x10E5CF4", Offset = "0x10E5CF4", VA = "0x10E5CF4")]
	public static Vector2 ZW(this Vector4 vec)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002936")]
	[Cpp2IlInjected.Address(RVA = "0x10E5D1C", Offset = "0x10E5D1C", VA = "0x10E5D1C")]
	public static Vector3 XZW(this Vector4 vec)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6002937")]
	[Cpp2IlInjected.Address(RVA = "0x10E5D50", Offset = "0x10E5D50", VA = "0x10E5D50")]
	public static Vector3 YZW(this Vector4 vec)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6002938")]
	[Cpp2IlInjected.Address(RVA = "0x10E5D8C", Offset = "0x10E5D8C", VA = "0x10E5D8C")]
	public static Color MultiplyRGB(this Color firstColor, Color secondColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002939")]
	[Cpp2IlInjected.Address(RVA = "0x10E5E68", Offset = "0x10E5E68", VA = "0x10E5E68")]
	public static Color MultiplyRGBA(this Color firstColor, Color secondColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600293A")]
	[Cpp2IlInjected.Address(RVA = "0x10E5F80", Offset = "0x10E5F80", VA = "0x10E5F80")]
	public static string Hex3(this Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600293B")]
	[Cpp2IlInjected.Address(RVA = "0x10E6030", Offset = "0x10E6030", VA = "0x10E6030")]
	public static string Hex4(this Color color)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600293C")]
	[Cpp2IlInjected.Address(RVA = "0x10E60FC", Offset = "0x10E60FC", VA = "0x10E60FC")]
	public static int ToDirectionInt(this bool value)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600293D")]
	[Cpp2IlInjected.Address(RVA = "0x10E6110", Offset = "0x10E6110", VA = "0x10E6110")]
	public static int ToInt(this bool value)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600293E")]
	[Cpp2IlInjected.Address(RVA = "0x10E6114", Offset = "0x10E6114", VA = "0x10E6114")]
	public static int ModulusPositive(this int myInteger, int modulusNumber)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600293F")]
	[Cpp2IlInjected.Address(RVA = "0x10E6138", Offset = "0x10E6138", VA = "0x10E6138")]
	public static float AngleLerp(this float curAngle, float targetAngle, float amount)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002940")]
	[Cpp2IlInjected.Address(RVA = "0x10E5954", Offset = "0x10E5954", VA = "0x10E5954")]
	public static float AngleTowards(this float curAngle, float targetAngle, float maxChange)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002941")]
	[Cpp2IlInjected.Address(RVA = "0x10E61B8", Offset = "0x10E61B8", VA = "0x10E61B8")]
	public static bool deepCompare(this int[] firstArray, int[] secondArray)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002942")]
	[Cpp2IlInjected.Address(RVA = "0x10E6234", Offset = "0x10E6234", VA = "0x10E6234")]
	public static List<int> GetTrueIndexes(this bool[] array)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002943")]
	[Cpp2IlInjected.Address(RVA = "0x10E62F8", Offset = "0x10E62F8", VA = "0x10E62F8")]
	public static List<int> GetTrueIndexes(params bool[][] arrays)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002944")]
	[Cpp2IlInjected.Address(RVA = "0x1601EAC", Offset = "0x1601EAC", VA = "0x1601EAC")]
	public static int Count<T>(this T[] arr, T value)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002945")]
	[Cpp2IlInjected.Address(RVA = "0x10E6418", Offset = "0x10E6418", VA = "0x10E6418")]
	public static bool PressingShift(this KeyboardState kb)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002946")]
	[Cpp2IlInjected.Address(RVA = "0x10E6478", Offset = "0x10E6478", VA = "0x10E6478")]
	public static bool PressingControl(this KeyboardState kb)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002947")]
	[Cpp2IlInjected.Address(RVA = "0x166B0F0", Offset = "0x166B0F0", VA = "0x166B0F0")]
	public static R[] MapArray<R, T>(T[] array, Func<T, R> mapper)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002948")]
	[Cpp2IlInjected.Address(RVA = "0x10E64D8", Offset = "0x10E64D8", VA = "0x10E64D8")]
	public static bool PlotLine(Point16 p0, Point16 p1, TileActionAttempt plot, bool jump = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002949")]
	[Cpp2IlInjected.Address(RVA = "0x10E67D8", Offset = "0x10E67D8", VA = "0x10E67D8")]
	public static bool PlotLine(Point p0, Point p1, TileActionAttempt plot, bool jump = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600294A")]
	[Cpp2IlInjected.Address(RVA = "0x10E6880", Offset = "0x10E6880", VA = "0x10E6880")]
	private static void PlotLineLength(int x0, int y0, int x1, int y1, ref int length, bool jump = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600294B")]
	[Cpp2IlInjected.Address(RVA = "0x10E6A4C", Offset = "0x10E6A4C", VA = "0x10E6A4C")]
	private static bool PlotLineOffset(Vector2D start, Vector2D end, double halfWidth, int x0, int y0, int x1, int y1, TileActionAttempt plot, bool jump = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600294C")]
	[Cpp2IlInjected.Address(RVA = "0x10E7404", Offset = "0x10E7404", VA = "0x10E7404")]
	private static bool PlotLineOffsetTale(Vector2D start, Vector2D end, int length, double halfWidth, int x0, int y0, int x1, int y1, TileActionAttempt plot, bool jump = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600294D")]
	[Cpp2IlInjected.Address(RVA = "0x10E6574", Offset = "0x10E6574", VA = "0x10E6574")]
	private static bool PlotLine(int x0, int y0, int x1, int y1, TileActionAttempt plot, bool jump = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600294E")]
	[Cpp2IlInjected.Address(RVA = "0x10E7B84", Offset = "0x10E7B84", VA = "0x10E7B84")]
	public static int RandomNext(ref ulong seed, int bits)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600294F")]
	[Cpp2IlInjected.Address(RVA = "0x10E7C44", Offset = "0x10E7C44", VA = "0x10E7C44")]
	public static ulong RandomNextSeed(ulong seed)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6002950")]
	[Cpp2IlInjected.Address(RVA = "0x10E7C6C", Offset = "0x10E7C6C", VA = "0x10E7C6C")]
	public static float RandomFloat(ref ulong seed)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6002951")]
	[Cpp2IlInjected.Address(RVA = "0x10E7D00", Offset = "0x10E7D00", VA = "0x10E7D00")]
	public static int RandomInt(ref ulong seed, int max)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002952")]
	[Cpp2IlInjected.Address(RVA = "0x10E7DFC", Offset = "0x10E7DFC", VA = "0x10E7DFC")]
	public static int RandomInt(ref ulong seed, int min, int max)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002953")]
	[Cpp2IlInjected.Address(RVA = "0x10E7E84", Offset = "0x10E7E84", VA = "0x10E7E84")]
	public static bool PlotTileLineInner(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002954")]
	[Cpp2IlInjected.Address(RVA = "0x10E7F34", Offset = "0x10E7F34", VA = "0x10E7F34")]
	public static bool PlotTileLine(Vector2 start, Vector2 end, float width, TileActionAttempt plot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002955")]
	[Cpp2IlInjected.Address(RVA = "0x10E806C", Offset = "0x10E806C", VA = "0x10E806C")]
	public static bool PlotTileLine(Vector2D start, Vector2D end, double width, TileActionAttempt plot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002956")]
	[Cpp2IlInjected.Address(RVA = "0x10E8468", Offset = "0x10E8468", VA = "0x10E8468")]
	public static bool PlotTileTale(Vector2D start, Vector2D end, double width, TileActionAttempt plot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002957")]
	[Cpp2IlInjected.Address(RVA = "0x10E8704", Offset = "0x10E8704", VA = "0x10E8704")]
	public static bool PlotTileArea(int x, int y, TileActionAttempt plot)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002958")]
	[Cpp2IlInjected.Address(RVA = "0x10E936C", Offset = "0x10E936C", VA = "0x10E936C")]
	public static int RandomConsecutive(double random, int odds)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002959")]
	[Cpp2IlInjected.Address(RVA = "0x10E9430", Offset = "0x10E9430", VA = "0x10E9430")]
	public static Vector2 RandomVector2(UnifiedRandom random, float min, float max)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600295A")]
	[Cpp2IlInjected.Address(RVA = "0x10E94C8", Offset = "0x10E94C8", VA = "0x10E94C8")]
	public static Vector2D RandomVector2D(UnifiedRandom random, double min, double max)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600295B")]
	[Cpp2IlInjected.Address(RVA = "0x1760A80", Offset = "0x1760A80", VA = "0x1760A80")]
	public static bool IndexInRange<T>(this T[] t, int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600295C")]
	[Cpp2IlInjected.Address(RVA = "0x1760A44", Offset = "0x1760A44", VA = "0x1760A44")]
	public static bool IndexInRange<T>(this List<T> t, int index)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600295D")]
	[Cpp2IlInjected.Address(RVA = "0x15F1B98", Offset = "0x15F1B98", VA = "0x15F1B98")]
	public static T SelectRandom<T>(UnifiedRandom random, params T[] choices)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600295E")]
	[Cpp2IlInjected.Address(RVA = "0x10E9560", Offset = "0x10E9560", VA = "0x10E9560")]
	public static void DrawBorderStringFourWay(SpriteBatch sb, SpriteFont font, string text, float x, float y, Color textColor, Color borderColor, Vector2 origin, float scale = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600295F")]
	[Cpp2IlInjected.Address(RVA = "0x10E972C", Offset = "0x10E972C", VA = "0x10E972C")]
	public static Vector2 DrawBorderString(SpriteBatch sb, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002960")]
	[Cpp2IlInjected.Address(RVA = "0x10E993C", Offset = "0x10E993C", VA = "0x10E993C")]
	public static Vector2 DrawBorderStringBig(SpriteBatch spriteBatch, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6002961")]
	[Cpp2IlInjected.Address(RVA = "0x10E9C74", Offset = "0x10E9C74", VA = "0x10E9C74")]
	public static void DrawInvBG(SpriteBatch sb, Rectangle R, [Optional] Color c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002962")]
	[Cpp2IlInjected.Address(RVA = "0x10EA6F8", Offset = "0x10EA6F8", VA = "0x10EA6F8")]
	public static void DrawInvBG(SpriteBatch sb, float x, float y, float w, float h, [Optional] Color c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002963")]
	[Cpp2IlInjected.Address(RVA = "0x10E9D18", Offset = "0x10E9D18", VA = "0x10E9D18")]
	public static void DrawInvBG(SpriteBatch sb, int x, int y, int w, int h, [Optional] Color c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002964")]
	[Cpp2IlInjected.Address(RVA = "0x10EA7C4", Offset = "0x10EA7C4", VA = "0x10EA7C4")]
	public static string ReadEmbeddedResource(string path)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002965")]
	[Cpp2IlInjected.Address(RVA = "0x10EA9EC", Offset = "0x10EA9EC", VA = "0x10EA9EC")]
	public static void DrawSplicedPanel(SpriteBatch sb, Texture2D texture, int x, int y, int w, int h, int leftEnd, int rightEnd, int topEnd, int bottomEnd, Color c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002966")]
	[Cpp2IlInjected.Address(RVA = "0x10EB390", Offset = "0x10EB390", VA = "0x10EB390")]
	public static void DrawSettingsPanel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002967")]
	[Cpp2IlInjected.Address(RVA = "0x10EB854", Offset = "0x10EB854", VA = "0x10EB854")]
	public static void DrawSettings2Panel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002968")]
	[Cpp2IlInjected.Address(RVA = "0x10EB484", Offset = "0x10EB484", VA = "0x10EB484")]
	public static void DrawPanel(Texture2D texture, int edgeWidth, int edgeShove, SpriteBatch spriteBatch, Vector2 position, float width, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002969")]
	[Cpp2IlInjected.Address(RVA = "0x10EB948", Offset = "0x10EB948", VA = "0x10EB948")]
	public static void DrawRectangle(SpriteBatch sb, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600296A")]
	[Cpp2IlInjected.Address(RVA = "0x10EBE98", Offset = "0x10EBE98", VA = "0x10EBE98")]
	public static void DrawLaser(SpriteBatch sb, Texture2D tex, Vector2 start, Vector2 end, Vector2 scale, LaserLineFraming framing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600296B")]
	[Cpp2IlInjected.Address(RVA = "0x10EC6F0", Offset = "0x10EC6F0", VA = "0x10EC6F0")]
	public static void DrawLine(SpriteBatch spriteBatch, Point start, Point end, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600296C")]
	[Cpp2IlInjected.Address(RVA = "0x10EC800", Offset = "0x10EC800", VA = "0x10EC800")]
	public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600296D")]
	[Cpp2IlInjected.Address(RVA = "0x10EBAF0", Offset = "0x10EBAF0", VA = "0x10EBAF0")]
	public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600296E")]
	[Cpp2IlInjected.Address(RVA = "0x10ECC18", Offset = "0x10ECC18", VA = "0x10ECC18")]
	public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Rectangle rect, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600296F")]
	[Cpp2IlInjected.Address(RVA = "0x10ECCF8", Offset = "0x10ECCF8", VA = "0x10ECCF8")]
	public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Point start, Point end, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002970")]
	[Cpp2IlInjected.Address(RVA = "0x10ECF7C", Offset = "0x10ECF7C", VA = "0x10ECF7C")]
	public static void DrawRect(SpriteBatch spriteBatch, Rectangle rect, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002971")]
	[Cpp2IlInjected.Address(RVA = "0x10ECE0C", Offset = "0x10ECE0C", VA = "0x10ECE0C")]
	public static void DrawRect(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002972")]
	[Cpp2IlInjected.Address(RVA = "0x10ED084", Offset = "0x10ED084", VA = "0x10ED084")]
	public static void DrawRect(SpriteBatch spriteBatch, Vector2 topLeft, Vector2 topRight, Vector2 bottomRight, Vector2 bottomLeft, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002973")]
	[Cpp2IlInjected.Address(RVA = "0x10ED180", Offset = "0x10ED180", VA = "0x10ED180")]
	public static void DrawCursorSingle(SpriteBatch sb, Color color, float rot = float.NaN, float scale = 1f, [Optional] Vector2 manualPosition, int cursorSlot = 0, int specialMode = 0)
	{
	}
}
