using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000B8 RID: 184
	[Il2CppEagerStaticClassConstruction]
	[UsedByNativeCode]
	[DefaultMember("Item")]
	[NativeType("Runtime/Math/Vector2Int.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
	public struct Vector2Int : IEquatable<Vector2Int>, IFormattable
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000279D File Offset: 0x0000099D
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000027A0 File Offset: 0x000009A0
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		public int x
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F620", Offset = "0x1F7F620", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F628", Offset = "0x1F7F628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000027A3 File Offset: 0x000009A3
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000027A6 File Offset: 0x000009A6
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public int y
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F630", Offset = "0x1F7F630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7F638", Offset = "0x1F7F638", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000027A9 File Offset: 0x000009A9
		[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F640", Offset = "0x1F7F640", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Vector2Int(int x, int y)
		{
			throw null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000027AC File Offset: 0x000009AC
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F648", Offset = "0x1F7F648", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Vector2(Vector2Int v)
		{
			throw null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000027AF File Offset: 0x000009AF
		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F658", Offset = "0x1F7F658", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000027B2 File Offset: 0x000009B2
		[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F6E0", Offset = "0x1F7F6E0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public bool Equals(Vector2Int other)
		{
			throw null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000027B5 File Offset: 0x000009B5
		[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F708", Offset = "0x1F7F708", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000027B8 File Offset: 0x000009B8
		[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F750", Offset = "0x1F7F750", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000027BB File Offset: 0x000009BB
		[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F75C", Offset = "0x1F7F75C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000027BE File Offset: 0x000009BE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7F8B4", Offset = "0x1F7F8B4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector2Int()
		{
			throw null;
		}

		// Token: 0x04000351 RID: 849
		[global::Cpp2ILInjected.Token(Token = "0x4000389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_X;

		// Token: 0x04000352 RID: 850
		[global::Cpp2ILInjected.Token(Token = "0x400038A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int m_Y;

		// Token: 0x04000353 RID: 851
		[global::Cpp2ILInjected.Token(Token = "0x400038B")]
		private static readonly Vector2Int s_Zero;

		// Token: 0x04000354 RID: 852
		[global::Cpp2ILInjected.Token(Token = "0x400038C")]
		private static readonly Vector2Int s_One;

		// Token: 0x04000355 RID: 853
		[global::Cpp2ILInjected.Token(Token = "0x400038D")]
		private static readonly Vector2Int s_Up;

		// Token: 0x04000356 RID: 854
		[global::Cpp2ILInjected.Token(Token = "0x400038E")]
		private static readonly Vector2Int s_Down;

		// Token: 0x04000357 RID: 855
		[global::Cpp2ILInjected.Token(Token = "0x400038F")]
		private static readonly Vector2Int s_Left;

		// Token: 0x04000358 RID: 856
		[global::Cpp2ILInjected.Token(Token = "0x4000390")]
		private static readonly Vector2Int s_Right;
	}
}
