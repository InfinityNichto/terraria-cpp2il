using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004C3 RID: 1219
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20005B0")]
	[global::System.Serializable]
	public sealed class NumberFormatInfo : global::System.ICloneable, global::System.IFormatProvider
	{
		// Token: 0x060028A2 RID: 10402 RVA: 0x0001B65C File Offset: 0x0001985C
		[global::Cpp2ILInjected.Token(Token = "0x6002C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF18B8", Offset = "0x1BF18B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NumberFormatInfo()
		{
			throw null;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0001B65F File Offset: 0x0001985F
		[global::System.Runtime.Serialization.OnSerializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002C01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1D8C", Offset = "0x1BF1D8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private void OnSerializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0001B662 File Offset: 0x00019862
		[global::System.Runtime.Serialization.OnDeserializing]
		[global::Cpp2ILInjected.Token(Token = "0x6002C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1E10", Offset = "0x1BF1E10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserializing(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0001B665 File Offset: 0x00019865
		[global::System.Runtime.Serialization.OnDeserialized]
		[global::Cpp2ILInjected.Token(Token = "0x6002C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1E14", Offset = "0x1BF1E14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnDeserialized(global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0001B668 File Offset: 0x00019868
		[global::Cpp2ILInjected.Token(Token = "0x6002C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF18C0", Offset = "0x1BF18C0", Length = "0x4CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_NumberFormat", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new object[] { typeof(NumberFormatInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		internal NumberFormatInfo(CultureData cultureData)
		{
			throw null;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0001B66B File Offset: 0x0001986B
		[global::Cpp2ILInjected.Token(Token = "0x6002C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1E18", Offset = "0x1BF1E18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NumberFormatInfo), Member = "set_NaNSymbol", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void VerifyWritable()
		{
			throw null;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x0001B66E File Offset: 0x0001986E
		[global::Cpp2ILInjected.Token(Token = "0x1700067E")]
		public static NumberFormatInfo InvariantInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF1E84", Offset = "0x1BF1E84", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 75)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(NumberFormatInfo) }, ReturnType = typeof(NumberFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0001B671 File Offset: 0x00019871
		[global::Cpp2ILInjected.Token(Token = "0x6002C07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1FEC", Offset = "0x1BF1FEC", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static NumberFormatInfo GetInstance(global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0001B674 File Offset: 0x00019874
		[global::Cpp2ILInjected.Token(Token = "0x6002C08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2290", Offset = "0x1BF2290", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0001B677 File Offset: 0x00019877
		[global::Cpp2ILInjected.Token(Token = "0x1700067F")]
		public int CurrencyDecimalDigits
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF22F8", Offset = "0x1BF22F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x0001B67A File Offset: 0x0001987A
		[global::Cpp2ILInjected.Token(Token = "0x17000680")]
		public string CurrencyDecimalSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2300", Offset = "0x1BF2300", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0001B67D File Offset: 0x0001987D
		[global::Cpp2ILInjected.Token(Token = "0x17000681")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2308", Offset = "0x1BF2308", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x0001B680 File Offset: 0x00019880
		[global::Cpp2ILInjected.Token(Token = "0x17000682")]
		public int[] CurrencyGroupSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2310", Offset = "0x1BF2310", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatCurrency", MemberParameters = new object[]
			{
				"System.Text.ValueStringBuilder&",
				"NumberBuffer&",
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x0001B683 File Offset: 0x00019883
		[global::Cpp2ILInjected.Token(Token = "0x17000683")]
		public int[] NumberGroupSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2380", Offset = "0x1BF2380", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatNumber", MemberParameters = new object[]
			{
				"System.Text.ValueStringBuilder&",
				"NumberBuffer&",
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "NumberToStringFormat", MemberParameters = new object[]
			{
				"System.Text.ValueStringBuilder&",
				"NumberBuffer&",
				"System.ReadOnlySpan`1<Char>",
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x0001B686 File Offset: 0x00019886
		[global::Cpp2ILInjected.Token(Token = "0x17000684")]
		public int[] PercentGroupSizes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF23F0", Offset = "0x1BF23F0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatPercent", MemberParameters = new object[]
			{
				"System.Text.ValueStringBuilder&",
				"NumberBuffer&",
				typeof(int),
				typeof(int),
				typeof(NumberFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0001B689 File Offset: 0x00019889
		[global::Cpp2ILInjected.Token(Token = "0x17000685")]
		public string CurrencyGroupSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2460", Offset = "0x1BF2460", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x0001B68C File Offset: 0x0001988C
		[global::Cpp2ILInjected.Token(Token = "0x17000686")]
		public string CurrencySymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2468", Offset = "0x1BF2468", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x0001B68F File Offset: 0x0001988F
		[global::Cpp2ILInjected.Token(Token = "0x17000687")]
		public static NumberFormatInfo CurrentInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C11")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF21A8", Offset = "0x1BF21A8", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(NumberStyles)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref long)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Numerics.BigInteger", Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x0001B692 File Offset: 0x00019892
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x0001B695 File Offset: 0x00019895
		[global::Cpp2ILInjected.Token(Token = "0x17000688")]
		public string NaNSymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2470", Offset = "0x1BF2470", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002C13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2478", Offset = "0x1BF2478", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new object[] { typeof(NumberFormatInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "VerifyWritable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x0001B698 File Offset: 0x00019898
		[global::Cpp2ILInjected.Token(Token = "0x17000689")]
		public int CurrencyNegativePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2504", Offset = "0x1BF2504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0001B69B File Offset: 0x0001989B
		[global::Cpp2ILInjected.Token(Token = "0x1700068A")]
		public int NumberNegativePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF250C", Offset = "0x1BF250C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x0001B69E File Offset: 0x0001989E
		[global::Cpp2ILInjected.Token(Token = "0x1700068B")]
		public int PercentPositivePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2514", Offset = "0x1BF2514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0001B6A1 File Offset: 0x000198A1
		[global::Cpp2ILInjected.Token(Token = "0x1700068C")]
		public int PercentNegativePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF251C", Offset = "0x1BF251C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x0001B6A4 File Offset: 0x000198A4
		[global::Cpp2ILInjected.Token(Token = "0x1700068D")]
		public string NegativeInfinitySymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C18")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2524", Offset = "0x1BF2524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x0001B6A7 File Offset: 0x000198A7
		[global::Cpp2ILInjected.Token(Token = "0x1700068E")]
		public string NegativeSign
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF252C", Offset = "0x1BF252C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0001B6AA File Offset: 0x000198AA
		[global::Cpp2ILInjected.Token(Token = "0x1700068F")]
		public int NumberDecimalDigits
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2534", Offset = "0x1BF2534", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x0001B6AD File Offset: 0x000198AD
		[global::Cpp2ILInjected.Token(Token = "0x17000690")]
		public string NumberDecimalSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF253C", Offset = "0x1BF253C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x0001B6B0 File Offset: 0x000198B0
		[global::Cpp2ILInjected.Token(Token = "0x17000691")]
		public string NumberGroupSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2544", Offset = "0x1BF2544", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x0001B6B3 File Offset: 0x000198B3
		[global::Cpp2ILInjected.Token(Token = "0x17000692")]
		public int CurrencyPositivePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF254C", Offset = "0x1BF254C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x0001B6B6 File Offset: 0x000198B6
		[global::Cpp2ILInjected.Token(Token = "0x17000693")]
		public string PositiveInfinitySymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2554", Offset = "0x1BF2554", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0001B6B9 File Offset: 0x000198B9
		[global::Cpp2ILInjected.Token(Token = "0x17000694")]
		public string PositiveSign
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF255C", Offset = "0x1BF255C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x0001B6BC File Offset: 0x000198BC
		[global::Cpp2ILInjected.Token(Token = "0x17000695")]
		public int PercentDecimalDigits
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2564", Offset = "0x1BF2564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x0001B6BF File Offset: 0x000198BF
		[global::Cpp2ILInjected.Token(Token = "0x17000696")]
		public string PercentDecimalSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF256C", Offset = "0x1BF256C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x0001B6C2 File Offset: 0x000198C2
		[global::Cpp2ILInjected.Token(Token = "0x17000697")]
		public string PercentGroupSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2574", Offset = "0x1BF2574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0001B6C5 File Offset: 0x000198C5
		[global::Cpp2ILInjected.Token(Token = "0x17000698")]
		public string PercentSymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF257C", Offset = "0x1BF257C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x0001B6C8 File Offset: 0x000198C8
		[global::Cpp2ILInjected.Token(Token = "0x17000699")]
		public string PerMilleSymbol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002C24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BF2584", Offset = "0x1BF2584", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0001B6CB File Offset: 0x000198CB
		[global::Cpp2ILInjected.Token(Token = "0x6002C25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF258C", Offset = "0x1BF258C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object GetFormat(global::System.Type formatType)
		{
			throw null;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0001B6CE File Offset: 0x000198CE
		[global::Cpp2ILInjected.Token(Token = "0x6002C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF1F20", Offset = "0x1BF1F20", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			throw null;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0001B6D1 File Offset: 0x000198D1
		[global::Cpp2ILInjected.Token(Token = "0x6002C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF2624", Offset = "0x1BF2624", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref sbyte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref ushort)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
			throw null;
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0001B6D4 File Offset: 0x000198D4
		[global::Cpp2ILInjected.Token(Token = "0x6002C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BF26F0", Offset = "0x1BF26F0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(global::System.IFormatProvider),
			typeof(ref decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			throw null;
		}

		// Token: 0x040014BA RID: 5306
		[global::Cpp2ILInjected.Token(Token = "0x400187E")]
		private static NumberFormatInfo invariantInfo;

		// Token: 0x040014BB RID: 5307
		[global::Cpp2ILInjected.Token(Token = "0x400187F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int[] numberGroupSizes;

		// Token: 0x040014BC RID: 5308
		[global::Cpp2ILInjected.Token(Token = "0x4001880")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] currencyGroupSizes;

		// Token: 0x040014BD RID: 5309
		[global::Cpp2ILInjected.Token(Token = "0x4001881")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int[] percentGroupSizes;

		// Token: 0x040014BE RID: 5310
		[global::Cpp2ILInjected.Token(Token = "0x4001882")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string positiveSign;

		// Token: 0x040014BF RID: 5311
		[global::Cpp2ILInjected.Token(Token = "0x4001883")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string negativeSign;

		// Token: 0x040014C0 RID: 5312
		[global::Cpp2ILInjected.Token(Token = "0x4001884")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string numberDecimalSeparator;

		// Token: 0x040014C1 RID: 5313
		[global::Cpp2ILInjected.Token(Token = "0x4001885")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string numberGroupSeparator;

		// Token: 0x040014C2 RID: 5314
		[global::Cpp2ILInjected.Token(Token = "0x4001886")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal string currencyGroupSeparator;

		// Token: 0x040014C3 RID: 5315
		[global::Cpp2ILInjected.Token(Token = "0x4001887")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal string currencyDecimalSeparator;

		// Token: 0x040014C4 RID: 5316
		[global::Cpp2ILInjected.Token(Token = "0x4001888")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal string currencySymbol;

		// Token: 0x040014C5 RID: 5317
		[global::Cpp2ILInjected.Token(Token = "0x4001889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal string ansiCurrencySymbol;

		// Token: 0x040014C6 RID: 5318
		[global::Cpp2ILInjected.Token(Token = "0x400188A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal string nanSymbol;

		// Token: 0x040014C7 RID: 5319
		[global::Cpp2ILInjected.Token(Token = "0x400188B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal string positiveInfinitySymbol;

		// Token: 0x040014C8 RID: 5320
		[global::Cpp2ILInjected.Token(Token = "0x400188C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal string negativeInfinitySymbol;

		// Token: 0x040014C9 RID: 5321
		[global::Cpp2ILInjected.Token(Token = "0x400188D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal string percentDecimalSeparator;

		// Token: 0x040014CA RID: 5322
		[global::Cpp2ILInjected.Token(Token = "0x400188E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal string percentGroupSeparator;

		// Token: 0x040014CB RID: 5323
		[global::Cpp2ILInjected.Token(Token = "0x400188F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal string percentSymbol;

		// Token: 0x040014CC RID: 5324
		[global::Cpp2ILInjected.Token(Token = "0x4001890")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal string perMilleSymbol;

		// Token: 0x040014CD RID: 5325
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x4001891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal string[] nativeDigits;

		// Token: 0x040014CE RID: 5326
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x4001892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal int m_dataItem;

		// Token: 0x040014CF RID: 5327
		[global::Cpp2ILInjected.Token(Token = "0x4001893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		internal int numberDecimalDigits;

		// Token: 0x040014D0 RID: 5328
		[global::Cpp2ILInjected.Token(Token = "0x4001894")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal int currencyDecimalDigits;

		// Token: 0x040014D1 RID: 5329
		[global::Cpp2ILInjected.Token(Token = "0x4001895")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		internal int currencyPositivePattern;

		// Token: 0x040014D2 RID: 5330
		[global::Cpp2ILInjected.Token(Token = "0x4001896")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal int currencyNegativePattern;

		// Token: 0x040014D3 RID: 5331
		[global::Cpp2ILInjected.Token(Token = "0x4001897")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		internal int numberNegativePattern;

		// Token: 0x040014D4 RID: 5332
		[global::Cpp2ILInjected.Token(Token = "0x4001898")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal int percentPositivePattern;

		// Token: 0x040014D5 RID: 5333
		[global::Cpp2ILInjected.Token(Token = "0x4001899")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		internal int percentNegativePattern;

		// Token: 0x040014D6 RID: 5334
		[global::Cpp2ILInjected.Token(Token = "0x400189A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal int percentDecimalDigits;

		// Token: 0x040014D7 RID: 5335
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x400189B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		internal int digitSubstitution;

		// Token: 0x040014D8 RID: 5336
		[global::Cpp2ILInjected.Token(Token = "0x400189C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal bool isReadOnly;

		// Token: 0x040014D9 RID: 5337
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x400189D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD1")]
		internal bool m_useUserOverride;

		// Token: 0x040014DA RID: 5338
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		[global::Cpp2ILInjected.Token(Token = "0x400189E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD2")]
		internal bool m_isInvariant;

		// Token: 0x040014DB RID: 5339
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x400189F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD3")]
		internal bool validForParseAsNumber;

		// Token: 0x040014DC RID: 5340
		[global::System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		[global::Cpp2ILInjected.Token(Token = "0x40018A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
		internal bool validForParseAsCurrency;

		// Token: 0x040014DD RID: 5341
		[global::Cpp2ILInjected.Token(Token = "0x40018A1")]
		private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);
	}
}
