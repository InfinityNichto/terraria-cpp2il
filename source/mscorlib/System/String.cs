using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Cryptography;
using System.Security.Util;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography;
using Mono;
using Mono.Globalization.Unicode;
using Mono.Security.Cryptography;
using Mono.Xml;

namespace System
{
	// Token: 0x0200004C RID: 76
	[global::Cpp2ILInjected.Token(Token = "0x2000067")]
	[global::System.Serializable]
	public sealed class String : global::System.IComparable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<char>, global::System.IComparable<string>, global::System.IEquatable<string>, global::System.IConvertible, global::System.ICloneable
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00014B52 File Offset: 0x00012D52
		[global::Cpp2ILInjected.Token(Token = "0x6000243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7440", Offset = "0x1AC7440", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[MethodImpl(256)]
		private static bool EqualsHelper(string strA, string strB)
		{
			throw null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00014B55 File Offset: 0x00012D55
		[global::Cpp2ILInjected.Token(Token = "0x6000244")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7460", Offset = "0x1AC7460", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[MethodImpl(256)]
		private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00014B58 File Offset: 0x00012D58
		[global::Cpp2ILInjected.Token(Token = "0x6000245")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7484", Offset = "0x1AC7484", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static int CompareOrdinalHelper(string strA, string strB)
		{
			throw null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00014B5B File Offset: 0x00012D5B
		[global::Cpp2ILInjected.Token(Token = "0x6000246")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7618", Offset = "0x1AC7618", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SoundID.<>c", Member = "<FillAccessMap>b__495_1", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int Compare(string strA, string strB)
		{
			throw null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00014B5E File Offset: 0x00012D5E
		[global::Cpp2ILInjected.Token(Token = "0x6000247")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC789C", Offset = "0x1AC789C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.AuthenticationManager", Member = "DoUnregister", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndpointPermission", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseAuthentication", MemberParameters = new object[] { "System.Net.AuthenticationSchemes" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermission", Member = "FromXml", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketPermissionAttribute", Member = "CreatePermission", ReturnType = typeof(global::System.Security.IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "GetResponse", MemberParameters = new object[]
		{
			"System.Net.BufferOffsetSize",
			typeof(ref int),
			"System.Net.ReadState&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public static int Compare(string strA, string strB, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00014B61 File Offset: 0x00012D61
		[global::Cpp2ILInjected.Token(Token = "0x6000248")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7620", Offset = "0x1AC7620", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 88)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static int Compare(string strA, string strB, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00014B64 File Offset: 0x00012D64
		[global::Cpp2ILInjected.Token(Token = "0x6000249")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC78C0", Offset = "0x1AC78C0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int Compare(string strA, string strB, global::System.Globalization.CultureInfo culture, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00014B67 File Offset: 0x00012D67
		[global::Cpp2ILInjected.Token(Token = "0x600024A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7950", Offset = "0x1AC7950", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.CodeAccessPermission), Member = "IsUnrestricted", MemberParameters = new object[] { typeof(global::System.Security.SecurityElement) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReferenceConverter.ReferenceComparer", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "OnINotifyPropertyChanged", MemberParameters = new object[]
		{
			typeof(object),
			"System.ComponentModel.PropertyChangedEventArgs"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.MemberDescriptorComparer", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		public static int Compare(string strA, string strB, bool ignoreCase, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00014B6A File Offset: 0x00012D6A
		[global::Cpp2ILInjected.Token(Token = "0x600024B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7960", Offset = "0x1AC7960", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "FilterNameIgnoreCaseImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "GetTokens", MemberParameters = new object[]
		{
			typeof(global::System.Security.Util.TokenizerStream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "CompareNames", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Reflection.AssemblyName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Module), Member = "FilterTypeNameIgnoreCaseImpl", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialKey", Member = "IsPrefix", MemberParameters = new object[] { "System.Uri", "System.Uri" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "Create", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(bool)
		}, ReturnType = "System.Net.WebRequest")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "IsDomainEqualToHost", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			"System.Net.CookieVariant",
			"System.Uri",
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "IsLocalDomain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = "IsLocal", MemberParameters = new object[] { "System.Uri" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static int Compare(string strA, int indexA, string strB, int indexB, int length, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00014B6D File Offset: 0x00012D6D
		[global::Cpp2ILInjected.Token(Token = "0x600024C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7D5C", Offset = "0x1AC7D5C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalComparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalCaseSensitiveComparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FastResourceComparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FastResourceComparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "CheckIriUnicodeRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl.NodeData", Member = "System.IComparable.CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		public static int CompareOrdinal(string strA, string strB)
		{
			throw null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00014B70 File Offset: 0x00012D70
		[global::Cpp2ILInjected.Token(Token = "0x600024D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7DA0", Offset = "0x1AC7DA0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		internal static int CompareOrdinal(global::System.ReadOnlySpan<char> strA, global::System.ReadOnlySpan<char> strB)
		{
			throw null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00014B73 File Offset: 0x00012D73
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7E40", Offset = "0x1AC7E40", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexBoyerMoore", Member = "MatchPattern", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XHashtable`1.XHashtableState", Member = "FindEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNamespace", Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = "System.Xml.Linq.XNamespace")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			throw null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00014B76 File Offset: 0x00012D76
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8038", Offset = "0x1AC8038", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int CompareTo(object value)
		{
			throw null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00014B79 File Offset: 0x00012D79
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC80F4", Offset = "0x1AC80F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIItemDuplication", Member = "CompareItemOrder", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "WorldListSortMethod", MemberParameters = new object[] { "Terraria.IO.WorldFileData", "Terraria.IO.WorldFileData" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "PlayerListSortMethod", MemberParameters = new object[] { "Terraria.IO.PlayerFileData", "Terraria.IO.PlayerFileData" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.SortingSteps.Alphabetical", Member = "Compare", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry", "Terraria.GameContent.Bestiary.BestiaryEntry" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.SortingSteps.Alphabetical", Member = "Compare", MemberParameters = new object[] { "Terraria.Item", "Terraria.Item" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public int CompareTo(string strB)
		{
			throw null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00014B7C File Offset: 0x00012D7C
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC80FC", Offset = "0x1AC80FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		public bool EndsWith(string value)
		{
			throw null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00014B7F File Offset: 0x00012D7F
		[global::Cpp2ILInjected.Token(Token = "0x6000252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8104", Offset = "0x1AC8104", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<LoadWorlds>b__1785_0", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<LoadPlayers>b__1787_0", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData.<>c__DisplayClass14_0", Member = "<MoveToLocal>b__0", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.PlayerFileData", Member = "MapBelongsToPath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityElement), Member = "SearchForTextOfLocalName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "IsSuffix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequest", Member = "RegisterPrefix", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.IWebRequestCreate"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonPosition", Member = "FormatMessage", MemberParameters = new object[]
		{
			"Newtonsoft.Json.IJsonLineInfo",
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public bool EndsWith(string value, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00014B82 File Offset: 0x00012D82
		[global::Cpp2ILInjected.Token(Token = "0x6000253")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8388", Offset = "0x1AC8388", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		public bool EndsWith(char value)
		{
			throw null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00014B85 File Offset: 0x00012D85
		[global::Cpp2ILInjected.Token(Token = "0x6000254")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC83D8", Offset = "0x1AC83D8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00014B88 File Offset: 0x00012D88
		[global::Cpp2ILInjected.Token(Token = "0x6000255")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8474", Offset = "0x1AC8474", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 127)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		public bool Equals(string value)
		{
			throw null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00014B8B File Offset: 0x00012D8B
		[global::Cpp2ILInjected.Token(Token = "0x6000256")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC84B4", Offset = "0x1AC84B4", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.DateTimeFormatInfo),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public bool Equals(string value, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00014B8E File Offset: 0x00012D8E
		[global::Cpp2ILInjected.Token(Token = "0x6000257")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8718", Offset = "0x1AC8718", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalCaseSensitiveComparer), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FastResourceComparer), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FastResourceComparer), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReferenceConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlNamespaceManager", Member = "RemoveNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlNamespaceManager", Member = "LookupNamespaceDecl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlNamespaceManager", Member = "LookupPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils", Member = "WriteEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextWriter),
			typeof(string),
			typeof(char),
			typeof(bool),
			"System.Boolean[]",
			"Newtonsoft.Json.StringEscapeHandling",
			"Newtonsoft.Json.IArrayPool`1<Char>",
			"System.Char[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		public static bool Equals(string a, string b)
		{
			throw null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00014B91 File Offset: 0x00012D91
		[global::Cpp2ILInjected.Token(Token = "0x6000258")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8764", Offset = "0x1AC8764", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static bool Equals(string a, string b, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00014B94 File Offset: 0x00012D94
		[global::Cpp2ILInjected.Token(Token = "0x6000259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD080", Offset = "0x1ABD080", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1493)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public static bool operator ==(string a, string b)
		{
			throw null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00014B97 File Offset: 0x00012D97
		[global::Cpp2ILInjected.Token(Token = "0x600025A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC89C8", Offset = "0x1AC89C8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 255)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(string a, string b)
		{
			throw null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00014B9A File Offset: 0x00012D9A
		[global::Cpp2ILInjected.Token(Token = "0x600025B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC89E0", Offset = "0x1AC89E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00014B9D File Offset: 0x00012D9D
		[global::Cpp2ILInjected.Token(Token = "0x600025C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC89E4", Offset = "0x1AC89E4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int GetLegacyNonRandomizedHashCode()
		{
			throw null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00014BA0 File Offset: 0x00012DA0
		[global::Cpp2ILInjected.Token(Token = "0x600025D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8A34", Offset = "0x1AC8A34", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 79)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool StartsWith(string value)
		{
			throw null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00014BA3 File Offset: 0x00012DA3
		[global::Cpp2ILInjected.Token(Token = "0x600025E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8A8C", Offset = "0x1AC8A8C", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public bool StartsWith(string value, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00014BA6 File Offset: 0x00012DA6
		[global::Cpp2ILInjected.Token(Token = "0x600025F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC78A4", Offset = "0x1AC78A4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		internal static void CheckStringComparison(global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00014BA9 File Offset: 0x00012DA9
		[global::Cpp2ILInjected.Token(Token = "0x6000260")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8D28", Offset = "0x1AC8D28", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "JoinCore", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static void FillStringChecked(string dest, int destPos, string src)
		{
			throw null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00014BAC File Offset: 0x00012DAC
		[global::Cpp2ILInjected.Token(Token = "0x6000261")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8D9C", Offset = "0x1AC8D9C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string Concat(object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00014BAF File Offset: 0x00012DAF
		[global::Cpp2ILInjected.Token(Token = "0x6000262")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8E34", Offset = "0x1AC8E34", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "FormatValueForPrint", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalBase", Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			"Newtonsoft.Json.Serialization.JsonContract",
			typeof(object),
			"Newtonsoft.Json.IJsonLineInfo",
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string Concat(object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00014BB2 File Offset: 0x00012DB2
		[global::Cpp2ILInjected.Token(Token = "0x6000263")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABCFA4", Offset = "0x1ABCFA4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1211)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string Concat(string str0, string str1)
		{
			throw null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00014BB5 File Offset: 0x00012DB5
		[global::Cpp2ILInjected.Token(Token = "0x6000264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8F04", Offset = "0x1AC8F04", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 488)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string Concat(string str0, string str1, string str2)
		{
			throw null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00014BB8 File Offset: 0x00012DB8
		[global::Cpp2ILInjected.Token(Token = "0x6000265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8FE4", Offset = "0x1AC8FE4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 162)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string Concat(string str0, string str1, string str2, string str3)
		{
			throw null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00014BBB File Offset: 0x00012DBB
		[global::Cpp2ILInjected.Token(Token = "0x6000266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC90EC", Offset = "0x1AC90EC", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 129)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static string Concat(params string[] values)
		{
			throw null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00014BBE File Offset: 0x00012DBE
		[global::Cpp2ILInjected.Token(Token = "0x6000267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0BC0", Offset = "0x1AC0BC0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 248)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		public static string Format(string format, object arg0)
		{
			throw null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00014BC1 File Offset: 0x00012DC1
		[global::Cpp2ILInjected.Token(Token = "0x6000268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC9398", Offset = "0x1AC9398", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 112)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		public static string Format(string format, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00014BC4 File Offset: 0x00012DC4
		[global::Cpp2ILInjected.Token(Token = "0x6000269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC93DC", Offset = "0x1AC93DC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 47)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		public static string Format(string format, object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00014BC7 File Offset: 0x00012DC7
		[global::Cpp2ILInjected.Token(Token = "0x600026A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC9420", Offset = "0x1AC9420", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string Format(string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00014BCA File Offset: 0x00012DCA
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC94C8", Offset = "0x1AC94C8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		public static string Format(global::System.IFormatProvider provider, string format, object arg0)
		{
			throw null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00014BCD File Offset: 0x00012DCD
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC951C", Offset = "0x1AC951C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		public static string Format(global::System.IFormatProvider provider, string format, object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00014BD0 File Offset: 0x00012DD0
		[global::Cpp2ILInjected.Token(Token = "0x600026D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC9574", Offset = "0x1AC9574", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeLoadException), Member = "SetMessageField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.TextWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(string),
			"System.Diagnostics.TraceEventType",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		public static string Format(global::System.IFormatProvider provider, string format, object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00014BD3 File Offset: 0x00012DD3
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC95D0", Offset = "0x1AC95D0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string Format(global::System.IFormatProvider provider, string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00014BD6 File Offset: 0x00012DD6
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC92DC", Offset = "0x1AC92DC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.SymmetricTransform), Member = "ThrowBadPaddingException", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.PaddingMode),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string FormatHelper(global::System.IFormatProvider provider, string format, global::System.ParamsArray args)
		{
			throw null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00014BD9 File Offset: 0x00012DD9
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC9680", Offset = "0x1AC9680", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UITextBox", Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetLocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			"System.Char[]",
			typeof(ref int),
			"System.UriFormat"
		}, ReturnType = "System.Char[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Insert", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe string Insert(int startIndex, string value)
		{
			throw null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00014BDC File Offset: 0x00012DDC
		[global::Cpp2ILInjected.Token(Token = "0x6000271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC97B4", Offset = "0x1AC97B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.NetGroupInfo", Member = "ComposeInfo", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Xml.SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "Convert", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnumName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ToEnumName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonObjectContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			"Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter.<ExecuteFilter>d__4", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidJavaProxy", Member = "Invoke", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = "UnityEngine.AndroidJavaObject")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string Join(string separator, params string[] value)
		{
			throw null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00014BDF File Offset: 0x00012DDF
		[global::Cpp2ILInjected.Token(Token = "0x6000272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC988C", Offset = "0x1AC988C", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIBestiary", Member = "SetBestiaryNotesOnItemCache", MemberParameters = new object[] { "Terraria.GameContent.ItemDropRules.DropRateInfo" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Chat.Commands.ListPlayersCommand", Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.LootSimulationItemCounter", Member = "PrintCollectedItems", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryInfoItemLine", Member = "SetBestiaryNotesOnItemCache", MemberParameters = new object[] { "Terraria.GameContent.ItemDropRules.DropRateInfo" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static string Join(string separator, global::System.Collections.Generic.IEnumerable<string> values)
		{
			throw null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00014BE2 File Offset: 0x00012DE2
		[global::Cpp2ILInjected.Token(Token = "0x6000273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC9814", Offset = "0x1AC9814", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "GetResponse", MemberParameters = new object[]
		{
			"System.Net.BufferOffsetSize",
			typeof(ref int),
			"System.Net.ReadState&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "JoinCore", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public unsafe static string Join(string separator, string[] value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00014BE5 File Offset: 0x00012DE5
		[global::Cpp2ILInjected.Token(Token = "0x6000274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC9D40", Offset = "0x1AC9D40", Length = "0x374")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Join", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private unsafe static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00014BE8 File Offset: 0x00012DE8
		[global::Cpp2ILInjected.Token(Token = "0x6000275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA0B4", Offset = "0x1ACA0B4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexFCD", Member = "Prefix", MemberParameters = new object[] { "System.Text.RegularExpressions.RegexTree" }, ReturnType = "System.Text.RegularExpressions.RegexPrefix")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public unsafe string PadRight(int totalWidth, char paddingChar)
		{
			throw null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00014BEB File Offset: 0x00012DEB
		[global::Cpp2ILInjected.Token(Token = "0x6000276")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA190", Offset = "0x1ACA190", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "MouseText_DrawItemTooltip", MemberParameters = new object[]
		{
			"Terraria.Main.MouseTextCache",
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.AssetPathHelper", Member = "CollapseParentDirectory", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "EvaluateInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.ParameterizedStrings.FormatParam[]),
			"System.ParameterizedStrings.LowLevelStack",
			typeof(ref global::System.ParameterizedStrings.FormatParam[]),
			typeof(ref global::System.ParameterizedStrings.FormatParam[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetLocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			"System.Char[]",
			typeof(ref int),
			"System.UriFormat"
		}, ReturnType = "System.Char[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ForwardSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe string Remove(int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00014BEE File Offset: 0x00012DEE
		[global::Cpp2ILInjected.Token(Token = "0x6000277")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA324", Offset = "0x1ACA324", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIBestiary", Member = "DrawLootDrops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIBestiary", Member = "DrawFilters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public string Remove(int startIndex)
		{
			throw null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00014BF1 File Offset: 0x00012DF1
		[global::Cpp2ILInjected.Token(Token = "0x6000278")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA584", Offset = "0x1ACA584", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public unsafe string Replace(char oldChar, char newChar)
		{
			throw null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00014BF4 File Offset: 0x00012DF4
		[global::Cpp2ILInjected.Token(Token = "0x6000279")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA654", Offset = "0x1ACA654", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 174)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = ".ctor", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "AsSpan", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ReplaceHelper", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(global::System.ReadOnlySpan<int>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public string Replace(string oldValue, string newValue)
		{
			throw null;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00014BF7 File Offset: 0x00012DF7
		[global::Cpp2ILInjected.Token(Token = "0x600027A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA974", Offset = "0x1ACA974", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private string ReplaceHelper(int oldValueLength, string newValue, global::System.ReadOnlySpan<int> indices)
		{
			throw null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00014BFA File Offset: 0x00012DFA
		[global::Cpp2ILInjected.Token(Token = "0x600027B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACACB8", Offset = "0x1ACACB8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string[] Split(char separator, global::System.StringSplitOptions options = global::System.StringSplitOptions.None)
		{
			throw null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00014BFD File Offset: 0x00012DFD
		[global::Cpp2ILInjected.Token(Token = "0x600027C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACB054", Offset = "0x1ACB054", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "Convert", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetContentLengthFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV4", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV6", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "GetStringUsingEncoding", MemberParameters = new object[] { "System.Net.WebRequest", "System.Byte[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "set_Port", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndpointPermission", Member = "IsSubsetOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndpointPermission", Member = "Intersect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndpointPermission", Member = "Resolve", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ParseEnumName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "ToEnumName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string[] Split(params char[] separator)
		{
			throw null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00014C00 File Offset: 0x00012E00
		[global::Cpp2ILInjected.Token(Token = "0x600027D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACB0C8", Offset = "0x1ACB0C8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerContext", Member = "ParseAuthentication", MemberParameters = new object[] { "System.Net.AuthenticationSchemes" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "SetRequestLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string[] Split(char[] separator, int count)
		{
			throw null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00014C03 File Offset: 0x00012E03
		[global::Cpp2ILInjected.Token(Token = "0x600027E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACB140", Offset = "0x1ACB140", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CodePageDataItem), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "SplitString", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string[] Split(char[] separator, global::System.StringSplitOptions options)
		{
			throw null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00014C06 File Offset: 0x00012E06
		[global::Cpp2ILInjected.Token(Token = "0x600027F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACAD18", Offset = "0x1ACAD18", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = ".ctor", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "AsSpan", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitOmitEmptyEntries", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<int>),
			typeof(global::System.ReadOnlySpan<int>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitKeepEmptyEntries", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<int>),
			typeof(global::System.ReadOnlySpan<int>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private string[] SplitInternal(global::System.ReadOnlySpan<char> separators, int count, global::System.StringSplitOptions options)
		{
			throw null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00014C09 File Offset: 0x00012E09
		[global::Cpp2ILInjected.Token(Token = "0x6000280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACBAC0", Offset = "0x1ACBAC0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.NetGroupInfo", Member = "DecomposeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Collections.Generic.Dictionary`2<InfoProviderId, String>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "PrettyPrintProfiles", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "AreEqual", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X500DistinguishedName", "System.Security.Cryptography.X509Certificates.X500DistinguishedName" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public string[] Split(string[] separator, global::System.StringSplitOptions options)
		{
			throw null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00014C0C File Offset: 0x00012E0C
		[global::Cpp2ILInjected.Token(Token = "0x6000281")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACBAD4", Offset = "0x1ACBAD4", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = ".ctor", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "AsSpan", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitOmitEmptyEntries", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<int>),
			typeof(global::System.ReadOnlySpan<int>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitKeepEmptyEntries", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<int>),
			typeof(global::System.ReadOnlySpan<int>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private string[] SplitInternal(string separator, string[] separators, int count, global::System.StringSplitOptions options)
		{
			throw null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00014C0F File Offset: 0x00012E0F
		[global::Cpp2ILInjected.Token(Token = "0x6000282")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACBEF4", Offset = "0x1ACBEF4", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = ".ctor", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "AsSpan", ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitOmitEmptyEntries", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<int>),
			typeof(global::System.ReadOnlySpan<int>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "SplitKeepEmptyEntries", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<int>),
			typeof(global::System.ReadOnlySpan<int>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private string[] SplitInternal(string separator, int count, global::System.StringSplitOptions options)
		{
			throw null;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00014C12 File Offset: 0x00012E12
		[global::Cpp2ILInjected.Token(Token = "0x6000283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACB654", Offset = "0x1ACB654", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<int>), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private string[] SplitKeepEmptyEntries(global::System.ReadOnlySpan<int> sepList, global::System.ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			throw null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00014C15 File Offset: 0x00012E15
		[global::Cpp2ILInjected.Token(Token = "0x6000284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACB840", Offset = "0x1ACB840", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<int>), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private string[] SplitOmitEmptyEntries(global::System.ReadOnlySpan<int> sepList, global::System.ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			throw null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00014C18 File Offset: 0x00012E18
		[global::Cpp2ILInjected.Token(Token = "0x6000285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACB1B8", Offset = "0x1ACB1B8", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemoryExtensions), Member = "Contains", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(char)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private unsafe void MakeSeparatorList(global::System.ReadOnlySpan<char> separators, ref global::System.Collections.Generic.ValueListBuilder<int> sepListBuilder)
		{
			throw null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00014C1B File Offset: 0x00012E1B
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC434", Offset = "0x1ACC434", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void MakeSeparatorList(string separator, ref global::System.Collections.Generic.ValueListBuilder<int> sepListBuilder)
		{
			throw null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00014C1E File Offset: 0x00012E1E
		[global::Cpp2ILInjected.Token(Token = "0x6000287")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC0D8", Offset = "0x1ACC0D8", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "SplitInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(global::System.StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.ValueListBuilder<>), Member = "Grow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void MakeSeparatorList(string[] separators, ref global::System.Collections.Generic.ValueListBuilder<int> sepListBuilder, ref global::System.Collections.Generic.ValueListBuilder<int> lengthListBuilder)
		{
			throw null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00014C21 File Offset: 0x00012E21
		[global::Cpp2ILInjected.Token(Token = "0x6000288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC6FC", Offset = "0x1ACC6FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 138)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string Substring(int startIndex)
		{
			throw null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00014C24 File Offset: 0x00012E24
		[global::Cpp2ILInjected.Token(Token = "0x6000289")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACA3DC", Offset = "0x1ACA3DC", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 323)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public unsafe string Substring(int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00014C27 File Offset: 0x00012E27
		[global::Cpp2ILInjected.Token(Token = "0x600028A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC7F4", Offset = "0x1ACC7F4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe string InternalSubString(int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00014C2A File Offset: 0x00012E2A
		[global::Cpp2ILInjected.Token(Token = "0x600028B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC844", Offset = "0x1ACC844", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 86)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToLower()
		{
			throw null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00014C2D File Offset: 0x00012E2D
		[global::Cpp2ILInjected.Token(Token = "0x600028C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC8B4", Offset = "0x1ACC8B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "Convert", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "ToUnicode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "GetStringUsingEncoding", MemberParameters = new object[] { "System.Net.WebRequest", "System.Byte[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			"System.Net.CookieVariant",
			"System.Uri",
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Builder", Member = "GetOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string ToLower(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00014C30 File Offset: 0x00012E30
		[global::Cpp2ILInjected.Token(Token = "0x600028D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC930", Offset = "0x1ACC930", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UID", Member = "Generate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UID", Member = "UIDGenerationAddString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CalendarData), Member = "nativeGetCalendarData", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CalendarData),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TrackingValidationObjectDictionary", Member = "PersistValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NclUtilities", Member = "GuessWhetherHostIsLoopback", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_Connection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.StringDictionary", Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.StringDictionary", Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.StringDictionary", Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.StringDictionary", Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToLowerInvariant()
		{
			throw null;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00014C33 File Offset: 0x00012E33
		[global::Cpp2ILInjected.Token(Token = "0x600028E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC9A0", Offset = "0x1ACC9A0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputDeviceProfile", Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "GetPlatformName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToUpper()
		{
			throw null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00014C36 File Offset: 0x00012E36
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCA10", Offset = "0x1ACCA10", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpMethodInfo", Member = "GetMethodInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Net.FtpMethodInfo")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ToolboxItemAttribute", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EditorAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EditorAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DesignerAttribute", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DesignerAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DesignerAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.RuntimeLicenseContext", Member = "GetSavedLicenseKey", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "GetAttributeFromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = "Mono.Security.X509.X520.AttributeTypeAndValue")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse", Member = "PasswordToKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "PasswordToKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type1Message", Member = "GetBytes", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string ToUpper(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00014C39 File Offset: 0x00012E39
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCA8C", Offset = "0x1ACCA8C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.RegionInfo), Member = "GetByTerritory", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialHostKey", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialKey", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_Method", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new object[]
		{
			"Mono.Security.Protocol.Ntlm.Type2Message",
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string ToUpperInvariant()
		{
			throw null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00014C3C File Offset: 0x00012E3C
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCAFC", Offset = "0x1ACCAFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 110)]
		public string Trim()
		{
			throw null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00014C3F File Offset: 0x00012E3F
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCC3C", Offset = "0x1ACCC3C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ReadXdgUserDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string.TrimType)
		}, ReturnType = typeof(string))]
		public unsafe string Trim(char trimChar)
		{
			throw null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00014C42 File Offset: 0x00012E42
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCD94", Offset = "0x1ACCD94", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "ResolveHelper", MemberParameters = new object[]
		{
			"System.Uri",
			"System.Uri",
			typeof(ref string),
			typeof(ref bool),
			"System.UriFormatException&"
		}, ReturnType = "System.Uri")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpValidationHelpers", Member = "CheckBadHeaderValueChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerPrefix", Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TrimString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string.TrimType)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new object[] { typeof(string.TrimType) }, ReturnType = typeof(string))]
		public unsafe string Trim(params char[] trimChars)
		{
			throw null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00014C45 File Offset: 0x00012E45
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCDB4", Offset = "0x1ACCDB4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "PrettifyPercentDisplay", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TrimStringStart", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string.TrimType)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new object[] { typeof(string.TrimType) }, ReturnType = typeof(string))]
		public unsafe string TrimStart(params char[] trimChars)
		{
			throw null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00014C48 File Offset: 0x00012E48
		[global::Cpp2ILInjected.Token(Token = "0x6000295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCDD4", Offset = "0x1ACCDD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X500DistinguishedName", Member = "Canonize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new object[] { typeof(string.TrimType) }, ReturnType = typeof(string))]
		public string TrimEnd()
		{
			throw null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00014C4B File Offset: 0x00012E4B
		[global::Cpp2ILInjected.Token(Token = "0x6000296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCDDC", Offset = "0x1ACCDDC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIControllerMappings", Member = "DrawTitle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIKeyboardMappings", Member = "DrawTitle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIInterfaceEdit", Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISettingsOverlay", Member = "DrawTitle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "PrettifyPercentDisplay", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodBase), Member = "ConstructParameters", MemberParameters = new object[]
		{
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.CallingConventions),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "FormatParameters", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(global::System.Reflection.CallingConventions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateResponseUri", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.FtpWebRequest"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TrimStringEnd", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ParsePath", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<PathFilter>",
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string.TrimType)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new object[] { typeof(string.TrimType) }, ReturnType = typeof(string))]
		public unsafe string TrimEnd(params char[] trimChars)
		{
			throw null;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00014C4E File Offset: 0x00012E4E
		[global::Cpp2ILInjected.Token(Token = "0x6000297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCB04", Offset = "0x1ACCB04", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimStart", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateTrimmedString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private string TrimWhiteSpaceHelper(string.TrimType trimType)
		{
			throw null;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00014C51 File Offset: 0x00012E51
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCC5C", Offset = "0x1ACCC5C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimStart", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateTrimmedString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private unsafe string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType)
		{
			throw null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00014C54 File Offset: 0x00012E54
		[global::Cpp2ILInjected.Token(Token = "0x6000299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCDFC", Offset = "0x1ACCDFC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimWhiteSpaceHelper", MemberParameters = new object[] { typeof(string.TrimType) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "TrimHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string.TrimType)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe string CreateTrimmedString(int start, int end)
		{
			throw null;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00014C57 File Offset: 0x00012E57
		[global::Cpp2ILInjected.Token(Token = "0x600029A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCEA0", Offset = "0x1ACCEA0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public bool Contains(string value)
		{
			throw null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00014C5A File Offset: 0x00012E5A
		[global::Cpp2ILInjected.Token(Token = "0x600029B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCED4", Offset = "0x1ACCED4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 101)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		public int IndexOf(char value)
		{
			throw null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00014C5D File Offset: 0x00012E5D
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCEE4", Offset = "0x1ACCEE4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CSVReader", Member = "DecodeLine", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseMDateRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref int),
			typeof(ref global::System.DayOfWeek)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GetZoneAbbreviation", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.TypeInfo), Member = "CanCastTo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "GetTypeNameFromAssemblyQualifiedName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "get_Segments", ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CombineUri", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(string),
			"System.UriFormat"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequestUriBuilder", Member = "GetPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "InternalGetCookies", MemberParameters = new object[] { "System.Uri" }, ReturnType = "System.Net.CookieCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestHeaderParser", Member = "GetKeywordAndValue", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebResponse", Member = "get_CharacterSet", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeFreeNegoCredentials", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "NormalizeFileName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "ReadAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = "Mono.Security.X509.X520.AttributeTypeAndValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		public int IndexOf(char value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00014C60 File Offset: 0x00012E60
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCEF0", Offset = "0x1ACCEF0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			"System.Net.CookieVariant",
			"System.Uri",
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerPrefix", Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ListenerPrefix", Member = "CheckUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int IndexOf(char value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00014C63 File Offset: 0x00012E63
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCFC8", Offset = "0x1ACCFC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		public int IndexOfAny(char[] anyOf)
		{
			throw null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00014C66 File Offset: 0x00012E66
		[global::Cpp2ILInjected.Token(Token = "0x600029F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD18C", Offset = "0x1ACD18C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility", Member = "HtmlDecode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "FindtNextWordBegin", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public int IndexOfAny(char[] anyOf, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00014C69 File Offset: 0x00012E69
		[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCFD4", Offset = "0x1ACCFD4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X501", Member = "AppendEntry", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			"Mono.Security.ASN1",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfCharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public int IndexOfAny(char[] anyOf, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00014C6C File Offset: 0x00012E6C
		[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD198", Offset = "0x1ACD198", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private int IndexOfAny(char value1, char value2, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00014C6F File Offset: 0x00012E6F
		[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD21C", Offset = "0x1ACD21C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00014C72 File Offset: 0x00012E72
		[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD270", Offset = "0x1ACD270", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe int IndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00014C75 File Offset: 0x00012E75
		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC708", Offset = "0x1ACC708", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "MakeSeparatorList", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.Collections.Generic.ValueListBuilder<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOfCharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOfCharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe static void InitializeProbabilisticMap(uint* charMap, global::System.ReadOnlySpan<char> anyOf)
		{
			throw null;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00014C78 File Offset: 0x00012E78
		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD3D0", Offset = "0x1ACD3D0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ArrayContains(char searchChar, char[] anyOf)
		{
			throw null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00014C7B File Offset: 0x00012E7B
		[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACC7D0", Offset = "0x1ACC7D0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static bool IsCharBitSet(uint* charMap, byte value)
		{
			throw null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00014C7E File Offset: 0x00012E7E
		[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD40C", Offset = "0x1ACD40C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private unsafe static void SetCharBit(uint* charMap, byte value)
		{
			throw null;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00014C81 File Offset: 0x00012E81
		[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD430", Offset = "0x1ACD430", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public int IndexOf(string value)
		{
			throw null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00014C84 File Offset: 0x00012E84
		[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD440", Offset = "0x1ACD440", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.X509PalImpl", Member = "PEM", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new object[]
		{
			"System.Net.ResponseDescription",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "PEM", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public int IndexOf(string value, int startIndex)
		{
			throw null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00014C87 File Offset: 0x00012E87
		[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACCEC4", Offset = "0x1ACCEC4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.Filters.BySearch", Member = "FitsFilter", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.BestiaryEntry" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.ItemFilters.BySearch", Member = "FitsFilter", MemberParameters = new object[] { "Terraria.Item" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.BasicClient", Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.WebRequest",
			"System.Net.ICredentials"
		}, ReturnType = "System.Net.Authorization")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndPointManager", Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.HttpListener"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.EndPointManager", Member = "RemovePrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.HttpListener"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.IO.MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebResponse", Member = "get_CharacterSet", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "CheckAuthHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "Initialize", MemberParameters = new object[] { "System.Net.BufferOffsetSize" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager", Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryVerifyTOKEN", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Uri")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUri", MemberParameters = new object[]
		{
			typeof(string),
			"System.Uri&"
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public int IndexOf(string value, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00014C8A File Offset: 0x00012E8A
		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD450", Offset = "0x1ACD450", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int IndexOf(string value, int startIndex, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00014C8D File Offset: 0x00012E8D
		[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD460", Offset = "0x1ACD460", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "IndexOfOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public int IndexOf(string value, int startIndex, int count, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00014C90 File Offset: 0x00012E90
		[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD764", Offset = "0x1ACD764", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DefaultFileAPI", Member = "GetUserSavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "FilterNameImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "FilterNameIgnoreCaseImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "findExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Authentication.ExtendedProtection.ServiceNameCollection", Member = "NormalizeServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPathInfo", MemberParameters = new object[]
		{
			"System.Net.FtpControlStream.GetPathOption",
			"System.Uri",
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateResponseUri", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.FtpWebRequest"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLoginDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CredentialKey", Member = "IsPrefix", MemberParameters = new object[] { "System.Uri", "System.Uri" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Cookie", Member = "VerifySetDefaults", MemberParameters = new object[]
		{
			"System.Net.CookieVariant",
			"System.Uri",
			typeof(bool),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "Unquote", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_Host", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager", Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlEntityReference", Member = "ConstructBaseURI", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.RegexConverter", Member = "ReadRegexString", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine._Scripting.APIUpdating.APIUpdaterRuntimeHelpers", Member = "GetObsoleteTypeRedirection", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XName", Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Xml.Linq.XName")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		public int LastIndexOf(char value)
		{
			throw null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00014C93 File Offset: 0x00012E93
		[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD774", Offset = "0x1ACD774", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.AssetPathHelper", Member = "CollapseParentDirectory", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "InternalGetCookies", MemberParameters = new object[] { "System.Uri" }, ReturnType = "System.Net.CookieCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public int LastIndexOf(char value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00014C96 File Offset: 0x00012E96
		[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD77C", Offset = "0x1ACD77C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public int LastIndexOf(char value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00014C99 File Offset: 0x00012E99
		[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD860", Offset = "0x1ACD860", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "findExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public int LastIndexOfAny(char[] anyOf)
		{
			throw null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00014C9C File Offset: 0x00012E9C
		[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD998", Offset = "0x1ACD998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "FindtPrevWordBegin", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public int LastIndexOfAny(char[] anyOf, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00014C9F File Offset: 0x00012E9F
		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD86C", Offset = "0x1ACD86C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"Ionic.Zip.AddOrUpdateAction",
			typeof(bool),
			typeof(int)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfCharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public int LastIndexOfAny(char[] anyOf, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00014CA2 File Offset: 0x00012EA2
		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACD9A0", Offset = "0x1ACD9A0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "InitializeProbabilisticMap", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe int LastIndexOfCharArray(char[] anyOf, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00014CA5 File Offset: 0x00012EA5
		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDB00", Offset = "0x1ACDB00", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "TryUpdateContentLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV6", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.CopyHelper", Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public int LastIndexOf(string value)
		{
			throw null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00014CA8 File Offset: 0x00012EA8
		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDE70", Offset = "0x1ACDE70", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		public int LastIndexOf(string value, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00014CAB File Offset: 0x00012EAB
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDB10", Offset = "0x1ACDB10", Length = "0x360")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "LastIndexOfOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public int LastIndexOf(string value, int startIndex, int count, global::System.StringComparison comparisonType)
		{
			throw null;
		}

		// Token: 0x0600025B RID: 603
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDE80", Offset = "0x1ACDE80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern String(char[] value);

		// Token: 0x0600025C RID: 604 RVA: 0x00014CAE File Offset: 0x00012EAE
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDE84", Offset = "0x1ACDE84", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Internal.Cryptography.Helpers), Member = "ToHexStringUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static string Ctor(char[] value)
		{
			throw null;
		}

		// Token: 0x0600025D RID: 605
		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDF0C", Offset = "0x1ACDF0C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern String(char[] value, int startIndex, int length);

		// Token: 0x0600025E RID: 606 RVA: 0x00014CB1 File Offset: 0x00012EB1
		[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACDF10", Offset = "0x1ACDF10", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private unsafe static string Ctor(char[] value, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x0600025F RID: 607
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE0B4", Offset = "0x1ACE0B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public unsafe extern String(char* value, int startIndex, int length);

		// Token: 0x06000260 RID: 608 RVA: 0x00014CB4 File Offset: 0x00012EB4
		[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE0B8", Offset = "0x1ACE0B8", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06000261 RID: 609
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE230", Offset = "0x1ACE230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public unsafe extern String(sbyte* value, int startIndex, int length);

		// Token: 0x06000262 RID: 610 RVA: 0x00014CB7 File Offset: 0x00012EB7
		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE234", Offset = "0x1ACE234", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00014CBA File Offset: 0x00012EBA
		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE3AC", Offset = "0x1ACE3AC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			throw null;
		}

		// Token: 0x06000264 RID: 612
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE420", Offset = "0x1ACE420", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public unsafe extern String(sbyte* value, int startIndex, int length, global::System.Text.Encoding enc);

		// Token: 0x06000265 RID: 613 RVA: 0x00014CBD File Offset: 0x00012EBD
		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE424", Offset = "0x1ACE424", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "GetString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private unsafe static string Ctor(sbyte* value, int startIndex, int length, global::System.Text.Encoding enc)
		{
			throw null;
		}

		// Token: 0x06000266 RID: 614
		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE608", Offset = "0x1ACE608", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern String(char c, int count);

		// Token: 0x06000267 RID: 615 RVA: 0x00014CC0 File Offset: 0x00012EC0
		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE60C", Offset = "0x1ACE60C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string Ctor(char c, int count)
		{
			throw null;
		}

		// Token: 0x06000268 RID: 616
		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE720", Offset = "0x1ACE720", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern String(global::System.ReadOnlySpan<char> value);

		// Token: 0x06000269 RID: 617 RVA: 0x00014CC3 File Offset: 0x00012EC3
		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE724", Offset = "0x1ACE724", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static string Ctor(global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00014CC6 File Offset: 0x00012EC6
		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x159F2A4", Offset = "0x159F2A4", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string Create<TState>(int length, TState state, global::System.Buffers.SpanAction<char, TState> action)
		{
			throw null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00014CC9 File Offset: 0x00012EC9
		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE7DC", Offset = "0x1ACE7DC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public static implicit operator global::System.ReadOnlySpan<char>(string value)
		{
			throw null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00014CCC File Offset: 0x00012ECC
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE82C", Offset = "0x1ACE82C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00014CCF File Offset: 0x00012ECF
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE830", Offset = "0x1ACE830", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(global::System.Runtime.Remoting.ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.CADMethodCallMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe static string Copy(string str)
		{
			throw null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00014CD2 File Offset: 0x00012ED2
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE8BC", Offset = "0x1ACE8BC", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StringReader), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "ReCreateParts", MemberParameters = new object[]
		{
			"System.UriComponents",
			typeof(ushort),
			"System.UriFormat"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			"System.Char[]",
			typeof(ref int),
			"System.UriFormat"
		}, ReturnType = "System.Char[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CombineUri", MemberParameters = new object[]
		{
			"System.Uri",
			typeof(string),
			"System.UriFormat"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "InitStringInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Text.Encoding),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "WriteDateTimeString", MemberParameters = new object[]
		{
			"System.Char[]",
			typeof(int),
			typeof(global::System.DateTime),
			"System.Nullable`1<TimeSpan>",
			typeof(global::System.DateTimeKind),
			"Newtonsoft.Json.DateFormatHandling"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.JavaScriptUtils", Member = "WriteEscapedJavaScriptString", MemberParameters = new object[]
		{
			typeof(global::System.IO.TextWriter),
			typeof(string),
			typeof(char),
			typeof(bool),
			"System.Boolean[]",
			"Newtonsoft.Json.StringEscapeHandling",
			"Newtonsoft.Json.IArrayPool`1<Char>",
			"System.Char[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public unsafe void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			throw null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00014CD5 File Offset: 0x00012ED5
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEA30", Offset = "0x1ACEA30", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "ToByteArray", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetByteCount", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.TextWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.TextWriter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.CStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpDateParse", Member = "ParseHttpDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlConvert", Member = "FromBinHexString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTime", MemberParameters = new object[]
		{
			typeof(string),
			"Newtonsoft.Json.DateTimeZoneHandling",
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToCamelCase", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"Ionic.Zip.AddOrUpdateAction",
			typeof(bool),
			typeof(int)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe char[] ToCharArray()
		{
			throw null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00014CD8 File Offset: 0x00012ED8
		[global::System.Runtime.Versioning.NonVersionable]
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8FC4", Offset = "0x1AC8FC4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 350)]
		public static bool IsNullOrEmpty(string value)
		{
			throw null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00014CDB File Offset: 0x00012EDB
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEAF8", Offset = "0x1ACEAF8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsNullOrWhiteSpace(string value)
		{
			throw null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00014CDE File Offset: 0x00012EDE
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7458", Offset = "0x1AC7458", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 241)]
		internal ref char GetRawStringData()
		{
			throw null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00014CE1 File Offset: 0x00012EE1
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEBA8", Offset = "0x1ACEBA8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.ASCIIEncoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.EncodingNLS), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF7Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF8Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UnicodeEncoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00014CE4 File Offset: 0x00012EE4
		[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEC64", Offset = "0x1ACEC64", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "ToString", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "ConvertFromUtf32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static string CreateFromChar(char c)
		{
			throw null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00014CE7 File Offset: 0x00012EE7
		[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8D90", Offset = "0x1AC8D90", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "ThreadSafeCopy", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		internal unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
			throw null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00014CEA File Offset: 0x00012EEA
		[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEC80", Offset = "0x1ACEC80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00014CED File Offset: 0x00012EED
		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEC84", Offset = "0x1ACEC84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public string ToString(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00014CF0 File Offset: 0x00012EF0
		[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEC88", Offset = "0x1ACEC88", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CharEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Collections.Generic.IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00014CF3 File Offset: 0x00012EF3
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACECE4", Offset = "0x1ACECE4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CharEnumerator), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00014CF6 File Offset: 0x00012EF6
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACED40", Offset = "0x1ACED40", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref global::System.Text.ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToDouble", MemberParameters = new object[] { typeof(ref global::System.Number.NumberBuffer) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "get_Size", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static int wcslen(char* ptr)
		{
			throw null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00014CF9 File Offset: 0x00012EF9
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEE48", Offset = "0x1ACEE48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.TypeCode GetTypeCode()
		{
			throw null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00014CFC File Offset: 0x00012EFC
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEE50", Offset = "0x1ACEE50", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.IConvertible.ToBoolean(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00014CFF File Offset: 0x00012EFF
		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEEB8", Offset = "0x1ACEEB8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private char System.IConvertible.ToChar(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00014D02 File Offset: 0x00012F02
		[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEF20", Offset = "0x1ACEF20", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private sbyte System.IConvertible.ToSByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00014D05 File Offset: 0x00012F05
		[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEF88", Offset = "0x1ACEF88", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte System.IConvertible.ToByte(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00014D08 File Offset: 0x00012F08
		[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACEFF0", Offset = "0x1ACEFF0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private short System.IConvertible.ToInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00014D0B File Offset: 0x00012F0B
		[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF058", Offset = "0x1ACF058", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ushort System.IConvertible.ToUInt16(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00014D0E File Offset: 0x00012F0E
		[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF0C0", Offset = "0x1ACF0C0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.IConvertible.ToInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00014D11 File Offset: 0x00012F11
		[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF128", Offset = "0x1ACF128", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private uint System.IConvertible.ToUInt32(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00014D14 File Offset: 0x00012F14
		[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF190", Offset = "0x1ACF190", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private long System.IConvertible.ToInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00014D17 File Offset: 0x00012F17
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF1F8", Offset = "0x1ACF1F8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ulong System.IConvertible.ToUInt64(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00014D1A File Offset: 0x00012F1A
		[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF260", Offset = "0x1ACF260", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float System.IConvertible.ToSingle(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00014D1D File Offset: 0x00012F1D
		[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF2C8", Offset = "0x1ACF2C8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private double System.IConvertible.ToDouble(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00014D20 File Offset: 0x00012F20
		[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF330", Offset = "0x1ACF330", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private decimal System.IConvertible.ToDecimal(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00014D23 File Offset: 0x00012F23
		[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF398", Offset = "0x1ACF398", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.DateTime System.IConvertible.ToDateTime(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00014D26 File Offset: 0x00012F26
		[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF400", Offset = "0x1ACF400", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "DefaultToType", MemberParameters = new object[]
		{
			typeof(global::System.IConvertible),
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private object System.IConvertible.ToType(global::System.Type type, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00014D29 File Offset: 0x00012F29
		[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF470", Offset = "0x1ACF470", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.IdnMapping), Member = "NamePrep", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			typeof(ushort),
			"System.ParsingError&",
			"Flags&",
			"System.UriParser",
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			"System.UriParser",
			typeof(string),
			"Flags&",
			typeof(ref bool),
			typeof(ref string),
			"System.ParsingError&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			"System.UriParser",
			"Flags&",
			typeof(ref string),
			"System.ParsingError&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "InitializeUri", MemberParameters = new object[] { "System.ParsingError", "System.UriKind", "System.UriFormatException&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Normalization), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Text.NormalizationForm)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string Normalize(global::System.Text.NormalizationForm normalizationForm)
		{
			throw null;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00014D2C File Offset: 0x00012F2C
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ACF4D8", Offset = "0x1ACF4D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00014D2F File Offset: 0x00012F2F
		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF4E0", Offset = "0x1ACF4E0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "IndexOfOrdinalCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		internal int IndexOfUnchecked(string value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00014D32 File Offset: 0x00012F32
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF5AC", Offset = "0x1ACF5AC", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "IndexOfOrdinalCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00014D35 File Offset: 0x00012F35
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF73C", Offset = "0x1ACF73C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "internal_index_switch", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "LastIndexOfOrdinalCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		internal int LastIndexOfUnchecked(string value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00014D38 File Offset: 0x00012F38
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF804", Offset = "0x1ACF804", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "LastIndexOfOrdinalCore", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00014D3B File Offset: 0x00012F3B
		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF980", Offset = "0x1ACF980", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ReadXdgUserDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		internal bool StartsWithOrdinalUnchecked(string value)
		{
			throw null;
		}

		// Token: 0x06000292 RID: 658
		[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC8FE0", Offset = "0x1AC8FE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Create", MemberTypeParameters = new object[] { "TState" }, MemberParameters = new object[]
		{
			typeof(int),
			"TState",
			"System.Buffers.SpanAction`2<Char, TState>"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NegativeInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "Int32ToHexStr", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "UInt32ToDecStr", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NegativeInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "Int64ToHexStr", MemberParameters = new object[]
		{
			typeof(long),
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "UInt64ToDecStr", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TextInfo), Member = "ToUpperInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TextInfo), Member = "ToLowerInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string FastAllocateString(int length);

		// Token: 0x06000293 RID: 659 RVA: 0x00014D3E File Offset: 0x00012F3E
		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACF9C4", Offset = "0x1ACF9C4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "bzero", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static void memset(byte* dest, int val, int len)
		{
			throw null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00014D41 File Offset: 0x00012F41
		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFA80", Offset = "0x1ACFA80", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00014D44 File Offset: 0x00012F44
		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFA8C", Offset = "0x1ACFA8C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "memset", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal unsafe static void bzero(byte* dest, int len)
		{
			throw null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00014D47 File Offset: 0x00012F47
		[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFA98", Offset = "0x1ACFA98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			throw null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00014D4A File Offset: 0x00012F4A
		[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAA0", Offset = "0x1ACFAA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			throw null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00014D4D File Offset: 0x00012F4D
		[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAA8", Offset = "0x1ACFAA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			throw null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00014D50 File Offset: 0x00012F50
		[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAB0", Offset = "0x1ACFAB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			throw null;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00014D53 File Offset: 0x00012F53
		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAB8", Offset = "0x1ACFAB8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00014D56 File Offset: 0x00012F56
		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAC4", Offset = "0x1ACFAC4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00014D59 File Offset: 0x00012F59
		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAD0", Offset = "0x1ACFAD0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00014D5C File Offset: 0x00012F5C
		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFADC", Offset = "0x1ACFADC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00014D5F File Offset: 0x00012F5F
		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACE5F8", Offset = "0x1ACE5F8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00014D62 File Offset: 0x00012F62
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAE8", Offset = "0x1ACFAE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "UTF8_ToManaged", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Globalization.Unicode.MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::Mono.Globalization.Unicode.TailoringInfo),
			typeof(ref global::Mono.Globalization.Unicode.Contraction[]),
			typeof(ref global::Mono.Globalization.Unicode.Level2Map[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "ConvertFromUtf32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Span<>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckSchemeSyntax", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			"System.UriParser&"
		}, ReturnType = "System.ParsingError")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			typeof(ushort),
			"System.ParsingError&",
			"Flags&",
			"System.UriParser",
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			"System.UriParser",
			typeof(string),
			"Flags&",
			typeof(ref bool),
			typeof(ref string),
			"System.ParsingError&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			"System.UriParser",
			"Flags&",
			typeof(ref string),
			"System.ParsingError&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DomainNameHelper", Member = "IdnEquivalent", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "IPv4AddressToString", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.BinHexDecoder", Member = "Decode", MemberParameters = new object[]
		{
			"System.Char*",
			"System.Char*",
			"System.Byte*",
			"System.Byte*",
			typeof(ref bool),
			typeof(ref byte),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private unsafe string CreateString(char* value, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00014D65 File Offset: 0x00012F65
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFAF8", Offset = "0x1ACFAF8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 57)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private string CreateString(char[] val, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00014D68 File Offset: 0x00012F68
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC7438", Offset = "0x1AC7438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParameterizedStrings), Member = "StringFromAsciiBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "GetString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Utils), Member = "DiscardWhiteSpaces", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "CheckIriUnicodeRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.BinHexDecoder", Member = "Decode", MemberParameters = new object[]
		{
			"System.Char[]",
			typeof(bool)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlRawWriter", Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlRawWriter", Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlException", Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.StringUtils", Member = "ToCamelCase", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "GenerateRandomStringImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		private string CreateString(char[] val)
		{
			throw null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00014D6B File Offset: 0x00012F6B
		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFB08", Offset = "0x1ACFB08", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.MultiTimer", Member = "StopAndPrint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UITextPanel`1", Member = "DrawText", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.SpriteBatch" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.MultiTimer", Member = "StopAndPrint", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureArrayType), Member = "get_Suffix", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection.HeaderEncoding", Member = "GetString", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.DtdParser", Member = "ParseExternalId", MemberParameters = new object[]
		{
			"System.Xml.DtdParser.Token",
			"System.Xml.DtdParser.Token",
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteIndent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateLabel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		private string CreateString(char c, int count)
		{
			throw null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00014D6E File Offset: 0x00012F6E
		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFB14", Offset = "0x1ACFB14", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimeMarshal), Member = "PtrToUtf8String", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.StackTraceUtility", Member = "ExtractStackTrace", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(sbyte*),
			typeof(int),
			typeof(int),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(string))]
		private unsafe string CreateString(sbyte* value, int startIndex, int length, global::System.Text.Encoding enc)
		{
			throw null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00014D71 File Offset: 0x00012F71
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ACFB28", Offset = "0x1ACFB28", Length = "0x100C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateTimeParseException", MemberParameters = new object[] { typeof(ref global::System.DateTimeResult) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "AppendFormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.ValueStringBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.FileStatus), Member = "EnsureStatInitialized", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetFileName", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareString", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IPv4AddressHelper", Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IPv6AddressHelper", Member = "Parse", MemberParameters = new object[]
		{
			"System.ReadOnlySpan`1<Char>",
			"System.UInt16*",
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IPv6AddressHelper", Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.ValueStringBuilder", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Ctor", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string CreateString(global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x17000037 RID: 55
		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		[IndexerName("Chars")]
		public char this[int index]
		{
			[global::System.Runtime.CompilerServices.Intrinsic]
			[global::Cpp2ILInjected.Token(Token = "0x6000301")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC4708", Offset = "0x1AC4708", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1213)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x040000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		private const int StackallocIntBufferSizeLimit = 128;

		// Token: 0x040000E6 RID: 230
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;

		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;

		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		private const int PROBABILISTICMAP_SIZE = 8;

		// Token: 0x040000E9 RID: 233
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		private int _stringLength;

		// Token: 0x040000EA RID: 234
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		[global::System.NonSerialized]
		private char _firstChar;

		// Token: 0x040000EB RID: 235
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		public static readonly string Empty;

		// Token: 0x02000570 RID: 1392
		[global::Cpp2ILInjected.Token(Token = "0x2000068")]
		private enum TrimType
		{
			// Token: 0x0400175B RID: 5979
			[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
			Head,
			// Token: 0x0400175C RID: 5980
			[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
			Tail,
			// Token: 0x0400175D RID: 5981
			[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
			Both
		}

		// Token: 0x02000571 RID: 1393
		[global::Cpp2ILInjected.Token(Token = "0x2000069")]
		[StructLayout(2, Pack = 1, Size = 32)]
		private struct ProbabilisticMap
		{
		}
	}
}
