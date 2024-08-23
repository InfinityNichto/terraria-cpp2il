using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BD RID: 189
	[DefaultMember("Item")]
	[NativeClass("ColorRGBAf")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Math/Color.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
	public struct Color : IEquatable<Color>, IFormattable
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x0000289C File Offset: 0x00000A9C
		[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81C30", Offset = "0x1F81C30", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Color(float r, float g, float b, float a)
		{
			throw null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000289F File Offset: 0x00000A9F
		[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81C3C", Offset = "0x1F81C3C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Color(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000028A2 File Offset: 0x00000AA2
		[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81C50", Offset = "0x1F81C50", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000028A5 File Offset: 0x00000AA5
		[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81C5C", Offset = "0x1F81C5C", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000028A8 File Offset: 0x00000AA8
		[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81E28", Offset = "0x1F81E28", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000028AB File Offset: 0x00000AAB
		[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81EAC", Offset = "0x1F81EAC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000028AE File Offset: 0x00000AAE
		[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81F80", Offset = "0x1F81F80", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[MethodImpl(256)]
		public bool Equals(Color other)
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000028B1 File Offset: 0x00000AB1
		[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82000", Offset = "0x1F82000", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Color operator *(Color a, float b)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000028B4 File Offset: 0x00000AB4
		[global::Cpp2ILInjected.Token(Token = "0x6000400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82014", Offset = "0x1F82014", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator ==(Color lhs, Color rhs)
		{
			throw null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000028B7 File Offset: 0x00000AB7
		[global::Cpp2ILInjected.Token(Token = "0x6000401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82054", Offset = "0x1F82054", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator !=(Color lhs, Color rhs)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000028BA File Offset: 0x00000ABA
		[global::Cpp2ILInjected.Token(Token = "0x6000402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82094", Offset = "0x1F82094", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Color Lerp(Color a, Color b, float t)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000028BD File Offset: 0x00000ABD
		[global::Cpp2ILInjected.Token(Token = "0x6000403")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F820E0", Offset = "0x1F820E0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal Color RGBMultiplied(float multiplier)
		{
			throw null;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000028C0 File Offset: 0x00000AC0
		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public static Color red
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000404")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F820FC", Offset = "0x1F820FC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000028C3 File Offset: 0x00000AC3
		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public static Color green
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000405")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82110", Offset = "0x1F82110", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000028C6 File Offset: 0x00000AC6
		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public static Color blue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000406")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82124", Offset = "0x1F82124", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000028C9 File Offset: 0x00000AC9
		[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
		public static Color white
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000407")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82138", Offset = "0x1F82138", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000028CC File Offset: 0x00000ACC
		[global::Cpp2ILInjected.Token(Token = "0x170000D6")]
		public static Color black
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000408")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8214C", Offset = "0x1F8214C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000028CF File Offset: 0x00000ACF
		[global::Cpp2ILInjected.Token(Token = "0x170000D7")]
		public static Color yellow
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000409")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82160", Offset = "0x1F82160", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000028D2 File Offset: 0x00000AD2
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public static Color cyan
		{
			[global::Cpp2ILInjected.Token(Token = "0x600040A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8217C", Offset = "0x1F8217C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000028D5 File Offset: 0x00000AD5
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		public static Color gray
		{
			[global::Cpp2ILInjected.Token(Token = "0x600040B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82190", Offset = "0x1F82190", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000028D8 File Offset: 0x00000AD8
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		public static Color clear
		{
			[global::Cpp2ILInjected.Token(Token = "0x600040C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F821A4", Offset = "0x1F821A4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000028DB File Offset: 0x00000ADB
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		public Color linear
		{
			[global::Cpp2ILInjected.Token(Token = "0x600040D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F821B8", Offset = "0x1F821B8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000028DE File Offset: 0x00000ADE
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		public float maxColorComponent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600040E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F82214", Offset = "0x1F82214", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000028E1 File Offset: 0x00000AE1
		[global::Cpp2ILInjected.Token(Token = "0x600040F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82230", Offset = "0x1F82230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Vector4(Color c)
		{
			throw null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000028E4 File Offset: 0x00000AE4
		[global::Cpp2ILInjected.Token(Token = "0x6000410")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F82234", Offset = "0x1F82234", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Color(Vector4 v)
		{
			throw null;
		}

		// Token: 0x04000388 RID: 904
		[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float r;

		// Token: 0x04000389 RID: 905
		[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float g;

		// Token: 0x0400038A RID: 906
		[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float b;

		// Token: 0x0400038B RID: 907
		[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float a;
	}
}
