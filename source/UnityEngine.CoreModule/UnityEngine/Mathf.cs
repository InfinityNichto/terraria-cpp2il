using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x020000BF RID: 191
	[NativeHeader("Runtime/Math/PerlinNoise.h")]
	[NativeHeader("Runtime/Utilities/BitUtility.h")]
	[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
	[Il2CppEagerStaticClassConstruction]
	[NativeHeader("Runtime/Math/FloatConversion.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
	public struct Mathf
	{
		// Token: 0x06000415 RID: 1045
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82B10", Offset = "0x1F82B10", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cubemap), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(TextureFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2DArray), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsPowerOfTwo(int value);

		// Token: 0x06000416 RID: 1046
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600042A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82B4C", Offset = "0x1F82B4C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Color), Member = "get_linear", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern float GammaToLinearSpace(float value);

		// Token: 0x06000417 RID: 1047 RVA: 0x00002923 File Offset: 0x00000B23
		[FreeFunction(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600042B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82B84", Offset = "0x1F82B84", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "ExtractColorTemperature", MemberParameters = new object[] { typeof(Light) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			throw null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002926 File Offset: 0x00000B26
		[global::Cpp2ILInjected.Token(Token = "0x600042C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82C28", Offset = "0x1F82C28", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static float Sin(float f)
		{
			throw null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002929 File Offset: 0x00000B29
		[global::Cpp2ILInjected.Token(Token = "0x600042D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82C8C", Offset = "0x1F82C8C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static float Cos(float f)
		{
			throw null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000292C File Offset: 0x00000B2C
		[global::Cpp2ILInjected.Token(Token = "0x600042E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82CF0", Offset = "0x1F82CF0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static float Tan(float f)
		{
			throw null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000292F File Offset: 0x00000B2F
		[global::Cpp2ILInjected.Token(Token = "0x600042F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82D54", Offset = "0x1F82D54", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static float Atan(float f)
		{
			throw null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002932 File Offset: 0x00000B32
		[global::Cpp2ILInjected.Token(Token = "0x6000430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82DB8", Offset = "0x1F82DB8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static float Atan2(float y, float x)
		{
			throw null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002935 File Offset: 0x00000B35
		[global::Cpp2ILInjected.Token(Token = "0x6000431")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82E24", Offset = "0x1F82E24", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Sqrt(float f)
		{
			throw null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002938 File Offset: 0x00000B38
		[global::Cpp2ILInjected.Token(Token = "0x6000432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82E80", Offset = "0x1F82E80", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Abs(float f)
		{
			throw null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000293B File Offset: 0x00000B3B
		[global::Cpp2ILInjected.Token(Token = "0x6000433")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82EDC", Offset = "0x1F82EDC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static int Abs(int value)
		{
			throw null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000293E File Offset: 0x00000B3E
		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82F34", Offset = "0x1F82F34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Min(float a, float b)
		{
			throw null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002941 File Offset: 0x00000B41
		[global::Cpp2ILInjected.Token(Token = "0x6000435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82F40", Offset = "0x1F82F40", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static int Min(int a, int b)
		{
			throw null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002944 File Offset: 0x00000B44
		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82F4C", Offset = "0x1F82F4C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static int Min(params int[] values)
		{
			throw null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002947 File Offset: 0x00000B47
		[global::Cpp2ILInjected.Token(Token = "0x6000437")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82F90", Offset = "0x1F82F90", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Max(float a, float b)
		{
			throw null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000294A File Offset: 0x00000B4A
		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82F9C", Offset = "0x1F82F9C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static int Max(int a, int b)
		{
			throw null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000294D File Offset: 0x00000B4D
		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82FA8", Offset = "0x1F82FA8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Pow(float f, float p)
		{
			throw null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002950 File Offset: 0x00000B50
		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83018", Offset = "0x1F83018", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Log", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Log(float f, float p)
		{
			throw null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002953 File Offset: 0x00000B53
		[global::Cpp2ILInjected.Token(Token = "0x600043B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83088", Offset = "0x1F83088", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Ceil(float f)
		{
			throw null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002956 File Offset: 0x00000B56
		[global::Cpp2ILInjected.Token(Token = "0x600043C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F830E4", Offset = "0x1F830E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Floor(float f)
		{
			throw null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002959 File Offset: 0x00000B59
		[global::Cpp2ILInjected.Token(Token = "0x600043D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83140", Offset = "0x1F83140", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static float Round(float f)
		{
			throw null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000295C File Offset: 0x00000B5C
		[global::Cpp2ILInjected.Token(Token = "0x600043E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83208", Offset = "0x1F83208", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static int CeilToInt(float f)
		{
			throw null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000295F File Offset: 0x00000B5F
		[global::Cpp2ILInjected.Token(Token = "0x600043F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8327C", Offset = "0x1F8327C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static int FloorToInt(float f)
		{
			throw null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002962 File Offset: 0x00000B62
		[global::Cpp2ILInjected.Token(Token = "0x6000440")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F832F0", Offset = "0x1F832F0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static int RoundToInt(float f)
		{
			throw null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002965 File Offset: 0x00000B65
		[global::Cpp2ILInjected.Token(Token = "0x6000441")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F833CC", Offset = "0x1F833CC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Sign(float f)
		{
			throw null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002968 File Offset: 0x00000B68
		[global::Cpp2ILInjected.Token(Token = "0x6000442")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F833E0", Offset = "0x1F833E0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Clamp(float value, float min, float max)
		{
			throw null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000296B File Offset: 0x00000B6B
		[global::Cpp2ILInjected.Token(Token = "0x6000443")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F833FC", Offset = "0x1F833FC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static int Clamp(int value, int min, int max)
		{
			throw null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000296E File Offset: 0x00000B6E
		[global::Cpp2ILInjected.Token(Token = "0x6000444")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83418", Offset = "0x1F83418", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Clamp01(float value)
		{
			throw null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002971 File Offset: 0x00000B71
		[global::Cpp2ILInjected.Token(Token = "0x6000445")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83434", Offset = "0x1F83434", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Lerp(float a, float b, float t)
		{
			throw null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002974 File Offset: 0x00000B74
		[global::Cpp2ILInjected.Token(Token = "0x6000446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83458", Offset = "0x1F83458", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float MoveTowards(float current, float target, float maxDelta)
		{
			throw null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002977 File Offset: 0x00000B77
		[global::Cpp2ILInjected.Token(Token = "0x6000447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83488", Offset = "0x1F83488", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static bool Approximately(float a, float b)
		{
			throw null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000297A File Offset: 0x00000B7A
		[global::Cpp2ILInjected.Token(Token = "0x6000448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83518", Offset = "0x1F83518", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			throw null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000297D File Offset: 0x00000B7D
		[global::Cpp2ILInjected.Token(Token = "0x6000449")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F835E4", Offset = "0x1F835E4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Repeat(float t, float length)
		{
			throw null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002980 File Offset: 0x00000B80
		[global::Cpp2ILInjected.Token(Token = "0x600044A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8360C", Offset = "0x1F8360C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float InverseLerp(float a, float b, float value)
		{
			throw null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002983 File Offset: 0x00000B83
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600044B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8363C", Offset = "0x1F8363C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Mathf()
		{
			throw null;
		}

		// Token: 0x06000438 RID: 1080
		[global::Cpp2ILInjected.Token(Token = "0x600044C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82BDC", Offset = "0x1F82BDC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret);

		// Token: 0x04000391 RID: 913
		[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
		public static readonly float Epsilon;
	}
}
