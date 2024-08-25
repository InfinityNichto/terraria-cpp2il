using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005C6")]
	[global::System.Serializable]
	[StructLayout(0)]
	public class RegionInfo
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002D3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C045BC", Offset = "0x1C045BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern bool construct_internal_region_from_name(string name);

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

		[global::Cpp2ILInjected.Token(Token = "0x6002D49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0476C", Offset = "0x1C0476C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04790", Offset = "0x1C04790", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C047A0", Offset = "0x1C047A0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void ClearCachedData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001943")]
		private static RegionInfo currentRegion;

		[global::Cpp2ILInjected.Token(Token = "0x4001944")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int regionId;

		[global::Cpp2ILInjected.Token(Token = "0x4001945")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string iso2Name;

		[global::Cpp2ILInjected.Token(Token = "0x4001946")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string iso3Name;

		[global::Cpp2ILInjected.Token(Token = "0x4001947")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string win3Name;

		[global::Cpp2ILInjected.Token(Token = "0x4001948")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string englishName;

		[global::Cpp2ILInjected.Token(Token = "0x4001949")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string nativeName;

		[global::Cpp2ILInjected.Token(Token = "0x400194A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string currencySymbol;

		[global::Cpp2ILInjected.Token(Token = "0x400194B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string isoCurrencySymbol;

		[global::Cpp2ILInjected.Token(Token = "0x400194C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string currencyEnglishName;

		[global::Cpp2ILInjected.Token(Token = "0x400194D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string currencyNativeName;
	}
}
