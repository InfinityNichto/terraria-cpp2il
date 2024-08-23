using System;
using System.Globalization;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000E4 RID: 228
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000116")]
	[global::System.Serializable]
	public readonly struct UInt64 : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<ulong>, global::System.IEquatable<ulong>, global::System.ISpanFormattable
	{
		// Token: 0x06000A3C RID: 2620 RVA: 0x000162BC File Offset: 0x000144BC
		[global::Cpp2ILInjected.Token(Token = "0x6000AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C522C4", Offset = "0x1C522C4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000162BF File Offset: 0x000144BF
		[global::Cpp2ILInjected.Token(Token = "0x6000AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52390", Offset = "0x1C52390", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(ulong value)
		{
			throw null;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000162C2 File Offset: 0x000144C2
		[global::Cpp2ILInjected.Token(Token = "0x6000AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C523AC", Offset = "0x1C523AC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000162C5 File Offset: 0x000144C5
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000AE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52424", Offset = "0x1C52424", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", Member = "Equals", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", Member = "op_Equality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", Member = "op_Inequality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", Member = "op_Inequality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", Member = "op_Equality", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", Member = "Equals", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public bool Equals(ulong obj)
		{
			throw null;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000162C8 File Offset: 0x000144C8
		[global::Cpp2ILInjected.Token(Token = "0x6000AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52434", Offset = "0x1C52434", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfVector4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Rgba64", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Short4", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.KeyBindingSource", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.KeyCombo", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000162CB File Offset: 0x000144CB
		[global::Cpp2ILInjected.Token(Token = "0x6000AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52440", Offset = "0x1C52440", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.NetGroupInfo.SteamLobbyInfoProvider", Member = "ProvideInfoNeededToJoin", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UIntPtr), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000162CE File Offset: 0x000144CE
		[global::Cpp2ILInjected.Token(Token = "0x6000AEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C524D8", Offset = "0x1C524D8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonToken" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToOid", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000162D1 File Offset: 0x000144D1
		[global::Cpp2ILInjected.Token(Token = "0x6000AEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52574", Offset = "0x1C52574", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedShort4", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Short4", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x000162D4 File Offset: 0x000144D4
		[global::Cpp2ILInjected.Token(Token = "0x6000AEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52628", Offset = "0x1C52628", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt64Converter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000162D7 File Offset: 0x000144D7
		[global::Cpp2ILInjected.Token(Token = "0x6000AED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C526E0", Offset = "0x1C526E0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format = default(global::System.ReadOnlySpan<char>), global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000162DA File Offset: 0x000144DA
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52784", Offset = "0x1C52784", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static ulong Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000162DD File Offset: 0x000144DD
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52848", Offset = "0x1C52848", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt64Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static ulong Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000162E0 File Offset: 0x000144E0
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5291C", Offset = "0x1C5291C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ulong)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt64", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out ulong result)
		{
			throw null;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000162E3 File Offset: 0x000144E3
		[global::Cpp2ILInjected.Token(Token = "0x6000AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52A14", Offset = "0x1C52A14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000162E6 File Offset: 0x000144E6
		[global::Cpp2ILInjected.Token(Token = "0x6000AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52A1C", Offset = "0x1C52A1C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000162E9 File Offset: 0x000144E9
		[global::Cpp2ILInjected.Token(Token = "0x6000AF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52A78", Offset = "0x1C52A78", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000162EC File Offset: 0x000144EC
		[global::Cpp2ILInjected.Token(Token = "0x6000AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52AD4", Offset = "0x1C52AD4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000162EF File Offset: 0x000144EF
		[global::Cpp2ILInjected.Token(Token = "0x6000AF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52B30", Offset = "0x1C52B30", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000162F2 File Offset: 0x000144F2
		[global::Cpp2ILInjected.Token(Token = "0x6000AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52B8C", Offset = "0x1C52B8C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000162F5 File Offset: 0x000144F5
		[global::Cpp2ILInjected.Token(Token = "0x6000AF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52BE8", Offset = "0x1C52BE8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000162F8 File Offset: 0x000144F8
		[global::Cpp2ILInjected.Token(Token = "0x6000AF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52C44", Offset = "0x1C52C44", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000162FB File Offset: 0x000144FB
		[global::Cpp2ILInjected.Token(Token = "0x6000AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52CA0", Offset = "0x1C52CA0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000162FE File Offset: 0x000144FE
		[global::Cpp2ILInjected.Token(Token = "0x6000AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52CFC", Offset = "0x1C52CFC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00016301 File Offset: 0x00014501
		[global::Cpp2ILInjected.Token(Token = "0x6000AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52D58", Offset = "0x1C52D58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00016304 File Offset: 0x00014504
		[global::Cpp2ILInjected.Token(Token = "0x6000AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52D60", Offset = "0x1C52D60", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00016307 File Offset: 0x00014507
		[global::Cpp2ILInjected.Token(Token = "0x6000AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52DBC", Offset = "0x1C52DBC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001630A File Offset: 0x0001450A
		[global::Cpp2ILInjected.Token(Token = "0x6000AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52E18", Offset = "0x1C52E18", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001630D File Offset: 0x0001450D
		[global::Cpp2ILInjected.Token(Token = "0x6000AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52E74", Offset = "0x1C52E74", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00016310 File Offset: 0x00014510
		[global::Cpp2ILInjected.Token(Token = "0x6000B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C52EF8", Offset = "0x1C52EF8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x040002AA RID: 682
		[global::Cpp2ILInjected.Token(Token = "0x40003FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ulong m_value;

		// Token: 0x040002AB RID: 683
		[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
		public const ulong MaxValue = 18446744073709551615UL;

		// Token: 0x040002AC RID: 684
		[global::Cpp2ILInjected.Token(Token = "0x40003FE")]
		public const ulong MinValue = 0UL;
	}
}
