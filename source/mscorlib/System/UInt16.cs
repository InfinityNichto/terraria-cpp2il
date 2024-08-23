using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000E2 RID: 226
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000114")]
	[global::System.Serializable]
	public readonly struct UInt16 : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<ushort>, global::System.IEquatable<ushort>, global::System.ISpanFormattable
	{
		// Token: 0x060009FE RID: 2558 RVA: 0x00016202 File Offset: 0x00014402
		[global::Cpp2ILInjected.Token(Token = "0x6000AA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C506A0", Offset = "0x1C506A0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_unsignedShort", Member = "Compare", MemberParameters = new object[]
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

		// Token: 0x060009FF RID: 2559 RVA: 0x00016205 File Offset: 0x00014405
		[global::Cpp2ILInjected.Token(Token = "0x6000AA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5075C", Offset = "0x1C5075C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int CompareTo(ushort value)
		{
			throw null;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00016208 File Offset: 0x00014408
		[global::Cpp2ILInjected.Token(Token = "0x6000AA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50768", Offset = "0x1C50768", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt16", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0001620B File Offset: 0x0001440B
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C507E0", Offset = "0x1C507E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ushort obj)
		{
			throw null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0001620E File Offset: 0x0001440E
		[global::Cpp2ILInjected.Token(Token = "0x6000AAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C507F0", Offset = "0x1C507F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Bgr565", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Bgra4444", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.Bgra5551", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.HalfSingle", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte2", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Numerics.Vector<>), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInputDeviceDriverType", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInputDeviceTransportType", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt16", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00016211 File Offset: 0x00014411
		[global::Cpp2ILInjected.Token(Token = "0x6000AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C507F8", Offset = "0x1C507F8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Tile_PC", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.TileDestroyedCondition", Member = ".ctor", MemberParameters = new object[] { "LocalUser", "System.UInt16[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.KeyCombo", Member = "Load", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "LoadData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00016214 File Offset: 0x00014414
		[global::Cpp2ILInjected.Token(Token = "0x6000AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50890", Offset = "0x1C50890", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "ReCreateParts", MemberParameters = new object[]
		{
			"System.UriComponents",
			typeof(ushort),
			"System.UriFormat"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetUriPartsFromUserString", MemberParameters = new object[] { "System.UriComponents" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetComponentsHelper", MemberParameters = new object[] { "System.UriComponents", "System.UriFormat" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalUInt16", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00016217 File Offset: 0x00014417
		[global::Cpp2ILInjected.Token(Token = "0x6000AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5092C", Offset = "0x1C5092C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PackedVector.NormalizedByte2", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001621A File Offset: 0x0001441A
		[global::Cpp2ILInjected.Token(Token = "0x6000AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C509E0", Offset = "0x1C509E0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt16Converter", Member = "ToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToString(string format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001621D File Offset: 0x0001441D
		[global::Cpp2ILInjected.Token(Token = "0x6000AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50A98", Offset = "0x1C50A98", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IPv6AddressHelper", Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
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

		// Token: 0x06000A08 RID: 2568 RVA: 0x00016220 File Offset: 0x00014420
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50B3C", Offset = "0x1C50B3C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerPrefix", Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static ushort Parse(string s)
		{
			throw null;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00016223 File Offset: 0x00014423
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50D38", Offset = "0x1C50D38", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static ushort Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00016226 File Offset: 0x00014426
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50DB0", Offset = "0x1C50DB0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt16Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static ushort Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00016229 File Offset: 0x00014429
		[global::Cpp2ILInjected.Token(Token = "0x6000AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50BAC", Offset = "0x1C50BAC", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static ushort Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info)
		{
			throw null;
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0001622C File Offset: 0x0001442C
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50E40", Offset = "0x1C50E40", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ServiceNameCollection", Member = "NormalizeServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ushort)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out ushort result)
		{
			throw null;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0001622F File Offset: 0x0001442F
		[global::Cpp2ILInjected.Token(Token = "0x6000AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50EE8", Offset = "0x1C50EE8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseUInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.Globalization.NumberFormatInfo info, out ushort result)
		{
			throw null;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00016232 File Offset: 0x00014432
		[global::Cpp2ILInjected.Token(Token = "0x6000AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50FA4", Offset = "0x1C50FA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00016235 File Offset: 0x00014435
		[global::Cpp2ILInjected.Token(Token = "0x6000AB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50FAC", Offset = "0x1C50FAC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00016238 File Offset: 0x00014438
		[global::Cpp2ILInjected.Token(Token = "0x6000AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51008", Offset = "0x1C51008", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0001623B File Offset: 0x0001443B
		[global::Cpp2ILInjected.Token(Token = "0x6000AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51064", Offset = "0x1C51064", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0001623E File Offset: 0x0001443E
		[global::Cpp2ILInjected.Token(Token = "0x6000ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C510C0", Offset = "0x1C510C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00016241 File Offset: 0x00014441
		[global::Cpp2ILInjected.Token(Token = "0x6000ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5111C", Offset = "0x1C5111C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00016244 File Offset: 0x00014444
		[global::Cpp2ILInjected.Token(Token = "0x6000ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51178", Offset = "0x1C51178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00016247 File Offset: 0x00014447
		[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51180", Offset = "0x1C51180", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0001624A File Offset: 0x0001444A
		[global::Cpp2ILInjected.Token(Token = "0x6000ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C511DC", Offset = "0x1C511DC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0001624D File Offset: 0x0001444D
		[global::Cpp2ILInjected.Token(Token = "0x6000ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51238", Offset = "0x1C51238", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00016250 File Offset: 0x00014450
		[global::Cpp2ILInjected.Token(Token = "0x6000AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51294", Offset = "0x1C51294", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00016253 File Offset: 0x00014453
		[global::Cpp2ILInjected.Token(Token = "0x6000AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C512F0", Offset = "0x1C512F0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00016256 File Offset: 0x00014456
		[global::Cpp2ILInjected.Token(Token = "0x6000AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5134C", Offset = "0x1C5134C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00016259 File Offset: 0x00014459
		[global::Cpp2ILInjected.Token(Token = "0x6000AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C513A8", Offset = "0x1C513A8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001625C File Offset: 0x0001445C
		[global::Cpp2ILInjected.Token(Token = "0x6000AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51404", Offset = "0x1C51404", Length = "0x84")]
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

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001625F File Offset: 0x0001445F
		[global::Cpp2ILInjected.Token(Token = "0x6000AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C51488", Offset = "0x1C51488", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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

		// Token: 0x040002A4 RID: 676
		[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly ushort m_value;

		// Token: 0x040002A5 RID: 677
		[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
		public const ushort MaxValue = 65535;

		// Token: 0x040002A6 RID: 678
		[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
		public const ushort MinValue = 0;
	}
}
