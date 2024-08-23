using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;
using Mono.Interop;

namespace System.Globalization
{
	// Token: 0x020004D1 RID: 1233
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005C0")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class CultureInfo : global::System.ICloneable, global::System.IFormatProvider
	{
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x0001B8CC File Offset: 0x00019ACC
		[global::Cpp2ILInjected.Token(Token = "0x170006C0")]
		internal CultureData _cultureData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFC630", Offset = "0x1BFC630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x0001B8CF File Offset: 0x00019ACF
		[global::Cpp2ILInjected.Token(Token = "0x170006C1")]
		internal bool _isInherited
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFC638", Offset = "0x1BFC638", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600297C RID: 10620 RVA: 0x0001B8D2 File Offset: 0x00019AD2
		[global::Cpp2ILInjected.Token(Token = "0x170006C2")]
		public static CultureInfo InvariantCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4DB0", Offset = "0x1BF4DB0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 669)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x0001B8D5 File Offset: 0x00019AD5
		[global::Cpp2ILInjected.Token(Token = "0x170006C3")]
		public static CultureInfo CurrentCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF4FCC", Offset = "0x1BF4FCC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 144)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600297E RID: 10622 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		[global::Cpp2ILInjected.Token(Token = "0x170006C4")]
		public static CultureInfo CurrentUICulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFC640", Offset = "0x1BFC640", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CheckValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.Binder),
				typeof(CultureInfo),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceFallbackManager), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(CultureInfo),
				typeof(CultureInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "ApplyResources", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string),
				typeof(CultureInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0001B8DB File Offset: 0x00019ADB
		[global::Cpp2ILInjected.Token(Token = "0x6002CDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFC658", Offset = "0x1BFC658", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "nativeInitCultureAccessors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ConstructCurrentUICulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_UserDefaultCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal static CultureInfo ConstructCurrentCulture()
		{
			throw null;
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0001B8DE File Offset: 0x00019ADE
		[global::Cpp2ILInjected.Token(Token = "0x6002CDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFCA4C", Offset = "0x1BFCA4C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "nativeInitCultureAccessors", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_UserDefaultUICulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static CultureInfo ConstructCurrentUICulture()
		{
			throw null;
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x0001B8E1 File Offset: 0x00019AE1
		[global::Cpp2ILInjected.Token(Token = "0x170006C5")]
		internal string Territory
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCA98", Offset = "0x1BFCA98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002982 RID: 10626 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		[global::Cpp2ILInjected.Token(Token = "0x170006C6")]
		internal string _name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCAA0", Offset = "0x1BFCAA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x0001B8E7 File Offset: 0x00019AE7
		[global::Cpp2ILInjected.Token(Token = "0x170006C7")]
		public virtual int LCID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCAA8", Offset = "0x1BFCAA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x0001B8EA File Offset: 0x00019AEA
		[global::Cpp2ILInjected.Token(Token = "0x170006C8")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCAB0", Offset = "0x1BFCAB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x0001B8ED File Offset: 0x00019AED
		[global::Cpp2ILInjected.Token(Token = "0x170006C9")]
		public virtual Calendar Calendar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCAB8", Offset = "0x1BFCAB8", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "CreateCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Calendar))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x0001B8F0 File Offset: 0x00019AF0
		[global::Cpp2ILInjected.Token(Token = "0x170006CA")]
		public virtual CultureInfo Parent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCD7C", Offset = "0x1BFCD7C", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x0001B8F3 File Offset: 0x00019AF3
		[global::Cpp2ILInjected.Token(Token = "0x170006CB")]
		public virtual TextInfo TextInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFCFA0", Offset = "0x1BFCFA0", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "CreateTextInfo", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(TextInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x0001B8F6 File Offset: 0x00019AF6
		[global::Cpp2ILInjected.Token(Token = "0x6002CE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD130", Offset = "0x1BFD130", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x0001B8F9 File Offset: 0x00019AF9
		[global::Cpp2ILInjected.Token(Token = "0x6002CE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD2C0", Offset = "0x1BFD2C0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x0001B8FC File Offset: 0x00019AFC
		[global::Cpp2ILInjected.Token(Token = "0x6002CE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD364", Offset = "0x1BFD364", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "GetStandardValues", MemberParameters = new object[] { "System.ComponentModel.ITypeDescriptorContext" }, ReturnType = "System.ComponentModel.TypeConverter.StandardValuesCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static CultureInfo[] GetCultures(CultureTypes types)
		{
			throw null;
		}

		// Token: 0x0600298B RID: 10635 RVA: 0x0001B8FF File Offset: 0x00019AFF
		[global::Cpp2ILInjected.Token(Token = "0x6002CEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD58C", Offset = "0x1BFD58C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private CultureInfo.Data GetTextInfoData()
		{
			throw null;
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x0001B902 File Offset: 0x00019B02
		[global::Cpp2ILInjected.Token(Token = "0x6002CEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD618", Offset = "0x1BFD618", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x0001B905 File Offset: 0x00019B05
		[global::Cpp2ILInjected.Token(Token = "0x6002CEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD624", Offset = "0x1BFD624", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(NumberFormatInfo) }, ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(TextInfo) }, ReturnType = typeof(TextInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static CultureInfo ReadOnly(CultureInfo ci)
		{
			throw null;
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x0001B908 File Offset: 0x00019B08
		[global::Cpp2ILInjected.Token(Token = "0x6002CED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD7B8", Offset = "0x1BFD7B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600298F RID: 10639 RVA: 0x0001B90B File Offset: 0x00019B0B
		[global::Cpp2ILInjected.Token(Token = "0x170006CC")]
		public virtual CompareInfo CompareInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFD7C0", Offset = "0x1BFD7C0", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x0001B90E File Offset: 0x00019B0E
		[global::Cpp2ILInjected.Token(Token = "0x170006CD")]
		public virtual bool IsNeutralCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFD90C", Offset = "0x1BFD90C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x0001B911 File Offset: 0x00019B11
		[global::Cpp2ILInjected.Token(Token = "0x6002CF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD954", Offset = "0x1BFD954", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void CheckNeutral()
		{
			throw null;
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x0001B914 File Offset: 0x00019B14
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x0001B917 File Offset: 0x00019B17
		[global::Cpp2ILInjected.Token(Token = "0x170006CE")]
		public virtual NumberFormatInfo NumberFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFD958", Offset = "0x1BFD958", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002CF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFD9E0", Offset = "0x1BFD9E0", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x0001B91A File Offset: 0x00019B1A
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x0001B91D File Offset: 0x00019B1D
		[global::Cpp2ILInjected.Token(Token = "0x170006CF")]
		public virtual DateTimeFormatInfo DateTimeFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFDAA8", Offset = "0x1BFDAA8", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(CultureData),
				typeof(Calendar)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002CF4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFDBF4", Offset = "0x1BFDBF4", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x0001B920 File Offset: 0x00019B20
		[global::Cpp2ILInjected.Token(Token = "0x170006D0")]
		public virtual string EnglishName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFDCBC", Offset = "0x1BFDCBC", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x0001B923 File Offset: 0x00019B23
		[global::Cpp2ILInjected.Token(Token = "0x170006D1")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002CF6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFDCEC", Offset = "0x1BFDCEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x0001B926 File Offset: 0x00019B26
		[global::Cpp2ILInjected.Token(Token = "0x6002CF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFDCF4", Offset = "0x1BFDCF4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object GetFormat(global::System.Type formatType)
		{
			throw null;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x0001B929 File Offset: 0x00019B29
		[global::Cpp2ILInjected.Token(Token = "0x6002CF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFCB3C", Offset = "0x1BFCB3C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Construct()
		{
			throw null;
		}

		// Token: 0x0600299A RID: 10650
		[global::Cpp2ILInjected.Token(Token = "0x6002CF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFDE04", Offset = "0x1BFDE04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool construct_internal_locale_from_lcid(int lcid);

		// Token: 0x0600299B RID: 10651
		[global::Cpp2ILInjected.Token(Token = "0x6002CFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFDE08", Offset = "0x1BFDE08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool construct_internal_locale_from_name(string name);

		// Token: 0x0600299C RID: 10652
		[global::Cpp2ILInjected.Token(Token = "0x6002CFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFC83C", Offset = "0x1BFC83C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string get_current_locale_name();

		// Token: 0x0600299D RID: 10653
		[global::Cpp2ILInjected.Token(Token = "0x6002CFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD57C", Offset = "0x1BFD57C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed);

		// Token: 0x0600299E RID: 10654 RVA: 0x0001B92C File Offset: 0x00019B2C
		[global::Cpp2ILInjected.Token(Token = "0x6002CFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFDE0C", Offset = "0x1BFDE0C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ConstructInvariant(bool read_only)
		{
			throw null;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0001B92F File Offset: 0x00019B2F
		[global::Cpp2ILInjected.Token(Token = "0x6002CFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFD0BC", Offset = "0x1BFD0BC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_TextInfo", ReturnType = typeof(TextInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TextInfo CreateTextInfo(bool readOnly)
		{
			throw null;
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0001B932 File Offset: 0x00019B32
		[global::Cpp2ILInjected.Token(Token = "0x6002CFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFCF94", Offset = "0x1BFCF94", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public CultureInfo(int culture)
		{
			throw null;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x0001B935 File Offset: 0x00019B35
		[global::Cpp2ILInjected.Token(Token = "0x6002D00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFDF5C", Offset = "0x1BFDF5C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public CultureInfo(int culture, bool useUserOverride)
		{
			throw null;
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0001B938 File Offset: 0x00019B38
		[global::Cpp2ILInjected.Token(Token = "0x6002D01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFDF68", Offset = "0x1BFDF68", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_Parent", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private CultureInfo(int culture, bool useUserOverride, bool read_only)
		{
			throw null;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0001B93B File Offset: 0x00019B3B
		[global::Cpp2ILInjected.Token(Token = "0x6002D02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFCF88", Offset = "0x1BFCF88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.GameCulture", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Text.StringReaderWrapExtension", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TaiwanCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public CultureInfo(string name)
		{
			throw null;
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0001B93E File Offset: 0x00019B3E
		[global::Cpp2ILInjected.Token(Token = "0x6002D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF6794", Offset = "0x1BF6794", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public CultureInfo(string name, bool useUserOverride)
		{
			throw null;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x0001B941 File Offset: 0x00019B41
		[global::Cpp2ILInjected.Token(Token = "0x6002D04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE1C0", Offset = "0x1BFE1C0", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_Parent", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateCulture", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "OnCultureInfoChangedInAppX", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private CultureInfo(string name, bool useUserOverride, bool read_only)
		{
			throw null;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x0001B944 File Offset: 0x00019B44
		[global::Cpp2ILInjected.Token(Token = "0x6002D05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE534", Offset = "0x1BFE534", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private CultureInfo()
		{
			throw null;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0001B947 File Offset: 0x00019B47
		[global::Cpp2ILInjected.Token(Token = "0x6002D06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE554", Offset = "0x1BFE554", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void insert_into_shared_tables(CultureInfo c)
		{
			throw null;
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x0001B94A File Offset: 0x00019B4A
		[global::Cpp2ILInjected.Token(Token = "0x6002D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE6C4", Offset = "0x1BFE6C4", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "insert_into_shared_tables", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static CultureInfo GetCultureInfo(int culture)
		{
			throw null;
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x0001B94D File Offset: 0x00019B4D
		[global::Cpp2ILInjected.Token(Token = "0x6002D08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE8EC", Offset = "0x1BFE8EC", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(ref global::System.Resources.UltimateResourceFallbackLocation)
		}, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "GetCompareInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CompareInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "OnSerializing", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CalendarData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextInfo), Member = "OnSerializing", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "insert_into_shared_tables", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static CultureInfo GetCultureInfo(string name)
		{
			throw null;
		}

		// Token: 0x060029AA RID: 10666 RVA: 0x0001B950 File Offset: 0x00019B50
		[global::Cpp2ILInjected.Token(Token = "0x6002D09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFEAFC", Offset = "0x1BFEAFC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = "FillName", MemberParameters = new object[]
		{
			typeof(global::Mono.MonoAssemblyName*),
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe static CultureInfo CreateCulture(string name, bool reference)
		{
			throw null;
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x0001B953 File Offset: 0x00019B53
		[global::Cpp2ILInjected.Token(Token = "0x6002D0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFC840", Offset = "0x1BFC840", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(CultureData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static CultureInfo CreateSpecificCulture(string name)
		{
			throw null;
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x0001B956 File Offset: 0x00019B56
		[global::Cpp2ILInjected.Token(Token = "0x6002D0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE3E8", Offset = "0x1BFE3E8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ConstructLocaleFromName(string name)
		{
			throw null;
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x0001B959 File Offset: 0x00019B59
		[global::Cpp2ILInjected.Token(Token = "0x6002D0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFEB68", Offset = "0x1BFEB68", Length = "0x2740")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 150)]
		private static CultureInfo CreateSpecificCultureFromNeutral(string name)
		{
			throw null;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x0001B95C File Offset: 0x00019B5C
		[global::Cpp2ILInjected.Token(Token = "0x170006D2")]
		internal int CalendarType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BFD5A4", Offset = "0x1BFD5A4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "GetCultures", MemberParameters = new object[] { typeof(CultureTypes) }, ReturnType = typeof(CultureInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x0001B95F File Offset: 0x00019B5F
		[global::Cpp2ILInjected.Token(Token = "0x6002D0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFCB5C", Offset = "0x1BFCB5C", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_Calendar", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendar), Member = ".ctor", MemberParameters = new object[] { typeof(GregorianCalendarTypes) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static Calendar CreateCalendar(int calendarType)
		{
			throw null;
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0001B962 File Offset: 0x00019B62
		[global::Cpp2ILInjected.Token(Token = "0x6002D0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFE46C", Offset = "0x1BFE46C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.Exception CreateNotFoundException(string name)
		{
			throw null;
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x0001B965 File Offset: 0x00019B65
		[global::Cpp2ILInjected.Token(Token = "0x170006D3")]
		public static CultureInfo DefaultThreadCurrentCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C012A8", Offset = "0x1C012A8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060029B2 RID: 10674 RVA: 0x0001B968 File Offset: 0x00019B68
		[global::Cpp2ILInjected.Token(Token = "0x170006D4")]
		public static CultureInfo DefaultThreadCurrentUICulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D11")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C01308", Offset = "0x1C01308", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x0001B96B File Offset: 0x00019B6B
		[global::Cpp2ILInjected.Token(Token = "0x170006D5")]
		internal string SortName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C01368", Offset = "0x1C01368", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x0001B96E File Offset: 0x00019B6E
		[global::Cpp2ILInjected.Token(Token = "0x170006D6")]
		internal static CultureInfo UserDefaultUICulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C01370", Offset = "0x1C01370", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentUICulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x0001B971 File Offset: 0x00019B71
		[global::Cpp2ILInjected.Token(Token = "0x170006D7")]
		internal static CultureInfo UserDefaultCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C013BC", Offset = "0x1C013BC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060029B6 RID: 10678
		[global::Cpp2ILInjected.Token(Token = "0x6002D15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C01408", Offset = "0x1C01408", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX);

		// Token: 0x060029B7 RID: 10679
		[global::Cpp2ILInjected.Token(Token = "0x6002D16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C01418", Offset = "0x1C01418", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern void SetUserPreferredCultureInfoInAppX(string name);

		// Token: 0x060029B8 RID: 10680 RVA: 0x0001B974 File Offset: 0x00019B74
		[global::Mono.Interop.MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
		[global::Cpp2ILInjected.Token(Token = "0x6002D17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BFC598", Offset = "0x1BFC598", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void OnCultureInfoChangedInAppX(string language)
		{
			throw null;
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0001B977 File Offset: 0x00019B77
		[global::Cpp2ILInjected.Token(Token = "0x6002D18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C01428", Offset = "0x1C01428", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo.OnCultureInfoChangedDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
		{
			throw null;
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0001B97A File Offset: 0x00019B7A
		[global::Cpp2ILInjected.Token(Token = "0x6002D19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C01500", Offset = "0x1C01500", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo.OnCultureInfoChangedDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static void SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo cultureInfo)
		{
			throw null;
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x0001B97D File Offset: 0x00019B7D
		[global::Cpp2ILInjected.Token(Token = "0x170006D8")]
		internal bool HasInvariantCultureName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C01604", Offset = "0x1C01604", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Resources.ResourceFallbackManager.<GetEnumerator>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.FileBasedResourceGroveler), Member = "GrovelForResourceSet", MemberParameters = new object[]
			{
				typeof(CultureInfo),
				typeof(global::System.Collections.Generic.Dictionary<string, global::System.Resources.ResourceSet>),
				typeof(bool),
				typeof(bool),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(global::System.Resources.ResourceSet))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "GrovelForResourceSet", MemberParameters = new object[]
			{
				typeof(CultureInfo),
				typeof(global::System.Collections.Generic.Dictionary<string, global::System.Resources.ResourceSet>),
				typeof(bool),
				typeof(bool),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(global::System.Resources.ResourceSet))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "UltimateFallbackFixup", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "GetResourceFileName", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "GetResourceSet", MemberParameters = new object[]
			{
				typeof(CultureInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.Resources.ResourceSet))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0001B980 File Offset: 0x00019B80
		[global::Cpp2ILInjected.Token(Token = "0x6002D1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C01688", Offset = "0x1C01688", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceManager), Member = "GetResourceFileName", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "VerifyCultureName", MemberParameters = new object[]
		{
			typeof(CultureInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static bool VerifyCultureName(string cultureName, bool throwException)
		{
			throw null;
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x0001B983 File Offset: 0x00019B83
		[global::Cpp2ILInjected.Token(Token = "0x6002D1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C017C8", Offset = "0x1C017C8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "set_CurrentUICulture", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "VerifyCultureName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool VerifyCultureName(CultureInfo culture, bool throwException)
		{
			throw null;
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0001B986 File Offset: 0x00019B86
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002D1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C01854", Offset = "0x1C01854", Length = "0x109C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static CultureInfo()
		{
			throw null;
		}

		// Token: 0x0400152D RID: 5421
		[global::Cpp2ILInjected.Token(Token = "0x400190A")]
		private static CultureInfo invariant_culture_info;

		// Token: 0x0400152E RID: 5422
		[global::Cpp2ILInjected.Token(Token = "0x400190B")]
		private static object shared_table_lock;

		// Token: 0x0400152F RID: 5423
		[global::Cpp2ILInjected.Token(Token = "0x400190C")]
		private static CultureInfo default_current_culture;

		// Token: 0x04001530 RID: 5424
		[global::Cpp2ILInjected.Token(Token = "0x400190D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_isReadOnly;

		// Token: 0x04001531 RID: 5425
		[global::Cpp2ILInjected.Token(Token = "0x400190E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int cultureID;

		// Token: 0x04001532 RID: 5426
		[global::Cpp2ILInjected.Token(Token = "0x400190F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		private int parent_lcid;

		// Token: 0x04001533 RID: 5427
		[global::Cpp2ILInjected.Token(Token = "0x4001910")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		[global::System.NonSerialized]
		private int datetime_index;

		// Token: 0x04001534 RID: 5428
		[global::Cpp2ILInjected.Token(Token = "0x4001911")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private int number_index;

		// Token: 0x04001535 RID: 5429
		[global::Cpp2ILInjected.Token(Token = "0x4001912")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		[global::System.NonSerialized]
		private int default_calendar_type;

		// Token: 0x04001536 RID: 5430
		[global::Cpp2ILInjected.Token(Token = "0x4001913")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_useUserOverride;

		// Token: 0x04001537 RID: 5431
		[global::Cpp2ILInjected.Token(Token = "0x4001914")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal NumberFormatInfo numInfo;

		// Token: 0x04001538 RID: 5432
		[global::Cpp2ILInjected.Token(Token = "0x4001915")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal DateTimeFormatInfo dateTimeInfo;

		// Token: 0x04001539 RID: 5433
		[global::Cpp2ILInjected.Token(Token = "0x4001916")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private TextInfo textInfo;

		// Token: 0x0400153A RID: 5434
		[global::Cpp2ILInjected.Token(Token = "0x4001917")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal string m_name;

		// Token: 0x0400153B RID: 5435
		[global::Cpp2ILInjected.Token(Token = "0x4001918")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[global::System.NonSerialized]
		private string englishname;

		// Token: 0x0400153C RID: 5436
		[global::Cpp2ILInjected.Token(Token = "0x4001919")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		[global::System.NonSerialized]
		private string nativename;

		// Token: 0x0400153D RID: 5437
		[global::Cpp2ILInjected.Token(Token = "0x400191A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		[global::System.NonSerialized]
		private string iso3lang;

		// Token: 0x0400153E RID: 5438
		[global::Cpp2ILInjected.Token(Token = "0x400191B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		[global::System.NonSerialized]
		private string iso2lang;

		// Token: 0x0400153F RID: 5439
		[global::Cpp2ILInjected.Token(Token = "0x400191C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		[global::System.NonSerialized]
		private string win3lang;

		// Token: 0x04001540 RID: 5440
		[global::Cpp2ILInjected.Token(Token = "0x400191D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		[global::System.NonSerialized]
		private string territory;

		// Token: 0x04001541 RID: 5441
		[global::Cpp2ILInjected.Token(Token = "0x400191E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		[global::System.NonSerialized]
		private string[] native_calendar_names;

		// Token: 0x04001542 RID: 5442
		[global::Cpp2ILInjected.Token(Token = "0x400191F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private CompareInfo compareInfo;

		// Token: 0x04001543 RID: 5443
		[global::Cpp2ILInjected.Token(Token = "0x4001920")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		[global::System.NonSerialized]
		private unsafe readonly void* textinfo_data;

		// Token: 0x04001544 RID: 5444
		[global::Cpp2ILInjected.Token(Token = "0x4001921")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int m_dataItem;

		// Token: 0x04001545 RID: 5445
		[global::Cpp2ILInjected.Token(Token = "0x4001922")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private Calendar calendar;

		// Token: 0x04001546 RID: 5446
		[global::Cpp2ILInjected.Token(Token = "0x4001923")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		[global::System.NonSerialized]
		private CultureInfo parent_culture;

		// Token: 0x04001547 RID: 5447
		[global::Cpp2ILInjected.Token(Token = "0x4001924")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		[global::System.NonSerialized]
		private bool constructed;

		// Token: 0x04001548 RID: 5448
		[global::Cpp2ILInjected.Token(Token = "0x4001925")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		[global::System.NonSerialized]
		internal byte[] cached_serialized_form;

		// Token: 0x04001549 RID: 5449
		[global::Cpp2ILInjected.Token(Token = "0x4001926")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		[global::System.NonSerialized]
		internal CultureData m_cultureData;

		// Token: 0x0400154A RID: 5450
		[global::Cpp2ILInjected.Token(Token = "0x4001927")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		[global::System.NonSerialized]
		internal bool m_isInherited;

		// Token: 0x0400154B RID: 5451
		[global::Cpp2ILInjected.Token(Token = "0x4001928")]
		internal const int InvariantCultureId = 127;

		// Token: 0x0400154C RID: 5452
		[global::Cpp2ILInjected.Token(Token = "0x4001929")]
		private const int CalendarTypeBits = 8;

		// Token: 0x0400154D RID: 5453
		[global::Cpp2ILInjected.Token(Token = "0x400192A")]
		internal const int LOCALE_INVARIANT = 127;

		// Token: 0x0400154E RID: 5454
		[global::Cpp2ILInjected.Token(Token = "0x400192B")]
		private const string MSG_READONLY = "This instance is read only";

		// Token: 0x0400154F RID: 5455
		[global::Cpp2ILInjected.Token(Token = "0x400192C")]
		private static CultureInfo s_DefaultThreadCurrentUICulture;

		// Token: 0x04001550 RID: 5456
		[global::Cpp2ILInjected.Token(Token = "0x400192D")]
		private static CultureInfo s_DefaultThreadCurrentCulture;

		// Token: 0x04001551 RID: 5457
		[global::Cpp2ILInjected.Token(Token = "0x400192E")]
		private static global::System.Collections.Generic.Dictionary<int, CultureInfo> shared_by_number;

		// Token: 0x04001552 RID: 5458
		[global::Cpp2ILInjected.Token(Token = "0x400192F")]
		private static global::System.Collections.Generic.Dictionary<string, CultureInfo> shared_by_name;

		// Token: 0x04001553 RID: 5459
		[global::Cpp2ILInjected.Token(Token = "0x4001930")]
		private static CultureInfo s_UserPreferredCultureInfoInAppX;

		// Token: 0x04001554 RID: 5460
		[global::Cpp2ILInjected.Token(Token = "0x4001931")]
		internal static readonly bool IsTaiwanSku;

		// Token: 0x02000639 RID: 1593
		[global::Cpp2ILInjected.Token(Token = "0x20005C1")]
		private struct Data
		{
			// Token: 0x04001A63 RID: 6755
			[global::Cpp2ILInjected.Token(Token = "0x4001932")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int ansi;

			// Token: 0x04001A64 RID: 6756
			[global::Cpp2ILInjected.Token(Token = "0x4001933")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int ebcdic;

			// Token: 0x04001A65 RID: 6757
			[global::Cpp2ILInjected.Token(Token = "0x4001934")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int mac;

			// Token: 0x04001A66 RID: 6758
			[global::Cpp2ILInjected.Token(Token = "0x4001935")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int oem;

			// Token: 0x04001A67 RID: 6759
			[global::Cpp2ILInjected.Token(Token = "0x4001936")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool right_to_left;

			// Token: 0x04001A68 RID: 6760
			[global::Cpp2ILInjected.Token(Token = "0x4001937")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
			public byte list_sep;
		}

		// Token: 0x0200063A RID: 1594
		// (Invoke) Token: 0x06004234 RID: 16948
		[global::Cpp2ILInjected.Token(Token = "0x20005C2")]
		private delegate void OnCultureInfoChangedDelegate(string language);
	}
}
