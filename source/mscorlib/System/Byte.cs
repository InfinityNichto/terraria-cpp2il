using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.Versioning;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System
{
	// Token: 0x0200006C RID: 108
	[global::Cpp2ILInjected.Token(Token = "0x2000093")]
	[global::System.Serializable]
	public readonly struct Byte : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<byte>, global::System.IEquatable<byte>, global::System.ISpanFormattable
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00015023 File Offset: 0x00013223
		[global::Cpp2ILInjected.Token(Token = "0x6000446")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB915C", Offset = "0x1BB915C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "Max", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedByte", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00015026 File Offset: 0x00013226
		[global::Cpp2ILInjected.Token(Token = "0x6000447")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9214", Offset = "0x1BB9214", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_25", Member = "<.cctor>b__89", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSorting.ItemSortingLayers.<>c__DisplayClass39_31", Member = "<.cctor>b__101", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ByteArrayCompare", MemberParameters = new object[] { "System.Byte[]", "System.Byte[]" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public int CompareTo(byte value)
		{
			throw null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00015029 File Offset: 0x00013229
		[global::Cpp2ILInjected.Token(Token = "0x6000448")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9220", Offset = "0x1BB9220", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0001502C File Offset: 0x0001322C
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000449")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9298", Offset = "0x1BB9298", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T&",
			"T",
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public bool Equals(byte obj)
		{
			throw null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0001502F File Offset: 0x0001322F
		[global::Cpp2ILInjected.Token(Token = "0x600044A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB92A8", Offset = "0x1BB92A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Alpha8", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ByteEqualityComparer), Member = "GetHashCode", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00015032 File Offset: 0x00013232
		[global::Cpp2ILInjected.Token(Token = "0x600044B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB92B0", Offset = "0x1BB92B0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00015035 File Offset: 0x00013235
		[global::Cpp2ILInjected.Token(Token = "0x600044C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB94D0", Offset = "0x1BB94D0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ByteConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00015038 File Offset: 0x00013238
		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB933C", Offset = "0x1BB933C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static byte Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001503B File Offset: 0x0001323B
		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9574", Offset = "0x1BB9574", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AddPercentEncodedOctetToRawOctetsList", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref byte)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out byte result)
		{
			throw null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0001503E File Offset: 0x0001323E
		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB961C", Offset = "0x1BB961C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info, out byte result)
		{
			throw null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00015041 File Offset: 0x00013241
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB96D8", Offset = "0x1BB96D8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "ProcessData", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Tile_PC", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.ItemTagHandler", Member = "GenerateTag", MemberParameters = new object[] { "Terraria.Item" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00015044 File Offset: 0x00013244
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9770", Offset = "0x1BB9770", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIClothesWindow", Member = "DrawHSLSlider", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIHairWindow", Member = "DrawHSLSlider", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIPlayerCreateMenu", Member = "DrawHSLSlider", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "Hex3", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Color" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "Hex4", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Color" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.ASN1), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "Default", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "GetAuthorityKeyIdentifier", MemberParameters = new object[] { "Mono.Security.X509.X509Extension" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Extension", Member = "FormatUnkownData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509KeyUsageExtension", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509SubjectKeyIdentifierExtension", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = "HashToHexString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00015047 File Offset: 0x00013247
		[global::Cpp2ILInjected.Token(Token = "0x6000452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9824", Offset = "0x1BB9824", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketAddress", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToOid", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001504A File Offset: 0x0001324A
		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB98C0", Offset = "0x1BB98C0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendSpanFormattable", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "HandleSatelliteMissing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AppendOctetsPercentEncoded", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			"System.Collections.Generic.IEnumerable`1<Byte>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "GetOctetsAsString", MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<Byte>" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ByteConverter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Color32", Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Extension", Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "GetUniqueName", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.Extensions.AuthorityKeyIdentifierExtension", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.Extensions.SubjectKeyIdentifierExtension", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "ToHex", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001504D File Offset: 0x0001324D
		[global::Cpp2ILInjected.Token(Token = "0x6000454")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9978", Offset = "0x1BB9978", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IPv4AddressHelper", Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
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

		// Token: 0x060003BB RID: 955 RVA: 0x00015050 File Offset: 0x00013250
		[global::Cpp2ILInjected.Token(Token = "0x6000455")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9A1C", Offset = "0x1BB9A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00015053 File Offset: 0x00013253
		[global::Cpp2ILInjected.Token(Token = "0x6000456")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9A24", Offset = "0x1BB9A24", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00015056 File Offset: 0x00013256
		[global::Cpp2ILInjected.Token(Token = "0x6000457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9A8C", Offset = "0x1BB9A8C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00015059 File Offset: 0x00013259
		[global::Cpp2ILInjected.Token(Token = "0x6000458")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9AEC", Offset = "0x1BB9AEC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0001505C File Offset: 0x0001325C
		[global::Cpp2ILInjected.Token(Token = "0x6000459")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9B9C", Offset = "0x1BB9B9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0001505F File Offset: 0x0001325F
		[global::Cpp2ILInjected.Token(Token = "0x600045A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9BA4", Offset = "0x1BB9BA4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00015062 File Offset: 0x00013262
		[global::Cpp2ILInjected.Token(Token = "0x600045B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9C04", Offset = "0x1BB9C04", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00015065 File Offset: 0x00013265
		[global::Cpp2ILInjected.Token(Token = "0x600045C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9C64", Offset = "0x1BB9C64", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00015068 File Offset: 0x00013268
		[global::Cpp2ILInjected.Token(Token = "0x600045D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9CC4", Offset = "0x1BB9CC4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001506B File Offset: 0x0001326B
		[global::Cpp2ILInjected.Token(Token = "0x600045E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9D24", Offset = "0x1BB9D24", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001506E File Offset: 0x0001326E
		[global::Cpp2ILInjected.Token(Token = "0x600045F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9D84", Offset = "0x1BB9D84", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00015071 File Offset: 0x00013271
		[global::Cpp2ILInjected.Token(Token = "0x6000460")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9DE4", Offset = "0x1BB9DE4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00015074 File Offset: 0x00013274
		[global::Cpp2ILInjected.Token(Token = "0x6000461")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9E48", Offset = "0x1BB9E48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00015077 File Offset: 0x00013277
		[global::Cpp2ILInjected.Token(Token = "0x6000462")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9EAC", Offset = "0x1BB9EAC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0001507A File Offset: 0x0001327A
		[global::Cpp2ILInjected.Token(Token = "0x6000463")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9F5C", Offset = "0x1BB9F5C", Length = "0x84")]
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

		// Token: 0x060003CA RID: 970 RVA: 0x0001507D File Offset: 0x0001327D
		[global::Cpp2ILInjected.Token(Token = "0x6000464")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9FE0", Offset = "0x1BB9FE0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly byte m_value;

		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x4000208")]
		public const byte MaxValue = 255;

		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		public const byte MinValue = 0;
	}
}
