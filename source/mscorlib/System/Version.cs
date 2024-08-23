using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System
{
	// Token: 0x020000F0 RID: 240
	[global::Cpp2ILInjected.Token(Token = "0x2000122")]
	[global::System.Serializable]
	public sealed class Version : global::System.ICloneable, global::System.IComparable, global::System.IComparable<global::System.Version>, global::System.IEquatable<global::System.Version>, global::System.ISpanFormattable
	{
		// Token: 0x06000ACA RID: 2762 RVA: 0x0001645A File Offset: 0x0001465A
		[global::Cpp2ILInjected.Token(Token = "0x6000B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C539BC", Offset = "0x1C539BC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ParseVersion", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "CreateVersionFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = "FillName", MemberParameters = new object[]
		{
			typeof(global::Mono.MonoAssemblyName*),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public unsafe Version(int major, int minor, int build, int revision)
		{
			throw null;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0001645D File Offset: 0x0001465D
		[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53AD0", Offset = "0x1C53AD0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ParseVersion", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public Version(int major, int minor, int build)
		{
			throw null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00016460 File Offset: 0x00014660
		[global::Cpp2ILInjected.Token(Token = "0x6000B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53BBC", Offset = "0x1C53BBC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ParseVersion", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpVersion", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Version(int major, int minor)
		{
			throw null;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00016463 File Offset: 0x00014663
		[global::Cpp2ILInjected.Token(Token = "0x6000B75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53C74", Offset = "0x1C53C74", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "GetSatelliteContractVersion", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "SetRequestLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "VersionTryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.VersionConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Version))]
		public Version(string version)
		{
			throw null;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00016466 File Offset: 0x00014666
		[global::Cpp2ILInjected.Token(Token = "0x6000B76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53D58", Offset = "0x1C53D58", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Version()
		{
			throw null;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00016469 File Offset: 0x00014669
		[global::Cpp2ILInjected.Token(Token = "0x6000B77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53D7C", Offset = "0x1C53D7C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Version(global::System.Version version)
		{
			throw null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001646C File Offset: 0x0001466C
		[global::Cpp2ILInjected.Token(Token = "0x6000B78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53DC0", Offset = "0x1C53DC0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0001646F File Offset: 0x0001466F
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		public int Major
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C53E38", Offset = "0x1C53E38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00016472 File Offset: 0x00014672
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public int Minor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C53E40", Offset = "0x1C53E40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00016475 File Offset: 0x00014675
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public int Build
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C53E48", Offset = "0x1C53E48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00016478 File Offset: 0x00014678
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public int Revision
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C53E50", Offset = "0x1C53E50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0001647B File Offset: 0x0001467B
		[global::Cpp2ILInjected.Token(Token = "0x6000B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53E58", Offset = "0x1C53E58", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public int CompareTo(object version)
		{
			throw null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001647E File Offset: 0x0001467E
		[global::Cpp2ILInjected.Token(Token = "0x6000B7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53F24", Offset = "0x1C53F24", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public int CompareTo(global::System.Version value)
		{
			throw null;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00016481 File Offset: 0x00014681
		[global::Cpp2ILInjected.Token(Token = "0x6000B7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53F8C", Offset = "0x1C53F8C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00016484 File Offset: 0x00014684
		[global::Cpp2ILInjected.Token(Token = "0x6000B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53FF0", Offset = "0x1C53FF0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_SupportsPipelining", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public bool Equals(global::System.Version obj)
		{
			throw null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00016487 File Offset: 0x00014687
		[global::Cpp2ILInjected.Token(Token = "0x6000B81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54050", Offset = "0x1C54050", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0001648A File Offset: 0x0001468A
		[global::Cpp2ILInjected.Token(Token = "0x6000B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5406C", Offset = "0x1C5406C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0001648D File Offset: 0x0001468D
		[global::Cpp2ILInjected.Token(Token = "0x6000B83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C540BC", Offset = "0x1C540BC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OperatingSystem), Member = "get_VersionString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "ToCachedStringBuilder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string ToString(int fieldCount)
		{
			throw null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00016490 File Offset: 0x00014690
		[global::Cpp2ILInjected.Token(Token = "0x6000B84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54380", Offset = "0x1C54380", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool TryFormat(global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00016493 File Offset: 0x00014693
		[global::Cpp2ILInjected.Token(Token = "0x6000B85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C543AC", Offset = "0x1C543AC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "ToCachedStringBuilder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(global::System.Text.StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Span<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryFormat(global::System.Span<char> destination, int fieldCount, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00016496 File Offset: 0x00014696
		[global::Cpp2ILInjected.Token(Token = "0x6000B86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C544CC", Offset = "0x1C544CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		private bool System.ISpanFormattable.TryFormat(global::System.Span<char> destination, out int charsWritten, global::System.ReadOnlySpan<char> format, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00016499 File Offset: 0x00014699
		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		private int DefaultFormatFieldCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C54094", Offset = "0x1C54094", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001649C File Offset: 0x0001469C
		[global::Cpp2ILInjected.Token(Token = "0x6000B88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54148", Offset = "0x1C54148", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ToString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private global::System.Text.StringBuilder ToCachedStringBuilder(int fieldCount)
		{
			throw null;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001649F File Offset: 0x0001469F
		[global::Cpp2ILInjected.Token(Token = "0x6000B89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53CC0", Offset = "0x1C53CC0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "ParseVersion", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.Version Parse(string input)
		{
			throw null;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000164A2 File Offset: 0x000146A2
		[global::Cpp2ILInjected.Token(Token = "0x6000B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C544F8", Offset = "0x1C544F8", Length = "0x4C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "TryParseComponent", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static global::System.Version ParseVersion(global::System.ReadOnlySpan<char> input, bool throwOnFailure)
		{
			throw null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000164A5 File Offset: 0x000146A5
		[global::Cpp2ILInjected.Token(Token = "0x6000B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C549BC", Offset = "0x1C549BC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "ParseVersion", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Version))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool TryParseComponent(global::System.ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent)
		{
			throw null;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x000164A8 File Offset: 0x000146A8
		[global::Cpp2ILInjected.Token(Token = "0x6000B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C53F10", Offset = "0x1C53F10", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Assembly), Member = "InternalGetSatelliteAssembly", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Version),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = "set_Version", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "get_KeepAlive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "set_ProtocolVersion", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_SendContinue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream", Member = "Initialize", MemberParameters = new object[] { "System.Net.BufferOffsetSize" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "Equals", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(bool))]
		public static bool operator ==(global::System.Version v1, global::System.Version v2)
		{
			throw null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000164AB File Offset: 0x000146AB
		[global::Cpp2ILInjected.Token(Token = "0x6000B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54AD0", Offset = "0x1C54AD0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "HandleSatelliteMissing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "set_ProtocolVersion", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream", Member = ".ctor", MemberParameters = new object[]
		{
			"System.Net.WebConnection",
			"System.Net.WebOperation",
			typeof(global::System.IO.Stream),
			"System.Net.WebConnectionTunnel"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "Equals", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(bool))]
		public static bool operator !=(global::System.Version v1, global::System.Version v2)
		{
			throw null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000164AE File Offset: 0x000146AE
		[global::Cpp2ILInjected.Token(Token = "0x6000B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54AF8", Offset = "0x1C54AF8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest", Member = "GetRequestHeaders", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool operator <(global::System.Version v1, global::System.Version v2)
		{
			throw null;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000164B1 File Offset: 0x000146B1
		[global::Cpp2ILInjected.Token(Token = "0x6000B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54B58", Offset = "0x1C54B58", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Version), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.IO.MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.Version) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool operator <=(global::System.Version v1, global::System.Version v2)
		{
			throw null;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000164B4 File Offset: 0x000146B4
		[global::Cpp2ILInjected.Token(Token = "0x6000B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54BBC", Offset = "0x1C54BBC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		public static bool operator >(global::System.Version v1, global::System.Version v2)
		{
			throw null;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x000164B7 File Offset: 0x000146B7
		[global::Cpp2ILInjected.Token(Token = "0x6000B91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C54BCC", Offset = "0x1C54BCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerRequest", Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(global::System.IO.MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.Version),
			typeof(global::System.Version)
		}, ReturnType = typeof(bool))]
		public static bool operator >=(global::System.Version v1, global::System.Version v2)
		{
			throw null;
		}

		// Token: 0x040002C6 RID: 710
		[global::Cpp2ILInjected.Token(Token = "0x4000418")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly int _Major;

		// Token: 0x040002C7 RID: 711
		[global::Cpp2ILInjected.Token(Token = "0x4000419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly int _Minor;

		// Token: 0x040002C8 RID: 712
		[global::Cpp2ILInjected.Token(Token = "0x400041A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int _Build;

		// Token: 0x040002C9 RID: 713
		[global::Cpp2ILInjected.Token(Token = "0x400041B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private readonly int _Revision;
	}
}
