using System;
using System.Collections;
using System.Globalization;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200009F RID: 159
	[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
	[global::System.Serializable]
	public readonly struct Int32 : global::System.IComparable, global::System.IConvertible, global::System.IFormattable, global::System.IComparable<int>, global::System.IEquatable<int>, global::System.ISpanFormattable
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x0001596B File Offset: 0x00013B6B
		[global::Cpp2ILInjected.Token(Token = "0x6000792")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32AE8", Offset = "0x1C32AE8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_int", Member = "Compare", MemberParameters = new object[]
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

		// Token: 0x060006EE RID: 1774 RVA: 0x0001596E File Offset: 0x00013B6E
		[global::Cpp2ILInjected.Token(Token = "0x6000793")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32BB4", Offset = "0x1C32BB4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 142)]
		public int CompareTo(int value)
		{
			throw null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00015971 File Offset: 0x00013B71
		[global::Cpp2ILInjected.Token(Token = "0x6000794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32BD0", Offset = "0x1C32BD0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementTracker`1", Member = "SetValue", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OptionalInt32", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00015974 File Offset: 0x00013B74
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x6000795")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32C48", Offset = "0x1C32C48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(int obj)
		{
			throw null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00015977 File Offset: 0x00013B77
		[global::Cpp2ILInjected.Token(Token = "0x6000796")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32C58", Offset = "0x1C32C58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 55)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001597A File Offset: 0x00013B7A
		[global::Cpp2ILInjected.Token(Token = "0x6000797")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32C60", Offset = "0x1C32C60", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 671)]
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

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001597D File Offset: 0x00013B7D
		[global::Cpp2ILInjected.Token(Token = "0x6000798")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32CF4", Offset = "0x1C32CF4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPV6AddressFromIPV4", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.GamePadState", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.JoystickState", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureSettings", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "NewUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "NetscapeCertType", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = "Response", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"System.Net.HttpWebRequest"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
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

		// Token: 0x060006F4 RID: 1780 RVA: 0x00015980 File Offset: 0x00013B80
		[global::Cpp2ILInjected.Token(Token = "0x6000799")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32DA4", Offset = "0x1C32DA4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
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

		// Token: 0x060006F5 RID: 1781 RVA: 0x00015983 File Offset: 0x00013B83
		[global::Cpp2ILInjected.Token(Token = "0x600079A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32E3C", Offset = "0x1C32E3C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
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

		// Token: 0x060006F6 RID: 1782 RVA: 0x00015986 File Offset: 0x00013B86
		[global::Cpp2ILInjected.Token(Token = "0x600079B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32EF0", Offset = "0x1C32EF0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IPv6AddressHelper", Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigInteger", MemberParameters = new object[]
		{
			typeof(bool),
			"System.Numerics.BigInteger",
			typeof(string),
			"System.ReadOnlySpan`1<Char>",
			typeof(global::System.Globalization.NumberFormatInfo),
			"System.Span`1<Char>",
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
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

		// Token: 0x060006F7 RID: 1783 RVA: 0x00015989 File Offset: 0x00013B89
		[global::Cpp2ILInjected.Token(Token = "0x600079C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C32F90", Offset = "0x1C32F90", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMultiplayerJoin", Member = "ParsePort", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMultiplayerServerPort", Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.CodeAccessPermission), Member = "CheckSecurityElement", MemberParameters = new object[]
		{
			typeof(global::System.Security.SecurityElement),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerPrefix", Member = "CheckUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "FromXml", MemberParameters = new object[]
		{
			typeof(global::System.Collections.ArrayList),
			"System.Net.NetworkAccess"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermissionAttribute", Member = "CreatePermission", ReturnType = typeof(global::System.Security.IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int Parse(string s)
		{
			throw null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001598C File Offset: 0x00013B8C
		[global::Cpp2ILInjected.Token(Token = "0x600079D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33050", Offset = "0x1C33050", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkParser", Member = "GetChunkSize", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(ref int),
			typeof(int)
		}, ReturnType = "System.Net.MonoChunkParser.State")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int Parse(string s, global::System.Globalization.NumberStyles style)
		{
			throw null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001598F File Offset: 0x00013B8F
		[global::Cpp2ILInjected.Token(Token = "0x600079E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33128", Offset = "0x1C33128", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int Parse(string s, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00015992 File Offset: 0x00013B92
		[global::Cpp2ILInjected.Token(Token = "0x600079F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C331F8", Offset = "0x1C331F8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Int32Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int Parse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00015995 File Offset: 0x00013B95
		[global::Cpp2ILInjected.Token(Token = "0x60007A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C332D8", Offset = "0x1C332D8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "TryParseComponent", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "ParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Parse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style = global::System.Globalization.NumberStyles.Integer, global::System.IFormatProvider provider = null)
		{
			throw null;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00015998 File Offset: 0x00013B98
		[global::Cpp2ILInjected.Token(Token = "0x60007A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33374", Offset = "0x1C33374", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse(string s, out int result)
		{
			throw null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001599B File Offset: 0x00013B9B
		[global::Cpp2ILInjected.Token(Token = "0x60007A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33444", Offset = "0x1C33444", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseMDateRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref int),
			typeof(ref global::System.DayOfWeek)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool TryParse(global::System.ReadOnlySpan<char> s, out int result)
		{
			throw null;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001599E File Offset: 0x00013B9E
		[global::Cpp2ILInjected.Token(Token = "0x60007A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C334C8", Offset = "0x1C334C8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Chat.ColorTagHandler", Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
		{
			typeof(string),
			"Microsoft.Xna.Framework.Graphics.Color",
			typeof(string)
		}, ReturnType = "Terraria.UI.Chat.TextSnippet")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "AppendUnicodeCodePointValuePercentEncoded", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadInt32String", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Nullable`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryParse(string s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out int result)
		{
			throw null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000159A1 File Offset: 0x00013BA1
		[global::Cpp2ILInjected.Token(Token = "0x60007A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C335BC", Offset = "0x1C335BC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "TryParseComponent", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new object[] { typeof(global::System.Globalization.NumberStyles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.NumberFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.Globalization.NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Number), Member = "TryParseInt32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool TryParse(global::System.ReadOnlySpan<char> s, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, out int result)
		{
			throw null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000159A4 File Offset: 0x00013BA4
		[global::Cpp2ILInjected.Token(Token = "0x60007A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33660", Offset = "0x1C33660", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000159A7 File Offset: 0x00013BA7
		[global::Cpp2ILInjected.Token(Token = "0x60007A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33668", Offset = "0x1C33668", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000159AA File Offset: 0x00013BAA
		[global::Cpp2ILInjected.Token(Token = "0x60007A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C336C4", Offset = "0x1C336C4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000159AD File Offset: 0x00013BAD
		[global::Cpp2ILInjected.Token(Token = "0x60007A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33720", Offset = "0x1C33720", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000159B0 File Offset: 0x00013BB0
		[global::Cpp2ILInjected.Token(Token = "0x60007A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3377C", Offset = "0x1C3377C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000159B3 File Offset: 0x00013BB3
		[global::Cpp2ILInjected.Token(Token = "0x60007AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C337D8", Offset = "0x1C337D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000159B6 File Offset: 0x00013BB6
		[global::Cpp2ILInjected.Token(Token = "0x60007AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33834", Offset = "0x1C33834", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000159B9 File Offset: 0x00013BB9
		[global::Cpp2ILInjected.Token(Token = "0x60007AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33890", Offset = "0x1C33890", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000159BC File Offset: 0x00013BBC
		[global::Cpp2ILInjected.Token(Token = "0x60007AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33898", Offset = "0x1C33898", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000159BF File Offset: 0x00013BBF
		[global::Cpp2ILInjected.Token(Token = "0x60007AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C338F4", Offset = "0x1C338F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000159C2 File Offset: 0x00013BC2
		[global::Cpp2ILInjected.Token(Token = "0x60007AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33950", Offset = "0x1C33950", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000159C5 File Offset: 0x00013BC5
		[global::Cpp2ILInjected.Token(Token = "0x60007B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C339AC", Offset = "0x1C339AC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000159C8 File Offset: 0x00013BC8
		[global::Cpp2ILInjected.Token(Token = "0x60007B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33A08", Offset = "0x1C33A08", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000159CB File Offset: 0x00013BCB
		[global::Cpp2ILInjected.Token(Token = "0x60007B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33A64", Offset = "0x1C33A64", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000159CE File Offset: 0x00013BCE
		[global::Cpp2ILInjected.Token(Token = "0x60007B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33AC0", Offset = "0x1C33AC0", Length = "0x80")]
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

		// Token: 0x0600070F RID: 1807 RVA: 0x000159D1 File Offset: 0x00013BD1
		[global::Cpp2ILInjected.Token(Token = "0x60007B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C33B40", Offset = "0x1C33B40", Length = "0xAC")]
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

		// Token: 0x04000211 RID: 529
		[global::Cpp2ILInjected.Token(Token = "0x400035E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int m_value;

		// Token: 0x04000212 RID: 530
		[global::Cpp2ILInjected.Token(Token = "0x400035F")]
		public const int MaxValue = 2147483647;

		// Token: 0x04000213 RID: 531
		[global::Cpp2ILInjected.Token(Token = "0x4000360")]
		public const int MinValue = -2147483648;
	}
}
