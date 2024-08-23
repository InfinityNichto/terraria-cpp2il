using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BB RID: 187
	[NativeClass("Vector3f")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[Il2CppEagerStaticClassConstruction]
	[NativeType(Header = "Runtime/Math/Vector3.h")]
	[NativeHeader("Runtime/Math/Vector3.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
	public struct Vector3 : IEquatable<Vector3>, IFormattable
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00002815 File Offset: 0x00000A15
		[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80B14", Offset = "0x1F80B14", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			throw null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002818 File Offset: 0x00000A18
		[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80B50", Offset = "0x1F80B50", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			throw null;
		}

		// Token: 0x170000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		public float this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F80C64", Offset = "0x1F80C64", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F80CDC", Offset = "0x1F80CDC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002821 File Offset: 0x00000A21
		[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80D54", Offset = "0x1F80D54", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Vector3(float x, float y, float z)
		{
			throw null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002824 File Offset: 0x00000A24
		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80D60", Offset = "0x1F80D60", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Vector3(float x, float y)
		{
			throw null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002827 File Offset: 0x00000A27
		[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80D6C", Offset = "0x1F80D6C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 Scale(Vector3 a, Vector3 b)
		{
			throw null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000282A File Offset: 0x00000A2A
		[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80D7C", Offset = "0x1F80D7C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			throw null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000282D File Offset: 0x00000A2D
		[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80DA4", Offset = "0x1F80DA4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002830 File Offset: 0x00000A30
		[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80DEC", Offset = "0x1F80DEC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002833 File Offset: 0x00000A33
		[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80E84", Offset = "0x1F80E84", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public bool Equals(Vector3 other)
		{
			throw null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002836 File Offset: 0x00000A36
		[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80EB4", Offset = "0x1F80EB4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public static Vector3 Normalize(Vector3 value)
		{
			throw null;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00002839 File Offset: 0x00000A39
		[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
		public Vector3 normalized
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F80F84", Offset = "0x1F80F84", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000283C File Offset: 0x00000A3C
		[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81050", Offset = "0x1F81050", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Dot(Vector3 lhs, Vector3 rhs)
		{
			throw null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000283F File Offset: 0x00000A3F
		[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81068", Offset = "0x1F81068", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Distance(Vector3 a, Vector3 b)
		{
			throw null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002842 File Offset: 0x00000A42
		[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81108", Offset = "0x1F81108", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public static float Magnitude(Vector3 vector)
		{
			throw null;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00002845 File Offset: 0x00000A45
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		public float magnitude
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81188", Offset = "0x1F81188", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00002848 File Offset: 0x00000A48
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		public float sqrMagnitude
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81208", Offset = "0x1F81208", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000284B File Offset: 0x00000A4B
		[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81228", Offset = "0x1F81228", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			throw null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000284E File Offset: 0x00000A4E
		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81244", Offset = "0x1F81244", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			throw null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00002851 File Offset: 0x00000A51
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public static Vector3 zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81260", Offset = "0x1F81260", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00002854 File Offset: 0x00000A54
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public static Vector3 one
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F812AC", Offset = "0x1F812AC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00002857 File Offset: 0x00000A57
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public static Vector3 forward
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F812F8", Offset = "0x1F812F8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0000285A File Offset: 0x00000A5A
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public static Vector3 back
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81344", Offset = "0x1F81344", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000285D File Offset: 0x00000A5D
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public static Vector3 up
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81390", Offset = "0x1F81390", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00002860 File Offset: 0x00000A60
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public static Vector3 down
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F813DC", Offset = "0x1F813DC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00002863 File Offset: 0x00000A63
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public static Vector3 left
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81428", Offset = "0x1F81428", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00002866 File Offset: 0x00000A66
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public static Vector3 right
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F81474", Offset = "0x1F81474", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002869 File Offset: 0x00000A69
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F814C0", Offset = "0x1F814C0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			throw null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000286C File Offset: 0x00000A6C
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F814D0", Offset = "0x1F814D0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000286F File Offset: 0x00000A6F
		[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F814E0", Offset = "0x1F814E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 operator -(Vector3 a)
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002872 File Offset: 0x00000A72
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F814F0", Offset = "0x1F814F0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 operator *(Vector3 a, float d)
		{
			throw null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002875 File Offset: 0x00000A75
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81500", Offset = "0x1F81500", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 operator *(float d, Vector3 a)
		{
			throw null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002878 File Offset: 0x00000A78
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81514", Offset = "0x1F81514", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector3 operator /(Vector3 a, float d)
		{
			throw null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000287B File Offset: 0x00000A7B
		[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81524", Offset = "0x1F81524", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			throw null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000287E File Offset: 0x00000A7E
		[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81558", Offset = "0x1F81558", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			throw null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002881 File Offset: 0x00000A81
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8158C", Offset = "0x1F8158C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.RaycastResult", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002884 File Offset: 0x00000A84
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F77968", Offset = "0x1F77968", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bounds), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Ray), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector3), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002887 File Offset: 0x00000A87
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81598", Offset = "0x1F81598", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector3()
		{
			throw null;
		}

		// Token: 0x04000374 RID: 884
		[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
		public const float kEpsilon = 1E-05f;

		// Token: 0x04000375 RID: 885
		[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
		public const float kEpsilonNormalSqrt = 1E-15f;

		// Token: 0x04000376 RID: 886
		[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000377 RID: 887
		[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000378 RID: 888
		[global::Cpp2ILInjected.Token(Token = "0x40003B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x04000379 RID: 889
		[global::Cpp2ILInjected.Token(Token = "0x40003B1")]
		private static readonly Vector3 zeroVector;

		// Token: 0x0400037A RID: 890
		[global::Cpp2ILInjected.Token(Token = "0x40003B2")]
		private static readonly Vector3 oneVector;

		// Token: 0x0400037B RID: 891
		[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
		private static readonly Vector3 upVector;

		// Token: 0x0400037C RID: 892
		[global::Cpp2ILInjected.Token(Token = "0x40003B4")]
		private static readonly Vector3 downVector;

		// Token: 0x0400037D RID: 893
		[global::Cpp2ILInjected.Token(Token = "0x40003B5")]
		private static readonly Vector3 leftVector;

		// Token: 0x0400037E RID: 894
		[global::Cpp2ILInjected.Token(Token = "0x40003B6")]
		private static readonly Vector3 rightVector;

		// Token: 0x0400037F RID: 895
		[global::Cpp2ILInjected.Token(Token = "0x40003B7")]
		private static readonly Vector3 forwardVector;

		// Token: 0x04000380 RID: 896
		[global::Cpp2ILInjected.Token(Token = "0x40003B8")]
		private static readonly Vector3 backVector;

		// Token: 0x04000381 RID: 897
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		private static readonly Vector3 positiveInfinityVector;

		// Token: 0x04000382 RID: 898
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		private static readonly Vector3 negativeInfinityVector;
	}
}
