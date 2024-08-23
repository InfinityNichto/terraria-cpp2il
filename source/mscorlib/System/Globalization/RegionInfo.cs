using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004D5 RID: 1237
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005C6")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class RegionInfo
	{
		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		[global::Cpp2ILInjected.Token(Token = "0x170006D9")]
		public static RegionInfo CurrentRegion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C04084", Offset = "0x1C04084", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x0001B9CB File Offset: 0x00019BCB
		[global::Cpp2ILInjected.Token(Token = "0x6002D36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C042D4", Offset = "0x1C042D4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegionInfo), Member = "GetByTerritory", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public RegionInfo(int culture)
		{
			throw null;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x0001B9CE File Offset: 0x00019BCE
		[global::Cpp2ILInjected.Token(Token = "0x6002D37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04484", Offset = "0x1C04484", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegionInfo), Member = "GetByTerritory", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public RegionInfo(string name)
		{
			throw null;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x0001B9D1 File Offset: 0x00019BD1
		[global::Cpp2ILInjected.Token(Token = "0x6002D38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04148", Offset = "0x1C04148", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegionInfo), Member = "get_CurrentRegion", ReturnType = typeof(RegionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private RegionInfo(CultureInfo ci)
		{
			throw null;
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x0001B9D4 File Offset: 0x00019BD4
		[global::Cpp2ILInjected.Token(Token = "0x6002D39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C043DC", Offset = "0x1C043DC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool GetByTerritory(CultureInfo ci)
		{
			throw null;
		}

		// Token: 0x060029D9 RID: 10713
		[global::Cpp2ILInjected.Token(Token = "0x6002D3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C045BC", Offset = "0x1C045BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool construct_internal_region_from_name(string name);

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x0001B9D7 File Offset: 0x00019BD7
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006DA")]
		public virtual string CurrencyEnglishName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C045C0", Offset = "0x1C045C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x0001B9DA File Offset: 0x00019BDA
		[global::Cpp2ILInjected.Token(Token = "0x170006DB")]
		public virtual string CurrencySymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C045C8", Offset = "0x1C045C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x0001B9DD File Offset: 0x00019BDD
		[global::System.MonoTODO("DisplayName currently only returns the EnglishName")]
		[global::Cpp2ILInjected.Token(Token = "0x170006DC")]
		public virtual string DisplayName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C045D0", Offset = "0x1C045D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060029DD RID: 10717 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		[global::Cpp2ILInjected.Token(Token = "0x170006DD")]
		public virtual string EnglishName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C045D8", Offset = "0x1C045D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060029DE RID: 10718 RVA: 0x0001B9E3 File Offset: 0x00019BE3
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006DE")]
		public virtual int GeoId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C045E0", Offset = "0x1C045E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x0001B9E6 File Offset: 0x00019BE6
		[global::Cpp2ILInjected.Token(Token = "0x170006DF")]
		public virtual bool IsMetric
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C045E8", Offset = "0x1C045E8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x0001B9E9 File Offset: 0x00019BE9
		[global::Cpp2ILInjected.Token(Token = "0x170006E0")]
		public virtual string ISOCurrencySymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C04674", Offset = "0x1C04674", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0001B9EC File Offset: 0x00019BEC
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006E1")]
		public virtual string NativeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0467C", Offset = "0x1C0467C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x0001B9EF File Offset: 0x00019BEF
		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170006E2")]
		public virtual string CurrencyNativeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C04684", Offset = "0x1C04684", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060029E3 RID: 10723 RVA: 0x0001B9F2 File Offset: 0x00019BF2
		[global::Cpp2ILInjected.Token(Token = "0x170006E3")]
		public virtual string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0468C", Offset = "0x1C0468C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0001B9F5 File Offset: 0x00019BF5
		[global::Cpp2ILInjected.Token(Token = "0x170006E4")]
		public virtual string ThreeLetterISORegionName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C04694", Offset = "0x1C04694", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		[global::Cpp2ILInjected.Token(Token = "0x170006E5")]
		public virtual string ThreeLetterWindowsRegionName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C0469C", Offset = "0x1C0469C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x0001B9FB File Offset: 0x00019BFB
		[global::Cpp2ILInjected.Token(Token = "0x170006E6")]
		public virtual string TwoLetterISORegionName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D47")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C046A4", Offset = "0x1C046A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0001B9FE File Offset: 0x00019BFE
		[global::Cpp2ILInjected.Token(Token = "0x6002D48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C046AC", Offset = "0x1C046AC", Length = "0xC0")]
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

		// Token: 0x060029E8 RID: 10728 RVA: 0x0001BA01 File Offset: 0x00019C01
		[global::Cpp2ILInjected.Token(Token = "0x6002D49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0476C", Offset = "0x1C0476C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x0001BA04 File Offset: 0x00019C04
		[global::Cpp2ILInjected.Token(Token = "0x6002D4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04790", Offset = "0x1C04790", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x0001BA07 File Offset: 0x00019C07
		[global::Cpp2ILInjected.Token(Token = "0x6002D4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C047A0", Offset = "0x1C047A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void ClearCachedData()
		{
			throw null;
		}

		// Token: 0x04001560 RID: 5472
		[global::Cpp2ILInjected.Token(Token = "0x4001943")]
		private static RegionInfo currentRegion;

		// Token: 0x04001561 RID: 5473
		[global::Cpp2ILInjected.Token(Token = "0x4001944")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int regionId;

		// Token: 0x04001562 RID: 5474
		[global::Cpp2ILInjected.Token(Token = "0x4001945")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string iso2Name;

		// Token: 0x04001563 RID: 5475
		[global::Cpp2ILInjected.Token(Token = "0x4001946")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string iso3Name;

		// Token: 0x04001564 RID: 5476
		[global::Cpp2ILInjected.Token(Token = "0x4001947")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string win3Name;

		// Token: 0x04001565 RID: 5477
		[global::Cpp2ILInjected.Token(Token = "0x4001948")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string englishName;

		// Token: 0x04001566 RID: 5478
		[global::Cpp2ILInjected.Token(Token = "0x4001949")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string nativeName;

		// Token: 0x04001567 RID: 5479
		[global::Cpp2ILInjected.Token(Token = "0x400194A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string currencySymbol;

		// Token: 0x04001568 RID: 5480
		[global::Cpp2ILInjected.Token(Token = "0x400194B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string isoCurrencySymbol;

		// Token: 0x04001569 RID: 5481
		[global::Cpp2ILInjected.Token(Token = "0x400194C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string currencyEnglishName;

		// Token: 0x0400156A RID: 5482
		[global::Cpp2ILInjected.Token(Token = "0x400194D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string currencyNativeName;
	}
}
